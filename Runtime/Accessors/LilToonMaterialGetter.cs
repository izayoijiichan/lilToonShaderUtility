// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialGetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER
#define LILTOON_1_3_0_OR_NEWER
#endif
namespace LilToonShader
{
    using UnityEngine;
    using UnityEngine.Rendering;
    using LilToonShader.Extensions;

#if LILTOON_1_3_0_OR_NEWER
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
                    RenderingMode = material.GetSafeEnum<LilRenderingMode>(PropertyName.TransparentMode),
                    //TransparentMode = LilTransparentMode.Normal,
                    IsOverlay = material.GetSafeBool(PropertyName.AsOverlay),
                    IsOutline = material.GetSafeBool(PropertyName.UseOutline),
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

#if LILTOON_1_3_0_OR_NEWER
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
#if LILTOON_1_3_0_OR_NEWER
                Multi = GetLilMultiPropertyValues(material, isMulti: propertyContainer.PropertyEntityType == LilPropertyEntityType.Multi),  // v1.3.0
#endif
                Rendering = GetLilRenderingPropertyValues(material),
                RenderingForward = GetLilRenderingForwardPropertyValues(material),
                RenderingForwardAdd = GetLilRenderingForwardAddPropertyValues(material, propertyContainer.IsGem),
                RenderingStencil = GetLilRenderingStencilPropertyValues(material),
                Save = GetLilSavePropertyValues(material),
            };
        }

#if LILTOON_1_3_0_OR_NEWER
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
                Invisible = material.GetSafeBool(PropertyName.Invisible),
                FlipNormal = material.GetSafeBool(PropertyName.FlipNormal),
                ShiftBackfaceUV = material.GetSafeBool(PropertyName.ShiftBackfaceUV),
                BackfaceForceShadow = material.GetSafeBool(PropertyName.BackfaceForceShadow),
