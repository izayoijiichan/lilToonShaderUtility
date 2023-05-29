// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialGetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER && !LILTOON_1_4_0_OR_NEWER
#define LILTOON_1_4_0_OR_NEWER
#endif
namespace LilToonShader
{
    using UnityEngine;
    using UnityEngine.Rendering;
    using LilToonShader.Extensions;

#if LILTOON_1_4_0_OR_NEWER
    using LilToonShader.v1_4_0;
#elif LILTOON_1_3_0_OR_NEWER
    using LilToonShader.v1_3_0;
#elif LILTOON_1_2_12_OR_OLDER
    using LilToonShader.v1_2_12;
#endif

    /// <summary>
    /// lilToon Material Getter
    /// </summary>
    public class LilToonMaterialGetter
    {
        #region Methods (Container)

        /// <summary>
        /// Get the lilToon property container from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns>A lilToon Property Container.</returns>
        public virtual LilToonPropertyContainer GetLilToonPropertyContainer(Material material)
        {
            int lilToonVersion = material.GetLilToonVersion();

            // @notice judge from shader name
            LilPropertyEntityType propertyEntityType = material.shader.GetLilPropertyEntityType();

            LilToonPropertyContainer propertyContainer;

            if (propertyEntityType == LilPropertyEntityType.Multi)
            {
                propertyContainer = new LilToonPropertyContainer
                {
                    PropertyEntityType = LilPropertyEntityType.Multi,
                    RenderingMode = material.GetSafeEnum<LilRenderingMode>(PropertyNameID.TransparentMode),
                    //TransparentMode = LilTransparentMode.Normal,
                    IsOverlay = material.GetSafeBool(PropertyNameID.AsOverlay),
                    IsOutline = material.GetSafeBool(PropertyNameID.UseOutline),
                    IsTessellation = false,  // @notice
                    LilToonVersion = lilToonVersion,
                };

                if (propertyContainer.RenderingMode == LilRenderingMode.FurTwoPass)
                {
                    propertyContainer.TransparentMode = LilTransparentMode.TwoPass;
                }
                else  // @notice
                {
                    propertyContainer.TransparentMode = LilTransparentMode.Normal;
                }

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                propertyContainer.NormalProperty = GetLilToonNormalPropertyEntity(material, propertyContainer);
#elif LILTOON_1_2_12_OR_OLDER
                propertyContainer.MultiProperty = GetLilToonMultiPropertyEntity(material, propertyContainer);
#endif
            }
            else
            {
                // @notice judge from shader name
                propertyContainer = new LilToonPropertyContainer
                {
                    PropertyEntityType = propertyEntityType,
                    RenderingMode = material.shader.GetRenderingMode(),
                    TransparentMode = material.shader.GetTransparentMode(),
                    IsOverlay = material.shader.IsOverlay(),
                    IsOutline = material.shader.IsOutline(),
                    IsTessellation = material.shader.IsTessellation(),
                    LilToonVersion = lilToonVersion,
                };

                if (propertyEntityType == LilPropertyEntityType.FakeShadow)
                {
                    propertyContainer.FakeShadowProperty = GetLilToonFakeShadowPropertyEntity(material, propertyContainer);
                }
                else if (propertyEntityType == LilPropertyEntityType.Lite)
                {
                    propertyContainer.LiteProperty = GetLilToonLitePropertyEntity(material, propertyContainer);
                }
                else
                {
                    propertyContainer.NormalProperty = GetLilToonNormalPropertyEntity(material, propertyContainer);
                }
            }

            return propertyContainer;
        }

        #endregion

        #region Methods (Entity)

        /// <summary>
        /// Get the lilToon Lite property entity from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        /// <returns>A lilToon Lite property entity.</returns>
        public virtual LilToonLitePropertyEntity GetLilToonLitePropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            return new LilToonLitePropertyEntity
            {
                Base = GetLilLiteBasePropertyValues(material),
                Lighting = GetLilLightingPropertyValues(material),
                LightingAdvanced = GetLilLightingAdvancedPropertyValues(material),
                Main = GetLilLiteMainPropertyValues(material),
                Shadow = GetLilLiteShadowPropertyValues(material),
                MatCap = GetLilLiteMatCapPropertyValues(material),
                Rim = GetLilLiteRimPropertyValues(material),
                Emission = GetLilLiteEmissionPropertyValues(material),
                Outline = GetLilLiteOutlinePropertyValues(material, propertyContainer.IsOutline),
                OutlineRendering = GetLilOutlineRenderingPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingForward = GetLilOutlineRenderingForwardPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingForwardAdd = GetLilOutlineRenderingForwardAddPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingStencil = GetLilOutlineRenderingStencilPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                Rendering = GetLilRenderingPropertyValues(material),
                RenderingForward = GetLilRenderingForwardPropertyValues(material),
                RenderingForwardAdd = GetLilRenderingForwardAddPropertyValues(material, propertyContainer.IsGem),
                RenderingStencil = GetLilRenderingStencilPropertyValues(material),
                Save = GetLilSavePropertyValues(material),
            };
        }

        /// <summary>
        /// Get the lilToon Normal property entity from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        /// <returns>A lilToon Normal property entity.</returns>
        public virtual LilToonNormalPropertyEntity GetLilToonNormalPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            return new LilToonNormalPropertyEntity
            {
                Base = GetLilBasePropertyValues(material),
                Lighting = GetLilLightingPropertyValues(material),
                LightingAdvanced = GetLilLightingAdvancedPropertyValues(material),
                Main = GetLilMainPropertyValues(material),
                Main2nd = GetLilMain2ndPropertyValues(material),
                Main3rd = GetLilMain3rdPropertyValues(material),
                AlphaMask = GetLilAlphaMaskPropertyValues(material),
                NormalMap = GetLilNormalMapPropertyValues(material),
                NormalMap2nd = GetLilNormalMap2ndPropertyValues(material),
                Anisotropy = GetLilAnisotropyPropertyValues(material),
                Backlight = GetLilBacklightPropertyValues(material),
                Shadow = GetLilShadowPropertyValues(material),
                Reflection = GetLilReflectionPropertyValues(material),
                MatCap = GetLilMatCapPropertyValues(material),
                MatCap2nd = GetLilMatCap2ndPropertyValues(material),
                Rim = GetLilRimPropertyValues(material),
                Glitter = GetLilGlitterPropertyValues(material),
                Emission = GetLilEmissionPropertyValues(material),
                EmissionGradation = GetLilEmissionGradationPropertyValues(material),
                Emission2nd = GetLilEmission2ndPropertyValues(material),
                Emission2ndGradation = GetLilEmission2ndGradationPropertyValues(material),
                Parallax = GetLilParallaxPropertyValues(material),
                DistanceFade = GetLilDistanceFadePropertyValues(material),
                AudioLink = GetLilAudioLinkPropertyValues(material),
                Dissolve = GetLilDissolvePropertyValues(material),
#if LILTOON_1_4_0_OR_NEWER
                IDMask = GetLilIDMaskPropertyValues(material),  // v1.4.0
#endif
                Encryption = GetLilEncryptionPropertyValues(material),
                Refraction = GetLilRefractionPropertyValues(material, propertyContainer.IsRefraction, propertyContainer.IsGem),
                Fur = GetLilFurPropertyValues(material, propertyContainer.IsFur),
                FurRendering = GetLilFurRenderingPropertyValues(material, propertyContainer.IsFur),
                FurRenderingForward = GetLilFurRenderingForwardPropertyValues(material, propertyContainer.IsFur),
                FurRenderingForwardAdd = GetLilFurRenderingForwardAddPropertyValues(material, propertyContainer.IsFur),
                FurRenderingStencil = GetLilFurRenderingStencilPropertyValues(material, propertyContainer.IsFur),
                Gem = GetLilGemPropertyValues(material, propertyContainer.IsGem),
                Tessellation = GetLilTessellationPropertyValues(material, propertyContainer.IsTessellation),
                Outline = GetLilOutlinePropertyValues(material, propertyContainer.IsOutline),
                OutlineRendering = GetLilOutlineRenderingPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingForward = GetLilOutlineRenderingForwardPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingForwardAdd = GetLilOutlineRenderingForwardAddPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
                OutlineRenderingStencil = GetLilOutlineRenderingStencilPropertyValues(material, propertyContainer.IsOutline, propertyContainer.IsRefraction),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Multi = GetLilMultiPropertyValues(material, isMulti: propertyContainer.PropertyEntityType == LilPropertyEntityType.Multi),  // v1.3.0
#endif
                Rendering = GetLilRenderingPropertyValues(material),
                RenderingForward = GetLilRenderingForwardPropertyValues(material),
                RenderingForwardAdd = GetLilRenderingForwardAddPropertyValues(material, propertyContainer.IsGem),
                RenderingStencil = GetLilRenderingStencilPropertyValues(material),
                Save = GetLilSavePropertyValues(material),
            };
        }

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
        //
#elif LILTOON_1_2_12_OR_OLDER
        /// <summary>
        /// Get the lilToon Multi property entity from the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        /// <returns>A lilToon Multi property entity.</returns>
        public virtual LilToonMultiPropertyEntity GetLilToonMultiPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            var multiPropertyEntity = GetLilToonNormalPropertyEntity(material, propertyContainer) as LilToonMultiPropertyEntity;

            multiPropertyEntity.Multi = GetLilMultiPropertyValues(material, isMulti: propertyContainer.PropertyEntityType == LilPropertyEntityType.Multi);

            return multiPropertyEntity;
        }
