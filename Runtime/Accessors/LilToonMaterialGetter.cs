// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialGetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER && !LILTOON_1_4_0_OR_NEWER && !LILTOON_1_5_0_OR_NEWER
#define LILTOON_1_5_0_OR_NEWER
#endif
#nullable enable
namespace LilToonShader
{
    using UnityEngine;
    using LilToonShader.Extensions;
    using LilToonShader.Proxies;

#if LILTOON_1_5_0_OR_NEWER
    using LilToonShader.v1_5_0;
#elif LILTOON_1_4_0_OR_NEWER
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
        public virtual LilToonMultiPropertyEntity? GetLilToonMultiPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            var multiPropertyEntity = GetLilToonNormalPropertyEntity(material, propertyContainer) as LilToonMultiPropertyEntity;

            if (multiPropertyEntity is null)
            {
                return null;
            }

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
            var materialProxy = new LilBaseMaterialProxy(material);

            return new LilBase
            {
                Invisible = materialProxy.Invisible,
                FlipNormal = materialProxy.FlipNormal,
                ShiftBackfaceUV = materialProxy.ShiftBackfaceUV,
                BackfaceForceShadow = materialProxy.BackfaceForceShadow,
#if LILTOON_1_3_0_OR_NEWER
                BackfaceColor = materialProxy.BackfaceColor,  // v1.3.0
                AAStrength = materialProxy.AAStrength,        // v1.3.7
#endif
#if LILTOON_1_4_0_OR_NEWER
                UseDither = materialProxy.UseDither,            // v1.4.0
                DitherTex = materialProxy.DitherTex,            // v1.4.0
                DitherMaxValue = materialProxy.DitherMaxValue,  // v1.4.0
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
            var materialProxy = new LilLiteBaseMaterialProxy(material);

            return new LilLiteBase
            {
                Invisible = materialProxy.Invisible,
                FlipNormal = materialProxy.FlipNormal,
                ShiftBackfaceUV = materialProxy.ShiftBackfaceUV,
                BackfaceForceShadow = materialProxy.BackfaceForceShadow,
#if LILTOON_1_3_0_OR_NEWER
                AAStrength = materialProxy.AAStrength,  // v1.3.7
#endif
                TriMask = materialProxy.TriMask,
            };
        }