#if LILTOON_1_3_0_OR_NEWER
                BackfaceColor = material.GetSafeColor(PropertyName.BackfaceColor),  // v1.3.0
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
                Invisible = material.GetSafeBool(PropertyName.Invisible),
                FlipNormal = material.GetSafeBool(PropertyName.FlipNormal),
                ShiftBackfaceUV = material.GetSafeBool(PropertyName.ShiftBackfaceUV),
                BackfaceForceShadow = material.GetSafeBool(PropertyName.BackfaceForceShadow),
                TriMask = material.GetSafeTexture(PropertyName.TriMask),
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
                Invisible = material.GetSafeBool(PropertyName.Invisible),
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
                LightMinLimit = material.GetSafeFloat(PropertyName.LightMinLimit),
                LightMaxLimit = material.GetSafeFloat(PropertyName.LightMaxLimit),
                MonochromeLighting = material.GetSafeFloat(PropertyName.MonochromeLighting),
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
                AsUnlit = material.GetSafeBool(PropertyName.AsUnlit),
                VertexLightStrength = material.GetSafeFloat(PropertyName.VertexLightStrength),
                LightDirectionOverride = material.GetSafeVector3(PropertyName.LightDirectionOverride),
                AlphaBoostFA = material.GetSafeFloat(PropertyName.AlphaBoostFA),
                BeforeExposureLimit = material.GetSafeFloat(PropertyName.BeforeExposureLimit),
                LilDirectionalLightStrength = material.GetSafeFloat(PropertyName.LilDirectionalLightStrength),
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
                Color = material.GetSafeColor(PropertyName.Color),
                MainTex = material.GetSafeTexture(PropertyName.MainTex),
                FakeShadowVector = material.GetSafeVector4(PropertyName.FakeShadowVector),
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
                Color = material.GetSafeColor(PropertyName.Color),
                MainTex = material.GetSafeTexture(PropertyName.MainTex),
                MainTex_ScrollRotate = material.GetSafeVector4(PropertyName.MainTex_ScrollRotate),
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
                Color = material.GetSafeColor(PropertyName.Color),
                MainTex = material.GetSafeTexture(PropertyName.MainTex),
                MainTex_ScrollRotate = material.GetSafeVector4(PropertyName.MainTex_ScrollRotate),
                MainTexHSVG = material.GetSafeVector4(PropertyName.MainTexHSVG),
                MainGradationStrength = material.GetSafeFloat(PropertyName.MainGradationStrength),
                MainGradationTex = material.GetSafeTexture(PropertyName.MainGradationTex),
                MainColorAdjustMask = material.GetSafeTexture(PropertyName.MainColorAdjustMask),
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
                UseMain2ndTex = material.GetSafeBool(PropertyName.UseMain2ndTex),
                Color2nd = material.GetSafeColor(PropertyName.Color2nd),
                Main2ndTex = material.GetSafeTexture(PropertyName.Main2ndTex),
                Main2ndTex_UVMode = material.GetSafeEnum<LilMainUVMode>(PropertyName.Main2ndTex_UVMode),
                Main2ndTexAngle = material.GetSafeFloat(PropertyName.Main2ndTexAngle),
                Main2ndTexDecalAnimation = material.GetSafeVector4(PropertyName.Main2ndTexDecalAnimation),
                Main2ndTexDecalSubParam = material.GetSafeVector4(PropertyName.Main2ndTexDecalSubParam),
                Main2ndTexIsDecal = material.GetSafeBool(PropertyName.Main2ndTexIsDecal),
                Main2ndTexIsLeftOnly = material.GetSafeBool(PropertyName.Main2ndTexIsLeftOnly),
                Main2ndTexIsRightOnly = material.GetSafeBool(PropertyName.Main2ndTexIsRightOnly),
                Main2ndTexShouldCopy = material.GetSafeBool(PropertyName.Main2ndTexShouldCopy),
                Main2ndTexShouldFlipMirror = material.GetSafeBool(PropertyName.Main2ndTexShouldFlipMirror),
                Main2ndTexShouldFlipCopy = material.GetSafeBool(PropertyName.Main2ndTexShouldFlipCopy),
                Main2ndTexIsMSDF = material.GetSafeBool(PropertyName.Main2ndTexIsMSDF),
                Main2ndBlendMask = material.GetSafeTexture(PropertyName.Main2ndBlendMask),
                Main2ndTexBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyName.Main2ndTexBlendMode),
                Main2ndEnableLighting = material.GetSafeBool(PropertyName.Main2ndEnableLighting),
                Main2ndDissolveMask = material.GetSafeTexture(PropertyName.Main2ndDissolveMask),
                Main2ndDissolveNoiseMask = material.GetSafeTexture(PropertyName.Main2ndDissolveNoiseMask),
                Main2ndDissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyName.Main2ndDissolveNoiseMask_ScrollRotate),
                Main2ndDissolveNoiseStrength = material.GetSafeFloat(PropertyName.Main2ndDissolveNoiseStrength),
                Main2ndDissolveColor = material.GetSafeColor(PropertyName.Main2ndDissolveColor),
                Main2ndDissolveParams = material.GetSafeVector4(PropertyName.Main2ndDissolveParams),
                Main2ndDissolvePos = material.GetSafeVector4(PropertyName.Main2ndDissolvePos),
                Main2ndDistanceFade = material.GetSafeVector4(PropertyName.Main2ndDistanceFade),
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
                UseMain3rdTex = material.GetSafeBool(PropertyName.UseMain3rdTex),
                Color3rd = material.GetSafeColor(PropertyName.Color3rd),
                Main3rdTex = material.GetSafeTexture(PropertyName.Main3rdTex),
                Main3rdTex_UVMode = material.GetSafeEnum<LilMainUVMode>(PropertyName.Main3rdTex_UVMode),
                Main3rdTexAngle = material.GetSafeFloat(PropertyName.Main3rdTexAngle),
                Main3rdTexDecalAnimation = material.GetSafeVector4(PropertyName.Main3rdTexDecalAnimation),
                Main3rdTexDecalSubParam = material.GetSafeVector4(PropertyName.Main3rdTexDecalSubParam),
                Main3rdTexIsDecal = material.GetSafeBool(PropertyName.Main3rdTexIsDecal),
                Main3rdTexIsLeftOnly = material.GetSafeBool(PropertyName.Main3rdTexIsLeftOnly),
                Main3rdTexIsRightOnly = material.GetSafeBool(PropertyName.Main3rdTexIsRightOnly),
                Main3rdTexShouldCopy = material.GetSafeBool(PropertyName.Main3rdTexShouldCopy),
                Main3rdTexShouldFlipMirror = material.GetSafeBool(PropertyName.Main3rdTexShouldFlipMirror),
                Main3rdTexShouldFlipCopy = material.GetSafeBool(PropertyName.Main3rdTexShouldFlipCopy),
                Main3rdTexIsMSDF = material.GetSafeBool(PropertyName.Main3rdTexIsMSDF),
                Main3rdBlendMask = material.GetSafeTexture(PropertyName.Main3rdBlendMask),
                Main3rdTexBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyName.Main3rdTexBlendMode),
                Main3rdEnableLighting = material.GetSafeBool(PropertyName.Main3rdEnableLighting),
                Main3rdDissolveMask = material.GetSafeTexture(PropertyName.Main3rdDissolveMask),
                Main3rdDissolveNoiseMask = material.GetSafeTexture(PropertyName.Main3rdDissolveNoiseMask),
                Main3rdDissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyName.Main3rdDissolveNoiseMask_ScrollRotate),
                Main3rdDissolveNoiseStrength = material.GetSafeFloat(PropertyName.Main3rdDissolveNoiseStrength),
                Main3rdDissolveColor = material.GetSafeColor(PropertyName.Main3rdDissolveColor),
                Main3rdDissolveParams = material.GetSafeVector4(PropertyName.Main3rdDissolveParams),
                Main3rdDissolvePos = material.GetSafeVector4(PropertyName.Main3rdDissolvePos),
                Main3rdDistanceFade = material.GetSafeVector4(PropertyName.Main3rdDistanceFade),
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
                AlphaMaskMode = material.GetSafeEnum<LilAlphaMaskMode>(PropertyName.AlphaMaskMode),
                AlphaMask = material.GetSafeTexture(PropertyName.AlphaMask),
                AlphaMaskScale = material.GetSafeFloat(PropertyName.AlphaMaskScale),
                AlphaMaskValue = material.GetSafeFloat(PropertyName.AlphaMaskValue),
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
                UseBumpMap = material.GetSafeBool(PropertyName.UseBumpMap),
                BumpMap = material.GetSafeTexture(PropertyName.BumpMap),
                BumpScale = material.GetSafeFloat(PropertyName.BumpScale),
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
                UseBump2ndMap = material.GetSafeBool(PropertyName.UseBump2ndMap),
                Bump2ndMap = material.GetSafeTexture(PropertyName.Bump2ndMap),
                Bump2ndScale = material.GetSafeFloat(PropertyName.Bump2ndScale),
                Bump2ndScaleMask = material.GetSafeTexture(PropertyName.Bump2ndScaleMask),
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
                UseAnisotropy = material.GetSafeBool(PropertyName.UseAnisotropy),
                AnisotropyTangentMap = material.GetSafeTexture(PropertyName.AnisotropyTangentMap),
                AnisotropyScale = material.GetSafeFloat(PropertyName.AnisotropyScale),
                AnisotropyScaleMask = material.GetSafeTexture(PropertyName.AnisotropyScaleMask),
                AnisotropyTangentWidth = material.GetSafeFloat(PropertyName.AnisotropyTangentWidth),
                AnisotropyBitangentWidth = material.GetSafeFloat(PropertyName.AnisotropyBitangentWidth),
                AnisotropyShift = material.GetSafeFloat(PropertyName.AnisotropyShift),
                AnisotropyShiftNoiseScale = material.GetSafeFloat(PropertyName.AnisotropyShiftNoiseScale),
                AnisotropySpecularStrength = material.GetSafeFloat(PropertyName.AnisotropySpecularStrength),
                Anisotropy2ndTangentWidth = material.GetSafeFloat(PropertyName.Anisotropy2ndTangentWidth),
                Anisotropy2ndBitangentWidth = material.GetSafeFloat(PropertyName.Anisotropy2ndBitangentWidth),
                Anisotropy2ndShift = material.GetSafeFloat(PropertyName.Anisotropy2ndShift),
                Anisotropy2ndShiftNoiseScale = material.GetSafeFloat(PropertyName.Anisotropy2ndShiftNoiseScale),
                Anisotropy2ndSpecularStrength = material.GetSafeFloat(PropertyName.Anisotropy2ndSpecularStrength),
                AnisotropyShiftNoiseMask = material.GetSafeTexture(PropertyName.AnisotropyShiftNoiseMask),
                Anisotropy2Reflection = material.GetSafeBool(PropertyName.Anisotropy2Reflection),
                Anisotropy2MatCap = material.GetSafeBool(PropertyName.Anisotropy2MatCap),
                Anisotropy2MatCap2nd = material.GetSafeBool(PropertyName.Anisotropy2MatCap2nd),
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
                UseBacklight = material.GetSafeBool(PropertyName.UseBacklight),
                BacklightColor = material.GetSafeColor(PropertyName.BacklightColor),
                BacklightColorTex = material.GetSafeTexture(PropertyName.BacklightColorTex),
#if LILTOON_1_3_0_OR_NEWER
                BacklightMainStrength = material.GetSafeFloat(PropertyName.BacklightMainStrength),  // v1.3.0
#endif
                BacklightNormalStrength = material.GetSafeFloat(PropertyName.BacklightNormalStrength),
                BacklightBorder = material.GetSafeFloat(PropertyName.BacklightBorder),
                BacklightBlur = material.GetSafeFloat(PropertyName.BacklightBlur),
                BacklightDirectivity = material.GetSafeFloat(PropertyName.BacklightDirectivity),
                BacklightViewStrength = material.GetSafeFloat(PropertyName.BacklightViewStrength),
                BacklightReceiveShadow = material.GetSafeBool(PropertyName.BacklightReceiveShadow),
                BacklightBackfaceMask = material.GetSafeBool(PropertyName.BacklightBackfaceMask),
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
                UseShadow = material.GetSafeBool(PropertyName.UseShadow),
                ShadowColorTex = material.GetSafeTexture(PropertyName.ShadowColorTex),
                ShadowBorder = material.GetSafeFloat(PropertyName.ShadowBorder),
                ShadowBlur = material.GetSafeFloat(PropertyName.ShadowBlur),
                Shadow2ndColorTex = material.GetSafeTexture(PropertyName.Shadow2ndColorTex),
                Shadow2ndBorder = material.GetSafeFloat(PropertyName.Shadow2ndBorder),
                Shadow2ndBlur = material.GetSafeFloat(PropertyName.Shadow2ndBlur),
                ShadowBorderColor = material.GetSafeColor(PropertyName.ShadowBorderColor),
                ShadowBorderRange = material.GetSafeFloat(PropertyName.ShadowBorderRange),
                ShadowEnvStrength = material.GetSafeFloat(PropertyName.ShadowEnvStrength),
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
                UseShadow = material.GetSafeBool(PropertyName.UseShadow),
                //ShadowReceive = material.GetSafeBool(PropertyName.ShadowReceive),
                ShadowStrength = material.GetSafeFloat(PropertyName.ShadowStrength),
                ShadowStrengthMask = material.GetSafeTexture(PropertyName.ShadowStrengthMask),