#endif

        /// <summary>
        /// Get the lilToon FakeShadow property values from the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        /// <returns>A lilToon FakeShadow property entity.</returns>
        public virtual LilToonFakeShadowPropertyEntity GetLilToonFakeShadowPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            return new LilToonFakeShadowPropertyEntity
            {
                Base = GetLilFakeShadowBasePropertyValues(material),
                Main = GetLilFakeShadowMainPropertyValues(material),
                Encryption = GetLilEncryptionPropertyValues(material),
                Rendering = GetLilRenderingPropertyValues(material, isFakeShadow: true),
                RenderingForward = GetLilRenderingForwardPropertyValues(material),
                RenderingStencil = GetLilRenderingStencilPropertyValues(material),
                Save = GetLilSavePropertyValues(material),
            };
        }

        #endregion

        #region Methods (Block)

        #region Base (Normal, Lite, FakeShadow)

        /// <summary>
        /// Get the lilToon Base property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilBase GetLilBasePropertyValues(Material material)
        {
            return new LilBase
            {
                Invisible = material.GetSafeBool(PropertyNameID.Invisible),
                FlipNormal = material.GetSafeBool(PropertyNameID.FlipNormal),
                ShiftBackfaceUV = material.GetSafeBool(PropertyNameID.ShiftBackfaceUV),
                BackfaceForceShadow = material.GetSafeBool(PropertyNameID.BackfaceForceShadow),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                BackfaceColor = material.GetSafeColor(PropertyNameID.BackfaceColor),  // v1.3.0
                AAStrength = material.GetSafeFloat(PropertyNameID.AAStrength),  // v1.3.7
#endif
#if LILTOON_1_4_0_OR_NEWER
                UseDither = material.GetSafeBool(PropertyNameID.UseDither),             // v1.4.0
                DitherTex = material.GetSafeTexture(PropertyNameID.DitherTex),          // v1.4.0
                DitherMaxValue = material.GetSafeFloat(PropertyNameID.DitherMaxValue),  // v1.4.0
#endif
            };
        }

        /// <summary>
        /// Get the lilToon Lite Base property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteBase GetLilLiteBasePropertyValues(Material material)
        {
            return new LilLiteBase
            {
                Invisible = material.GetSafeBool(PropertyNameID.Invisible),
                FlipNormal = material.GetSafeBool(PropertyNameID.FlipNormal),
                ShiftBackfaceUV = material.GetSafeBool(PropertyNameID.ShiftBackfaceUV),
                BackfaceForceShadow = material.GetSafeBool(PropertyNameID.BackfaceForceShadow),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                AAStrength = material.GetSafeFloat(PropertyNameID.AAStrength),  // v1.3.7
#endif
                TriMask = material.GetSafeTexture(PropertyNameID.TriMask),
            };
        }

        /// <summary>
        /// Get the lilToon Fake Shadow Base property values from the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <returns></returns>
        public virtual LilFakeShadowBase GetLilFakeShadowBasePropertyValues(Material material)
        {
            return new LilFakeShadowBase
            {
                Invisible = material.GetSafeBool(PropertyNameID.Invisible),
            };
        }

        #endregion

        #region Lighting

        /// <summary>
        /// Get the lilToon Lighting property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilLighting GetLilLightingPropertyValues(Material material)
        {
            return new LilLighting
            {
                LightMinLimit = material.GetSafeFloat(PropertyNameID.LightMinLimit),
                LightMaxLimit = material.GetSafeFloat(PropertyNameID.LightMaxLimit),
                MonochromeLighting = material.GetSafeFloat(PropertyNameID.MonochromeLighting),
            };
        }

        /// <summary>
        /// Get the lilToon Lighting Advanced property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilLightingAdvanced GetLilLightingAdvancedPropertyValues(Material material)
        {
            return new LilLightingAdvanced
            {
                AsUnlit = material.GetSafeBool(PropertyNameID.AsUnlit),
                VertexLightStrength = material.GetSafeFloat(PropertyNameID.VertexLightStrength),
                LightDirectionOverride = material.GetSafeVector3(PropertyNameID.LightDirectionOverride),
                AlphaBoostFA = material.GetSafeFloat(PropertyNameID.AlphaBoostFA),
                BeforeExposureLimit = material.GetSafeFloat(PropertyNameID.BeforeExposureLimit),
                LilDirectionalLightStrength = material.GetSafeFloat(PropertyNameID.LilDirectionalLightStrength),
            };
        }

        #endregion

        #region Main (Normal, Lite, FakeShadow)

        /// <summary>
        /// Get the lilToon Fake Shadow Main property values from the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <returns></returns>
        public virtual LilFakeShadowMain GetLilFakeShadowMainPropertyValues(Material material)
        {
            return new LilFakeShadowMain
            {
                Color = material.GetSafeColor(PropertyNameID.Color),
                MainTex = material.GetSafeTexture(PropertyNameID.MainTex),
                FakeShadowVector = material.GetSafeVector4(PropertyNameID.FakeShadowVector),
            };
        }

        /// <summary>
        /// Get the lilToon Lite Main property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteMain GetLilLiteMainPropertyValues(Material material)
        {
            return new LilLiteMain
            {
                Color = material.GetSafeColor(PropertyNameID.Color),
                MainTex = material.GetSafeTexture(PropertyNameID.MainTex),
                MainTex_ScrollRotate = material.GetSafeVector4(PropertyNameID.MainTex_ScrollRotate),
            };
        }

        /// <summary>
        /// Get the lilToon Main property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain GetLilMainPropertyValues(Material material)
        {
            return new LilMain
            {
                Color = material.GetSafeColor(PropertyNameID.Color),
                MainTex = material.GetSafeTexture(PropertyNameID.MainTex),
                MainTex_ScrollRotate = material.GetSafeVector4(PropertyNameID.MainTex_ScrollRotate),
                MainTexHSVG = material.GetSafeVector4(PropertyNameID.MainTexHSVG),
                MainGradationStrength = material.GetSafeFloat(PropertyNameID.MainGradationStrength),
                MainGradationTex = material.GetSafeTexture(PropertyNameID.MainGradationTex),
                MainColorAdjustMask = material.GetSafeTexture(PropertyNameID.MainColorAdjustMask),
            };
        }

        /// <summary>
        /// Get the lilToon Main 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain2nd GetLilMain2ndPropertyValues(Material material)
        {
            return new LilMain2nd
            {
                UseMain2ndTex = material.GetSafeBool(PropertyNameID.UseMain2ndTex),
                Color2nd = material.GetSafeColor(PropertyNameID.Color2nd),
                Main2ndTex = material.GetSafeTexture(PropertyNameID.Main2ndTex),
                Main2ndTexAngle = material.GetSafeFloat(PropertyNameID.Main2ndTexAngle),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Main2ndTex_ScrollRotate = material.GetSafeVector4(PropertyNameID.Main2ndTex_ScrollRotate),  // v1.3.7
#endif
                Main2ndTex_UVMode = material.GetSafeEnum<LilMainUVMode>(PropertyNameID.Main2ndTex_UVMode),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Main2ndTex_Cull = material.GetSafeEnum<CullMode>(PropertyNameID.Main2ndTex_Cull),  // v1.3.1
#endif
                Main2ndTexDecalAnimation = material.GetSafeVector4(PropertyNameID.Main2ndTexDecalAnimation),
                Main2ndTexDecalSubParam = material.GetSafeVector4(PropertyNameID.Main2ndTexDecalSubParam),
                Main2ndTexIsDecal = material.GetSafeBool(PropertyNameID.Main2ndTexIsDecal),
                Main2ndTexIsLeftOnly = material.GetSafeBool(PropertyNameID.Main2ndTexIsLeftOnly),
                Main2ndTexIsRightOnly = material.GetSafeBool(PropertyNameID.Main2ndTexIsRightOnly),
                Main2ndTexShouldCopy = material.GetSafeBool(PropertyNameID.Main2ndTexShouldCopy),
                Main2ndTexShouldFlipMirror = material.GetSafeBool(PropertyNameID.Main2ndTexShouldFlipMirror),
                Main2ndTexShouldFlipCopy = material.GetSafeBool(PropertyNameID.Main2ndTexShouldFlipCopy),
                Main2ndTexIsMSDF = material.GetSafeBool(PropertyNameID.Main2ndTexIsMSDF),
                Main2ndBlendMask = material.GetSafeTexture(PropertyNameID.Main2ndBlendMask),
                Main2ndTexBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.Main2ndTexBlendMode),
#if LILTOON_1_4_0_OR_NEWER
                Main2ndTexAlphaMode = material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.Main2ndTexAlphaMode),  // v1.4.0