        /// <summary>
        /// Get the lilToon Fake Shadow Base property values from the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <returns></returns>
        public virtual LilFakeShadowBase GetLilFakeShadowBasePropertyValues(Material material)
        {
            var materialProxy = new LilFakeShadowBaseMaterialProxy(material);

            return new LilFakeShadowBase
            {
                Invisible = materialProxy.Invisible,
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
            var materialProxy = new LilLightingMaterialProxy(material);

            return new LilLighting
            {
                LightMinLimit = materialProxy.LightMinLimit,
                LightMaxLimit = materialProxy.LightMaxLimit,
                MonochromeLighting = materialProxy.MonochromeLighting,
            };
        }

        /// <summary>
        /// Get the lilToon Lighting Advanced property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilLightingAdvanced GetLilLightingAdvancedPropertyValues(Material material)
        {
            var materialProxy = new LilLightingAdvancedMaterialProxy(material);

            return new LilLightingAdvanced
            {
                AsUnlit = materialProxy.AsUnlit,
                VertexLightStrength = materialProxy.VertexLightStrength,
                LightDirectionOverride = materialProxy.LightDirectionOverride,
                AlphaBoostFA = materialProxy.AlphaBoostFA,
                BeforeExposureLimit = materialProxy.BeforeExposureLimit,
                LilDirectionalLightStrength = materialProxy.LilDirectionalLightStrength,
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
            var materialProxy = new LilFakeShadowMainMaterialProxy(material);

            return new LilFakeShadowMain
            {
                Color = materialProxy.Color,
                MainTex = materialProxy.MainTex,
                FakeShadowVector = materialProxy.FakeShadowVector,
            };
        }

        /// <summary>
        /// Get the lilToon Lite Main property values from the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <returns></returns>
        public virtual LilLiteMain GetLilLiteMainPropertyValues(Material material)
        {
            var materialProxy = new LilLiteMainMaterialProxy(material);

            return new LilLiteMain
            {
                Color = materialProxy.Color,
                MainTex = materialProxy.MainTex,
                MainTex_ScrollRotate = materialProxy.MainTex_ScrollRotate,
            };
        }

        /// <summary>
        /// Get the lilToon Main property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain GetLilMainPropertyValues(Material material)
        {
            var materialProxy = new LilMainMaterialProxy(material);

            return new LilMain
            {
                Color = materialProxy.Color,
                MainTex = materialProxy.MainTex,
                MainTex_ScrollRotate = materialProxy.MainTex_ScrollRotate,
                MainTexHSVG = materialProxy.MainTexHSVG,
                MainGradationStrength = materialProxy.MainGradationStrength,
                MainGradationTex = materialProxy.MainGradationTex,
                MainColorAdjustMask = materialProxy.MainColorAdjustMask,
            };
        }

        /// <summary>
        /// Get the lilToon Main 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain2nd GetLilMain2ndPropertyValues(Material material)
        {
            var materialProxy = new LilMain2ndMaterialProxy(material);

            return new LilMain2nd
            {
                UseMain2ndTex = materialProxy.UseMain2ndTex,
                Color2nd = materialProxy.Color2nd,
                Main2ndTex = materialProxy.Main2ndTex,
                Main2ndTexAngle = materialProxy.Main2ndTexAngle,
#if LILTOON_1_3_0_OR_NEWER
                Main2ndTex_ScrollRotate = materialProxy.Main2ndTex_ScrollRotate,  // v1.3.7
#endif
                Main2ndTex_UVMode = materialProxy.Main2ndTex_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Main2ndTex_Cull = materialProxy.Main2ndTex_Cull,  // v1.3.1
#endif
                Main2ndTexDecalAnimation = materialProxy.Main2ndTexDecalAnimation,
                Main2ndTexDecalSubParam = materialProxy.Main2ndTexDecalSubParam,
                Main2ndTexIsDecal = materialProxy.Main2ndTexIsDecal,
                Main2ndTexIsLeftOnly = materialProxy.Main2ndTexIsLeftOnly,
                Main2ndTexIsRightOnly = materialProxy.Main2ndTexIsRightOnly,
                Main2ndTexShouldCopy = materialProxy.Main2ndTexShouldCopy,
                Main2ndTexShouldFlipMirror = materialProxy.Main2ndTexShouldFlipMirror,
                Main2ndTexShouldFlipCopy = materialProxy.Main2ndTexShouldFlipCopy,
                Main2ndTexIsMSDF = materialProxy.Main2ndTexIsMSDF,
                Main2ndBlendMask = materialProxy.Main2ndBlendMask,
                Main2ndTexBlendMode = materialProxy.Main2ndTexBlendMode,
#if LILTOON_1_4_0_OR_NEWER
                Main2ndTexAlphaMode = materialProxy.Main2ndTexAlphaMode,  // v1.4.0
#endif
                Main2ndEnableLighting = materialProxy.Main2ndEnableLighting,
                Main2ndDissolveMask = materialProxy.Main2ndDissolveMask,
                Main2ndDissolveNoiseMask = materialProxy.Main2ndDissolveNoiseMask,
                Main2ndDissolveNoiseMask_ScrollRotate = materialProxy.Main2ndDissolveNoiseMask_ScrollRotate,
                Main2ndDissolveNoiseStrength = materialProxy.Main2ndDissolveNoiseStrength,
                Main2ndDissolveColor = materialProxy.Main2ndDissolveColor,
                Main2ndDissolveParams = materialProxy.Main2ndDissolveParams,
                Main2ndDissolvePos = materialProxy.Main2ndDissolvePos,
                Main2ndDistanceFade = materialProxy.Main2ndDistanceFade,
            };
        }

        /// <summary>
        /// Get the lilToon Main 3rd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMain3rd GetLilMain3rdPropertyValues(Material material)
        {
            var materialProxy = new LilMain3rdMaterialProxy(material);

            return new LilMain3rd
            {
                UseMain3rdTex = materialProxy.UseMain3rdTex,
                Color3rd = materialProxy.Color3rd,
                Main3rdTex = materialProxy.Main3rdTex,
                Main3rdTexAngle = materialProxy.Main3rdTexAngle,
#if LILTOON_1_3_0_OR_NEWER
                Main3rdTex_ScrollRotate = materialProxy.Main3rdTex_ScrollRotate,  // v1.3.7
#endif
                Main3rdTex_UVMode = materialProxy.Main3rdTex_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Main3rdTex_Cull = materialProxy.Main3rdTex_Cull,  // v1.3.1
#endif
                Main3rdTexDecalAnimation = materialProxy.Main3rdTexDecalAnimation,
                Main3rdTexDecalSubParam = materialProxy.Main3rdTexDecalSubParam,
                Main3rdTexIsDecal = materialProxy.Main3rdTexIsDecal,
                Main3rdTexIsLeftOnly = materialProxy.Main3rdTexIsLeftOnly,
                Main3rdTexIsRightOnly = materialProxy.Main3rdTexIsRightOnly,
                Main3rdTexShouldCopy = materialProxy.Main3rdTexShouldCopy,
                Main3rdTexShouldFlipMirror = materialProxy.Main3rdTexShouldFlipMirror,
                Main3rdTexShouldFlipCopy = materialProxy.Main3rdTexShouldFlipCopy,
                Main3rdTexIsMSDF = materialProxy.Main3rdTexIsMSDF,
                Main3rdBlendMask = materialProxy.Main3rdBlendMask,
                Main3rdTexBlendMode = materialProxy.Main3rdTexBlendMode,
#if LILTOON_1_4_0_OR_NEWER
                Main3rdTexAlphaMode = materialProxy.Main3rdTexAlphaMode,  // v1.4.0
#endif
                Main3rdEnableLighting = materialProxy.Main3rdEnableLighting,
                Main3rdDissolveMask = materialProxy.Main3rdDissolveMask,
                Main3rdDissolveNoiseMask = materialProxy.Main3rdDissolveNoiseMask,
                Main3rdDissolveNoiseMask_ScrollRotate = materialProxy.Main3rdDissolveNoiseMask_ScrollRotate,
                Main3rdDissolveNoiseStrength = materialProxy.Main3rdDissolveNoiseStrength,
                Main3rdDissolveColor = materialProxy.Main3rdDissolveColor,
                Main3rdDissolveParams = materialProxy.Main3rdDissolveParams,
                Main3rdDissolvePos = materialProxy.Main3rdDissolvePos,
                Main3rdDistanceFade = materialProxy.Main3rdDistanceFade,
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
            var materialProxy = new LilAlphaMaskMaterialProxy(material);

            return new LilAlphaMask
            {
                AlphaMaskMode = materialProxy.AlphaMaskMode,
                AlphaMask = materialProxy.AlphaMask,
                AlphaMaskScale = materialProxy.AlphaMaskScale,
                AlphaMaskValue = materialProxy.AlphaMaskValue,
            };
        }

        #endregion

        #region NormalMap

        /// <summary>
        /// Get the lilToon NormalMap property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilNormalMap GetLilNormalMapPropertyValues(Material material)
        {
            var materialProxy = new LilNormalMapMaterialProxy(material);

            return new LilNormalMap
            {
                UseBumpMap = materialProxy.UseBumpMap,
                BumpMap = materialProxy.BumpMap,
                BumpScale = materialProxy.BumpScale,
            };
        }

        /// <summary>
        /// Get the lilToon NormalMap 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilNormalMap2nd GetLilNormalMap2ndPropertyValues(Material material)
        {
            var materialProxy = new LilNormalMap2ndMaterialProxy(material);

            return new LilNormalMap2nd
            {
                UseBump2ndMap = materialProxy.UseBump2ndMap,
                Bump2ndMap = materialProxy.Bump2ndMap,
#if LILTOON_1_3_0_OR_NEWER
                Bump2ndMap_UVMode = materialProxy.Bump2ndMap_UVMode,  // v1.3.1
#endif
                Bump2ndScale = materialProxy.Bump2ndScale,
                Bump2ndScaleMask = materialProxy.Bump2ndScaleMask,
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
            var materialProxy = new LilAnisotropyMaterialProxy(material);

            return new LilAnisotropy
            {
                UseAnisotropy = materialProxy.UseAnisotropy,
                AnisotropyTangentMap = materialProxy.AnisotropyTangentMap,
                AnisotropyScale = materialProxy.AnisotropyScale,
                AnisotropyScaleMask = materialProxy.AnisotropyScaleMask,
                AnisotropyTangentWidth = materialProxy.AnisotropyTangentWidth,
                AnisotropyBitangentWidth = materialProxy.AnisotropyBitangentWidth,
                AnisotropyShift = materialProxy.AnisotropyShift,
                AnisotropyShiftNoiseScale = materialProxy.AnisotropyShiftNoiseScale,
                AnisotropySpecularStrength = materialProxy.AnisotropySpecularStrength,
                Anisotropy2ndTangentWidth = materialProxy.Anisotropy2ndTangentWidth,
                Anisotropy2ndBitangentWidth = materialProxy.Anisotropy2ndBitangentWidth,
                Anisotropy2ndShift = materialProxy.Anisotropy2ndShift,
                Anisotropy2ndShiftNoiseScale = materialProxy.Anisotropy2ndShiftNoiseScale,
                Anisotropy2ndSpecularStrength = materialProxy.Anisotropy2ndSpecularStrength,
                AnisotropyShiftNoiseMask = materialProxy.AnisotropyShiftNoiseMask,
                Anisotropy2Reflection = materialProxy.Anisotropy2Reflection,
                Anisotropy2MatCap = materialProxy.Anisotropy2MatCap,
                Anisotropy2MatCap2nd = materialProxy.Anisotropy2MatCap2nd,
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
            var materialProxy = new LilBacklightMaterialProxy(material);

            return new LilBacklight
            {
                UseBacklight = materialProxy.UseBacklight,
                BacklightColor = materialProxy.BacklightColor,
                BacklightColorTex = materialProxy.BacklightColorTex,
#if LILTOON_1_3_0_OR_NEWER
                BacklightMainStrength = materialProxy.BacklightMainStrength,  // v1.3.0
#endif
                BacklightNormalStrength = materialProxy.BacklightNormalStrength,
                BacklightBorder = materialProxy.BacklightBorder,
                BacklightBlur = materialProxy.BacklightBlur,
                BacklightDirectivity = materialProxy.BacklightDirectivity,
                BacklightViewStrength = materialProxy.BacklightViewStrength,
                BacklightReceiveShadow = materialProxy.BacklightReceiveShadow,
                BacklightBackfaceMask = materialProxy.BacklightBackfaceMask,
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
            var materialProxy = new LilLiteShadowMaterialProxy(material);

            return new LilLiteShadow
            {
                UseShadow = materialProxy.UseShadow,
                ShadowColorTex = materialProxy.ShadowColorTex,
                ShadowBorder = materialProxy.ShadowBorder,
                ShadowBlur = materialProxy.ShadowBlur,
                Shadow2ndColorTex = materialProxy.Shadow2ndColorTex,
                Shadow2ndBorder = materialProxy.Shadow2ndBorder,
                Shadow2ndBlur = materialProxy.Shadow2ndBlur,
                ShadowBorderColor = materialProxy.ShadowBorderColor,
                ShadowBorderRange = materialProxy.ShadowBorderRange,
                ShadowEnvStrength = materialProxy.ShadowEnvStrength,
            };
        }

        /// <summary>
        /// Get the lilToon Shadow property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilShadow GetLilShadowPropertyValues(Material material)
        {
            var materialProxy = new LilShadowMaterialProxy(material);

            return new LilShadow
            {
                UseShadow = materialProxy.UseShadow,
                //ShadowReceive = materialProxy.ShadowReceive,
                ShadowStrength = materialProxy.ShadowStrength,
                ShadowStrengthMask = materialProxy.ShadowStrengthMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowStrengthMaskLOD = materialProxy.ShadowStrengthMaskLOD,  // v1.3.0
#endif
                ShadowBorderMask = materialProxy.ShadowBorderMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowBorderMaskLOD = materialProxy.ShadowBorderMaskLOD,  // v1.3.0
#endif
                ShadowBlurMask = materialProxy.ShadowBlurMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowBlurMaskLOD = materialProxy.ShadowBlurMaskLOD,  // v1.3.0
#endif
                ShadowAOShift = materialProxy.ShadowAOShift,
                ShadowAOShift2 = materialProxy.ShadowAOShift2,
                ShadowPostAO = materialProxy.ShadowPostAO,
#if LILTOON_1_3_0_OR_NEWER
                ShadowColorType = materialProxy.ShadowColorType,  // v1.3.5
#endif
                ShadowColor = materialProxy.ShadowColor,
                ShadowColorTex = materialProxy.ShadowColorTex,
                ShadowNormalStrength = materialProxy.ShadowNormalStrength,
                ShadowBorder = materialProxy.ShadowBorder,
                ShadowBlur = materialProxy.ShadowBlur,
                ShadowReceive = materialProxy.ShadowReceive,
                Shadow2ndColor = materialProxy.Shadow2ndColor,
                Shadow2ndColorTex = materialProxy.Shadow2ndColorTex,
                Shadow2ndNormalStrength = materialProxy.Shadow2ndNormalStrength,
                Shadow2ndBorder = materialProxy.Shadow2ndBorder,
                Shadow2ndBlur = materialProxy.Shadow2ndBlur,
#if LILTOON_1_3_0_OR_NEWER
                Shadow2ndReceive = materialProxy.Shadow2ndReceive,  // v1.3.0
#endif
                Shadow3rdColor = materialProxy.Shadow3rdColor,
                Shadow3rdColorTex = materialProxy.Shadow3rdColorTex,
                Shadow3rdNormalStrength = materialProxy.Shadow3rdNormalStrength,
                Shadow3rdBorder = materialProxy.Shadow3rdBorder,
                Shadow3rdBlur = materialProxy.Shadow3rdBlur,
#if LILTOON_1_3_0_OR_NEWER
                Shadow3rdReceive = materialProxy.Shadow3rdReceive,  // v1.3.0
#endif
                ShadowBorderColor = materialProxy.ShadowBorderColor,
                ShadowBorderRange = materialProxy.ShadowBorderRange,
                ShadowMainStrength = materialProxy.ShadowMainStrength,
                ShadowEnvStrength = materialProxy.ShadowEnvStrength,
#if LILTOON_1_3_0_OR_NEWER
                ShadowMaskType = materialProxy.ShadowMaskType,      // v1.3.0
                ShadowFlatBorder = materialProxy.ShadowFlatBorder,  // v1.3.0
                ShadowFlatBlur = materialProxy.ShadowFlatBlur,      // v1.3.0
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
            var materialProxy = new LilReflectionMaterialProxy(material);

            return new LilReflection
            {
                UseReflection = materialProxy.UseReflection,
                Smoothness = materialProxy.Smoothness,
                SmoothnessTex = materialProxy.SmoothnessTex,
                Metallic = materialProxy.Metallic,
                MetallicGlossMap = materialProxy.MetallicGlossMap,
                Reflectance = materialProxy.Reflectance,
#if LILTOON_1_3_0_OR_NEWER
                GSAAStrength = materialProxy.GSAAStrength,  // v1.3.0
#endif
                ApplySpecular = materialProxy.ApplySpecular,
                ApplySpecularFA = materialProxy.ApplySpecularFA,
                SpecularToon = materialProxy.SpecularToon,
                SpecularNormalStrength = materialProxy.SpecularNormalStrength,
                SpecularBorder = materialProxy.SpecularBorder,
                SpecularBlur = materialProxy.SpecularBlur,
                ApplyReflection = materialProxy.ApplyReflection,
                ReflectionNormalStrength = materialProxy.ReflectionNormalStrength,
                ReflectionColor = materialProxy.ReflectionColor,
                ReflectionColorTex = materialProxy.ReflectionColorTex,
                ReflectionApplyTransparency = materialProxy.ReflectionApplyTransparency,
                ReflectionCubeTex = materialProxy.ReflectionCubeTex,
                ReflectionCubeColor = materialProxy.ReflectionCubeColor,
                ReflectionCubeOverride = materialProxy.ReflectionCubeOverride,
                ReflectionCubeEnableLighting = materialProxy.ReflectionCubeEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                ReflectionBlendMode = materialProxy.ReflectionBlendMode,  // v1.3.0
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
            var materialProxy = new LilLiteMatCapMaterialProxy(material);

            return new LilLiteMatCap
            {
                UseMatCap = materialProxy.UseMatCap,
                MatCapTex = materialProxy.MatCapTex,
                MatCapBlendUV1 = materialProxy.MatCapBlendUV1,
                MatCapZRotCancel = materialProxy.MatCapZRotCancel,
                MatCapPerspective = materialProxy.MatCapPerspective,
                MatCapVRParallaxStrength = materialProxy.MatCapVRParallaxStrength,
                MatCapMul = materialProxy.MatCapMul,  // Lite only
            };
        }

        /// <summary>
        /// Get the lilToon MatCap property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMatCap GetLilMatCapPropertyValues(Material material)
        {
            var materialProxy = new LilMatCapMaterialProxy(material);

            return new LilMatCap
            {
                UseMatCap = materialProxy.UseMatCap,
                MatCapColor = materialProxy.MatCapColor,
                MatCapTex = materialProxy.MatCapTex,
#if LILTOON_1_3_0_OR_NEWER
                MatCapMainStrength = materialProxy.MatCapMainStrength,  // v1.3.0
#endif
                MatCapBlendUV1 = materialProxy.MatCapBlendUV1,
                MatCapZRotCancel = materialProxy.MatCapZRotCancel,
                MatCapPerspective = materialProxy.MatCapPerspective,
                MatCapVRParallaxStrength = materialProxy.MatCapVRParallaxStrength,
                MatCapBlend = materialProxy.MatCapBlend,
                MatCapBlendMask = materialProxy.MatCapBlendMask,
                MatCapEnableLighting = materialProxy.MatCapEnableLighting,
                MatCapShadowMask = materialProxy.MatCapShadowMask,
                MatCapBackfaceMask = materialProxy.MatCapBackfaceMask,
                MatCapLod = materialProxy.MatCapLod,
                MatCapBlendMode = materialProxy.MatCapBlendMode,
                MatCapApplyTransparency = materialProxy.MatCapApplyTransparency,
                MatCapNormalStrength = materialProxy.MatCapNormalStrength,
                MatCapCustomNormal = materialProxy.MatCapCustomNormal,
                MatCapBumpMap = materialProxy.MatCapBumpMap,
                MatCapBumpScale = materialProxy.MatCapBumpScale,
            };
        }

        /// <summary>
        /// Get the lilToon MatCap 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilMatCap2nd GetLilMatCap2ndPropertyValues(Material material)
        {
            var materialProxy = new LilMatCap2ndMaterialProxy(material);

            return new LilMatCap2nd
            {
                UseMatCap2nd = materialProxy.UseMatCap2nd,
                MatCap2ndColor = materialProxy.MatCap2ndColor,
                MatCap2ndTex = materialProxy.MatCap2ndTex,
#if LILTOON_1_3_0_OR_NEWER
                MatCap2ndMainStrength = materialProxy.MatCap2ndMainStrength,  // v1.3.0
#endif
                MatCap2ndBlendUV1 = materialProxy.MatCap2ndBlendUV1,
                MatCap2ndZRotCancel = materialProxy.MatCap2ndZRotCancel,
                MatCap2ndPerspective = materialProxy.MatCap2ndPerspective,
                MatCap2ndVRParallaxStrength = materialProxy.MatCap2ndVRParallaxStrength,
                MatCap2ndBlend = materialProxy.MatCap2ndBlend,
                MatCap2ndBlendMask = materialProxy.MatCap2ndBlendMask,
                MatCap2ndEnableLighting = materialProxy.MatCap2ndEnableLighting,
                MatCap2ndShadowMask = materialProxy.MatCap2ndShadowMask,
                MatCap2ndBackfaceMask = materialProxy.MatCap2ndBackfaceMask,
                MatCap2ndLod = materialProxy.MatCap2ndLod,
                MatCap2ndBlendMode = materialProxy.MatCap2ndBlendMode,
                MatCap2ndApplyTransparency = materialProxy.MatCap2ndApplyTransparency,
                MatCap2ndNormalStrength = materialProxy.MatCap2ndNormalStrength,
                MatCap2ndCustomNormal = materialProxy.MatCap2ndCustomNormal,
                MatCap2ndBumpMap = materialProxy.MatCap2ndBumpMap,
                MatCap2ndBumpScale = materialProxy.MatCap2ndBumpScale,
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
            var materialProxy = new LilLiteRimMaterialProxy(material);

            return new LilLiteRim
            {
                UseRim = materialProxy.UseRim,
                RimColor = materialProxy.RimColor,
                RimBorder = materialProxy.RimBorder,
                RimBlur = materialProxy.RimBlur,
                RimFresnelPower = materialProxy.RimFresnelPower,
                RimShadowMask = materialProxy.RimShadowMask,
            };
        }

        /// <summary>
        /// Get the lilToon Rim property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRim GetLilRimPropertyValues(Material material)
        {
            var materialProxy = new LilRimMaterialProxy(material);

            return new LilRim
            {
                UseRim = materialProxy.UseRim,
                RimColor = materialProxy.RimColor,
                RimColorTex = materialProxy.RimColorTex,
#if LILTOON_1_3_0_OR_NEWER
                RimMainStrength = materialProxy.RimMainStrength,  // v1.3.0
#endif
                RimNormalStrength = materialProxy.RimNormalStrength,
                RimBorder = materialProxy.RimBorder,
                RimBlur = materialProxy.RimBlur,
                RimFresnelPower = materialProxy.RimFresnelPower,
                RimEnableLighting = materialProxy.RimEnableLighting,
                RimShadowMask = materialProxy.RimShadowMask,
                RimBackfaceMask = materialProxy.RimBackfaceMask,
                RimVRParallaxStrength = materialProxy.RimVRParallaxStrength,
                RimApplyTransparency = materialProxy.RimApplyTransparency,
                RimDirStrength = materialProxy.RimDirStrength,
                RimDirRange = materialProxy.RimDirRange,
                RimIndirRange = materialProxy.RimIndirRange,
                RimIndirColor = materialProxy.RimIndirColor,
                RimIndirBorder = materialProxy.RimIndirBorder,
                RimIndirBlur = materialProxy.RimIndirBlur,
#if LILTOON_1_3_0_OR_NEWER
                RimBlendMode = materialProxy.RimBlendMode,  // v1.3.7
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
            var materialProxy = new LilGlitterMaterialProxy(material);

            return new LilGlitter
            {
                UseGlitter = materialProxy.UseGlitter,
                GlitterUVMode = materialProxy.GlitterUVMode,
                GlitterColor = materialProxy.GlitterColor,
                GlitterColorTex = materialProxy.GlitterColorTex,
#if LILTOON_1_3_0_OR_NEWER
                GlitterColorTex_UVMode = materialProxy.GlitterColorTex_UVMode,  // v1.3.2
#endif
                GlitterMainStrength = materialProxy.GlitterMainStrength,
                GlitterNormalStrength = materialProxy.GlitterNormalStrength,
#if LILTOON_1_3_0_OR_NEWER
                GlitterScaleRandomize = materialProxy.GlitterScaleRandomize,  // v1.3.0
                GlitterApplyShape = materialProxy.GlitterApplyShape,          // v1.3.0
                GlitterShapeTex = materialProxy.GlitterShapeTex,              // v1.3.0
                GlitterAtras = materialProxy.GlitterAtras,                    // v1.3.0
                GlitterAngleRandomize = materialProxy.GlitterAngleRandomize,  // v1.3.0
#endif
                GlitterParams1 = materialProxy.GlitterParams1,
                GlitterParams2 = materialProxy.GlitterParams2,
                GlitterPostContrast = materialProxy.GlitterPostContrast,
#if LILTOON_1_3_0_OR_NEWER
                GlitterSensitivity = materialProxy.GlitterSensitivity,  // v1.3.0
#endif
                GlitterEnableLighting = materialProxy.GlitterEnableLighting,
                GlitterShadowMask = materialProxy.GlitterShadowMask,
                GlitterBackfaceMask = materialProxy.GlitterBackfaceMask,
                GlitterApplyTransparency = materialProxy.GlitterApplyTransparency,
                GlitterVRParallaxStrength = materialProxy.GlitterVRParallaxStrength,
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
            var materialProxy = new LilLiteEmissionMaterialProxy(material);

            return new LilLiteEmission
            {
                UseEmission = materialProxy.UseEmission,
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,
                EmissionMap_ScrollRotate = materialProxy.EmissionMap_ScrollRotate,
                EmissionMap_UVMode = materialProxy.EmissionMap_UVMode,
                EmissionBlink = materialProxy.EmissionBlink,
            };
        }

        /// <summary>
        /// Get the lilToon Emission property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission GetLilEmissionPropertyValues(Material material)
        {
            var materialProxy = new LilEmissionMaterialProxy(material);

            return new LilEmission
            {
                UseEmission = materialProxy.UseEmission,
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,
                EmissionMap_ScrollRotate = materialProxy.EmissionMap_ScrollRotate,
                EmissionMap_UVMode = materialProxy.EmissionMap_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                EmissionMainStrength = materialProxy.EmissionMainStrength,  // v1.3.0
#endif
                EmissionBlend = materialProxy.EmissionBlend,
                EmissionBlendMask = materialProxy.EmissionBlendMask,
                EmissionBlendMask_ScrollRotate = materialProxy.EmissionBlendMask_ScrollRotate,
#if LILTOON_1_3_0_OR_NEWER
                EmissionBlendMode = materialProxy.EmissionBlendMode,  // v1.3.7
#endif
                EmissionBlink = materialProxy.EmissionBlink,
                EmissionUseGrad = materialProxy.EmissionUseGrad,
                EmissionGradTex = materialProxy.EmissionGradTex,
                EmissionGradSpeed = materialProxy.EmissionGradSpeed,
                EmissionParallaxDepth = materialProxy.EmissionParallaxDepth,
                EmissionFluorescence = materialProxy.EmissionFluorescence,
            };
        }

        /// <summary>
        /// Get the lilToon Emission Gradation property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmissionGradation GetLilEmissionGradationPropertyValues(Material material)
        {
            var materialProxy = new LilEmissionGradationMaterialProxy(material);

            return new LilEmissionGradation
            {
                Egci = materialProxy.Egci,
                Egai = materialProxy.Egai,
                Egc0 = materialProxy.Egc0,
                Egc1 = materialProxy.Egc1,
                Egc2 = materialProxy.Egc2,
                Egc3 = materialProxy.Egc3,
                Egc4 = materialProxy.Egc4,
                Egc5 = materialProxy.Egc5,
                Egc6 = materialProxy.Egc6,
                Egc7 = materialProxy.Egc7,
                Ega0 = materialProxy.Ega0,
                Ega1 = materialProxy.Ega1,
                Ega2 = materialProxy.Ega2,
                Ega3 = materialProxy.Ega3,
                Ega4 = materialProxy.Ega4,
                Ega5 = materialProxy.Ega5,
                Ega6 = materialProxy.Ega6,
                Ega7 = materialProxy.Ega7,
            };
        }

        /// <summary>
        /// Get the lilToon Emission 2nd property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission2nd GetLilEmission2ndPropertyValues(Material material)
        {
            var materialProxy = new LilEmission2ndMaterialProxy(material);

            return new LilEmission2nd
            {
                UseEmission2nd = materialProxy.UseEmission2nd,
                Emission2ndColor = materialProxy.Emission2ndColor,
                Emission2ndMap = materialProxy.Emission2ndMap,
                Emission2ndMap_ScrollRotate = materialProxy.Emission2ndMap_ScrollRotate,
                Emission2ndMap_UVMode = materialProxy.Emission2ndMap_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Emission2ndMainStrength = materialProxy.Emission2ndMainStrength,  // v1.3.0
#endif
                Emission2ndBlend = materialProxy.Emission2ndBlend,
                Emission2ndBlendMask = materialProxy.Emission2ndBlendMask,
                Emission2ndBlendMask_ScrollRotate = materialProxy.Emission2ndBlendMask_ScrollRotate,
#if LILTOON_1_3_0_OR_NEWER
                Emission2ndBlendMode = materialProxy.Emission2ndBlendMode,  // v1.3.7
#endif
                Emission2ndBlink = materialProxy.Emission2ndBlink,
                Emission2ndUseGrad = materialProxy.Emission2ndUseGrad,
                Emission2ndGradTex = materialProxy.Emission2ndGradTex,
                Emission2ndGradSpeed = materialProxy.Emission2ndGradSpeed,
                Emission2ndParallaxDepth = materialProxy.Emission2ndParallaxDepth,
                Emission2ndFluorescence = materialProxy.Emission2ndFluorescence,
            };
        }

        /// <summary>
        /// Get the lilToon Emission 2nd Gradation property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilEmission2ndGradation GetLilEmission2ndGradationPropertyValues(Material material)
        {
            var materialProxy = new LilEmission2ndGradationMaterialProxy(material);

            return new LilEmission2ndGradation
            {
                E2gci = materialProxy.E2gci,
                E2gai = materialProxy.E2gai,
                E2gc0 = materialProxy.E2gc0,
                E2gc1 = materialProxy.E2gc1,
                E2gc2 = materialProxy.E2gc2,
                E2gc3 = materialProxy.E2gc3,
                E2gc4 = materialProxy.E2gc4,
                E2gc5 = materialProxy.E2gc5,
                E2gc6 = materialProxy.E2gc6,
                E2gc7 = materialProxy.E2gc7,
                E2ga0 = materialProxy.E2ga0,
                E2ga1 = materialProxy.E2ga1,
                E2ga2 = materialProxy.E2ga2,
                E2ga3 = materialProxy.E2ga3,
                E2ga4 = materialProxy.E2ga4,
                E2ga5 = materialProxy.E2ga5,
                E2ga6 = materialProxy.E2ga6,
                E2ga7 = materialProxy.E2ga7,
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
            var materialProxy = new LilParallaxMaterialProxy(material);

            return new LilParallax
            {
                UseParallax = materialProxy.UseParallax,
#if LILTOON_1_3_0_OR_NEWER
                UsePOM = materialProxy.UsePOM,  // v1.3.0
#endif
                ParallaxMap = materialProxy.ParallaxMap,
                Parallax = materialProxy.Parallax,
                ParallaxOffset = materialProxy.ParallaxOffset,
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
            var materialProxy = new LilDistanceFadeMaterialProxy(material);

            return new LilDistanceFade
            {
                DistanceFade = materialProxy.DistanceFade,
                DistanceFadeColor = materialProxy.DistanceFadeColor,
#if LILTOON_1_4_0_OR_NEWER
                DistanceFadeMode = materialProxy.DistanceFadeMode,                        // v1.4.0
                DistanceFadeRimColor = materialProxy.DistanceFadeRimColor,                // v1.4.0
                DistanceFadeRimFresnelPower = materialProxy.DistanceFadeRimFresnelPower,  // v1.4.0
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
            var materialProxy = new LilAudioLinkMaterialProxy(material);

            return new LilAudioLink
            {
                UseAudioLink = materialProxy.UseAudioLink,
                AudioLinkDefaultValue = materialProxy.AudioLinkDefaultValue,
                AudioLinkUVMode = materialProxy.AudioLinkUVMode,
                AudioLinkUVParams = materialProxy.AudioLinkUVParams,
                AudioLinkStart = materialProxy.AudioLinkStart,
                AudioLinkMask = materialProxy.AudioLinkMask,
#if LILTOON_1_4_0_OR_NEWER
                AudioLinkMask_ScrollRotate = materialProxy.AudioLinkMask_ScrollRotate,  // v1.4.0
                AudioLinkMask_UVMode = materialProxy.AudioLinkMask_UVMode,  // v1.4.0
#endif
                AudioLink2Main2nd = materialProxy.AudioLink2Main2nd,
                AudioLink2Main3rd = materialProxy.AudioLink2Main3rd,
                AudioLink2Emission = materialProxy.AudioLink2Emission,
                AudioLink2EmissionGrad = materialProxy.AudioLink2EmissionGrad,
                AudioLink2Emission2nd = materialProxy.AudioLink2Emission2nd,
                AudioLink2Emission2ndGrad = materialProxy.AudioLink2Emission2ndGrad,
                AudioLink2Vertex = materialProxy.AudioLink2Vertex,
                AudioLinkVertexUVMode = materialProxy.AudioLinkVertexUVMode,
                AudioLinkVertexUVParams = materialProxy.AudioLinkVertexUVParams,
                AudioLinkVertexStart = materialProxy.AudioLinkVertexStart,
                AudioLinkVertexStrength = materialProxy.AudioLinkVertexStrength,
                AudioLinkAsLocal = materialProxy.AudioLinkAsLocal,
                AudioLinkLocalMap = materialProxy.AudioLinkLocalMap,
                AudioLinkLocalMapParams = materialProxy.AudioLinkLocalMapParams,
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
            var materialProxy = new LilDissolveMaterialProxy(material);

            return new LilDissolve
            {
                DissolveMask = materialProxy.DissolveMask,
                DissolveNoiseMask = materialProxy.DissolveNoiseMask,
                DissolveNoiseMask_ScrollRotate = materialProxy.DissolveNoiseMask_ScrollRotate,
                DissolveNoiseStrength = materialProxy.DissolveNoiseStrength,
                DissolveColor = materialProxy.DissolveColor,
                DissolveParams = materialProxy.DissolveParams,
                DissolvePos = materialProxy.DissolvePos,
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
            var materialProxy = new LilIDMaskMaterialProxy(material);

            return new LilIDMask
            {
#if LILTOON_1_5_0_OR_NEWER
                IDMaskCompile = materialProxy.IDMaskCompile,  // v1.5.1
#endif
                IDMaskFrom = materialProxy.IDMaskFrom,  // v1.4.0

                IDMask1 = materialProxy.IDMask1,  // v1.4.0
                IDMask2 = materialProxy.IDMask2,  // v1.4.0
                IDMask3 = materialProxy.IDMask3,  // v1.4.0
                IDMask4 = materialProxy.IDMask4,  // v1.4.0
                IDMask5 = materialProxy.IDMask5,  // v1.4.0
                IDMask6 = materialProxy.IDMask6,  // v1.4.0
                IDMask7 = materialProxy.IDMask7,  // v1.4.0
                IDMask8 = materialProxy.IDMask8,  // v1.4.0

#if LILTOON_1_5_0_OR_NEWER
                IDMaskIsBitmap = materialProxy.IDMaskIsBitmap,  // v1.5.0
#endif
                IDMaskIndex1 = materialProxy.IDMaskIndex1,  // v1.4.0
                IDMaskIndex2 = materialProxy.IDMaskIndex2,  // v1.4.0
                IDMaskIndex3 = materialProxy.IDMaskIndex3,  // v1.4.0
                IDMaskIndex4 = materialProxy.IDMaskIndex4,  // v1.4.0
                IDMaskIndex5 = materialProxy.IDMaskIndex5,  // v1.4.0
                IDMaskIndex6 = materialProxy.IDMaskIndex6,  // v1.4.0
                IDMaskIndex7 = materialProxy.IDMaskIndex7,  // v1.4.0
                IDMaskIndex8 = materialProxy.IDMaskIndex8,  // v1.4.0

#if LILTOON_1_5_0_OR_NEWER
                IDMaskControlsDissolve = materialProxy.IDMaskControlsDissolve,  // v1.5.0

                IDMaskPrior1 = materialProxy.IDMaskPrior1,  // v1.5.0
                IDMaskPrior2 = materialProxy.IDMaskPrior2,  // v1.5.0
                IDMaskPrior3 = materialProxy.IDMaskPrior3,  // v1.5.0
                IDMaskPrior4 = materialProxy.IDMaskPrior4,  // v1.5.0
                IDMaskPrior5 = materialProxy.IDMaskPrior5,  // v1.5.0
                IDMaskPrior6 = materialProxy.IDMaskPrior6,  // v1.5.0
                IDMaskPrior7 = materialProxy.IDMaskPrior7,  // v1.5.0
                IDMaskPrior8 = materialProxy.IDMaskPrior8,  // v1.5.0
#endif
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
            var materialProxy = new LilEncryptionMaterialProxy(material);

            return new LilEncryption
            {
                IgnoreEncryption = materialProxy.IgnoreEncryption,
                Keys = materialProxy.Keys,
#if LILTOON_1_3_0_OR_NEWER
                BitKey0 = materialProxy.BitKey0,  // v1.3.7
                BitKey1 = materialProxy.BitKey1,  // v1.3.7
                BitKey2 = materialProxy.BitKey2,  // v1.3.7
                BitKey3 = materialProxy.BitKey3,  // v1.3.7
                BitKey4 = materialProxy.BitKey4,  // v1.3.7
                BitKey5 = materialProxy.BitKey5,  // v1.3.7
                BitKey6 = materialProxy.BitKey6,  // v1.3.7
                BitKey7 = materialProxy.BitKey7,  // v1.3.7
                BitKey8 = materialProxy.BitKey8,  // v1.3.7
                BitKey9 = materialProxy.BitKey9,  // v1.3.7
                BitKey10 = materialProxy.BitKey10,  // v1.3.7
                BitKey11 = materialProxy.BitKey11,  // v1.3.7
                BitKey12 = materialProxy.BitKey12,  // v1.3.7
                BitKey13 = materialProxy.BitKey13,  // v1.3.7
                BitKey14 = materialProxy.BitKey14,  // v1.3.7
                BitKey15 = materialProxy.BitKey15,  // v1.3.7
                BitKey16 = materialProxy.BitKey16,  // v1.3.7
                BitKey17 = materialProxy.BitKey17,  // v1.3.7
                BitKey18 = materialProxy.BitKey18,  // v1.3.7
                BitKey19 = materialProxy.BitKey19,  // v1.3.7
                BitKey20 = materialProxy.BitKey20,  // v1.3.7
                BitKey21 = materialProxy.BitKey21,  // v1.3.7
                BitKey22 = materialProxy.BitKey22,  // v1.3.7
                BitKey23 = materialProxy.BitKey23,  // v1.3.7
                BitKey24 = materialProxy.BitKey24,  // v1.3.7
                BitKey25 = materialProxy.BitKey25,  // v1.3.7
                BitKey26 = materialProxy.BitKey26,  // v1.3.7
                BitKey27 = materialProxy.BitKey27,  // v1.3.7
                BitKey28 = materialProxy.BitKey28,  // v1.3.7
                BitKey29 = materialProxy.BitKey29,  // v1.3.7
                BitKey30 = materialProxy.BitKey30,  // v1.3.7
                BitKey31 = materialProxy.BitKey31,  // v1.3.7
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
        public virtual LilRefraction? GetLilRefractionPropertyValues(Material material, bool isRefraction = true, bool isGem = false)
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

            var materialProxy = new LilRefractionMaterialProxy(material);
            
            if (isGem)
            {
                // Refraction for Gem
                return new LilRefraction
                {
                    RefractionStrength = materialProxy.RefractionStrength,
                    RefractionFresnelPower = materialProxy.RefractionFresnelPower,
                };
            }
            else
            {
                return new LilRefraction
                {
                    RefractionStrength = materialProxy.RefractionStrength,
                    RefractionFresnelPower = materialProxy.RefractionFresnelPower,
                    RefractionColorFromMain = materialProxy.RefractionColorFromMain,
                    RefractionColor = materialProxy.RefractionColor,
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
        public virtual LilFur? GetLilFurPropertyValues(Material material, bool isFur = true)
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

            var materialProxy = new LilFurMaterialProxy(material);

            return new LilFur
            {
                FurNoiseMask = materialProxy.FurNoiseMask,
                FurMask = materialProxy.FurMask,
                FurLengthMask = materialProxy.FurLengthMask,
                FurVectorTex = materialProxy.FurVectorTex,
                FurVectorScale = materialProxy.FurVectorScale,
                FurVector = materialProxy.FurVector,
                VertexColor2FurVector = materialProxy.VertexColor2FurVector,
                FurGravity = materialProxy.FurGravity,
                FurRandomize = materialProxy.FurRandomize,
                FurAO = materialProxy.FurAO,
#if LILTOON_1_3_0_OR_NEWER
                FurMeshType = materialProxy.FurMeshType,  // v1.3.0
#endif
                FurLayerNum = materialProxy.FurLayerNum,
                FurRootOffset = materialProxy.FurRootOffset,
                FurCutoutLength = materialProxy.FurCutoutLength,
                FurTouchStrength = materialProxy.FurTouchStrength,
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
        public virtual LilFurRendering? GetLilFurRenderingPropertyValues(Material material, bool isFur = true)
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

            var materialProxy = new LilFurRenderingMaterialProxy(material);

            return new LilFurRendering
            {
                FurCull = materialProxy.FurCull,

                FurZClip = materialProxy.FurZClip,
                FurZWrite = materialProxy.FurZWrite,
                FurZTest = materialProxy.FurZTest,

                FurOffsetFactor = materialProxy.FurOffsetFactor,
                FurOffsetUnits = materialProxy.FurOffsetUnits,

                FurColorMask = materialProxy.FurColorMask,
                FurAlphaToMask = materialProxy.FurAlphaToMask,
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingForward? GetLilFurRenderingForwardPropertyValues(Material material, bool isFur = true)
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

            var materialProxy = new LilFurRenderingForwardMaterialProxy(material);
            
            return new LilFurRenderingForward
            {
                FurSrcBlend = materialProxy.FurSrcBlend,
                FurDstBlend = materialProxy.FurDstBlend,
                FurSrcBlendAlpha = materialProxy.FurSrcBlendAlpha,
                FurDstBlendAlpha = materialProxy.FurDstBlendAlpha,
                FurBlendOp = materialProxy.FurBlendOp,
                FurBlendOpAlpha = materialProxy.FurBlendOpAlpha,
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingForwardAdd? GetLilFurRenderingForwardAddPropertyValues(Material material, bool isFur = true)
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

            var materialProxy = new LilFurRenderingForwardAddMaterialProxy(material);

            return new LilFurRenderingForwardAdd
            {
                FurSrcBlendFA = materialProxy.FurSrcBlendFA,
                FurDstBlendFA = materialProxy.FurDstBlendFA,
                FurSrcBlendAlphaFA = materialProxy.FurSrcBlendAlphaFA,
                FurDstBlendAlphaFA = materialProxy.FurDstBlendAlphaFA,
                FurBlendOpFA = materialProxy.FurBlendOpFA,
                FurBlendOpAlphaFA = materialProxy.FurBlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Get the lilToon Fur Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFur"></param>
        /// <returns></returns>
        public virtual LilFurRenderingStencil? GetLilFurRenderingStencilPropertyValues(Material material, bool isFur = true)
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

            var materialProxy = new LilFurRenderingStencilMaterialProxy(material);

            return new LilFurRenderingStencil
            {
                FurStencilRef = materialProxy.FurStencilRef,
                FurStencilReadMask = materialProxy.FurStencilReadMask,
                FurStencilWriteMask = materialProxy.FurStencilWriteMask,
                FurStencilComp = materialProxy.FurStencilComp,
                FurStencilPass = materialProxy.FurStencilPass,
                FurStencilFail = materialProxy.FurStencilFail,
                FurStencilZFail = materialProxy.FurStencilZFail,
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
        public virtual LilGem? GetLilGemPropertyValues(Material material, bool isGem = true)
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

            var materialProxy = new LilGemMaterialProxy(material);

            return new LilGem
            {
                GemChromaticAberration = materialProxy.GemChromaticAberration,
                GemEnvContrast = materialProxy.GemEnvContrast,
                GemEnvColor = materialProxy.GemEnvColor,
                GemParticleLoop = materialProxy.GemParticleLoop,
                GemParticleColor = materialProxy.GemParticleColor,
                GemVRParallaxStrength = materialProxy.GemVRParallaxStrength,
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
        public virtual LilTessellation? GetLilTessellationPropertyValues(Material material, bool isTessellation = true)
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

            var materialProxy = new LilTessellationMaterialProxy(material);

            return new LilTessellation
            {
                TessEdge = materialProxy.TessEdge,
                TessStrength = materialProxy.TessStrength,
                TessShrink = materialProxy.TessShrink,
                TessFactorMax = materialProxy.TessFactorMax,
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
        public virtual LilLiteOutline? GetLilLiteOutlinePropertyValues(Material material, bool isOutline)
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

            var materialProxy = new LilLiteOutlineMaterialProxy(material);

            return new LilLiteOutline
            {
                OutlineColor = materialProxy.OutlineColor,
                OutlineTex = materialProxy.OutlineTex,
                OutlineTex_ScrollRotate = materialProxy.OutlineTex_ScrollRotate,
                OutlineWidth = materialProxy.OutlineWidth,
                OutlineWidthMask = materialProxy.OutlineWidthMask,
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = materialProxy.OutlineFixWidth,  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
                OutlineFixWidth = material.GetSafeInt(PropertyNameID.OutlineFixWidth),  // v1.2.12
#endif
                OutlineVertexR2Width = materialProxy.OutlineVertexR2Width,
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = materialProxy.OutlineDeleteMesh,  // v1.3.0
#endif
                OutlineEnableLighting = materialProxy.OutlineEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = materialProxy.OutlineZBias,  // v1.3.0
#endif
            };
        }

        /// <summary>
        /// Get the lilToon Outline property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <returns></returns>
        public virtual LilOutline? GetLilOutlinePropertyValues(Material material, bool isOutline)
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

            var materialProxy = new LilOutlineMaterialProxy(material);

            return new LilOutline
            {
                OutlineColor = materialProxy.OutlineColor,
                OutlineTex = materialProxy.OutlineTex,
                OutlineTex_ScrollRotate = materialProxy.OutlineTex_ScrollRotate,
                OutlineTexHSVG = materialProxy.OutlineTexHSVG,
#if LILTOON_1_3_0_OR_NEWER
                OutlineLitColor = materialProxy.OutlineLitColor,        // v1.3.0
                OutlineLitApplyTex = materialProxy.OutlineLitApplyTex,  // v1.3.0
                OutlineLitScale = materialProxy.OutlineLitScale,        // v1.3.0
                OutlineLitOffset = materialProxy.OutlineLitOffset,      // v1.3.0
                OutlineLitShadowReceive = materialProxy.OutlineLitShadowReceive,  // v1.3.1
#endif
                OutlineWidth = materialProxy.OutlineWidth,
                OutlineWidthMask = materialProxy.OutlineWidthMask,
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = materialProxy.OutlineFixWidth,  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
                OutlineFixWidth = material.GetSafeInt(PropertyNameID.OutlineFixWidth),  // v1.2.12
#endif
                OutlineVertexR2Width = materialProxy.OutlineVertexR2Width,
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = materialProxy.OutlineDeleteMesh,  // v1.3.0
#endif
                OutlineVectorTex = materialProxy.OutlineVectorTex,
#if LILTOON_1_3_0_OR_NEWER
                OutlineVectorUVMode = materialProxy.OutlineVectorUVMode,  // v1.3.0
#endif
                OutlineVectorScale = materialProxy.OutlineVectorScale,
                OutlineEnableLighting = materialProxy.OutlineEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = materialProxy.OutlineZBias,  // v1.3.0
                OutlineDisableInVR = materialProxy.OutlineDisableInVR,  // v1.3.0
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
        public virtual LilOutlineRendering? GetLilOutlineRenderingPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
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

            var materialProxy = new LilOutlineRenderingMaterialProxy(material);

            return new LilOutlineRendering
            {
                OutlineCull = materialProxy.OutlineCull,

                OutlineZClip = materialProxy.OutlineZClip,
                OutlineZWrite = materialProxy.OutlineZWrite,
                OutlineZTest = materialProxy.OutlineZTest,

                OutlineOffsetFactor = materialProxy.OutlineOffsetFactor,
                OutlineOffsetUnits = materialProxy.OutlineOffsetUnits,

                OutlineColorMask = materialProxy.OutlineColorMask,
                OutlineAlphaToMask = materialProxy.OutlineAlphaToMask,
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingForward? GetLilOutlineRenderingForwardPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
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

            var materialProxy = new LilOutlineRenderingForwardMaterialProxy(material);

            return new LilOutlineRenderingForward
            {
                OutlineSrcBlend = materialProxy.OutlineSrcBlend,
                OutlineDstBlend = materialProxy.OutlineDstBlend,
                OutlineSrcBlendAlpha = materialProxy.OutlineSrcBlendAlpha,
                OutlineDstBlendAlpha = materialProxy.OutlineDstBlendAlpha,
                OutlineBlendOp = materialProxy.OutlineBlendOp,
                OutlineBlendOpAlpha = materialProxy.OutlineBlendOpAlpha,
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingForwardAdd? GetLilOutlineRenderingForwardAddPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
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

            var materialProxy = new LilOutlineRenderingForwardAddMaterialProxy(material);

            return new LilOutlineRenderingForwardAdd
            {
                OutlineSrcBlendFA = materialProxy.OutlineSrcBlendFA,
                OutlineDstBlendFA = materialProxy.OutlineDstBlendFA,
                OutlineSrcBlendAlphaFA = materialProxy.OutlineSrcBlendAlphaFA,
                OutlineDstBlendAlphaFA = materialProxy.OutlineDstBlendAlphaFA,
                OutlineBlendOpFA = materialProxy.OutlineBlendOpFA,
                OutlineBlendOpAlphaFA = materialProxy.OutlineBlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Get the lilToon Outline Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isOutline"></param>
        /// <param name="isRefraction"></param>
        /// <returns></returns>
        public virtual LilOutlineRenderingStencil? GetLilOutlineRenderingStencilPropertyValues(Material material, bool isOutline = true, bool isRefraction = false)
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

            var materialProxy = new LilOutlineRenderingStencilMaterialProxy(material);

            return new LilOutlineRenderingStencil
            {
                OutlineStencilRef = materialProxy.OutlineStencilRef,
                OutlineStencilReadMask = materialProxy.OutlineStencilReadMask,
                OutlineStencilWriteMask = materialProxy.OutlineStencilWriteMask,
                OutlineStencilComp = materialProxy.OutlineStencilComp,
                OutlineStencilPass = materialProxy.OutlineStencilPass,
                OutlineStencilFail = materialProxy.OutlineStencilFail,
                OutlineStencilZFail = materialProxy.OutlineStencilZFail,
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
        public virtual LilMulti? GetLilMultiPropertyValues(Material material, bool isMulti = true)
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

            var materialProxy = new LilMultiMaterialProxy(material);

            return new LilMulti
            {
                UseOutline = materialProxy.UseOutline,
                TransparentMode = materialProxy.TransparentMode,
#if LILTOON_1_3_0_OR_NEWER
                // v1.3.0 deleted
#elif LILTOON_1_2_12_OR_OLDER
                UsePOM = materialProxy.UsePOM,
#else
                //
#endif
                UseClippingCanceller = materialProxy.UseClippingCanceller,
                AsOverlay = materialProxy.AsOverlay,
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
            var materialProxy = new LilRenderingMaterialProxy(material);

            var rendering = new LilRendering
            {
                Cull = materialProxy.Cull,
                ZClip = materialProxy.ZClip,
                ZWrite = materialProxy.ZWrite,
                ZTest = materialProxy.ZTest,
                OffsetFactor = materialProxy.OffsetFactor,
                OffsetUnits = materialProxy.OffsetUnits,
                ColorMask = materialProxy.ColorMask,
                AlphaToMask = materialProxy.AlphaToMask,
#if LILTOON_1_3_0_OR_NEWER
                LilShadowCasterBias = materialProxy.LilShadowCasterBias,  // v1.3.0
#endif
            };

            if (isFakeShadow)
            {
                return rendering;
            }

            rendering.Cutoff = materialProxy.Cutoff;
            rendering.SubpassCutoff = materialProxy.SubpassCutoff;

            return rendering;
        }

        /// <summary>
        /// Get the lilToon Rendering Forward property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingForward? GetLilRenderingForwardPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyNameID.SrcBlend) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.SrcBlend} property.");

                return null;
            }

            var materialProxy = new LilRenderingForwardMaterialProxy(material);

            return new LilRenderingForward
            {
                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                SrcBlendAlpha = materialProxy.SrcBlendAlpha,
                DstBlendAlpha = materialProxy.DstBlendAlpha,
                BlendOp = materialProxy.BlendOp,
                BlendOpAlpha = materialProxy.BlendOpAlpha,
            };
        }

        /// <summary>
        /// Get the lilToon Rendering Forward Add property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isGem"></param>
        /// <returns></returns>
        public virtual LilRenderingForwardAdd? GetLilRenderingForwardAddPropertyValues(Material material, bool isGem = false)
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

            var materialProxy = new LilRenderingForwardAddMaterialProxy(material);

            return new LilRenderingForwardAdd
            {
                SrcBlendFA = materialProxy.SrcBlendFA,
                DstBlendFA = materialProxy.DstBlendFA,
                SrcBlendAlphaFA = materialProxy.SrcBlendAlphaFA,
                DstBlendAlphaFA = materialProxy.DstBlendAlphaFA,
                BlendOpFA = materialProxy.BlendOpFA,
                BlendOpAlphaFA = materialProxy.BlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Get the lilToon Rendering Stencil property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns></returns>
        public virtual LilRenderingStencil? GetLilRenderingStencilPropertyValues(Material material)
        {
            if (material.HasProperty(PropertyNameID.StencilRef) == false)
            {
                Debug.LogWarning($"{material.name} don't have {PropertyName.StencilRef} property.");

                return null;
            }

            var materialProxy = new LilRenderingStencilMaterialProxy(material);

            return new LilRenderingStencil
            {
                StencilRef = materialProxy.StencilRef,
                StencilReadMask = materialProxy.StencilReadMask,
                StencilWriteMask = materialProxy.StencilWriteMask,
                StencilComp = materialProxy.StencilComp,
                StencilPass = materialProxy.StencilPass,
                StencilFail = materialProxy.StencilFail,
                StencilZFail = materialProxy.StencilZFail,
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
            var materialProxy = new LilSaveMaterialProxy(material);

            return new LilSave
            {
                BaseColor = materialProxy.BaseColor,
                BaseMap = materialProxy.BaseMap,
                BaseColorMap = materialProxy.BaseColorMap,
                LilToonVersion = materialProxy.LilToonVersion,
            };
        }

        #endregion

        #endregion
    }
}