#if LILTOON_1_3_0_OR_NEWER
                ShadowStrengthMaskLOD = material.GetSafeFloat(PropertyName.ShadowStrengthMaskLOD),  // v1.3.0
#endif
                ShadowBorderMask = material.GetSafeTexture(PropertyName.ShadowBorderMask),
#if LILTOON_1_3_0_OR_NEWER
                ShadowBorderMaskLOD = material.GetSafeFloat(PropertyName.ShadowBorderMaskLOD),  // v1.3.0
#endif
                ShadowBlurMask = material.GetSafeTexture(PropertyName.ShadowBlurMask),
#if LILTOON_1_3_0_OR_NEWER
                ShadowBlurMaskLOD = material.GetSafeFloat(PropertyName.ShadowBlurMaskLOD),  // v1.3.0
#endif
                ShadowAOShift = material.GetSafeVector4(PropertyName.ShadowAOShift),
                ShadowAOShift2 = material.GetSafeVector4(PropertyName.ShadowAOShift2),
                ShadowPostAO = material.GetSafeBool(PropertyName.ShadowPostAO),
                ShadowColor = material.GetSafeColor(PropertyName.ShadowColor),
                ShadowColorTex = material.GetSafeTexture(PropertyName.ShadowColorTex),
                ShadowNormalStrength = material.GetSafeFloat(PropertyName.ShadowNormalStrength),
                ShadowBorder = material.GetSafeFloat(PropertyName.ShadowBorder),
                ShadowBlur = material.GetSafeFloat(PropertyName.ShadowBlur),
                ShadowReceive = material.GetSafeBool(PropertyName.ShadowReceive),
                Shadow2ndColor = material.GetSafeColor(PropertyName.Shadow2ndColor),
                Shadow2ndColorTex = material.GetSafeTexture(PropertyName.Shadow2ndColorTex),
                Shadow2ndNormalStrength = material.GetSafeFloat(PropertyName.Shadow2ndNormalStrength),
                Shadow2ndBorder = material.GetSafeFloat(PropertyName.Shadow2ndBorder),
                Shadow2ndBlur = material.GetSafeFloat(PropertyName.Shadow2ndBlur),
#if LILTOON_1_3_0_OR_NEWER
                Shadow2ndReceive = material.GetSafeBool(PropertyName.Shadow2ndReceive),  // v1.3.0
#endif
                Shadow3rdColor = material.GetSafeColor(PropertyName.Shadow3rdColor),
                Shadow3rdColorTex = material.GetSafeTexture(PropertyName.Shadow3rdColorTex),
                Shadow3rdNormalStrength = material.GetSafeFloat(PropertyName.Shadow3rdNormalStrength),
                Shadow3rdBorder = material.GetSafeFloat(PropertyName.Shadow3rdBorder),
                Shadow3rdBlur = material.GetSafeFloat(PropertyName.Shadow3rdBlur),
#if LILTOON_1_3_0_OR_NEWER
                Shadow3rdReceive = material.GetSafeBool(PropertyName.Shadow3rdReceive),  // v1.3.0
#endif
                ShadowBorderColor = material.GetSafeColor(PropertyName.ShadowBorderColor),
                ShadowBorderRange = material.GetSafeFloat(PropertyName.ShadowBorderRange),
                ShadowMainStrength = material.GetSafeFloat(PropertyName.ShadowMainStrength),
                ShadowEnvStrength = material.GetSafeFloat(PropertyName.ShadowEnvStrength),
#if LILTOON_1_3_0_OR_NEWER
                ShadowMaskType = material.GetSafeEnum<LilShadowMaskType>(PropertyName.ShadowMaskType),  // v1.3.0
                ShadowFlatBorder = material.GetSafeFloat(PropertyName.ShadowFlatBorder),  // v1.3.0
                ShadowFlatBlur = material.GetSafeFloat(PropertyName.ShadowFlatBlur),  // v1.3.0
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
                UseReflection = material.GetSafeBool(PropertyName.UseReflection),
                Smoothness = material.GetSafeFloat(PropertyName.Smoothness),
                SmoothnessTex = material.GetSafeTexture(PropertyName.SmoothnessTex),
                Metallic = material.GetSafeFloat(PropertyName.Metallic),
                MetallicGlossMap = material.GetSafeTexture(PropertyName.MetallicGlossMap),
                Reflectance = material.GetSafeFloat(PropertyName.Reflectance),
#if LILTOON_1_3_0_OR_NEWER
                GSAAStrength = material.GetSafeFloat(PropertyName.GSAAStrength),  // v1.3.0
#endif
                ApplySpecular = material.GetSafeBool(PropertyName.ApplySpecular),
                ApplySpecularFA = material.GetSafeBool(PropertyName.ApplySpecularFA),
                SpecularToon = material.GetSafeBool(PropertyName.SpecularToon),
                SpecularNormalStrength = material.GetSafeFloat(PropertyName.SpecularNormalStrength),
                SpecularBorder = material.GetSafeFloat(PropertyName.SpecularBorder),
                SpecularBlur = material.GetSafeFloat(PropertyName.SpecularBlur),
                ApplyReflection = material.GetSafeBool(PropertyName.ApplyReflection),
                ReflectionNormalStrength = material.GetSafeFloat(PropertyName.ReflectionNormalStrength),
                ReflectionColor = material.GetSafeColor(PropertyName.ReflectionColor),
                ReflectionColorTex = material.GetSafeTexture(PropertyName.ReflectionColorTex),
                ReflectionApplyTransparency = material.GetSafeBool(PropertyName.ReflectionApplyTransparency),
                ReflectionCubeTex = material.GetSafeTexture(PropertyName.ReflectionCubeTex),
                ReflectionCubeColor = material.GetSafeColor(PropertyName.ReflectionCubeColor),
                ReflectionCubeOverride = material.GetSafeBool(PropertyName.ReflectionCubeOverride),
                ReflectionCubeEnableLighting = material.GetSafeFloat(PropertyName.ReflectionCubeEnableLighting),
#if LILTOON_1_3_0_OR_NEWER
                ReflectionBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyName.ReflectionBlendMode),  // v1.3.0
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
                UseMatCap = material.GetSafeBool(PropertyName.UseMatCap),
                MatCapTex = material.GetSafeTexture(PropertyName.MatCapTex),
                MatCapBlendUV1 = material.GetSafeVector4(PropertyName.MatCapBlendUV1),
                MatCapZRotCancel = material.GetSafeBool(PropertyName.MatCapZRotCancel),
                MatCapPerspective = material.GetSafeBool(PropertyName.MatCapPerspective),
                MatCapVRParallaxStrength = material.GetSafeFloat(PropertyName.MatCapVRParallaxStrength),
                MatCapMul = material.GetSafeBool(PropertyName.MatCapMul),  // Lite only
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
                UseMatCap = material.GetSafeBool(PropertyName.UseMatCap),
                MatCapColor = material.GetSafeColor(PropertyName.MatCapColor),
                MatCapTex = material.GetSafeTexture(PropertyName.MatCapTex),