#endif
                Main2ndEnableLighting = material.GetSafeBool(PropertyNameID.Main2ndEnableLighting),
                Main2ndDissolveMask = material.GetSafeTexture(PropertyNameID.Main2ndDissolveMask),
                Main2ndDissolveNoiseMask = material.GetSafeTexture(PropertyNameID.Main2ndDissolveNoiseMask),
                Main2ndDissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.Main2ndDissolveNoiseMask_ScrollRotate),
                Main2ndDissolveNoiseStrength = material.GetSafeFloat(PropertyNameID.Main2ndDissolveNoiseStrength),
                Main2ndDissolveColor = material.GetSafeColor(PropertyNameID.Main2ndDissolveColor),
                Main2ndDissolveParams = material.GetSafeVector4(PropertyNameID.Main2ndDissolveParams),
                Main2ndDissolvePos = material.GetSafeVector4(PropertyNameID.Main2ndDissolvePos),
                Main2ndDistanceFade = material.GetSafeVector4(PropertyNameID.Main2ndDistanceFade),
            };
        }

        /// <summary>
        /// Get the lilToon Main 3rd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain3rd GetLilMain3rdPropertyValues(Material material)
        {
            return new LilMain3rd
            {
                UseMain3rdTex = material.GetSafeBool(PropertyNameID.UseMain3rdTex),
                Color3rd = material.GetSafeColor(PropertyNameID.Color3rd),
                Main3rdTex = material.GetSafeTexture(PropertyNameID.Main3rdTex),
                Main3rdTexAngle = material.GetSafeFloat(PropertyNameID.Main3rdTexAngle),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Main3rdTex_ScrollRotate = material.GetSafeVector4(PropertyNameID.Main3rdTex_ScrollRotate),  // v1.3.7
#endif
                Main3rdTex_UVMode = material.GetSafeEnum<LilMainUVMode>(PropertyNameID.Main3rdTex_UVMode),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Main3rdTex_Cull = material.GetSafeEnum<CullMode>(PropertyNameID.Main3rdTex_Cull),  // v1.3.1
#endif
                Main3rdTexDecalAnimation = material.GetSafeVector4(PropertyNameID.Main3rdTexDecalAnimation),
                Main3rdTexDecalSubParam = material.GetSafeVector4(PropertyNameID.Main3rdTexDecalSubParam),
                Main3rdTexIsDecal = material.GetSafeBool(PropertyNameID.Main3rdTexIsDecal),
                Main3rdTexIsLeftOnly = material.GetSafeBool(PropertyNameID.Main3rdTexIsLeftOnly),
                Main3rdTexIsRightOnly = material.GetSafeBool(PropertyNameID.Main3rdTexIsRightOnly),
                Main3rdTexShouldCopy = material.GetSafeBool(PropertyNameID.Main3rdTexShouldCopy),
                Main3rdTexShouldFlipMirror = material.GetSafeBool(PropertyNameID.Main3rdTexShouldFlipMirror),
                Main3rdTexShouldFlipCopy = material.GetSafeBool(PropertyNameID.Main3rdTexShouldFlipCopy),
                Main3rdTexIsMSDF = material.GetSafeBool(PropertyNameID.Main3rdTexIsMSDF),
                Main3rdBlendMask = material.GetSafeTexture(PropertyNameID.Main3rdBlendMask),
#if LILTOON_1_4_0_OR_NEWER
                Main3rdTexAlphaMode = material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.Main3rdTexAlphaMode),  // v1.4.0
#endif
                Main3rdTexBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.Main3rdTexBlendMode),
                Main3rdEnableLighting = material.GetSafeBool(PropertyNameID.Main3rdEnableLighting),
                Main3rdDissolveMask = material.GetSafeTexture(PropertyNameID.Main3rdDissolveMask),
                Main3rdDissolveNoiseMask = material.GetSafeTexture(PropertyNameID.Main3rdDissolveNoiseMask),
                Main3rdDissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.Main3rdDissolveNoiseMask_ScrollRotate),
                Main3rdDissolveNoiseStrength = material.GetSafeFloat(PropertyNameID.Main3rdDissolveNoiseStrength),
                Main3rdDissolveColor = material.GetSafeColor(PropertyNameID.Main3rdDissolveColor),
                Main3rdDissolveParams = material.GetSafeVector4(PropertyNameID.Main3rdDissolveParams),
                Main3rdDissolvePos = material.GetSafeVector4(PropertyNameID.Main3rdDissolvePos),
                Main3rdDistanceFade = material.GetSafeVector4(PropertyNameID.Main3rdDistanceFade),
            };
        }

        #endregion

        #region Alpha Mask

        /// <summary>
        /// Get the lilToon Alpha Mask property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilAlphaMask GetLilAlphaMaskPropertyValues(Material material)
        {
            return new LilAlphaMask
            {
                AlphaMaskMode = material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.AlphaMaskMode),
                AlphaMask = material.GetSafeTexture(PropertyNameID.AlphaMask),
                AlphaMaskScale = material.GetSafeFloat(PropertyNameID.AlphaMaskScale),
                AlphaMaskValue = material.GetSafeFloat(PropertyNameID.AlphaMaskValue),
            };
        }

        #endregion

        #region NormalCap

        /// <summary>
        /// Get the lilToon NormalMap property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilNormalMap GetLilNormalMapPropertyValues(Material material)
        {
            return new LilNormalMap
            {
                UseBumpMap = material.GetSafeBool(PropertyNameID.UseBumpMap),
                BumpMap = material.GetSafeTexture(PropertyNameID.BumpMap),
                BumpScale = material.GetSafeFloat(PropertyNameID.BumpScale),
            };
        }

        /// <summary>
        /// Get the lilToon NormalMap 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilNormalMap2nd GetLilNormalMap2ndPropertyValues(Material material)
        {
            return new LilNormalMap2nd
            {
                UseBump2ndMap = material.GetSafeBool(PropertyNameID.UseBump2ndMap),
                Bump2ndMap = material.GetSafeTexture(PropertyNameID.Bump2ndMap),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Bump2ndMap_UVMode = material.GetSafeEnum<LilNormalMapUVMode>(PropertyNameID.Bump2ndMap_UVMode),  // v1.3.1
#endif
                Bump2ndScale = material.GetSafeFloat(PropertyNameID.Bump2ndScale),
                Bump2ndScaleMask = material.GetSafeTexture(PropertyNameID.Bump2ndScaleMask),
            };
        }

        #endregion

        #region Anisotropy

        /// <summary>
        /// Get the lilToon Anisotropy property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilAnisotropy GetLilAnisotropyPropertyValues(Material material)
        {
            return new LilAnisotropy
            {
                UseAnisotropy = material.GetSafeBool(PropertyNameID.UseAnisotropy),
                AnisotropyTangentMap = material.GetSafeTexture(PropertyNameID.AnisotropyTangentMap),
                AnisotropyScale = material.GetSafeFloat(PropertyNameID.AnisotropyScale),
                AnisotropyScaleMask = material.GetSafeTexture(PropertyNameID.AnisotropyScaleMask),
                AnisotropyTangentWidth = material.GetSafeFloat(PropertyNameID.AnisotropyTangentWidth),
                AnisotropyBitangentWidth = material.GetSafeFloat(PropertyNameID.AnisotropyBitangentWidth),
                AnisotropyShift = material.GetSafeFloat(PropertyNameID.AnisotropyShift),
                AnisotropyShiftNoiseScale = material.GetSafeFloat(PropertyNameID.AnisotropyShiftNoiseScale),
                AnisotropySpecularStrength = material.GetSafeFloat(PropertyNameID.AnisotropySpecularStrength),
                Anisotropy2ndTangentWidth = material.GetSafeFloat(PropertyNameID.Anisotropy2ndTangentWidth),
                Anisotropy2ndBitangentWidth = material.GetSafeFloat(PropertyNameID.Anisotropy2ndBitangentWidth),
                Anisotropy2ndShift = material.GetSafeFloat(PropertyNameID.Anisotropy2ndShift),
                Anisotropy2ndShiftNoiseScale = material.GetSafeFloat(PropertyNameID.Anisotropy2ndShiftNoiseScale),
                Anisotropy2ndSpecularStrength = material.GetSafeFloat(PropertyNameID.Anisotropy2ndSpecularStrength),
                AnisotropyShiftNoiseMask = material.GetSafeTexture(PropertyNameID.AnisotropyShiftNoiseMask),
                Anisotropy2Reflection = material.GetSafeBool(PropertyNameID.Anisotropy2Reflection),
                Anisotropy2MatCap = material.GetSafeBool(PropertyNameID.Anisotropy2MatCap),
                Anisotropy2MatCap2nd = material.GetSafeBool(PropertyNameID.Anisotropy2MatCap2nd),
            };
        }

        #endregion

        #region Backlight

        /// <summary>
        /// Get the lilToon Backlight property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilBacklight GetLilBacklightPropertyValues(Material material)
        {
            return new LilBacklight
            {
                UseBacklight = material.GetSafeBool(PropertyNameID.UseBacklight),
                BacklightColor = material.GetSafeColor(PropertyNameID.BacklightColor),
                BacklightColorTex = material.GetSafeTexture(PropertyNameID.BacklightColorTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                BacklightMainStrength = material.GetSafeFloat(PropertyNameID.BacklightMainStrength),  // v1.3.0
#endif
                BacklightNormalStrength = material.GetSafeFloat(PropertyNameID.BacklightNormalStrength),
                BacklightBorder = material.GetSafeFloat(PropertyNameID.BacklightBorder),
                BacklightBlur = material.GetSafeFloat(PropertyNameID.BacklightBlur),
                BacklightDirectivity = material.GetSafeFloat(PropertyNameID.BacklightDirectivity),
                BacklightViewStrength = material.GetSafeFloat(PropertyNameID.BacklightViewStrength),
                BacklightReceiveShadow = material.GetSafeBool(PropertyNameID.BacklightReceiveShadow),
                BacklightBackfaceMask = material.GetSafeBool(PropertyNameID.BacklightBackfaceMask),
            };
        }

        #endregion

        #region Shadow (Normal, Lite)

        /// <summary>
        /// Get the lilToon Lite Shadow property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteShadow GetLilLiteShadowPropertyValues(Material material)
        {
            return new LilLiteShadow
            {
                UseShadow = material.GetSafeBool(PropertyNameID.UseShadow),
                ShadowColorTex = material.GetSafeTexture(PropertyNameID.ShadowColorTex),
                ShadowBorder = material.GetSafeFloat(PropertyNameID.ShadowBorder),
                ShadowBlur = material.GetSafeFloat(PropertyNameID.ShadowBlur),
                Shadow2ndColorTex = material.GetSafeTexture(PropertyNameID.Shadow2ndColorTex),
                Shadow2ndBorder = material.GetSafeFloat(PropertyNameID.Shadow2ndBorder),
                Shadow2ndBlur = material.GetSafeFloat(PropertyNameID.Shadow2ndBlur),
                ShadowBorderColor = material.GetSafeColor(PropertyNameID.ShadowBorderColor),
                ShadowBorderRange = material.GetSafeFloat(PropertyNameID.ShadowBorderRange),
                ShadowEnvStrength = material.GetSafeFloat(PropertyNameID.ShadowEnvStrength),
            };
        }

        /// <summary>
        /// Get the lilToon Shadow property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilShadow GetLilShadowPropertyValues(Material material)
        {
            return new LilShadow
            {
                UseShadow = material.GetSafeBool(PropertyNameID.UseShadow),
                //ShadowReceive = material.GetSafeBool(PropertyNameID.ShadowReceive),
                ShadowStrength = material.GetSafeFloat(PropertyNameID.ShadowStrength),
                ShadowStrengthMask = material.GetSafeTexture(PropertyNameID.ShadowStrengthMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ShadowStrengthMaskLOD = material.GetSafeFloat(PropertyNameID.ShadowStrengthMaskLOD),  // v1.3.0
#endif
                ShadowBorderMask = material.GetSafeTexture(PropertyNameID.ShadowBorderMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ShadowBorderMaskLOD = material.GetSafeFloat(PropertyNameID.ShadowBorderMaskLOD),  // v1.3.0
#endif
                ShadowBlurMask = material.GetSafeTexture(PropertyNameID.ShadowBlurMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ShadowBlurMaskLOD = material.GetSafeFloat(PropertyNameID.ShadowBlurMaskLOD),  // v1.3.0
#endif
                ShadowAOShift = material.GetSafeVector4(PropertyNameID.ShadowAOShift),
                ShadowAOShift2 = material.GetSafeVector4(PropertyNameID.ShadowAOShift2),
                ShadowPostAO = material.GetSafeBool(PropertyNameID.ShadowPostAO),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ShadowColorType = material.GetSafeEnum<LilShadowColorType>(PropertyNameID.ShadowColorType),  // v1.3.5
#endif
                ShadowColor = material.GetSafeColor(PropertyNameID.ShadowColor),
                ShadowColorTex = material.GetSafeTexture(PropertyNameID.ShadowColorTex),
                ShadowNormalStrength = material.GetSafeFloat(PropertyNameID.ShadowNormalStrength),
                ShadowBorder = material.GetSafeFloat(PropertyNameID.ShadowBorder),
                ShadowBlur = material.GetSafeFloat(PropertyNameID.ShadowBlur),
                ShadowReceive = material.GetSafeBool(PropertyNameID.ShadowReceive),
                Shadow2ndColor = material.GetSafeColor(PropertyNameID.Shadow2ndColor),
                Shadow2ndColorTex = material.GetSafeTexture(PropertyNameID.Shadow2ndColorTex),
                Shadow2ndNormalStrength = material.GetSafeFloat(PropertyNameID.Shadow2ndNormalStrength),
                Shadow2ndBorder = material.GetSafeFloat(PropertyNameID.Shadow2ndBorder),
                Shadow2ndBlur = material.GetSafeFloat(PropertyNameID.Shadow2ndBlur),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Shadow2ndReceive = material.GetSafeBool(PropertyNameID.Shadow2ndReceive),  // v1.3.0
#endif
                Shadow3rdColor = material.GetSafeColor(PropertyNameID.Shadow3rdColor),
                Shadow3rdColorTex = material.GetSafeTexture(PropertyNameID.Shadow3rdColorTex),
                Shadow3rdNormalStrength = material.GetSafeFloat(PropertyNameID.Shadow3rdNormalStrength),
                Shadow3rdBorder = material.GetSafeFloat(PropertyNameID.Shadow3rdBorder),
                Shadow3rdBlur = material.GetSafeFloat(PropertyNameID.Shadow3rdBlur),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Shadow3rdReceive = material.GetSafeBool(PropertyNameID.Shadow3rdReceive),  // v1.3.0
#endif
                ShadowBorderColor = material.GetSafeColor(PropertyNameID.ShadowBorderColor),
                ShadowBorderRange = material.GetSafeFloat(PropertyNameID.ShadowBorderRange),
                ShadowMainStrength = material.GetSafeFloat(PropertyNameID.ShadowMainStrength),
                ShadowEnvStrength = material.GetSafeFloat(PropertyNameID.ShadowEnvStrength),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ShadowMaskType = material.GetSafeEnum<LilShadowMaskType>(PropertyNameID.ShadowMaskType),  // v1.3.0
                ShadowFlatBorder = material.GetSafeFloat(PropertyNameID.ShadowFlatBorder),  // v1.3.0
                ShadowFlatBlur = material.GetSafeFloat(PropertyNameID.ShadowFlatBlur),  // v1.3.0
#endif
            };
        }

        #endregion

        #region Reflection

        /// <summary>
        /// Get the lilToon Reflection property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilReflection GetLilReflectionPropertyValues(Material material)
        {
            return new LilReflection
            {
                UseReflection = material.GetSafeBool(PropertyNameID.UseReflection),
                Smoothness = material.GetSafeFloat(PropertyNameID.Smoothness),
                SmoothnessTex = material.GetSafeTexture(PropertyNameID.SmoothnessTex),
                Metallic = material.GetSafeFloat(PropertyNameID.Metallic),
                MetallicGlossMap = material.GetSafeTexture(PropertyNameID.MetallicGlossMap),
                Reflectance = material.GetSafeFloat(PropertyNameID.Reflectance),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                GSAAStrength = material.GetSafeFloat(PropertyNameID.GSAAStrength),  // v1.3.0
#endif
                ApplySpecular = material.GetSafeBool(PropertyNameID.ApplySpecular),
                ApplySpecularFA = material.GetSafeBool(PropertyNameID.ApplySpecularFA),
                SpecularToon = material.GetSafeBool(PropertyNameID.SpecularToon),
                SpecularNormalStrength = material.GetSafeFloat(PropertyNameID.SpecularNormalStrength),
                SpecularBorder = material.GetSafeFloat(PropertyNameID.SpecularBorder),
                SpecularBlur = material.GetSafeFloat(PropertyNameID.SpecularBlur),
                ApplyReflection = material.GetSafeBool(PropertyNameID.ApplyReflection),
                ReflectionNormalStrength = material.GetSafeFloat(PropertyNameID.ReflectionNormalStrength),
                ReflectionColor = material.GetSafeColor(PropertyNameID.ReflectionColor),
                ReflectionColorTex = material.GetSafeTexture(PropertyNameID.ReflectionColorTex),
                ReflectionApplyTransparency = material.GetSafeBool(PropertyNameID.ReflectionApplyTransparency),
                ReflectionCubeTex = material.GetSafeTexture(PropertyNameID.ReflectionCubeTex),
                ReflectionCubeColor = material.GetSafeColor(PropertyNameID.ReflectionCubeColor),
                ReflectionCubeOverride = material.GetSafeBool(PropertyNameID.ReflectionCubeOverride),
                ReflectionCubeEnableLighting = material.GetSafeFloat(PropertyNameID.ReflectionCubeEnableLighting),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                ReflectionBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.ReflectionBlendMode),  // v1.3.0
#endif
            };
        }

        #endregion

        #region MatCap (Normal, Lite)

        /// <summary>
        /// Get the lilToon Lite MatCap property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteMatCap GetLilLiteMatCapPropertyValues(Material material)
        {
            return new LilLiteMatCap
            {
                UseMatCap = material.GetSafeBool(PropertyNameID.UseMatCap),
                MatCapTex = material.GetSafeTexture(PropertyNameID.MatCapTex),
                MatCapBlendUV1 = material.GetSafeVector4(PropertyNameID.MatCapBlendUV1),
                MatCapZRotCancel = material.GetSafeBool(PropertyNameID.MatCapZRotCancel),
                MatCapPerspective = material.GetSafeBool(PropertyNameID.MatCapPerspective),
                MatCapVRParallaxStrength = material.GetSafeFloat(PropertyNameID.MatCapVRParallaxStrength),
                MatCapMul = material.GetSafeBool(PropertyNameID.MatCapMul),  // Lite only
            };
        }

        /// <summary>
        /// Get the lilToon MatCap property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMatCap GetLilMatCapPropertyValues(Material material)
        {
            return new LilMatCap
            {
                UseMatCap = material.GetSafeBool(PropertyNameID.UseMatCap),
                MatCapColor = material.GetSafeColor(PropertyNameID.MatCapColor),
                MatCapTex = material.GetSafeTexture(PropertyNameID.MatCapTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                MatCapMainStrength = material.GetSafeFloat(PropertyNameID.MatCapMainStrength),  // v1.3.0
#endif
                MatCapBlendUV1 = material.GetSafeVector4(PropertyNameID.MatCapBlendUV1),
                MatCapZRotCancel = material.GetSafeBool(PropertyNameID.MatCapZRotCancel),
                MatCapPerspective = material.GetSafeBool(PropertyNameID.MatCapPerspective),
                MatCapVRParallaxStrength = material.GetSafeFloat(PropertyNameID.MatCapVRParallaxStrength),
                MatCapBlend = material.GetSafeFloat(PropertyNameID.MatCapBlend),
                MatCapBlendMask = material.GetSafeTexture(PropertyNameID.MatCapBlendMask),
                MatCapEnableLighting = material.GetSafeFloat(PropertyNameID.MatCapEnableLighting),
                MatCapShadowMask = material.GetSafeFloat(PropertyNameID.MatCapShadowMask),
                MatCapBackfaceMask = material.GetSafeBool(PropertyNameID.MatCapBackfaceMask),
                MatCapLod = material.GetSafeFloat(PropertyNameID.MatCapLod),
                MatCapBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.MatCapBlendMode),
                MatCapApplyTransparency = material.GetSafeBool(PropertyNameID.MatCapApplyTransparency),
                MatCapNormalStrength = material.GetSafeFloat(PropertyNameID.MatCapNormalStrength),
                MatCapCustomNormal = material.GetSafeBool(PropertyNameID.MatCapCustomNormal),
                MatCapBumpMap = material.GetSafeTexture(PropertyNameID.MatCapBumpMap),
                MatCapBumpScale = material.GetSafeFloat(PropertyNameID.MatCapBumpScale),
            };
        }

        /// <summary>
        /// Get the lilToon MatCap 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMatCap2nd GetLilMatCap2ndPropertyValues(Material material)
        {
            return new LilMatCap2nd
            {
                UseMatCap2nd = material.GetSafeBool(PropertyNameID.UseMatCap2nd),
                MatCap2ndColor = material.GetSafeColor(PropertyNameID.MatCap2ndColor),
                MatCap2ndTex = material.GetSafeTexture(PropertyNameID.MatCap2ndTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                MatCap2ndMainStrength = material.GetSafeFloat(PropertyNameID.MatCap2ndMainStrength),  // v1.3.0
#endif
                MatCap2ndBlendUV1 = material.GetSafeVector4(PropertyNameID.MatCap2ndBlendUV1),
                MatCap2ndZRotCancel = material.GetSafeBool(PropertyNameID.MatCap2ndZRotCancel),
                MatCap2ndPerspective = material.GetSafeBool(PropertyNameID.MatCap2ndPerspective),
                MatCap2ndVRParallaxStrength = material.GetSafeFloat(PropertyNameID.MatCap2ndVRParallaxStrength),
                MatCap2ndBlend = material.GetSafeFloat(PropertyNameID.MatCap2ndBlend),
                MatCap2ndBlendMask = material.GetSafeTexture(PropertyNameID.MatCap2ndBlendMask),
                MatCap2ndEnableLighting = material.GetSafeFloat(PropertyNameID.MatCap2ndEnableLighting),
                MatCap2ndShadowMask = material.GetSafeFloat(PropertyNameID.MatCap2ndShadowMask),
                MatCap2ndBackfaceMask = material.GetSafeBool(PropertyNameID.MatCap2ndBackfaceMask),
                MatCap2ndLod = material.GetSafeFloat(PropertyNameID.MatCap2ndLod),
                MatCap2ndBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.MatCap2ndBlendMode),
                MatCap2ndApplyTransparency = material.GetSafeBool(PropertyNameID.MatCap2ndApplyTransparency),
                MatCap2ndNormalStrength = material.GetSafeFloat(PropertyNameID.MatCap2ndNormalStrength),
                MatCap2ndCustomNormal = material.GetSafeBool(PropertyNameID.MatCap2ndCustomNormal),
                MatCap2ndBumpMap = material.GetSafeTexture(PropertyNameID.MatCap2ndBumpMap),
                MatCap2ndBumpScale = material.GetSafeFloat(PropertyNameID.MatCap2ndBumpScale),
            };
        }

        #endregion

        #region Rim (Normal, Lite)

        /// <summary>
        /// Get the lilToon Lite Rim property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteRim GetLilLiteRimPropertyValues(Material material)
        {
            return new LilLiteRim
            {
                UseRim = material.GetSafeBool(PropertyNameID.UseRim),
                RimColor = material.GetSafeColor(PropertyNameID.RimColor),
                RimBorder = material.GetSafeFloat(PropertyNameID.RimBorder),
                RimBlur = material.GetSafeFloat(PropertyNameID.RimBlur),
                RimFresnelPower = material.GetSafeFloat(PropertyNameID.RimFresnelPower),
                RimShadowMask = material.GetSafeFloat(PropertyNameID.RimShadowMask),
            };
        }

        /// <summary>
        /// Get the lilToon Rim property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRim GetLilRimPropertyValues(Material material)
        {
            return new LilRim
            {
                UseRim = material.GetSafeBool(PropertyNameID.UseRim),
                RimColor = material.GetSafeColor(PropertyNameID.RimColor),
                RimColorTex = material.GetSafeTexture(PropertyNameID.RimColorTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                RimMainStrength = material.GetSafeFloat(PropertyNameID.RimMainStrength),  // v1.3.0
#endif
                RimNormalStrength = material.GetSafeFloat(PropertyNameID.RimNormalStrength),
                RimBorder = material.GetSafeFloat(PropertyNameID.RimBorder),
                RimBlur = material.GetSafeFloat(PropertyNameID.RimBlur),
                RimFresnelPower = material.GetSafeFloat(PropertyNameID.RimFresnelPower),
                RimEnableLighting = material.GetSafeFloat(PropertyNameID.RimEnableLighting),
                RimShadowMask = material.GetSafeFloat(PropertyNameID.RimShadowMask),
                RimBackfaceMask = material.GetSafeBool(PropertyNameID.RimBackfaceMask),
                RimVRParallaxStrength = material.GetSafeFloat(PropertyNameID.RimVRParallaxStrength),
                RimApplyTransparency = material.GetSafeBool(PropertyNameID.RimApplyTransparency),
                RimDirStrength = material.GetSafeFloat(PropertyNameID.RimDirStrength),
                RimDirRange = material.GetSafeFloat(PropertyNameID.RimDirRange),
                RimIndirRange = material.GetSafeFloat(PropertyNameID.RimIndirRange),
                RimIndirColor = material.GetSafeColor(PropertyNameID.RimIndirColor),
                RimIndirBorder = material.GetSafeFloat(PropertyNameID.RimIndirBorder),
                RimIndirBlur = material.GetSafeFloat(PropertyNameID.RimIndirBlur),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                RimBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.RimBlendMode),  // v1.3.7
#endif
            };
        }

        #endregion

        #region Glitter

        /// <summary>
        /// Get the lilToon Glitter property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilGlitter GetLilGlitterPropertyValues(Material material)
        {
            return new LilGlitter
            {
                UseGlitter = material.GetSafeBool(PropertyNameID.UseGlitter),
                GlitterUVMode = material.GetSafeEnum<LilGlitterUVMode>(PropertyNameID.GlitterUVMode),
                GlitterColor = material.GetSafeColor(PropertyNameID.GlitterColor),
                GlitterColorTex = material.GetSafeTexture(PropertyNameID.GlitterColorTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                GlitterColorTex_UVMode = material.GetSafeEnum<LilGlitterColorTextureUVMode>(PropertyNameID.GlitterColorTex_UVMode),  // v1.3.2
#endif
                GlitterMainStrength = material.GetSafeFloat(PropertyNameID.GlitterMainStrength),
                GlitterNormalStrength = material.GetSafeFloat(PropertyNameID.GlitterNormalStrength),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                GlitterScaleRandomize = material.GetSafeFloat(PropertyNameID.GlitterScaleRandomize),  // v1.3.0
                GlitterApplyShape = material.GetSafeBool(PropertyNameID.GlitterApplyShape),  // v1.3.0
                GlitterShapeTex = material.GetSafeTexture(PropertyNameID.GlitterShapeTex),  // v1.3.0
                GlitterAtras = material.GetSafeVector4(PropertyNameID.GlitterAtras),  // v1.3.0
                GlitterAngleRandomize = material.GetSafeBool(PropertyNameID.GlitterAngleRandomize),  // v1.3.0
#endif
                GlitterParams1 = material.GetSafeVector4(PropertyNameID.GlitterParams1),
                GlitterParams2 = material.GetSafeVector4(PropertyNameID.GlitterParams2),
                GlitterPostContrast = material.GetSafeFloat(PropertyNameID.GlitterPostContrast),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                GlitterSensitivity = material.GetSafeFloat(PropertyNameID.GlitterSensitivity),  // v1.3.0
#endif
                GlitterEnableLighting = material.GetSafeFloat(PropertyNameID.GlitterEnableLighting),
                GlitterShadowMask = material.GetSafeFloat(PropertyNameID.GlitterShadowMask),
                GlitterBackfaceMask = material.GetSafeBool(PropertyNameID.GlitterBackfaceMask),
                GlitterApplyTransparency = material.GetSafeBool(PropertyNameID.GlitterApplyTransparency),
                GlitterVRParallaxStrength = material.GetSafeFloat(PropertyNameID.GlitterVRParallaxStrength),
            };
        }

        #endregion

        #region Emission (Normal, Lite)

        /// <summary>
        /// Get the lilToon Lite Emission property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteEmission GetLilLiteEmissionPropertyValues(Material material)
        {
            return new LilLiteEmission
            {
                UseEmission = material.GetSafeBool(PropertyNameID.UseEmission),
                EmissionColor = material.GetSafeColor(PropertyNameID.EmissionColor),
                EmissionMap = material.GetSafeTexture(PropertyNameID.EmissionMap),
                EmissionMap_ScrollRotate = material.GetSafeVector4(PropertyNameID.EmissionMap_ScrollRotate),
                EmissionMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.EmissionMap_UVMode),
                EmissionBlink = material.GetSafeVector4(PropertyNameID.EmissionBlink),
            };
        }

        /// <summary>
        /// Get the lilToon Emission property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission GetLilEmissionPropertyValues(Material material)
        {
            return new LilEmission
            {
                UseEmission = material.GetSafeBool(PropertyNameID.UseEmission),
                EmissionColor = material.GetSafeColor(PropertyNameID.EmissionColor),
                EmissionMap = material.GetSafeTexture(PropertyNameID.EmissionMap),
                EmissionMap_ScrollRotate = material.GetSafeVector4(PropertyNameID.EmissionMap_ScrollRotate),
                EmissionMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.EmissionMap_UVMode),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                EmissionMainStrength = material.GetSafeFloat(PropertyNameID.EmissionMainStrength),  // v1.3.0
#endif
                EmissionBlend = material.GetSafeFloat(PropertyNameID.EmissionBlend),
                EmissionBlendMask = material.GetSafeTexture(PropertyNameID.EmissionBlendMask),
                EmissionBlendMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.EmissionBlendMask_ScrollRotate),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                EmissionBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.EmissionBlendMode),  // v1.3.7
#endif
                EmissionBlink = material.GetSafeVector4(PropertyNameID.EmissionBlink),
                EmissionUseGrad = material.GetSafeBool(PropertyNameID.EmissionUseGrad),
                EmissionGradTex = material.GetSafeTexture(PropertyNameID.EmissionGradTex),
                EmissionGradSpeed = material.GetSafeFloat(PropertyNameID.EmissionGradSpeed),
                EmissionParallaxDepth = material.GetSafeFloat(PropertyNameID.EmissionParallaxDepth),
                EmissionFluorescence = material.GetSafeFloat(PropertyNameID.EmissionFluorescence),
            };
        }

        /// <summary>
        /// Get the lilToon Emission Gradation property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmissionGradation GetLilEmissionGradationPropertyValues(Material material)
        {
            return new LilEmissionGradation
            {
                Egci = material.GetSafeInt(PropertyNameID.Egci),
                Egai = material.GetSafeInt(PropertyNameID.Egai),
                Egc0 = material.GetSafeColor(PropertyNameID.Egc0),
                Egc1 = material.GetSafeColor(PropertyNameID.Egc1),
                Egc2 = material.GetSafeColor(PropertyNameID.Egc2),
                Egc3 = material.GetSafeColor(PropertyNameID.Egc3),
                Egc4 = material.GetSafeColor(PropertyNameID.Egc4),
                Egc5 = material.GetSafeColor(PropertyNameID.Egc5),
                Egc6 = material.GetSafeColor(PropertyNameID.Egc6),
                Egc7 = material.GetSafeColor(PropertyNameID.Egc7),
                Ega0 = material.GetSafeColor(PropertyNameID.Ega0),
                Ega1 = material.GetSafeColor(PropertyNameID.Ega1),
                Ega2 = material.GetSafeColor(PropertyNameID.Ega2),
                Ega3 = material.GetSafeColor(PropertyNameID.Ega3),
                Ega4 = material.GetSafeColor(PropertyNameID.Ega4),
                Ega5 = material.GetSafeColor(PropertyNameID.Ega5),
                Ega6 = material.GetSafeColor(PropertyNameID.Ega6),
                Ega7 = material.GetSafeColor(PropertyNameID.Ega7),
            };
        }

        /// <summary>
        /// Get the lilToon Emission 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission2nd GetLilEmission2ndPropertyValues(Material material)
        {
            return new LilEmission2nd
            {
                UseEmission2nd = material.GetSafeBool(PropertyNameID.UseEmission2nd),
                Emission2ndColor = material.GetSafeColor(PropertyNameID.Emission2ndColor),
                Emission2ndMap = material.GetSafeTexture(PropertyNameID.Emission2ndMap),
                Emission2ndMap_ScrollRotate = material.GetSafeVector4(PropertyNameID.Emission2ndMap_ScrollRotate),
                Emission2ndMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.Emission2ndMap_UVMode),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Emission2ndMainStrength = material.GetSafeFloat(PropertyNameID.Emission2ndMainStrength),  // v1.3.0
#endif
                Emission2ndBlend = material.GetSafeFloat(PropertyNameID.Emission2ndBlend),
                Emission2ndBlendMask = material.GetSafeTexture(PropertyNameID.Emission2ndBlendMask),
                Emission2ndBlendMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.Emission2ndBlendMask_ScrollRotate),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                Emission2ndBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyNameID.Emission2ndBlendMode),  // v1.3.7