#if LILTOON_1_3_0_OR_NEWER
                MatCapMainStrength = material.GetSafeFloat(PropertyName.MatCapMainStrength),  // v1.3.0
#endif
                MatCapBlendUV1 = material.GetSafeVector4(PropertyName.MatCapBlendUV1),
                MatCapZRotCancel = material.GetSafeBool(PropertyName.MatCapZRotCancel),
                MatCapPerspective = material.GetSafeBool(PropertyName.MatCapPerspective),
                MatCapVRParallaxStrength = material.GetSafeFloat(PropertyName.MatCapVRParallaxStrength),
                MatCapBlend = material.GetSafeFloat(PropertyName.MatCapBlend),
                MatCapBlendMask = material.GetSafeTexture(PropertyName.MatCapBlendMask),
                MatCapEnableLighting = material.GetSafeFloat(PropertyName.MatCapEnableLighting),
                MatCapShadowMask = material.GetSafeFloat(PropertyName.MatCapShadowMask),
                MatCapBackfaceMask = material.GetSafeBool(PropertyName.MatCapBackfaceMask),
                MatCapLod = material.GetSafeFloat(PropertyName.MatCapLod),
                MatCapBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyName.MatCapBlendMode),
                MatCapApplyTransparency = material.GetSafeBool(PropertyName.MatCapApplyTransparency),
                MatCapNormalStrength = material.GetSafeFloat(PropertyName.MatCapNormalStrength),
                MatCapCustomNormal = material.GetSafeBool(PropertyName.MatCapCustomNormal),
                MatCapBumpMap = material.GetSafeTexture(PropertyName.MatCapBumpMap),
                MatCapBumpScale = material.GetSafeFloat(PropertyName.MatCapBumpScale),
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
                UseMatCap2nd = material.GetSafeBool(PropertyName.UseMatCap2nd),
                MatCap2ndColor = material.GetSafeColor(PropertyName.MatCap2ndColor),
                MatCap2ndTex = material.GetSafeTexture(PropertyName.MatCap2ndTex),
#if LILTOON_1_3_0_OR_NEWER
                MatCap2ndMainStrength = material.GetSafeFloat(PropertyName.MatCap2ndMainStrength),  // v1.3.0
#endif
                MatCap2ndBlendUV1 = material.GetSafeVector4(PropertyName.MatCap2ndBlendUV1),
                MatCap2ndZRotCancel = material.GetSafeBool(PropertyName.MatCap2ndZRotCancel),
                MatCap2ndPerspective = material.GetSafeBool(PropertyName.MatCap2ndPerspective),
                MatCap2ndVRParallaxStrength = material.GetSafeFloat(PropertyName.MatCap2ndVRParallaxStrength),
                MatCap2ndBlend = material.GetSafeFloat(PropertyName.MatCap2ndBlend),
                MatCap2ndBlendMask = material.GetSafeTexture(PropertyName.MatCap2ndBlendMask),
                MatCap2ndEnableLighting = material.GetSafeFloat(PropertyName.MatCap2ndEnableLighting),
                MatCap2ndShadowMask = material.GetSafeFloat(PropertyName.MatCap2ndShadowMask),
                MatCap2ndBackfaceMask = material.GetSafeBool(PropertyName.MatCap2ndBackfaceMask),
                MatCap2ndLod = material.GetSafeFloat(PropertyName.MatCap2ndLod),
                MatCap2ndBlendMode = material.GetSafeEnum<LilBlendMode>(PropertyName.MatCap2ndBlendMode),
                MatCap2ndApplyTransparency = material.GetSafeBool(PropertyName.MatCap2ndApplyTransparency),
                MatCap2ndNormalStrength = material.GetSafeFloat(PropertyName.MatCap2ndNormalStrength),
                MatCap2ndCustomNormal = material.GetSafeBool(PropertyName.MatCap2ndCustomNormal),
                MatCap2ndBumpMap = material.GetSafeTexture(PropertyName.MatCap2ndBumpMap),
                MatCap2ndBumpScale = material.GetSafeFloat(PropertyName.MatCap2ndBumpScale),
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
                UseRim = material.GetSafeBool(PropertyName.UseRim),
                RimColor = material.GetSafeColor(PropertyName.RimColor),
                RimBorder = material.GetSafeFloat(PropertyName.RimBorder),
                RimBlur = material.GetSafeFloat(PropertyName.RimBlur),
                RimFresnelPower = material.GetSafeFloat(PropertyName.RimFresnelPower),
                RimShadowMask = material.GetSafeFloat(PropertyName.RimShadowMask),
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
                UseRim = material.GetSafeBool(PropertyName.UseRim),
                RimColor = material.GetSafeColor(PropertyName.RimColor),
                RimColorTex = material.GetSafeTexture(PropertyName.RimColorTex),
#if LILTOON_1_3_0_OR_NEWER
                RimMainStrength = material.GetSafeFloat(PropertyName.RimMainStrength),  // v1.3.0
#endif
                RimNormalStrength = material.GetSafeFloat(PropertyName.RimNormalStrength),
                RimBorder = material.GetSafeFloat(PropertyName.RimBorder),
                RimBlur = material.GetSafeFloat(PropertyName.RimBlur),
                RimFresnelPower = material.GetSafeFloat(PropertyName.RimFresnelPower),
                RimEnableLighting = material.GetSafeFloat(PropertyName.RimEnableLighting),
                RimShadowMask = material.GetSafeFloat(PropertyName.RimShadowMask),
                RimBackfaceMask = material.GetSafeBool(PropertyName.RimBackfaceMask),
                RimVRParallaxStrength = material.GetSafeFloat(PropertyName.RimVRParallaxStrength),
                RimApplyTransparency = material.GetSafeBool(PropertyName.RimApplyTransparency),
                RimDirStrength = material.GetSafeFloat(PropertyName.RimDirStrength),
                RimDirRange = material.GetSafeFloat(PropertyName.RimDirRange),
                RimIndirRange = material.GetSafeFloat(PropertyName.RimIndirRange),
                RimIndirColor = material.GetSafeColor(PropertyName.RimIndirColor),
                RimIndirBorder = material.GetSafeFloat(PropertyName.RimIndirBorder),
                RimIndirBlur = material.GetSafeFloat(PropertyName.RimIndirBlur),
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
                UseGlitter = material.GetSafeBool(PropertyName.UseGlitter),
                GlitterUVMode = material.GetSafeEnum<LilGlitterUVMode>(PropertyName.GlitterUVMode),
                GlitterColor = material.GetSafeColor(PropertyName.GlitterColor),
                GlitterColorTex = material.GetSafeTexture(PropertyName.GlitterColorTex),
                GlitterMainStrength = material.GetSafeFloat(PropertyName.GlitterMainStrength),
                GlitterNormalStrength = material.GetSafeFloat(PropertyName.GlitterNormalStrength),