#endif
                Emission2ndBlink = material.GetSafeVector4(PropertyNameID.Emission2ndBlink),
                Emission2ndUseGrad = material.GetSafeBool(PropertyNameID.Emission2ndUseGrad),
                Emission2ndGradTex = material.GetSafeTexture(PropertyNameID.Emission2ndGradTex),
                Emission2ndGradSpeed = material.GetSafeFloat(PropertyNameID.Emission2ndGradSpeed),
                Emission2ndParallaxDepth = material.GetSafeFloat(PropertyNameID.Emission2ndParallaxDepth),
                Emission2ndFluorescence = material.GetSafeFloat(PropertyNameID.Emission2ndFluorescence),
            };
        }

        /// <summary>
        /// Get the lilToon Emission 2nd Gradation property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission2ndGradation GetLilEmission2ndGradationPropertyValues(Material material)
        {
            return new LilEmission2ndGradation
            {
                E2gci = material.GetSafeInt(PropertyNameID.E2gci),
                E2gai = material.GetSafeInt(PropertyNameID.E2gai),
                E2gc0 = material.GetSafeColor(PropertyNameID.E2gc0),
                E2gc1 = material.GetSafeColor(PropertyNameID.E2gc1),
                E2gc2 = material.GetSafeColor(PropertyNameID.E2gc2),
                E2gc3 = material.GetSafeColor(PropertyNameID.E2gc3),
                E2gc4 = material.GetSafeColor(PropertyNameID.E2gc4),
                E2gc5 = material.GetSafeColor(PropertyNameID.E2gc5),
                E2gc6 = material.GetSafeColor(PropertyNameID.E2gc6),
                E2gc7 = material.GetSafeColor(PropertyNameID.E2gc7),
                E2ga0 = material.GetSafeColor(PropertyNameID.E2ga0),
                E2ga1 = material.GetSafeColor(PropertyNameID.E2ga1),
                E2ga2 = material.GetSafeColor(PropertyNameID.E2ga2),
                E2ga3 = material.GetSafeColor(PropertyNameID.E2ga3),
                E2ga4 = material.GetSafeColor(PropertyNameID.E2ga4),
                E2ga5 = material.GetSafeColor(PropertyNameID.E2ga5),
                E2ga6 = material.GetSafeColor(PropertyNameID.E2ga6),
                E2ga7 = material.GetSafeColor(PropertyNameID.E2ga7),
            };
        }

        #endregion

        #region Parallax

        /// <summary>
        /// Get the lilToon Parallax property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilParallax GetLilParallaxPropertyValues(Material material)
        {
            return new LilParallax
            {
                UseParallax = material.GetSafeBool(PropertyNameID.UseParallax),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                UsePOM = material.GetSafeBool(PropertyNameID.UsePOM),  // v1.3.0
#endif
                ParallaxMap = material.GetSafeTexture(PropertyNameID.ParallaxMap),
                Parallax = material.GetSafeFloat(PropertyNameID.Parallax),
                ParallaxOffset = material.GetSafeFloat(PropertyNameID.ParallaxOffset),
            };
        }

        #endregion

        #region Distance Fade

        /// <summary>
        /// Get the lilToon Distance Fade property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilDistanceFade GetLilDistanceFadePropertyValues(Material material)
        {
            return new LilDistanceFade
            {
                DistanceFade = material.GetSafeVector4(PropertyNameID.DistanceFade),
                DistanceFadeColor = material.GetSafeColor(PropertyNameID.DistanceFadeColor),
#if LILTOON_1_4_0_OR_NEWER
                DistanceFadeMode = material.GetSafeEnum<LilDistanceFadeMode>(PropertyNameID.DistanceFadeMode),    // v1.4.0
                DistanceFadeRimColor = material.GetSafeColor(PropertyNameID.DistanceFadeRimColor),                // v1.4.0
                DistanceFadeRimFresnelPower = material.GetSafeFloat(PropertyNameID.DistanceFadeRimFresnelPower),  // v1.4.0
#endif
            };
        }

        #endregion

        #region Audio Link

        /// <summary>
        /// Get the lilToon Audio Link property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilAudioLink GetLilAudioLinkPropertyValues(Material material)
        {
            return new LilAudioLink
            {
                UseAudioLink = material.GetSafeBool(PropertyNameID.UseAudioLink),
                AudioLinkDefaultValue = material.GetSafeVector4(PropertyNameID.AudioLinkDefaultValue),
                AudioLinkUVMode = material.GetSafeEnum<LilAudioLinkUVMode>(PropertyNameID.AudioLinkUVMode),
                AudioLinkUVParams = material.GetSafeVector4(PropertyNameID.AudioLinkUVParams),
                AudioLinkStart = material.GetSafeVector4(PropertyNameID.AudioLinkStart),
                AudioLinkMask = material.GetSafeTexture(PropertyNameID.AudioLinkMask),
#if LILTOON_1_4_0_OR_NEWER
                AudioLinkMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.AudioLinkMask_ScrollRotate),      // v1.4.0
                AudioLinkMask_UVMode = material.GetSafeEnum<LilAudioLinkMaskUVMode>(PropertyNameID.AudioLinkUVMode),  // v1.4.0
#endif
                AudioLink2Main2nd = material.GetSafeBool(PropertyNameID.AudioLink2Main2nd),
                AudioLink2Main3rd = material.GetSafeBool(PropertyNameID.AudioLink2Main3rd),
                AudioLink2Emission = material.GetSafeBool(PropertyNameID.AudioLink2Emission),
                AudioLink2EmissionGrad = material.GetSafeBool(PropertyNameID.AudioLink2EmissionGrad),
                AudioLink2Emission2nd = material.GetSafeBool(PropertyNameID.AudioLink2Emission2nd),
                AudioLink2Emission2ndGrad = material.GetSafeBool(PropertyNameID.AudioLink2Emission2ndGrad),
                AudioLink2Vertex = material.GetSafeBool(PropertyNameID.AudioLink2Vertex),
                AudioLinkVertexUVMode = material.GetSafeEnum<LilAudioLinkVertexUVMode>(PropertyNameID.AudioLinkVertexUVMode),
                AudioLinkVertexUVParams = material.GetSafeVector4(PropertyNameID.AudioLinkVertexUVParams),
                AudioLinkVertexStart = material.GetSafeVector4(PropertyNameID.AudioLinkVertexStart),
                AudioLinkVertexStrength = material.GetSafeVector4(PropertyNameID.AudioLinkVertexStrength),
                AudioLinkAsLocal = material.GetSafeBool(PropertyNameID.AudioLinkAsLocal),
                AudioLinkLocalMap = material.GetSafeTexture(PropertyNameID.AudioLinkLocalMap),
                AudioLinkLocalMapParams = material.GetSafeVector4(PropertyNameID.AudioLinkLocalMapParams),
            };
        }

        #endregion

        #region Dissolve

        /// <summary>
        /// Get the lilToon Dissolve property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilDissolve GetLilDissolvePropertyValues(Material material)
        {
            return new LilDissolve
            {
                DissolveMask = material.GetSafeTexture(PropertyNameID.DissolveMask),
                DissolveNoiseMask = material.GetSafeTexture(PropertyNameID.DissolveNoiseMask),
                DissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyNameID.DissolveNoiseMask_ScrollRotate),
                DissolveNoiseStrength = material.GetSafeFloat(PropertyNameID.DissolveNoiseStrength),
                DissolveColor = material.GetSafeColor(PropertyNameID.DissolveColor),
                DissolveParams = material.GetSafeVector4(PropertyNameID.DissolveParams),
                DissolvePos = material.GetSafeVector4(PropertyNameID.DissolvePos),
            };
        }

        #endregion

        #region ID Mask

#if LILTOON_1_4_0_OR_NEWER
        /// <summary>
        /// Get the lilToon ID Mask property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilIDMask GetLilIDMaskPropertyValues(Material material)
        {
            return new LilIDMask
            {
                IDMaskFrom = material.GetSafeEnum<LilIDMaskFrom>(PropertyNameID.IDMaskFrom),  // v1.4.0
                IDMask1 = material.GetSafeBool(PropertyNameID.IDMask1),  // v1.4.0
                IDMask2 = material.GetSafeBool(PropertyNameID.IDMask2),  // v1.4.0
                IDMask3 = material.GetSafeBool(PropertyNameID.IDMask3),  // v1.4.0
                IDMask4 = material.GetSafeBool(PropertyNameID.IDMask4),  // v1.4.0
                IDMask5 = material.GetSafeBool(PropertyNameID.IDMask5),  // v1.4.0
                IDMask6 = material.GetSafeBool(PropertyNameID.IDMask6),  // v1.4.0
                IDMask7 = material.GetSafeBool(PropertyNameID.IDMask7),  // v1.4.0
                IDMask8 = material.GetSafeBool(PropertyNameID.IDMask8),  // v1.4.0
                IDMaskIndex1 = material.GetSafeInt(PropertyNameID.IDMaskIndex1),  // v1.4.0
                IDMaskIndex2 = material.GetSafeInt(PropertyNameID.IDMaskIndex2),  // v1.4.0
                IDMaskIndex3 = material.GetSafeInt(PropertyNameID.IDMaskIndex3),  // v1.4.0
                IDMaskIndex4 = material.GetSafeInt(PropertyNameID.IDMaskIndex4),  // v1.4.0
                IDMaskIndex5 = material.GetSafeInt(PropertyNameID.IDMaskIndex5),  // v1.4.0
                IDMaskIndex6 = material.GetSafeInt(PropertyNameID.IDMaskIndex6),  // v1.4.0
                IDMaskIndex7 = material.GetSafeInt(PropertyNameID.IDMaskIndex7),  // v1.4.0
                IDMaskIndex8 = material.GetSafeInt(PropertyNameID.IDMaskIndex8),  // v1.4.0
            };
        }