#if LILTOON_1_3_0_OR_NEWER
                GlitterScaleRandomize = material.GetSafeFloat(PropertyName.GlitterScaleRandomize),  // v1.3.0
                GlitterApplyShape = material.GetSafeBool(PropertyName.GlitterApplyShape),  // v1.3.0
                GlitterShapeTex = material.GetSafeTexture(PropertyName.GlitterShapeTex),  // v1.3.0
                GlitterAtras = material.GetSafeVector4(PropertyName.GlitterAtras),  // v1.3.0
                GlitterAngleRandomize = material.GetSafeBool(PropertyName.GlitterAngleRandomize),  // v1.3.0
#endif
                GlitterParams1 = material.GetSafeVector4(PropertyName.GlitterParams1),
                GlitterParams2 = material.GetSafeVector4(PropertyName.GlitterParams2),
                GlitterPostContrast = material.GetSafeFloat(PropertyName.GlitterPostContrast),
#if LILTOON_1_3_0_OR_NEWER
                GlitterSensitivity = material.GetSafeFloat(PropertyName.GlitterSensitivity),  // v1.3.0
#endif
                GlitterEnableLighting = material.GetSafeFloat(PropertyName.GlitterEnableLighting),
                GlitterShadowMask = material.GetSafeFloat(PropertyName.GlitterShadowMask),
                GlitterBackfaceMask = material.GetSafeBool(PropertyName.GlitterBackfaceMask),
                GlitterApplyTransparency = material.GetSafeBool(PropertyName.GlitterApplyTransparency),
                GlitterVRParallaxStrength = material.GetSafeFloat(PropertyName.GlitterVRParallaxStrength),
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
                UseEmission = material.GetSafeBool(PropertyName.UseEmission),
                EmissionColor = material.GetSafeColor(PropertyName.EmissionColor),
                EmissionMap = material.GetSafeTexture(PropertyName.EmissionMap),
                EmissionMap_ScrollRotate = material.GetSafeVector4(PropertyName.EmissionMap_ScrollRotate),
                EmissionMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyName.EmissionMap_UVMode),
                EmissionBlink = material.GetSafeVector4(PropertyName.EmissionBlink),
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
                UseEmission = material.GetSafeBool(PropertyName.UseEmission),
                EmissionColor = material.GetSafeColor(PropertyName.EmissionColor),
                EmissionMap = material.GetSafeTexture(PropertyName.EmissionMap),
                EmissionMap_ScrollRotate = material.GetSafeVector4(PropertyName.EmissionMap_ScrollRotate),
                EmissionMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyName.EmissionMap_UVMode),
#if LILTOON_1_3_0_OR_NEWER
                EmissionMainStrength = material.GetSafeFloat(PropertyName.EmissionMainStrength),  // v1.3.0
#endif
                EmissionBlend = material.GetSafeFloat(PropertyName.EmissionBlend),
                EmissionBlendMask = material.GetSafeTexture(PropertyName.EmissionBlendMask),
                EmissionBlendMask_ScrollRotate = material.GetSafeVector4(PropertyName.EmissionBlendMask_ScrollRotate),
                EmissionBlink = material.GetSafeVector4(PropertyName.EmissionBlink),
                EmissionUseGrad = material.GetSafeBool(PropertyName.EmissionUseGrad),
                EmissionGradTex = material.GetSafeTexture(PropertyName.EmissionGradTex),
                EmissionGradSpeed = material.GetSafeFloat(PropertyName.EmissionGradSpeed),
                EmissionParallaxDepth = material.GetSafeFloat(PropertyName.EmissionParallaxDepth),
                EmissionFluorescence = material.GetSafeFloat(PropertyName.EmissionFluorescence),
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
                Egci = material.GetSafeInt(PropertyName.Egci),
                Egai = material.GetSafeInt(PropertyName.Egai),
                Egc0 = material.GetSafeColor(PropertyName.Egc0),
                Egc1 = material.GetSafeColor(PropertyName.Egc1),
                Egc2 = material.GetSafeColor(PropertyName.Egc2),
                Egc3 = material.GetSafeColor(PropertyName.Egc3),
                Egc4 = material.GetSafeColor(PropertyName.Egc4),
                Egc5 = material.GetSafeColor(PropertyName.Egc5),
                Egc6 = material.GetSafeColor(PropertyName.Egc6),
                Egc7 = material.GetSafeColor(PropertyName.Egc7),
                Ega0 = material.GetSafeColor(PropertyName.Ega0),
                Ega1 = material.GetSafeColor(PropertyName.Ega1),
                Ega2 = material.GetSafeColor(PropertyName.Ega2),
                Ega3 = material.GetSafeColor(PropertyName.Ega3),
                Ega4 = material.GetSafeColor(PropertyName.Ega4),
                Ega5 = material.GetSafeColor(PropertyName.Ega5),
                Ega6 = material.GetSafeColor(PropertyName.Ega6),
                Ega7 = material.GetSafeColor(PropertyName.Ega7),
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
                UseEmission2nd = material.GetSafeBool(PropertyName.UseEmission2nd),
                Emission2ndColor = material.GetSafeColor(PropertyName.Emission2ndColor),
                Emission2ndMap = material.GetSafeTexture(PropertyName.Emission2ndMap),
                Emission2ndMap_ScrollRotate = material.GetSafeVector4(PropertyName.Emission2ndMap_ScrollRotate),
                Emission2ndMap_UVMode = material.GetSafeEnum<LilEmissionUVMode>(PropertyName.Emission2ndMap_UVMode),
#if LILTOON_1_3_0_OR_NEWER
                Emission2ndMainStrength = material.GetSafeFloat(PropertyName.Emission2ndMainStrength),  // v1.3.0
#endif
                Emission2ndBlend = material.GetSafeFloat(PropertyName.Emission2ndBlend),
                Emission2ndBlendMask = material.GetSafeTexture(PropertyName.Emission2ndBlendMask),
                Emission2ndBlendMask_ScrollRotate = material.GetSafeVector4(PropertyName.Emission2ndBlendMask_ScrollRotate),
                Emission2ndBlink = material.GetSafeVector4(PropertyName.Emission2ndBlink),
                Emission2ndUseGrad = material.GetSafeBool(PropertyName.Emission2ndUseGrad),
                Emission2ndGradTex = material.GetSafeTexture(PropertyName.Emission2ndGradTex),
                Emission2ndGradSpeed = material.GetSafeFloat(PropertyName.Emission2ndGradSpeed),
                Emission2ndParallaxDepth = material.GetSafeFloat(PropertyName.Emission2ndParallaxDepth),
                Emission2ndFluorescence = material.GetSafeFloat(PropertyName.Emission2ndFluorescence),
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
                E2gci = material.GetSafeInt(PropertyName.E2gci),
                E2gai = material.GetSafeInt(PropertyName.E2gai),
                E2gc0 = material.GetSafeColor(PropertyName.E2gc0),
                E2gc1 = material.GetSafeColor(PropertyName.E2gc1),
                E2gc2 = material.GetSafeColor(PropertyName.E2gc2),
                E2gc3 = material.GetSafeColor(PropertyName.E2gc3),
                E2gc4 = material.GetSafeColor(PropertyName.E2gc4),
                E2gc5 = material.GetSafeColor(PropertyName.E2gc5),
                E2gc6 = material.GetSafeColor(PropertyName.E2gc6),
                E2gc7 = material.GetSafeColor(PropertyName.E2gc7),
                E2ga0 = material.GetSafeColor(PropertyName.E2ga0),
                E2ga1 = material.GetSafeColor(PropertyName.E2ga1),
                E2ga2 = material.GetSafeColor(PropertyName.E2ga2),
                E2ga3 = material.GetSafeColor(PropertyName.E2ga3),
                E2ga4 = material.GetSafeColor(PropertyName.E2ga4),
                E2ga5 = material.GetSafeColor(PropertyName.E2ga5),
                E2ga6 = material.GetSafeColor(PropertyName.E2ga6),
                E2ga7 = material.GetSafeColor(PropertyName.E2ga7),
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
                UseParallax = material.GetSafeBool(PropertyName.UseParallax),