#endif
        #endregion

        #region Encryption

        /// <summary>
        /// Get the lilToon Encryption property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEncryption GetLilEncryptionPropertyValues(Material material)
        {
            return new LilEncryption
            {
                IgnoreEncryption = material.GetSafeBool(PropertyNameID.IgnoreEncryption),
                Keys = material.GetSafeVector4(PropertyNameID.Keys),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                BitKey0 = material.GetSafeFloat(PropertyNameID.BitKey0),
                BitKey1 = material.GetSafeFloat(PropertyNameID.BitKey1),
                BitKey2 = material.GetSafeFloat(PropertyNameID.BitKey2),
                BitKey3 = material.GetSafeFloat(PropertyNameID.BitKey3),
                BitKey4 = material.GetSafeFloat(PropertyNameID.BitKey4),
                BitKey5 = material.GetSafeFloat(PropertyNameID.BitKey5),
                BitKey6 = material.GetSafeFloat(PropertyNameID.BitKey6),
                BitKey7 = material.GetSafeFloat(PropertyNameID.BitKey7),
                BitKey8 = material.GetSafeFloat(PropertyNameID.BitKey8),
                BitKey9 = material.GetSafeFloat(PropertyNameID.BitKey9),
                BitKey10 = material.GetSafeFloat(PropertyNameID.BitKey10),
                BitKey11 = material.GetSafeFloat(PropertyNameID.BitKey11),
                BitKey12 = material.GetSafeFloat(PropertyNameID.BitKey12),
                BitKey13 = material.GetSafeFloat(PropertyNameID.BitKey13),
                BitKey14 = material.GetSafeFloat(PropertyNameID.BitKey14),
                BitKey15 = material.GetSafeFloat(PropertyNameID.BitKey15),
                BitKey16 = material.GetSafeFloat(PropertyNameID.BitKey16),
                BitKey17 = material.GetSafeFloat(PropertyNameID.BitKey17),
                BitKey18 = material.GetSafeFloat(PropertyNameID.BitKey18),
                BitKey19 = material.GetSafeFloat(PropertyNameID.BitKey19),
                BitKey20 = material.GetSafeFloat(PropertyNameID.BitKey20),
                BitKey21 = material.GetSafeFloat(PropertyNameID.BitKey21),
                BitKey22 = material.GetSafeFloat(PropertyNameID.BitKey22),
                BitKey23 = material.GetSafeFloat(PropertyNameID.BitKey23),
                BitKey24 = material.GetSafeFloat(PropertyNameID.BitKey24),
                BitKey25 = material.GetSafeFloat(PropertyNameID.BitKey25),
                BitKey26 = material.GetSafeFloat(PropertyNameID.BitKey26),
                BitKey27 = material.GetSafeFloat(PropertyNameID.BitKey27),
                BitKey28 = material.GetSafeFloat(PropertyNameID.BitKey28),
                BitKey29 = material.GetSafeFloat(PropertyNameID.BitKey29),
                BitKey30 = material.GetSafeFloat(PropertyNameID.BitKey30),
                BitKey31 = material.GetSafeFloat(PropertyNameID.BitKey31),
#endif
            };
        }

        #endregion

        #region Refraction

        /// <summary>
        /// Get the lilToon Refraction property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isRefraction"></param>
        /// <param name="isGem"></param>
        /// <returns></returns>
        public virtual LilRefraction GetLilRefractionPropertyValues(Material material, bool isRefraction = true, bool isGem = false)
        {
            if (isRefraction == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.RefractionStrength) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.GemChromaticAberration} property.");

                return null;
            }

            if (isGem)
            {
                // Refraction for Gem
                return new LilRefraction
                {
                    RefractionStrength = material.GetSafeFloat(PropertyNameID.RefractionStrength),
                    RefractionFresnelPower = material.GetSafeFloat(PropertyNameID.RefractionFresnelPower),
                };
            }
            else
            {
                return new LilRefraction
                {
                    RefractionStrength = material.GetSafeFloat(PropertyNameID.RefractionStrength),
                    RefractionFresnelPower = material.GetSafeFloat(PropertyNameID.RefractionFresnelPower),
                    RefractionColorFromMain = material.GetSafeBool(PropertyNameID.RefractionColorFromMain),
                    RefractionColor = material.GetSafeColor(PropertyNameID.RefractionColor),
                };
            }
        }

        #endregion

        #region Fur

        /// <summary>
        /// Get the lilToon Fur property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFur GetLilFurPropertyValues(Material material, bool isFur = true)
        {
            if (isFur == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.FurNoiseMask) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurNoiseMask} property.");

                return null;
            }

            return new LilFur
            {
                FurNoiseMask = material.GetSafeTexture(PropertyNameID.FurNoiseMask),
                FurMask = material.GetSafeTexture(PropertyNameID.FurMask),
                FurLengthMask = material.GetSafeTexture(PropertyNameID.FurLengthMask),
                FurVectorTex = material.GetSafeTexture(PropertyNameID.FurVectorTex),
                FurVectorScale = material.GetSafeFloat(PropertyNameID.FurVectorScale),
                FurVector = material.GetSafeVector4(PropertyNameID.FurVector),
                VertexColor2FurVector = material.GetSafeBool(PropertyNameID.VertexColor2FurVector),
                FurGravity = material.GetSafeFloat(PropertyNameID.FurGravity),
                FurRandomize = material.GetSafeFloat(PropertyNameID.FurRandomize),
                FurAO = material.GetSafeFloat(PropertyNameID.FurAO),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                FurMeshType = material.GetSafeEnum<LilFurMeshType>(PropertyNameID.FurMeshType),  // v1.3.0
#endif
                FurLayerNum = material.GetSafeInt(PropertyNameID.FurLayerNum),
                FurRootOffset = material.GetSafeFloat(PropertyNameID.FurRootOffset),
                FurCutoutLength = material.GetSafeFloat(PropertyNameID.FurCutoutLength),
                FurTouchStrength = material.GetSafeFloat(PropertyNameID.FurTouchStrength),
            };
        }

        #endregion

        #region Fur (Rendering)

        /// <summary>
        /// Get the lilToon Fur Rendering property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRendering GetLilFurRenderingPropertyValues(Material material, bool isFur = true)
        {
            if (isFur == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.FurCull) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurCull} property.");

                return null;
            }

            return new LilFurRendering
            {
                FurCull = material.GetSafeEnum<CullMode>(PropertyNameID.FurCull),

                FurZClip = material.GetSafeBool(PropertyNameID.FurZClip),
                FurZWrite = material.GetSafeBool(PropertyNameID.FurZWrite),
                FurZTest = material.GetSafeEnum<CompareFunction>(PropertyNameID.FurZTest),

                FurOffsetFactor = material.GetSafeFloat(PropertyNameID.FurOffsetFactor),
                FurOffsetUnits = material.GetSafeFloat(PropertyNameID.FurOffsetUnits),

                FurColorMask = material.GetSafeInt(PropertyNameID.FurColorMask),
                FurAlphaToMask = material.GetSafeBool(PropertyNameID.FurAlphaToMask),
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingForward GetLilFurRenderingForwardPropertyValues(Material material, bool isFur = true)
        {
            if (isFur == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.FurSrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurSrcBlend} property.");

                return null;
            }

            return new LilFurRenderingForward
            {
                FurSrcBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlend),
                FurDstBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlend),
                FurSrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendAlpha),
                FurDstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendAlpha),
                FurBlendOp = material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOp),
                FurBlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpAlpha),
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingForwardAdd GetLilFurRenderingForwardAddPropertyValues(Material material, bool isFur = true)
        {
            if (isFur == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.FurSrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurSrcBlendFA} property.");

                return null;
            }

            return new LilFurRenderingForwardAdd
            {
                FurSrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendFA),
                FurDstBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendFA),
                FurSrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendAlphaFA),
                FurDstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendAlphaFA),
                FurBlendOpFA = material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpFA),
                FurBlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpAlphaFA),
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingStencil GetLilFurRenderingStencilPropertyValues(Material material, bool isFur = true)
        {
            if (isFur == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.FurStencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurStencilRef} property.");

                return null;
            }

            return new LilFurRenderingStencil
            {
                FurStencilRef = material.GetSafeInt(PropertyNameID.FurStencilRef),
                FurStencilReadMask = material.GetSafeInt(PropertyNameID.FurStencilReadMask),
                FurStencilWriteMask = material.GetSafeInt(PropertyNameID.FurStencilWriteMask),
                FurStencilComp = material.GetSafeEnum<CompareFunction>(PropertyNameID.FurStencilComp),
                FurStencilPass = material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilPass),
                FurStencilFail = material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilFail),
                FurStencilZFail = material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilZFail),
            };
        }

        #endregion

        #region Gem

        /// <summary>
        /// Get the lilToon Gem property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isGem"></param>
        /// <returns></returns>
        public virtual LilGem GetLilGemPropertyValues(Material material, bool isGem = true)
        {
            if (isGem == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.GemChromaticAberration) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.GemChromaticAberration} property.");

                return null;
            }

            return new LilGem
            {
                GemChromaticAberration = material.GetSafeFloat(PropertyNameID.GemChromaticAberration),
                GemEnvContrast = material.GetSafeFloat(PropertyNameID.GemEnvContrast),
                GemEnvColor = material.GetSafeColor(PropertyNameID.GemEnvColor),
                GemParticleLoop = material.GetSafeFloat(PropertyNameID.GemParticleLoop),
                GemParticleColor = material.GetSafeColor(PropertyNameID.GemParticleColor),
                GemVRParallaxStrength = material.GetSafeFloat(PropertyNameID.GemVRParallaxStrength),
            };
        }

        #endregion

        #region Tessellation

        /// <summary>
        /// Get the lilToon Tessellation property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isTessellation"></param>
        /// <returns></returns>
        public virtual LilTessellation GetLilTessellationPropertyValues(Material material, bool isTessellation = true)
        {
            if (isTessellation == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.TessEdge) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.TessEdge} property.");

                return null;
            }

            return new LilTessellation
            {
                TessEdge = material.GetSafeFloat(PropertyNameID.TessEdge),
                TessStrength = material.GetSafeFloat(PropertyNameID.TessStrength),
                TessShrink = material.GetSafeFloat(PropertyNameID.TessShrink),
                TessFactorMax = material.GetSafeInt(PropertyNameID.TessFactorMax),
            };
        }

        #endregion

        #region Outline (Normal, Lite)

        /// <summary>
        /// Get the lilToon Lite Outline property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <returns></returns>
        public virtual LilLiteOutline GetLilLiteOutlinePropertyValues(Material material, bool isOutline)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineColor) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineColor} property.");

                return null;
            }

            return new LilLiteOutline
            {
                // Outline
                OutlineColor = material.GetSafeColor(PropertyNameID.OutlineColor),
                OutlineTex = material.GetSafeTexture(PropertyNameID.OutlineTex),
                OutlineWidth = material.GetSafeFloat(PropertyNameID.OutlineWidth),
                OutlineWidthMask = material.GetSafeTexture(PropertyNameID.OutlineWidthMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineFixWidth = material.GetSafeFloat(PropertyNameID.OutlineFixWidth),  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = material.GetSafeEnum<LilVertexColorMode>(PropertyNameID.OutlineVertexR2Width),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineDeleteMesh = material.GetSafeBool(PropertyNameID.OutlineDeleteMesh),  // v1.3.0
#endif
                OutlineEnableLighting = material.GetSafeFloat(PropertyNameID.OutlineEnableLighting),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineZBias = material.GetSafeFloat(PropertyNameID.OutlineZBias),  // v1.3.0
#endif
            };
        }

        /// <summary>
        /// Get the lilToon Outline property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <returns></returns>
        public virtual LilOutline GetLilOutlinePropertyValues(Material material, bool isOutline)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineColor) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineColor} property.");

                return null;
            }

            return new LilOutline
            {
                OutlineColor = material.GetSafeColor(PropertyNameID.OutlineColor),
                OutlineTex = material.GetSafeTexture(PropertyNameID.OutlineTex),
                OutlineTex_ScrollRotate = material.GetSafeVector4(PropertyNameID.OutlineTex_ScrollRotate),
                OutlineTexHSVG = material.GetSafeVector4(PropertyNameID.OutlineTexHSVG),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineLitColor = material.GetSafeColor(PropertyNameID.OutlineLitColor),       // v1.3.0
                OutlineLitApplyTex = material.GetSafeBool(PropertyNameID.OutlineLitApplyTex),  // v1.3.0
                OutlineLitScale = material.GetSafeFloat(PropertyNameID.OutlineLitScale),       // v1.3.0
                OutlineLitOffset = material.GetSafeFloat(PropertyNameID.OutlineLitOffset),     // v1.3.0
                OutlineLitShadowReceive = material.GetSafeBool(PropertyNameID.OutlineLitShadowReceive),  // v1.3.1
#endif
                OutlineWidth = material.GetSafeFloat(PropertyNameID.OutlineWidth),
                OutlineWidthMask = material.GetSafeTexture(PropertyNameID.OutlineWidthMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineFixWidth = material.GetSafeFloat(PropertyNameID.OutlineFixWidth),  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = material.GetSafeEnum<LilVertexColorMode>(PropertyNameID.OutlineVertexR2Width),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineDeleteMesh = material.GetSafeBool(PropertyNameID.OutlineDeleteMesh),  // v1.3.0
#endif
                OutlineVectorTex = material.GetSafeTexture(PropertyNameID.OutlineVectorTex),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineVectorUVMode = material.GetSafeEnum<LilOutlineVectorUVMode>(PropertyNameID.OutlineVectorUVMode),  // v1.3.0
#endif
                OutlineVectorScale = material.GetSafeFloat(PropertyNameID.OutlineVectorScale),
                OutlineEnableLighting = material.GetSafeFloat(PropertyNameID.OutlineEnableLighting),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                OutlineZBias = material.GetSafeFloat(PropertyNameID.OutlineZBias),  // v1.3.0
                OutlineDisableInVR = material.GetSafeBool(PropertyNameID.OutlineDisableInVR),  // v1.3.0
#endif
            };
        }

        #endregion

        #region Outline (Rendering)

        /// <summary>
        /// Get the lilToon Outline Rendering property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRendering GetLilOutlineRenderingPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (isRefraction)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineCull) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineCull} property.");

                return null;
            }

            return new LilOutlineRendering
            {
                OutlineCull = material.GetSafeEnum<CullMode>(PropertyNameID.OutlineCull),

                OutlineZClip = material.GetSafeBool(PropertyNameID.OutlineZClip),
                OutlineZWrite = material.GetSafeBool(PropertyNameID.OutlineZWrite),
                OutlineZTest = material.GetSafeEnum<CompareFunction>(PropertyNameID.OutlineZTest),

                OutlineOffsetFactor = material.GetSafeFloat(PropertyNameID.OutlineOffsetFactor),
                OutlineOffsetUnits = material.GetSafeFloat(PropertyNameID.OutlineOffsetUnits),

                OutlineColorMask = material.GetSafeInt(PropertyNameID.OutlineColorMask),
                OutlineAlphaToMask = material.GetSafeBool(PropertyNameID.OutlineAlphaToMask),
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingForward GetLilOutlineRenderingForwardPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (isRefraction)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineSrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineSrcBlend} property.");

                return null;
            }

            return new LilOutlineRenderingForward
            {
                OutlineSrcBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlend),
                OutlineDstBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlend),
                OutlineSrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendAlpha),
                OutlineDstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendAlpha),
                OutlineBlendOp = material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOp),
                OutlineBlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpAlpha),
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingForwardAdd GetLilOutlineRenderingForwardAddPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (isRefraction)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineSrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineSrcBlendFA} property.");

                return null;
            }

            return new LilOutlineRenderingForwardAdd
            {
                OutlineSrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendFA),
                OutlineDstBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendFA),
                OutlineSrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendAlphaFA),
                OutlineDstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendAlphaFA),
                OutlineBlendOpFA = material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpFA),
                OutlineBlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpAlphaFA),
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingStencil GetLilOutlineRenderingStencilPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
        {
            if (isOutline == false)
            {
                return null;
            }

            if (isRefraction)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.OutlineStencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineStencilRef} property.");

                return null;
            }

            return new LilOutlineRenderingStencil
            {
                OutlineStencilRef = material.GetSafeInt(PropertyNameID.OutlineStencilRef),
                OutlineStencilReadMask = material.GetSafeInt(PropertyNameID.OutlineStencilReadMask),
                OutlineStencilWriteMask = material.GetSafeInt(PropertyNameID.OutlineStencilWriteMask),
                OutlineStencilComp = material.GetSafeEnum<CompareFunction>(PropertyNameID.OutlineStencilComp),
                OutlineStencilPass = material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilPass),
                OutlineStencilFail = material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilFail),
                OutlineStencilZFail = material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilZFail),
            };
        }

        #endregion

        #region Multi

        /// <summary>
        /// Get the lilToon Multi property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isMulti"></param>
        /// <returns></returns>
        public virtual LilMulti GetLilMultiPropertyValues(Material material, bool isMulti = true)
        {
            if (isMulti == false)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.UseOutline) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.UseOutline} property.");

                return null;
            }

            return new LilMulti
            {
                UseOutline = material.GetSafeBool(PropertyNameID.UseOutline),
                TransparentMode = material.GetSafeEnum<LilRenderingMode>(PropertyNameID.TransparentMode),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                //
#elif LILTOON_1_2_12_OR_OLDER
                UsePOM = material.GetSafeBool(PropertyNameID.UsePOM),  // v1.3.0 deleted
#else
                //
#endif
                UseClippingCanceller = material.GetSafeBool(PropertyNameID.UseClippingCanceller),
                AsOverlay = material.GetSafeBool(PropertyNameID.AsOverlay),
            };
        }

        #endregion

        #region Rendering

        /// <summary>
        /// Get the lilToon Rendering property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFakeShadow"></param>
        /// <returns></returns>
        public virtual LilRendering GetLilRenderingPropertyValues(Material material, bool isFakeShadow = false)
        {
            var rendering = new LilRendering
            {
                Cull = material.GetSafeEnum<CullMode>(PropertyNameID.Cull, CullMode.Back),
                ZClip = material.GetSafeBool(PropertyNameID.ZClip),
                ZWrite = material.GetSafeBool(PropertyNameID.ZWrite),
                ZTest = material.GetSafeEnum<CompareFunction>(PropertyNameID.ZTest),
                OffsetFactor = material.GetSafeFloat(PropertyNameID.OffsetFactor),
                OffsetUnits = material.GetSafeFloat(PropertyNameID.OffsetUnits),
                ColorMask = material.GetSafeInt(PropertyNameID.ColorMask),
                AlphaToMask = material.GetSafeBool(PropertyNameID.AlphaToMask),
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
                LilShadowCasterBias = material.GetSafeFloat(PropertyNameID.LilShadowCasterBias),  // v1.3.0
#endif
            };

            if (isFakeShadow)
            {
                return rendering;
            }

            rendering.Cutoff = material.GetSafeFloat(PropertyNameID.Cutoff);
            rendering.SubpassCutoff = material.GetSafeFloat(PropertyNameID.SubpassCutoff);

            return rendering;
        }

        /// <summary>
        /// Get the lilToon Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingForward GetLilRenderingForwardPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyNameID.SrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.SrcBlend} property.");

                return null;
            }

            return new LilRenderingForward
            {
                SrcBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlend),
                DstBlend = material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlend),
                SrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendAlpha),
                DstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendAlpha),
                BlendOp = material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOp, BlendOp.Add),
                BlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpAlpha, BlendOp.Add),
            };
        }

        /// <summary>
        /// Get the lilToon Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isGem"></param>
        /// <returns></returns>
        public virtual LilRenderingForwardAdd GetLilRenderingForwardAddPropertyValues(Material material, bool isGem = false)
        {
            if (isGem)
            {
                return null;
            }

            if (material.HasProperty(PropertyNameID.SrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.SrcBlendFA} property.");

                return null;
            }

            return new LilRenderingForwardAdd
            {
                SrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendFA),
                DstBlendFA = material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendFA),
                SrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendAlphaFA),
                DstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendAlphaFA),
                BlendOpFA = material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpFA, BlendOp.Max),
                BlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpAlphaFA, BlendOp.Max),
            };
        }

        /// <summary>
        /// Get the lilToon Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingStencil GetLilRenderingStencilPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyNameID.StencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.StencilRef} property.");

                return null;
            }

            return new LilRenderingStencil
            {
                StencilRef = material.GetSafeInt(PropertyNameID.StencilRef),
                StencilReadMask = material.GetSafeInt(PropertyNameID.StencilReadMask),
                StencilWriteMask = material.GetSafeInt(PropertyNameID.StencilWriteMask),
                StencilComp = material.GetSafeEnum<CompareFunction>(PropertyNameID.StencilComp),
                StencilPass = material.GetSafeEnum<StencilOp>(PropertyNameID.StencilPass),
                StencilFail = material.GetSafeEnum<StencilOp>(PropertyNameID.StencilFail),
                StencilZFail = material.GetSafeEnum<StencilOp>(PropertyNameID.StencilZFail),
            };
        }

        #endregion

        #region Save

        /// <summary>
        /// Get the lilToon Save property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilSave GetLilSavePropertyValues(Material material)
        {
            return new LilSave
            {
                BaseColor = material.GetSafeColor(PropertyNameID.BaseColor),
                BaseMap = material.GetSafeTexture(PropertyNameID.BaseMap),
                BaseColorMap = material.GetSafeTexture(PropertyNameID.BaseColorMap),
                LilToonVersion = material.GetSafeInt(PropertyNameID.LilToonVersion),
            };
        }

        #endregion

        #endregion
    }
}