#if LILTOON_1_3_0_OR_NEWER
                UsePOM = material.GetSafeBool(PropertyName.UsePOM),  // v1.3.0
#endif
                ParallaxMap = material.GetSafeTexture(PropertyName.ParallaxMap),
                Parallax = material.GetSafeFloat(PropertyName.Parallax),
                ParallaxOffset = material.GetSafeFloat(PropertyName.ParallaxOffset),
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
                DistanceFade = material.GetSafeVector4(PropertyName.DistanceFade),
                DistanceFadeColor = material.GetSafeColor(PropertyName.DistanceFadeColor),
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
                UseAudioLink = material.GetSafeBool(PropertyName.UseAudioLink),
                AudioLinkDefaultValue = material.GetSafeVector4(PropertyName.AudioLinkDefaultValue),
                AudioLinkUVMode = material.GetSafeEnum<LilAudioLinkUVMode>(PropertyName.AudioLinkUVMode),
                AudioLinkUVParams = material.GetSafeVector4(PropertyName.AudioLinkUVParams),
                AudioLinkStart = material.GetSafeVector4(PropertyName.AudioLinkStart),
                AudioLinkMask = material.GetSafeTexture(PropertyName.AudioLinkMask),
                AudioLink2Main2nd = material.GetSafeBool(PropertyName.AudioLink2Main2nd),
                AudioLink2Main3rd = material.GetSafeBool(PropertyName.AudioLink2Main3rd),
                AudioLink2Emission = material.GetSafeBool(PropertyName.AudioLink2Emission),
                AudioLink2EmissionGrad = material.GetSafeBool(PropertyName.AudioLink2EmissionGrad),
                AudioLink2Emission2nd = material.GetSafeBool(PropertyName.AudioLink2Emission2nd),
                AudioLink2Emission2ndGrad = material.GetSafeBool(PropertyName.AudioLink2Emission2ndGrad),
                AudioLink2Vertex = material.GetSafeBool(PropertyName.AudioLink2Vertex),
                AudioLinkVertexUVMode = material.GetSafeEnum<LilAudioLinkVertexUVMode>(PropertyName.AudioLinkVertexUVMode),
                AudioLinkVertexUVParams = material.GetSafeVector4(PropertyName.AudioLinkVertexUVParams),
                AudioLinkVertexStart = material.GetSafeVector4(PropertyName.AudioLinkVertexStart),
                AudioLinkVertexStrength = material.GetSafeVector4(PropertyName.AudioLinkVertexStrength),
                AudioLinkAsLocal = material.GetSafeBool(PropertyName.AudioLinkAsLocal),
                AudioLinkLocalMap = material.GetSafeTexture(PropertyName.AudioLinkLocalMap),
                AudioLinkLocalMapParams = material.GetSafeVector4(PropertyName.AudioLinkLocalMapParams),
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
                DissolveMask = material.GetSafeTexture(PropertyName.DissolveMask),
                DissolveNoiseMask = material.GetSafeTexture(PropertyName.DissolveNoiseMask),
                DissolveNoiseMask_ScrollRotate = material.GetSafeVector4(PropertyName.DissolveNoiseMask_ScrollRotate),
                DissolveNoiseStrength = material.GetSafeFloat(PropertyName.DissolveNoiseStrength),
                DissolveColor = material.GetSafeColor(PropertyName.DissolveColor),
                DissolveParams = material.GetSafeVector4(PropertyName.DissolveParams),
                DissolvePos = material.GetSafeVector4(PropertyName.DissolvePos),
            };
        }

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
                IgnoreEncryption = material.GetSafeBool(PropertyName.IgnoreEncryption),
                Keys = material.GetSafeVector4(PropertyName.Keys),
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

            if (material.HasProperty(PropertyName.RefractionStrength) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.GemChromaticAberration} property.");

                return null;
            }

            if (isGem)
            {
                // Refraction for Gem
                return new LilRefraction
                {
                    RefractionStrength = material.GetSafeFloat(PropertyName.RefractionStrength),
                    RefractionFresnelPower = material.GetSafeFloat(PropertyName.RefractionFresnelPower),
                };
            }
            else
            {
                return new LilRefraction
                {
                    RefractionStrength = material.GetSafeFloat(PropertyName.RefractionStrength),
                    RefractionFresnelPower = material.GetSafeFloat(PropertyName.RefractionFresnelPower),
                    RefractionColorFromMain = material.GetSafeBool(PropertyName.RefractionColorFromMain),
                    RefractionColor = material.GetSafeColor(PropertyName.RefractionColor),
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

            if (material.HasProperty(PropertyName.FurNoiseMask) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurNoiseMask} property.");

                return null;
            }

            return new LilFur
            {
                FurNoiseMask = material.GetSafeTexture(PropertyName.FurNoiseMask),
                FurMask = material.GetSafeTexture(PropertyName.FurMask),
                FurLengthMask = material.GetSafeTexture(PropertyName.FurLengthMask),
                FurVectorTex = material.GetSafeTexture(PropertyName.FurVectorTex),
                FurVectorScale = material.GetSafeFloat(PropertyName.FurVectorScale),
                FurVector = material.GetSafeVector4(PropertyName.FurVector),
                VertexColor2FurVector = material.GetSafeBool(PropertyName.VertexColor2FurVector),
                FurGravity = material.GetSafeFloat(PropertyName.FurGravity),
                FurRandomize = material.GetSafeFloat(PropertyName.FurRandomize),
                FurAO = material.GetSafeFloat(PropertyName.FurAO),
#if LILTOON_1_3_0_OR_NEWER
                FurMeshType = material.GetSafeEnum<LilFurMeshType>(PropertyName.FurMeshType),  // v1.3.0
#endif
                FurLayerNum = material.GetSafeInt(PropertyName.FurLayerNum),
                FurRootOffset = material.GetSafeFloat(PropertyName.FurRootOffset),
                FurCutoutLength = material.GetSafeFloat(PropertyName.FurCutoutLength),
                FurTouchStrength = material.GetSafeFloat(PropertyName.FurTouchStrength),
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

            if (material.HasProperty(PropertyName.FurCull) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurCull} property.");

                return null;
            }

            return new LilFurRendering
            {
                FurCull = material.GetSafeEnum<CullMode>(PropertyName.FurCull),

                FurZClip = material.GetSafeBool(PropertyName.FurZClip),
                FurZWrite = material.GetSafeBool(PropertyName.FurZWrite),
                FurZTest = material.GetSafeEnum<CompareFunction>(PropertyName.FurZTest),

                FurOffsetFactor = material.GetSafeFloat(PropertyName.FurOffsetFactor),
                FurOffsetUnits = material.GetSafeFloat(PropertyName.FurOffsetUnits),

                FurColorMask = material.GetSafeInt(PropertyName.FurColorMask),
                FurAlphaToMask = material.GetSafeBool(PropertyName.FurAlphaToMask),
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

            if (material.HasProperty(PropertyName.FurSrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurSrcBlend} property.");

                return null;
            }

            return new LilFurRenderingForward
            {
                FurSrcBlend = material.GetSafeEnum<BlendMode>(PropertyName.FurSrcBlend),
                FurDstBlend = material.GetSafeEnum<BlendMode>(PropertyName.FurDstBlend),
                FurSrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.FurSrcBlendAlpha),
                FurDstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.FurDstBlendAlpha),
                FurBlendOp = material.GetSafeEnum<BlendOp>(PropertyName.FurBlendOp),
                FurBlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyName.FurBlendOpAlpha),
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

            if (material.HasProperty(PropertyName.FurSrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurSrcBlendFA} property.");

                return null;
            }

            return new LilFurRenderingForwardAdd
            {
                FurSrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.FurSrcBlendFA),
                FurDstBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.FurDstBlendFA),
                FurSrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.FurSrcBlendAlphaFA),
                FurDstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.FurDstBlendAlphaFA),
                FurBlendOpFA = material.GetSafeEnum<BlendOp>(PropertyName.FurBlendOpFA),
                FurBlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyName.FurBlendOpAlphaFA),
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

            if (material.HasProperty(PropertyName.FurStencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.FurStencilRef} property.");

                return null;
            }

            return new LilFurRenderingStencil
            {
                FurStencilRef = material.GetSafeInt(PropertyName.FurStencilRef),
                FurStencilReadMask = material.GetSafeInt(PropertyName.FurStencilReadMask),
                FurStencilWriteMask = material.GetSafeInt(PropertyName.FurStencilWriteMask),
                FurStencilComp = material.GetSafeEnum<CompareFunction>(PropertyName.FurStencilComp),
                FurStencilPass = material.GetSafeEnum<StencilOp>(PropertyName.FurStencilPass),
                FurStencilFail = material.GetSafeEnum<StencilOp>(PropertyName.FurStencilFail),
                FurStencilZFail = material.GetSafeEnum<StencilOp>(PropertyName.FurStencilZFail),
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

            if (material.HasProperty(PropertyName.GemChromaticAberration) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.GemChromaticAberration} property.");

                return null;
            }

            return new LilGem
            {
                GemChromaticAberration = material.GetSafeFloat(PropertyName.GemChromaticAberration),
                GemEnvContrast = material.GetSafeFloat(PropertyName.GemEnvContrast),
                GemEnvColor = material.GetSafeColor(PropertyName.GemEnvColor),
                GemParticleLoop = material.GetSafeFloat(PropertyName.GemParticleLoop),
                GemParticleColor = material.GetSafeColor(PropertyName.GemParticleColor),
                GemVRParallaxStrength = material.GetSafeFloat(PropertyName.GemVRParallaxStrength),
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

            if (material.HasProperty(PropertyName.TessEdge) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.TessEdge} property.");

                return null;
            }

            return new LilTessellation
            {
                TessEdge = material.GetSafeFloat(PropertyName.TessEdge),
                TessStrength = material.GetSafeFloat(PropertyName.TessStrength),
                TessShrink = material.GetSafeFloat(PropertyName.TessShrink),
                TessFactorMax = material.GetSafeInt(PropertyName.TessFactorMax),
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

            if (material.HasProperty(PropertyName.OutlineColor) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineColor} property.");

                return null;
            }

            return new LilLiteOutline
            {
                // Outline
                OutlineColor = material.GetSafeColor(PropertyName.OutlineColor),
                OutlineTex = material.GetSafeTexture(PropertyName.OutlineTex),
                OutlineWidth = material.GetSafeFloat(PropertyName.OutlineWidth),
                OutlineWidthMask = material.GetSafeTexture(PropertyName.OutlineWidthMask),
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = material.GetSafeFloat(PropertyName.OutlineFixWidth),  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = material.GetSafeEnum<LilVertexColorMode>(PropertyName.OutlineVertexR2Width),
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = material.GetSafeBool(PropertyName.OutlineDeleteMesh),  // v1.3.0
#endif
                OutlineEnableLighting = material.GetSafeFloat(PropertyName.OutlineEnableLighting),
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = material.GetSafeFloat(PropertyName.OutlineZBias),  // v1.3.0
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

            if (material.HasProperty(PropertyName.OutlineColor) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineColor} property.");

                return null;
            }

            return new LilOutline
            {
                OutlineColor = material.GetSafeColor(PropertyName.OutlineColor),
                OutlineTex = material.GetSafeTexture(PropertyName.OutlineTex),
                OutlineTex_ScrollRotate = material.GetSafeVector4(PropertyName.OutlineTex_ScrollRotate),
                OutlineTexHSVG = material.GetSafeVector4(PropertyName.OutlineTexHSVG),
#if LILTOON_1_3_0_OR_NEWER
                OutlineLitColor = material.GetSafeColor(PropertyName.OutlineLitColor),       // v1.3.0
                OutlineLitApplyTex = material.GetSafeBool(PropertyName.OutlineLitApplyTex),  // v1.3.0
                OutlineLitScale = material.GetSafeFloat(PropertyName.OutlineLitScale),       // v1.3.0
                OutlineLitOffset = material.GetSafeFloat(PropertyName.OutlineLitOffset),     // v1.3.0
#endif
                OutlineWidth = material.GetSafeFloat(PropertyName.OutlineWidth),
                OutlineWidthMask = material.GetSafeTexture(PropertyName.OutlineWidthMask),
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = material.GetSafeFloat(PropertyName.OutlineFixWidth),  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = material.GetSafeEnum<LilVertexColorMode>(PropertyName.OutlineVertexR2Width),
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = material.GetSafeBool(PropertyName.OutlineDeleteMesh),  // v1.3.0
#endif
                OutlineVectorTex = material.GetSafeTexture(PropertyName.OutlineVectorTex),
#if LILTOON_1_3_0_OR_NEWER
                OutlineVectorUVMode = material.GetSafeEnum<LilOutlineVectorUVMode>(PropertyName.OutlineVectorUVMode),  // v1.3.0
#endif
                OutlineVectorScale = material.GetSafeFloat(PropertyName.OutlineVectorScale),
                OutlineEnableLighting = material.GetSafeFloat(PropertyName.OutlineEnableLighting),
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = material.GetSafeFloat(PropertyName.OutlineZBias),  // v1.3.0
                OutlineDisableInVR = material.GetSafeBool(PropertyName.OutlineDisableInVR),  // v1.3.0
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

            if (material.HasProperty(PropertyName.OutlineCull) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineCull} property.");

                return null;
            }

            return new LilOutlineRendering
            {
                OutlineCull = material.GetSafeEnum<CullMode>(PropertyName.OutlineCull),

                OutlineZClip = material.GetSafeBool(PropertyName.OutlineZClip),
                OutlineZWrite = material.GetSafeBool(PropertyName.OutlineZWrite),
                OutlineZTest = material.GetSafeEnum<CompareFunction>(PropertyName.OutlineZTest),

                OutlineOffsetFactor = material.GetSafeFloat(PropertyName.OutlineOffsetFactor),
                OutlineOffsetUnits = material.GetSafeFloat(PropertyName.OutlineOffsetUnits),

                OutlineColorMask = material.GetSafeInt(PropertyName.OutlineColorMask),
                OutlineAlphaToMask = material.GetSafeBool(PropertyName.OutlineAlphaToMask),
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

            if (material.HasProperty(PropertyName.OutlineSrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineSrcBlend} property.");

                return null;
            }

            return new LilOutlineRenderingForward
            {
                OutlineSrcBlend = material.GetSafeEnum<BlendMode>(PropertyName.OutlineSrcBlend),
                OutlineDstBlend = material.GetSafeEnum<BlendMode>(PropertyName.OutlineDstBlend),
                OutlineSrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.OutlineSrcBlendAlpha),
                OutlineDstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.OutlineDstBlendAlpha),
                OutlineBlendOp = material.GetSafeEnum<BlendOp>(PropertyName.OutlineBlendOp),
                OutlineBlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyName.OutlineBlendOpAlpha),
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

            if (material.HasProperty(PropertyName.OutlineSrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineSrcBlendFA} property.");

                return null;
            }

            return new LilOutlineRenderingForwardAdd
            {
                OutlineSrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.OutlineSrcBlendFA),
                OutlineDstBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.OutlineDstBlendFA),
                OutlineSrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.OutlineSrcBlendAlphaFA),
                OutlineDstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.OutlineDstBlendAlphaFA),
                OutlineBlendOpFA = material.GetSafeEnum<BlendOp>(PropertyName.OutlineBlendOpFA),
                OutlineBlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyName.OutlineBlendOpAlphaFA),
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

            if (material.HasProperty(PropertyName.OutlineStencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.OutlineStencilRef} property.");

                return null;
            }

            return new LilOutlineRenderingStencil
            {
                OutlineStencilRef = material.GetSafeInt(PropertyName.OutlineStencilRef),
                OutlineStencilReadMask = material.GetSafeInt(PropertyName.OutlineStencilReadMask),
                OutlineStencilWriteMask = material.GetSafeInt(PropertyName.OutlineStencilWriteMask),
                OutlineStencilComp = material.GetSafeEnum<CompareFunction>(PropertyName.OutlineStencilComp),
                OutlineStencilPass = material.GetSafeEnum<StencilOp>(PropertyName.OutlineStencilPass),
                OutlineStencilFail = material.GetSafeEnum<StencilOp>(PropertyName.OutlineStencilFail),
                OutlineStencilZFail = material.GetSafeEnum<StencilOp>(PropertyName.OutlineStencilZFail),
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

            if (material.HasProperty(PropertyName.UseOutline) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.UseOutline} property.");

                return null;
            }

            return new LilMulti
            {
                UseOutline = material.GetSafeBool(PropertyName.UseOutline),
                TransparentMode = material.GetSafeEnum<LilRenderingMode>(PropertyName.TransparentMode),
#if LILTOON_1_3_0_OR_NEWER
                //
#elif LILTOON_1_2_12_OR_OLDER
                UsePOM = material.GetSafeBool(PropertyName.UsePOM),  // v1.3.0 deleted
#else
                //
#endif
                UseClippingCanceller = material.GetSafeBool(PropertyName.UseClippingCanceller),
                AsOverlay = material.GetSafeBool(PropertyName.AsOverlay),
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
                Cull = material.GetSafeEnum<CullMode>(PropertyName.Cull, CullMode.Back),
                ZClip = material.GetSafeBool(PropertyName.ZClip),
                ZWrite = material.GetSafeBool(PropertyName.ZWrite),
                ZTest = material.GetSafeEnum<CompareFunction>(PropertyName.ZTest),
                OffsetFactor = material.GetSafeFloat(PropertyName.OffsetFactor),
                OffsetUnits = material.GetSafeFloat(PropertyName.OffsetUnits),
                ColorMask = material.GetSafeInt(PropertyName.ColorMask),
                AlphaToMask = material.GetSafeBool(PropertyName.AlphaToMask),
#if LILTOON_1_3_0_OR_NEWER
                LilShadowCasterBias = material.GetSafeFloat(PropertyName.LilShadowCasterBias),  // v1.3.0
#endif
            };

            if (isFakeShadow)
            {
                return rendering;
            }

            rendering.Cutoff = material.GetSafeFloat(PropertyName.Cutoff);
            rendering.SubpassCutoff = material.GetSafeFloat(PropertyName.SubpassCutoff);

            return rendering;
        }

        /// <summary>
        /// Get the lilToon Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingForward GetLilRenderingForwardPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyName.SrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.SrcBlend} property.");

                return null;
            }

            return new LilRenderingForward
            {
                SrcBlend = material.GetSafeEnum<BlendMode>(PropertyName.SrcBlend),
                DstBlend = material.GetSafeEnum<BlendMode>(PropertyName.DstBlend),
                SrcBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.SrcBlendAlpha),
                DstBlendAlpha = material.GetSafeEnum<BlendMode>(PropertyName.DstBlendAlpha),
                BlendOp = material.GetSafeEnum<BlendOp>(PropertyName.BlendOp, BlendOp.Add),
                BlendOpAlpha = material.GetSafeEnum<BlendOp>(PropertyName.BlendOpAlpha, BlendOp.Add),
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

            if (material.HasProperty(PropertyName.SrcBlendFA) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.SrcBlendFA} property.");

                return null;
            }

            return new LilRenderingForwardAdd
            {
                SrcBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.SrcBlendFA),
                DstBlendFA = material.GetSafeEnum<BlendMode>(PropertyName.DstBlendFA),
                SrcBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.SrcBlendAlphaFA),
                DstBlendAlphaFA = material.GetSafeEnum<BlendMode>(PropertyName.DstBlendAlphaFA),
                BlendOpFA = material.GetSafeEnum<BlendOp>(PropertyName.BlendOpFA, BlendOp.Max),
                BlendOpAlphaFA = material.GetSafeEnum<BlendOp>(PropertyName.BlendOpAlphaFA, BlendOp.Max),
            };
        }

        /// <summary>
        /// Get the lilToon Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingStencil GetLilRenderingStencilPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyName.StencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.StencilRef} property.");

                return null;
            }

            return new LilRenderingStencil
            {
                StencilRef = material.GetSafeInt(PropertyName.StencilRef),
                StencilReadMask = material.GetSafeInt(PropertyName.StencilReadMask),
                StencilWriteMask = material.GetSafeInt(PropertyName.StencilWriteMask),
                StencilComp = material.GetSafeEnum<CompareFunction>(PropertyName.StencilComp),
                StencilPass = material.GetSafeEnum<StencilOp>(PropertyName.StencilPass),
                StencilFail = material.GetSafeEnum<StencilOp>(PropertyName.StencilFail),
                StencilZFail = material.GetSafeEnum<StencilOp>(PropertyName.StencilZFail),
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
                BaseColor = material.GetSafeColor(PropertyName.BaseColor),
                BaseMap = material.GetSafeTexture(PropertyName.BaseMap),
                BaseColorMap = material.GetSafeTexture(PropertyName.BaseColorMap),
                LilToonVersion = material.GetSafeInt(PropertyName.LilToonVersion),
            };
        }

        #endregion

        #endregion
    }
}