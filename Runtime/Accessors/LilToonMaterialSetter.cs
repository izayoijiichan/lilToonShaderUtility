// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialSetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER && !LILTOON_1_4_0_OR_NEWER && !LILTOON_1_5_0_OR_NEWER && !LILTOON_1_6_0_OR_NEWER && !LILTOON_1_7_0_OR_NEWER
#define LILTOON_1_7_0_OR_NEWER
#endif
#nullable enable
namespace LilToonShader
{
    using System;
    using UnityEngine;
    using LilToonShader.Extensions;
    using LilToonShader.Proxies;

#if LILTOON_1_7_0_OR_NEWER
    using LilToonShader.v1_7_0;
#elif LILTOON_1_6_0_OR_NEWER
    using LilToonShader.v1_6_0;
#elif LILTOON_1_5_0_OR_NEWER
    using LilToonShader.v1_5_0;
#elif LILTOON_1_4_0_OR_NEWER
    using LilToonShader.v1_4_0;
#elif LILTOON_1_3_0_OR_NEWER
    using LilToonShader.v1_3_0;
#elif LILTOON_1_2_12_OR_OLDER
    using LilToonShader.v1_2_12;
#endif

    /// <summary>
    /// lilToon Material Setter
    /// </summary>
    public class LilToonMaterialSetter
    {
        #region Default

#pragma warning disable IDE0090
        /// <summary>Default Texture Offset</summary>
        protected readonly Vector2 DefaultTextureOffset = new Vector2(0.0f, 0.0f);

        /// <summary>Default Texture Scale</summary>
        protected readonly Vector2 DefaultTextureScale = new Vector2(1.0f, 1.0f);

        /// <summary>Default Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        protected readonly Vector4 DefaultScrollRotate = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

        /// <summary>Default HSVG</summary>
        /// <remarks>Hue|Saturation|Value|Gamma</remarks>
        protected readonly Vector4 DefaultHSVG = new Vector4(0.0f, 1.0f, 1.0f, 1.0f);

        /// <summary>Default Keys</summary>
        protected readonly Vector4 DefaultKeys = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

        /// <summary>Default Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        protected readonly Vector4 DefaultDecalAnimation = new Vector4(1.0f, 1.0f, 1.0f, 30.0f);

        /// <summary>Default Dissolve Parameters</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        protected readonly Vector4 DefaultDissolveParams = new Vector4(0.0f, 0.0f, 0.5f, 0.1f);

        /// <summary>Default Distance Fade Parameters</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        protected readonly Vector4 DefaultDistanceFadeParams = new Vector4(0.1f, 0.01f, 0.0f, 0.0f);
#pragma warning restore IDE0090

        #endregion

        #region Methods (Container)

        /// <summary>
        /// Set the lilToon property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        public virtual void SetLilToonPropertyValues(Material material, LilToonPropertyContainer propertyContainer)
        {
            switch (propertyContainer.PropertyEntityType)
            {
                case LilPropertyEntityType.Normal:
                    SetLilToonNormalPropertyEntity(material, propertyContainer);
                    break;
                case LilPropertyEntityType.Lite:
                    SetLilToonLitePropertyEntity(material, propertyContainer);
                    break;
                case LilPropertyEntityType.Multi:
                    SetLilToonMultiPropertyEntity(material, propertyContainer);
                    break;
                case LilPropertyEntityType.FakeShadow:
                    SetLilToonFakeShadowPropertyEntity(material, propertyContainer);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        #endregion

        #region Methods (Entity)

        /// <summary>
        /// Set the lilToon Lite property entity to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        public virtual void SetLilToonLitePropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            if (propertyContainer.LiteProperty is null)
            {
                throw new Exception();
            }

            LilToonLitePropertyEntity litePropertyEntity = propertyContainer.LiteProperty;

            // Base (Lite)
            SetLilLiteBasePropertyValues(material, litePropertyEntity.Base);

            // Lighting
            SetLilLightingPropertyValues(material, litePropertyEntity.Lighting);
            SetLilLightingAdvancedPropertyValues(material, litePropertyEntity.LightingAdvanced);

            // Main (Lite)
            SetLilLiteMainPropertyValues(material, litePropertyEntity.Main);

            // Shadow (Lite)
            SetLilLiteShadowPropertyValues(material, litePropertyEntity.Shadow);

            // MatCap (Lite)
            SetLilLiteMatCapPropertyValues(material, litePropertyEntity.MatCap);

            // Rim (Lite)
            SetLilLiteRimPropertyValues(material, litePropertyEntity.Rim);

            // Emission (Lite)
            SetLilLiteEmissionPropertyValues(material, litePropertyEntity.Emission);

            // Outline
            if (propertyContainer.IsOutline)
            {
                // Outline (Lite)
                SetLilLiteOutlinePropertyValues(material, litePropertyEntity.Outline);

                if (propertyContainer.IsRefraction == false)
                {
                    // Outline (Rendering)
                    SetLilOutlineRenderingPropertyValues(material, litePropertyEntity.OutlineRendering);
                    SetLilOutlineRenderingForwardPropertyValues(material, litePropertyEntity.OutlineRenderingForward);
                    SetLilOutlineRenderingForwardAddPropertyValues(material, litePropertyEntity.OutlineRenderingForwardAdd);
                    SetLilOutlineRenderingStencilPropertyValues(material, litePropertyEntity.OutlineRenderingStencil);
                }
            }

            // Rendering
            SetLilRenderingPropertyValues(material, litePropertyEntity.Rendering);

            // Rendering (Forward)
            SetLilRenderingForwardPropertyValues(material, litePropertyEntity.RenderingForward);

            // Rendering (Forward Add)
            if (propertyContainer.IsGem == false)
            {
                SetLilRenderingForwardAddPropertyValues(material, litePropertyEntity.RenderingForwardAdd);
            }

            // Rendering (Stencil)
            SetLilRenderingStencilPropertyValues(material, litePropertyEntity.RenderingStencil);

            // Save
            //SetLilSavePropertyValues(material, litePropertyEntity.Save);
        }

        /// <summary>
        /// Set the lilToon property entity to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        public virtual void SetLilToonNormalPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
            if (propertyContainer.NormalProperty is null)
            {
                throw new Exception();
            }

            LilToonNormalPropertyEntity normalPropertyEntity = propertyContainer.NormalProperty;

            // Base
            SetLilBasePropertyValues(material, normalPropertyEntity.Base);

            // Lighting
            SetLilLightingPropertyValues(material, normalPropertyEntity.Lighting);
            SetLilLightingAdvancedPropertyValues(material, normalPropertyEntity.LightingAdvanced);

            // Main
            SetLilMainPropertyValues(material, normalPropertyEntity.Main);
            SetLilMain2ndPropertyValues(material, normalPropertyEntity.Main2nd);
            SetLilMain3rdPropertyValues(material, normalPropertyEntity.Main3rd);

            // Alpha Mask
            SetLilAlphaMaskPropertyValues(material, normalPropertyEntity.AlphaMask);

            // NormalMap
            SetLilNormalMapPropertyValues(material, normalPropertyEntity.NormalMap);
            SetLilNormalMap2ndPropertyValues(material, normalPropertyEntity.NormalMap2nd);

            // Anisotropy
            SetLilAnisotropyPropertyValues(material, normalPropertyEntity.Anisotropy);

            // Backlight
            SetLilBacklightPropertyValues(material, normalPropertyEntity.Backlight);

            // Shadow
            SetLilShadowPropertyValues(material, normalPropertyEntity.Shadow);

#if LILTOON_1_6_0_OR_NEWER
            // Rim Shade
            SetLilRimShadePropertyValues(material, normalPropertyEntity.RimShade);  // v1.6.0
#endif

            // Reflection
            SetLilReflectionPropertyValues(material, normalPropertyEntity.Reflection);

            // MatCap
            SetLilMatCapPropertyValues(material, normalPropertyEntity.MatCap);
            SetLilMatCap2ndPropertyValues(material, normalPropertyEntity.MatCap2nd);

            // Rim
            SetLilRimPropertyValues(material, normalPropertyEntity.Rim);

            // Glitter
            SetLilGlitterPropertyValues(material, normalPropertyEntity.Glitter);

            // Emission
            SetLilEmissionPropertyValues(material, normalPropertyEntity.Emission);
            SetLilEmissionGradationPropertyValues(material, normalPropertyEntity.EmissionGradation);
            SetLilEmission2ndPropertyValues(material, normalPropertyEntity.Emission2nd);
            SetLilEmission2ndGradationPropertyValues(material, normalPropertyEntity.Emission2ndGradation);

            // Parallax
            SetLilParallaxPropertyValues(material, normalPropertyEntity.Parallax);

            // Distance Fade
            SetLilDistanceFadePropertyValues(material, normalPropertyEntity.DistanceFade);

            // Audio Link
            SetLilAudioLinkPropertyValues(material, normalPropertyEntity.AudioLink);

            // Dissolve
            SetLilDissolvePropertyValues(material, normalPropertyEntity.Dissolve);

#if LILTOON_1_4_0_OR_NEWER
            // ID Mask
            SetLilIDMaskPropertyValues(material, normalPropertyEntity.IDMask);  // v1.4.0
#endif

#if LILTOON_1_7_0_OR_NEWER
            // UDIM Discard
            SetLilUdimDiscardPropertyValues(material, normalPropertyEntity.UdimDiscard);  // v1.7.0
#endif

            // Encryption
            SetLilEncryptionPropertyValues(material, normalPropertyEntity.Encryption);

            // Refraction
            if (propertyContainer.IsRefraction || propertyContainer.IsGem)
            {
                SetLilRefractionPropertyValues(material, normalPropertyEntity.Refraction, propertyContainer.IsRefraction, propertyContainer.IsGem);
            }

            // Fur
            if (propertyContainer.IsFur)
            {
                // Fur
                SetLilFurPropertyValues(material, normalPropertyEntity.Fur);

                // Fur (Rendering)
                SetLilFurRenderingPropertyValues(material, normalPropertyEntity.FurRendering);
                SetLilFurRenderingForwardPropertyValues(material, normalPropertyEntity.FurRenderingForward);
                SetLilFurRenderingForwardAddPropertyValues(material, normalPropertyEntity.FurRenderingForwardAdd);
                SetLilFurRenderingStencilPropertyValues(material, normalPropertyEntity.FurRenderingStencil);
            }

            // Gem
            if (propertyContainer.IsGem)
            {
                SetLilGemPropertyValues(material, normalPropertyEntity.Gem);
            }

            // Tessellation
            if (propertyContainer.IsTessellation)
            {
                SetLilTessellationPropertyValues(material, normalPropertyEntity.Tessellation);
            }

            // Outline
            if (propertyContainer.IsOutline)
            {
                // Outline
                SetLilOutlinePropertyValues(material, normalPropertyEntity.Outline);

                if (propertyContainer.IsRefraction == false)
                {
                    // Outline (Rendering)
                    SetLilOutlineRenderingPropertyValues(material, normalPropertyEntity.OutlineRendering);
                    SetLilOutlineRenderingForwardPropertyValues(material, normalPropertyEntity.OutlineRenderingForward);
                    SetLilOutlineRenderingForwardAddPropertyValues(material, normalPropertyEntity.OutlineRenderingForwardAdd);
                    SetLilOutlineRenderingStencilPropertyValues(material, normalPropertyEntity.OutlineRenderingStencil);
                }
            }

            // Rendering
            SetLilRenderingPropertyValues(material, normalPropertyEntity.Rendering);

            // Rendering (Forward)
            SetLilRenderingForwardPropertyValues(material, normalPropertyEntity.RenderingForward);

            // Rendering (Forward Add)
            if (propertyContainer.IsGem == false)
            {
                SetLilRenderingForwardAddPropertyValues(material, normalPropertyEntity.RenderingForwardAdd);
            }

            // Rendering (Stencil)
            SetLilRenderingStencilPropertyValues(material, normalPropertyEntity.RenderingStencil);

            // Save
            //SetLilSavePropertyValues(material, normalPropertyEntity.Save);
        }

        /// <summary>
        /// Set the lilToon Multi property entity to the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        public virtual void SetLilToonMultiPropertyEntity(Material material, LilToonPropertyContainer propertyContainer)
        {
#if LILTOON_1_3_0_OR_NEWER
            if (propertyContainer.NormalProperty is null)
            {
                throw new Exception();
            }

            LilToonNormalPropertyEntity multiPropertyEntity = propertyContainer.NormalProperty;
#elif LILTOON_1_2_12_OR_OLDER
            if (propertyContainer.MultiProperty is null)
            {
                throw new Exception();
            }

            LilToonMultiPropertyEntity multiPropertyEntity = propertyContainer.MultiProperty;
#endif
            // Keyword
            SetLilMultiKeywords(material, multiPropertyEntity);

            // Pass
            SetLilMultiPasses(material, multiPropertyEntity);

            // Property
            SetLilToonNormalPropertyEntity(material, propertyContainer);

            // Property (Multi)
            SetLilMultiPropertyValues(material, multiPropertyEntity.Multi);
        }

        /// <summary>
        /// Set the lilToon Fake Shadow property entity to the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyEntity">A lilToon property entity.</param>
        public virtual void SetLilToonFakeShadowPropertyEntity(Material material, LilToonPropertyContainer propertyEntity)
        {
            if (propertyEntity.FakeShadowProperty is null)
            {
                throw new Exception();
            }

            LilToonFakeShadowPropertyEntity fakeShadowPropertyEntity = propertyEntity.FakeShadowProperty;

            // Base (Fake Shadow)
            SetLilFakeShadowBasePropertyValues(material, fakeShadowPropertyEntity.Base);

            // Main (Fake Shadow)
            SetLilFakeShadowMainPropertyValues(material, fakeShadowPropertyEntity.Main);

            // Encryption
            SetLilEncryptionPropertyValues(material, fakeShadowPropertyEntity.Encryption);

            // Rendering
            SetLilRenderingPropertyValues(material, fakeShadowPropertyEntity.Rendering, isFakeShadow: true);
            SetLilRenderingForwardPropertyValues(material, fakeShadowPropertyEntity.RenderingForward);
            SetLilRenderingStencilPropertyValues(material, fakeShadowPropertyEntity.RenderingStencil);

            // Save
            //SetLilSavePropertyValues(material, fakeShadowPropertyEntity.Save);
        }

        #endregion

        #region Methods (Block)

        #region Base (Normal, Lite, FakeShadow)

        /// <summary>
        /// Set the lilToon Base property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilBasePropertyValues(Material material, ILilBase? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilBaseMaterialProxy(material)
            {
                Invisible = propertyBlock.Invisible,
                FlipNormal = propertyBlock.FlipNormal,
                ShiftBackfaceUV = propertyBlock.ShiftBackfaceUV,
                BackfaceForceShadow = propertyBlock.BackfaceForceShadow,
#if LILTOON_1_3_0_OR_NEWER
                BackfaceColor = propertyBlock.BackfaceColor,  // v1.3.0
                AAStrength = propertyBlock.AAStrength,        // v1.3.7
#endif
#if LILTOON_1_4_0_OR_NEWER
                UseDither = propertyBlock.UseDither,            // v1.4.0
                DitherTex = propertyBlock.DitherTex,            // v1.4.0
                DitherMaxValue = propertyBlock.DitherMaxValue,  // v1.4.0
#endif
            };
        }

        /// <summary>
        /// Set the lilToon Lite Base property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteBasePropertyValues(Material material, ILilLiteBase? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteBaseMaterialProxy(material)
            {
                Invisible = propertyBlock.Invisible,
                FlipNormal = propertyBlock.FlipNormal,
                ShiftBackfaceUV = propertyBlock.ShiftBackfaceUV,
                BackfaceForceShadow = propertyBlock.BackfaceForceShadow,
#if LILTOON_1_3_0_OR_NEWER
                AAStrength = propertyBlock.AAStrength,  // v1.3.7
#endif
                TriMask = propertyBlock.TriMask,  // Lite only
            };
        }

        /// <summary>
        /// Set the lilToon Fake Shadow Base property values to the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFakeShadowBasePropertyValues(Material material, ILilFakeShadowBase? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFakeShadowBaseMaterialProxy(material)
            {
                Invisible = propertyBlock.Invisible,
            };
        }

        #endregion

        #region Lighting

        /// <summary>
        /// Set the lilToon Lighting property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLightingPropertyValues(Material material, ILilLighting? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLightingMaterialProxy(material)
            {
                LightMinLimit = propertyBlock.LightMinLimit,
                LightMaxLimit = propertyBlock.LightMaxLimit,
                MonochromeLighting = propertyBlock.MonochromeLighting,
            };
        }

        /// <summary>
        /// Set the lilToon Lighting Advanced property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLightingAdvancedPropertyValues(Material material, ILilLightingAdvanced? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLightingAdvancedMaterialProxy(material)
            {
                AsUnlit = propertyBlock.AsUnlit,
                VertexLightStrength = propertyBlock.VertexLightStrength,
                LightDirectionOverride = propertyBlock.LightDirectionOverride,
                AlphaBoostFA = propertyBlock.AlphaBoostFA,
                BeforeExposureLimit = propertyBlock.BeforeExposureLimit,
                LilDirectionalLightStrength = propertyBlock.LilDirectionalLightStrength,
            };
        }

        #endregion

        #region Main (Normal, Lite, FakeShadow)

        /// <summary>
        /// Set the lilToon Fake Shadow Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFakeShadowMainPropertyValues(Material material, ILilFakeShadowMain? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFakeShadowMainMaterialProxy(material)
            {
                Color = propertyBlock.Color,
                MainTex = propertyBlock.MainTex,
                FakeShadowVector = propertyBlock.FakeShadowVector,
            };
        }

        /// <summary>
        /// Set the lilToon Lite Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteMainPropertyValues(Material material, ILilLiteMain? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteMainMaterialProxy(material)
            {
                Color = propertyBlock.Color,
                MainTex = propertyBlock.MainTex,
                MainTex_ScrollRotate = propertyBlock.MainTex_ScrollRotate,
            };
        }

        /// <summary>
        /// Set the lilToon Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMainPropertyValues(Material material, ILilMain? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilMainMaterialProxy(material)
            {
                Color = propertyBlock.Color,
                MainTex = propertyBlock.MainTex,
                MainTex_ScrollRotate = propertyBlock.MainTex_ScrollRotate,
                MainTexHSVG = propertyBlock.MainTexHSVG,
                MainGradationStrength = propertyBlock.MainGradationStrength,
                MainGradationTex = propertyBlock.MainGradationTex,
                MainColorAdjustMask = propertyBlock.MainColorAdjustMask,
            };
        }

        /// <summary>
        /// Set the lilToon Main 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMain2ndPropertyValues(Material material, ILilMain2nd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilMain2ndMaterialProxy(material)
            {
                UseMain2ndTex = propertyBlock.UseMain2ndTex,

                Color2nd = propertyBlock.Color2nd,
                Main2ndTex = propertyBlock.Main2ndTex,
                Main2ndTexAngle = propertyBlock.Main2ndTexAngle,

#if LILTOON_1_3_0_OR_NEWER
                Main2ndTex_ScrollRotate = propertyBlock.Main2ndTex_ScrollRotate,  // v1.3.7
#endif
                Main2ndTex_UVMode = propertyBlock.Main2ndTex_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Main2ndTex_Cull = propertyBlock.Main2ndTex_Cull,  // v1.3.1
#endif
                Main2ndTexDecalAnimation = propertyBlock.Main2ndTexDecalAnimation,
                Main2ndTexDecalSubParam = propertyBlock.Main2ndTexDecalSubParam,
                Main2ndTexIsDecal = propertyBlock.Main2ndTexIsDecal,
                Main2ndTexIsLeftOnly = propertyBlock.Main2ndTexIsLeftOnly,
                Main2ndTexIsRightOnly = propertyBlock.Main2ndTexIsRightOnly,
                Main2ndTexShouldCopy = propertyBlock.Main2ndTexShouldCopy,
                Main2ndTexShouldFlipMirror = propertyBlock.Main2ndTexShouldFlipMirror,
                Main2ndTexShouldFlipCopy = propertyBlock.Main2ndTexShouldFlipCopy,
                Main2ndTexIsMSDF = propertyBlock.Main2ndTexIsMSDF,
                Main2ndBlendMask = propertyBlock.Main2ndBlendMask,
                Main2ndTexBlendMode = propertyBlock.Main2ndTexBlendMode,
#if LILTOON_1_4_0_OR_NEWER
                Main2ndTexAlphaMode = propertyBlock.Main2ndTexAlphaMode,  // v1.4.0
#endif
                Main2ndEnableLighting = propertyBlock.Main2ndEnableLighting,

                Main2ndDissolveMask = propertyBlock.Main2ndDissolveMask,
                Main2ndDissolveNoiseMask = propertyBlock.Main2ndDissolveNoiseMask,
                Main2ndDissolveNoiseMask_ScrollRotate = propertyBlock.Main2ndDissolveNoiseMask_ScrollRotate,
                Main2ndDissolveNoiseStrength = propertyBlock.Main2ndDissolveNoiseStrength,
                Main2ndDissolveColor = propertyBlock.Main2ndDissolveColor,
                Main2ndDissolveParams = propertyBlock.Main2ndDissolveParams,
                Main2ndDissolvePos = propertyBlock.Main2ndDissolvePos,
                Main2ndDistanceFade = propertyBlock.Main2ndDistanceFade,
            };
        }

        /// <summary>
        /// Set the lilToon Main 3rd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMain3rdPropertyValues(Material material, ILilMain3rd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilMain3rdMaterialProxy(material)
            {
                UseMain3rdTex = propertyBlock.UseMain3rdTex,

                Color3rd = propertyBlock.Color3rd,
                Main3rdTex = propertyBlock.Main3rdTex,
                Main3rdTexAngle = propertyBlock.Main3rdTexAngle,

#if LILTOON_1_3_0_OR_NEWER
                Main3rdTex_ScrollRotate = propertyBlock.Main3rdTex_ScrollRotate,  // v1.3.7
#endif
                Main3rdTex_UVMode = propertyBlock.Main3rdTex_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Main3rdTex_Cull = propertyBlock.Main3rdTex_Cull,  // v1.3.1
#endif
                Main3rdTexDecalAnimation = propertyBlock.Main3rdTexDecalAnimation,
                Main3rdTexDecalSubParam = propertyBlock.Main3rdTexDecalSubParam,
                Main3rdTexIsDecal = propertyBlock.Main3rdTexIsDecal,
                Main3rdTexIsLeftOnly = propertyBlock.Main3rdTexIsLeftOnly,
                Main3rdTexIsRightOnly = propertyBlock.Main3rdTexIsRightOnly,
                Main3rdTexShouldCopy = propertyBlock.Main3rdTexShouldCopy,
                Main3rdTexShouldFlipMirror = propertyBlock.Main3rdTexShouldFlipMirror,
                Main3rdTexShouldFlipCopy = propertyBlock.Main3rdTexShouldFlipCopy,
                Main3rdTexIsMSDF = propertyBlock.Main3rdTexIsMSDF,
                Main3rdBlendMask = propertyBlock.Main3rdBlendMask,
                Main3rdTexBlendMode = propertyBlock.Main3rdTexBlendMode,
#if LILTOON_1_4_0_OR_NEWER
                Main3rdTexAlphaMode = propertyBlock.Main3rdTexAlphaMode,  // v1.4.0
#endif
                Main3rdEnableLighting = propertyBlock.Main3rdEnableLighting,

                Main3rdDissolveMask = propertyBlock.Main3rdDissolveMask,
                Main3rdDissolveNoiseMask = propertyBlock.Main3rdDissolveNoiseMask,
                Main3rdDissolveNoiseMask_ScrollRotate = propertyBlock.Main3rdDissolveNoiseMask_ScrollRotate,
                Main3rdDissolveNoiseStrength = propertyBlock.Main3rdDissolveNoiseStrength,
                Main3rdDissolveColor = propertyBlock.Main3rdDissolveColor,
                Main3rdDissolveParams = propertyBlock.Main3rdDissolveParams,
                Main3rdDissolvePos = propertyBlock.Main3rdDissolvePos,
                Main3rdDistanceFade = propertyBlock.Main3rdDistanceFade
            };
        }

        #endregion

        #region Alpha Mask

        /// <summary>
        /// Set the lilToon Alpha Mask property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAlphaMaskPropertyValues(Material material, ILilAlphaMask? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilAlphaMaskMaterialProxy(material)
            {
                AlphaMaskMode = propertyBlock.AlphaMaskMode,
                AlphaMask = propertyBlock.AlphaMask,
                AlphaMaskScale = propertyBlock.AlphaMaskScale,
                AlphaMaskValue = propertyBlock.AlphaMaskValue,
            };
        }

        #endregion

        #region NormalMap

        /// <summary>
        /// Set the lilToon NormalMap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilNormalMapPropertyValues(Material material, ILilNormalMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilNormalMapMaterialProxy(material)
            {
                UseBumpMap = propertyBlock.UseBumpMap,

                BumpMap = propertyBlock.BumpMap,
                BumpScale = propertyBlock.BumpScale,
            };
        }

        /// <summary>
        /// Set the lilToon NormalMap 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilNormalMap2ndPropertyValues(Material material, ILilNormalMap2nd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilNormalMap2ndMaterialProxy(material)
            {
                UseBump2ndMap = propertyBlock.UseBump2ndMap,

                Bump2ndMap = propertyBlock.Bump2ndMap,
#if LILTOON_1_3_0_OR_NEWER
                Bump2ndMap_UVMode = propertyBlock.Bump2ndMap_UVMode,  // v1.3.1
#endif
                Bump2ndScale = propertyBlock.Bump2ndScale,
                Bump2ndScaleMask = propertyBlock.Bump2ndScaleMask,
            };
        }

        #endregion

        #region Anisotropy

        /// <summary>
        /// Set the lilToon Anisotropy property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAnisotropyPropertyValues(Material material, ILilAnisotropy? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilAnisotropyMaterialProxy(material)
            {
                UseAnisotropy = propertyBlock.UseAnisotropy,

                AnisotropyTangentMap = propertyBlock.AnisotropyTangentMap,
                AnisotropyScale = propertyBlock.AnisotropyScale,
                AnisotropyScaleMask = propertyBlock.AnisotropyScaleMask,

                AnisotropyTangentWidth = propertyBlock.AnisotropyTangentWidth,
                AnisotropyBitangentWidth = propertyBlock.AnisotropyBitangentWidth,
                AnisotropyShift = propertyBlock.AnisotropyShift,
                AnisotropyShiftNoiseScale = propertyBlock.AnisotropyShiftNoiseScale,
                AnisotropySpecularStrength = propertyBlock.AnisotropySpecularStrength,

                Anisotropy2ndTangentWidth = propertyBlock.Anisotropy2ndTangentWidth,
                Anisotropy2ndBitangentWidth = propertyBlock.Anisotropy2ndBitangentWidth,
                Anisotropy2ndShift = propertyBlock.Anisotropy2ndShift,
                Anisotropy2ndShiftNoiseScale = propertyBlock.Anisotropy2ndShiftNoiseScale,
                Anisotropy2ndSpecularStrength = propertyBlock.Anisotropy2ndSpecularStrength,

                AnisotropyShiftNoiseMask = propertyBlock.AnisotropyShiftNoiseMask,
                Anisotropy2Reflection = propertyBlock.Anisotropy2Reflection,
                Anisotropy2MatCap = propertyBlock.Anisotropy2MatCap,
                Anisotropy2MatCap2nd = propertyBlock.Anisotropy2MatCap2nd,
            };
        }

        #endregion

        #region Backlight

        /// <summary>
        /// Set the lilToon Backlight property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilBacklightPropertyValues(Material material, ILilBacklight? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilBacklightMaterialProxy(material)
            {
                UseBacklight = propertyBlock.UseBacklight,

                BacklightColor = propertyBlock.BacklightColor,
                BacklightColorTex = propertyBlock.BacklightColorTex,
#if LILTOON_1_3_0_OR_NEWER
                BacklightMainStrength = propertyBlock.BacklightMainStrength,  // v1.3.0
#endif
                BacklightNormalStrength = propertyBlock.BacklightNormalStrength,
                BacklightBorder = propertyBlock.BacklightBorder,
                BacklightBlur = propertyBlock.BacklightBlur,
                BacklightDirectivity = propertyBlock.BacklightDirectivity,
                BacklightViewStrength = propertyBlock.BacklightViewStrength,
                BacklightReceiveShadow = propertyBlock.BacklightReceiveShadow,
                BacklightBackfaceMask = propertyBlock.BacklightBackfaceMask,
            };
        }

        #endregion

        #region Shadow (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite Shadow property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteShadowPropertyValues(Material material, ILilLiteShadow? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteShadowMaterialProxy(material)
            {
                UseShadow = propertyBlock.UseShadow,

                ShadowColorTex = propertyBlock.ShadowColorTex,
                ShadowBorder = propertyBlock.ShadowBorder,
                ShadowBlur = propertyBlock.ShadowBlur,

                Shadow2ndColorTex = propertyBlock.Shadow2ndColorTex,
                Shadow2ndBorder = propertyBlock.Shadow2ndBorder,
                Shadow2ndBlur = propertyBlock.Shadow2ndBlur,

                ShadowBorderColor = propertyBlock.ShadowBorderColor,
                ShadowBorderRange = propertyBlock.ShadowBorderRange,
                ShadowEnvStrength = propertyBlock.ShadowEnvStrength,
            };
        }

        /// <summary>
        /// Set the lilToon Shadow property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilShadowPropertyValues(Material material, ILilShadow? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilShadowMaterialProxy(material)
            {
                UseShadow = propertyBlock.UseShadow,
                //ShadowReceive= propertyBlock.ShadowReceive,
                ShadowStrength = propertyBlock.ShadowStrength,
                ShadowStrengthMask = propertyBlock.ShadowStrengthMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowStrengthMaskLOD = propertyBlock.ShadowStrengthMaskLOD,  // v1.3.0
#endif
                ShadowBorderMask = propertyBlock.ShadowBorderMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowBorderMaskLOD = propertyBlock.ShadowBorderMaskLOD,  // v1.3.0
#endif
                ShadowBlurMask = propertyBlock.ShadowBlurMask,
#if LILTOON_1_3_0_OR_NEWER
                ShadowBlurMaskLOD = propertyBlock.ShadowBlurMaskLOD,  // v1.3.0
#endif
                ShadowAOShift = propertyBlock.ShadowAOShift,
                ShadowAOShift2 = propertyBlock.ShadowAOShift2,
                ShadowPostAO = propertyBlock.ShadowPostAO,

#if LILTOON_1_3_0_OR_NEWER
                ShadowColorType = propertyBlock.ShadowColorType,  // v1.3.5
#endif
                ShadowColor = propertyBlock.ShadowColor,
                ShadowColorTex = propertyBlock.ShadowColorTex,
                ShadowNormalStrength = propertyBlock.ShadowNormalStrength,
                ShadowBorder = propertyBlock.ShadowBorder,
                ShadowBlur = propertyBlock.ShadowBlur,
                ShadowReceive = propertyBlock.ShadowReceive,

                Shadow2ndColor = propertyBlock.Shadow2ndColor,
                Shadow2ndColorTex = propertyBlock.Shadow2ndColorTex,
                Shadow2ndNormalStrength = propertyBlock.Shadow2ndNormalStrength,
                Shadow2ndBorder = propertyBlock.Shadow2ndBorder,
                Shadow2ndBlur = propertyBlock.Shadow2ndBlur,
#if LILTOON_1_3_0_OR_NEWER
                Shadow2ndReceive = propertyBlock.Shadow2ndReceive,  // v1.3.0
#endif

                Shadow3rdColor = propertyBlock.Shadow3rdColor,
                Shadow3rdColorTex = propertyBlock.Shadow3rdColorTex,
                Shadow3rdNormalStrength = propertyBlock.Shadow3rdNormalStrength,
                Shadow3rdBorder = propertyBlock.Shadow3rdBorder,
                Shadow3rdBlur = propertyBlock.Shadow3rdBlur,
#if LILTOON_1_3_0_OR_NEWER
                Shadow3rdReceive = propertyBlock.Shadow3rdReceive,  // v1.3.0
#endif

                ShadowBorderColor = propertyBlock.ShadowBorderColor,
                ShadowBorderRange = propertyBlock.ShadowBorderRange,

                ShadowMainStrength = propertyBlock.ShadowMainStrength,
                ShadowEnvStrength = propertyBlock.ShadowEnvStrength,

#if LILTOON_1_3_0_OR_NEWER
                ShadowMaskType = propertyBlock.ShadowMaskType,      // v1.3.0
                ShadowFlatBorder = propertyBlock.ShadowFlatBorder,  // v1.3.0
                ShadowFlatBlur = propertyBlock.ShadowFlatBlur,      // v1.3.0
#endif
            };
        }

        #endregion

        #region Rim Shade

#if LILTOON_1_6_0_OR_NEWER
        /// <summary>
        /// Set the lilToon Rim Shade property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRimShadePropertyValues(Material material, ILilRimShade? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilRimShadeMaterialProxy(material)
            {
                UseRimShade = propertyBlock.UseRimShade,                        // v1.6.0
                RimShadeColor = propertyBlock.RimShadeColor,                    // v1.6.0
                RimShadeMask = propertyBlock.RimShadeMask,                      // v1.6.0
                RimShadeNormalStrength = propertyBlock.RimShadeNormalStrength,  // v1.6.0
                RimShadeBorder = propertyBlock.RimShadeBorder,                  // v1.6.0
                RimShadeBlur = propertyBlock.RimShadeBlur,                      // v1.6.0
                RimShadeFresnelPower = propertyBlock.RimShadeFresnelPower,      // v1.6.0
            };
        }
#endif
        #endregion

        #region Reflection

        /// <summary>
        /// Set the lilToon Reflection property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilReflectionPropertyValues(Material material, ILilReflection? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilReflectionMaterialProxy(material)
            {
                UseReflection = propertyBlock.UseReflection,

                Smoothness = propertyBlock.Smoothness,
                SmoothnessTex = propertyBlock.SmoothnessTex,

                Metallic = propertyBlock.Metallic,
                MetallicGlossMap = propertyBlock.MetallicGlossMap,

                Reflectance = propertyBlock.Reflectance,
#if LILTOON_1_3_0_OR_NEWER
                GSAAStrength = propertyBlock.GSAAStrength,  // v1.3.0
#endif
                ApplySpecular = propertyBlock.ApplySpecular,
                ApplySpecularFA = propertyBlock.ApplySpecularFA,
                SpecularToon = propertyBlock.SpecularToon,
                SpecularNormalStrength = propertyBlock.SpecularNormalStrength,
                SpecularBorder = propertyBlock.SpecularBorder,
                SpecularBlur = propertyBlock.SpecularBlur,

                ApplyReflection = propertyBlock.ApplyReflection,
                ReflectionNormalStrength = propertyBlock.ReflectionNormalStrength,
                ReflectionColor = propertyBlock.ReflectionColor,
                ReflectionColorTex = propertyBlock.ReflectionColorTex,

                ReflectionApplyTransparency = propertyBlock.ReflectionApplyTransparency,
                ReflectionCubeTex = propertyBlock.ReflectionCubeTex,
                ReflectionCubeColor = propertyBlock.ReflectionCubeColor,
                ReflectionCubeOverride = propertyBlock.ReflectionCubeOverride,
                ReflectionCubeEnableLighting = propertyBlock.ReflectionCubeEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                ReflectionBlendMode = propertyBlock.ReflectionBlendMode,  // v1.3.0
#endif
            };
        }

        #endregion

        #region MatCap (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite MatCap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteMatCapPropertyValues(Material material, ILilLiteMatCap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteMatCapMaterialProxy(material)
            {
                UseMatCap = propertyBlock.UseMatCap,
                MatCapTex = propertyBlock.MatCapTex,
                MatCapBlendUV1 = propertyBlock.MatCapBlendUV1,
                MatCapZRotCancel = propertyBlock.MatCapZRotCancel,
                MatCapPerspective = propertyBlock.MatCapPerspective,
                MatCapVRParallaxStrength = propertyBlock.MatCapVRParallaxStrength,
                MatCapMul = propertyBlock.MatCapMul,  // Lite only
            };
        }

        /// <summary>
        /// Set the lilToon MatCap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMatCapPropertyValues(Material material, ILilMatCap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilMatCapMaterialProxy(material)
            {
                UseMatCap = propertyBlock.UseMatCap,
                MatCapColor = propertyBlock.MatCapColor,
                MatCapTex = propertyBlock.MatCapTex,
#if LILTOON_1_3_0_OR_NEWER
                MatCapMainStrength = propertyBlock.MatCapMainStrength,  // v1.3.0
#endif
                MatCapBlendUV1 = propertyBlock.MatCapBlendUV1,
                MatCapZRotCancel = propertyBlock.MatCapZRotCancel,
                MatCapPerspective = propertyBlock.MatCapPerspective,
                MatCapVRParallaxStrength = propertyBlock.MatCapVRParallaxStrength,

                MatCapBlend = propertyBlock.MatCapBlend,
                MatCapBlendMask = propertyBlock.MatCapBlendMask,

                MatCapEnableLighting = propertyBlock.MatCapEnableLighting,
                MatCapShadowMask = propertyBlock.MatCapShadowMask,
                MatCapBackfaceMask = propertyBlock.MatCapBackfaceMask,
                MatCapLod = propertyBlock.MatCapLod,
                MatCapBlendMode = propertyBlock.MatCapBlendMode,
                MatCapApplyTransparency = propertyBlock.MatCapApplyTransparency,

                MatCapNormalStrength = propertyBlock.MatCapNormalStrength,
                MatCapCustomNormal = propertyBlock.MatCapCustomNormal,
                MatCapBumpMap = propertyBlock.MatCapBumpMap,
                MatCapBumpScale = propertyBlock.MatCapBumpScale,
            };
        }

        /// <summary>
        /// Set the lilToon MatCap 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMatCap2ndPropertyValues(Material material, ILilMatCap2nd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilMatCap2ndMaterialProxy(material)
            {
                UseMatCap2nd = propertyBlock.UseMatCap2nd,
                MatCap2ndColor = propertyBlock.MatCap2ndColor,
                MatCap2ndTex = propertyBlock.MatCap2ndTex,
#if LILTOON_1_3_0_OR_NEWER
                MatCap2ndMainStrength = propertyBlock.MatCap2ndMainStrength,
#endif
                MatCap2ndBlendUV1 = propertyBlock.MatCap2ndBlendUV1,
                MatCap2ndZRotCancel = propertyBlock.MatCap2ndZRotCancel,
                MatCap2ndPerspective = propertyBlock.MatCap2ndPerspective,
                MatCap2ndVRParallaxStrength = propertyBlock.MatCap2ndVRParallaxStrength,

                MatCap2ndBlend = propertyBlock.MatCap2ndBlend,
                MatCap2ndBlendMask = propertyBlock.MatCap2ndBlendMask,

                MatCap2ndEnableLighting = propertyBlock.MatCap2ndEnableLighting,
                MatCap2ndShadowMask = propertyBlock.MatCap2ndShadowMask,
                MatCap2ndBackfaceMask = propertyBlock.MatCap2ndBackfaceMask,
                MatCap2ndLod = propertyBlock.MatCap2ndLod,
                MatCap2ndBlendMode = propertyBlock.MatCap2ndBlendMode,
                MatCap2ndApplyTransparency = propertyBlock.MatCap2ndApplyTransparency,

                MatCap2ndNormalStrength = propertyBlock.MatCap2ndNormalStrength,
                MatCap2ndCustomNormal = propertyBlock.MatCap2ndCustomNormal,
                MatCap2ndBumpMap = propertyBlock.MatCap2ndBumpMap,
                MatCap2ndBumpScale = propertyBlock.MatCap2ndBumpScale,
            };
        }

        #endregion

        #region Rim (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite Rim property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteRimPropertyValues(Material material, ILilLiteRim? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteRimMaterialProxy(material)
            {
                UseRim = propertyBlock.UseRim,
                RimColor = propertyBlock.RimColor,
                RimBorder = propertyBlock.RimBorder,
                RimBlur = propertyBlock.RimBlur,
                RimFresnelPower = propertyBlock.RimFresnelPower,
                RimShadowMask = propertyBlock.RimShadowMask
            };
        }

        /// <summary>
        /// Set the lilToon Rim property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRimPropertyValues(Material material, ILilRim? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilRimMaterialProxy(material)
            {
                UseRim = propertyBlock.UseRim,

                RimColor = propertyBlock.RimColor,
                RimColorTex = propertyBlock.RimColorTex,
#if LILTOON_1_3_0_OR_NEWER
                RimMainStrength = propertyBlock.RimMainStrength,  // v1.3.0
#endif
                RimNormalStrength = propertyBlock.RimNormalStrength,
                RimBorder = propertyBlock.RimBorder,
                RimBlur = propertyBlock.RimBlur,
                RimFresnelPower = propertyBlock.RimFresnelPower,
                RimEnableLighting = propertyBlock.RimEnableLighting,
                RimShadowMask = propertyBlock.RimShadowMask,
                RimBackfaceMask = propertyBlock.RimBackfaceMask,
                RimVRParallaxStrength = propertyBlock.RimVRParallaxStrength,
                RimApplyTransparency = propertyBlock.RimApplyTransparency,
                
                RimDirStrength = propertyBlock.RimDirStrength,
                RimDirRange = propertyBlock.RimDirRange,

                RimIndirRange = propertyBlock.RimIndirRange,
                RimIndirColor = propertyBlock.RimIndirColor,
                RimIndirBorder = propertyBlock.RimIndirBorder,
                RimIndirBlur = propertyBlock.RimIndirBlur,

#if LILTOON_1_3_0_OR_NEWER
                RimBlendMode = propertyBlock.RimBlendMode,  // v1.3.7
#endif
            };
        }

        #endregion

        #region Glitter

        /// <summary>
        /// Set the lilToon Glitter property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilGlitterPropertyValues(Material material, ILilGlitter? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilGlitterMaterialProxy(material)
            {
                UseGlitter = propertyBlock.UseGlitter,

                GlitterUVMode = propertyBlock.GlitterUVMode,
                GlitterColor = propertyBlock.GlitterColor,
                GlitterColorTex = propertyBlock.GlitterColorTex,
#if LILTOON_1_3_0_OR_NEWER
                GlitterColorTex_UVMode = propertyBlock.GlitterColorTex_UVMode,  // v1.3.2
#endif
                GlitterMainStrength = propertyBlock.GlitterMainStrength,
                GlitterNormalStrength = propertyBlock.GlitterNormalStrength,
#if LILTOON_1_3_0_OR_NEWER
                GlitterScaleRandomize = propertyBlock.GlitterScaleRandomize,  // v1.3.0
                GlitterApplyShape = propertyBlock.GlitterApplyShape,          // v1.3.0
                GlitterShapeTex = propertyBlock.GlitterShapeTex,              // v1.3.0
                GlitterAtras = propertyBlock.GlitterAtras,                    // v1.3.0
                GlitterAngleRandomize = propertyBlock.GlitterAngleRandomize,  // v1.3.0
#endif
                GlitterParams1 = propertyBlock.GlitterParams1,
                GlitterParams2 = propertyBlock.GlitterParams2,
                GlitterPostContrast = propertyBlock.GlitterPostContrast,
#if LILTOON_1_3_0_OR_NEWER
                GlitterSensitivity = propertyBlock.GlitterSensitivity,  // v1.3.0
#endif
                GlitterEnableLighting = propertyBlock.GlitterEnableLighting,
                GlitterShadowMask = propertyBlock.GlitterShadowMask,
                GlitterBackfaceMask = propertyBlock.GlitterBackfaceMask,
                GlitterApplyTransparency = propertyBlock.GlitterApplyTransparency,
                GlitterVRParallaxStrength = propertyBlock.GlitterVRParallaxStrength,
            };
        }

        #endregion

        #region Emission (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite Emission property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteEmissionPropertyValues(Material material, ILilLiteEmission? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteEmissionMaterialProxy(material)
            {
                UseEmission = propertyBlock.UseEmission,
                EmissionColor = propertyBlock.EmissionColor,
                EmissionMap = propertyBlock.EmissionMap,
                EmissionMap_ScrollRotate = propertyBlock.EmissionMap_ScrollRotate,
                EmissionMap_UVMode = propertyBlock.EmissionMap_UVMode,
                EmissionBlink = propertyBlock.EmissionBlink,
            };
        }

        /// <summary>
        /// Set the lilToon Emission property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmissionPropertyValues(Material material, ILilEmission? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilEmissionMaterialProxy(material)
            {
                UseEmission = propertyBlock.UseEmission,

                EmissionColor = propertyBlock.EmissionColor,
                EmissionMap = propertyBlock.EmissionMap,
                EmissionMap_ScrollRotate = propertyBlock.EmissionMap_ScrollRotate,
                EmissionMap_UVMode = propertyBlock.EmissionMap_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                EmissionMainStrength = propertyBlock.EmissionMainStrength,  // v1.3.0
#endif
                EmissionBlend = propertyBlock.EmissionBlend,
                EmissionBlendMask = propertyBlock.EmissionBlendMask,
                EmissionBlendMask_ScrollRotate = propertyBlock.EmissionBlendMask_ScrollRotate,
#if LILTOON_1_3_0_OR_NEWER
                EmissionBlendMode = propertyBlock.EmissionBlendMode,  // v1.3.7
#endif
                EmissionBlink = propertyBlock.EmissionBlink,

                EmissionUseGrad = propertyBlock.EmissionUseGrad,
                EmissionGradTex = propertyBlock.EmissionGradTex,
                EmissionGradSpeed = propertyBlock.EmissionGradSpeed,

                EmissionParallaxDepth = propertyBlock.EmissionParallaxDepth,
                EmissionFluorescence = propertyBlock.EmissionFluorescence,
            };
        }

        /// <summary>
        /// Set the lilToon Emission Gradation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmissionGradationPropertyValues(Material material, ILilEmissionGradation? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilEmissionGradationMaterialProxy(material)
            {
                Egci = propertyBlock.Egci,
                Egai = propertyBlock.Egai,

                Egc0 = propertyBlock.Egc0,
                Egc1 = propertyBlock.Egc1,
                Egc2 = propertyBlock.Egc2,
                Egc3 = propertyBlock.Egc3,
                Egc4 = propertyBlock.Egc4,
                Egc5 = propertyBlock.Egc5,
                Egc6 = propertyBlock.Egc6,
                Egc7 = propertyBlock.Egc7,

                Ega0 = propertyBlock.Ega0,
                Ega1 = propertyBlock.Ega1,
                Ega2 = propertyBlock.Ega2,
                Ega3 = propertyBlock.Ega3,
                Ega4 = propertyBlock.Ega4,
                Ega5 = propertyBlock.Ega5,
                Ega6 = propertyBlock.Ega6,
                Ega7 = propertyBlock.Ega7,
            };
        }

        /// <summary>
        /// Set the lilToon Emission 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmission2ndPropertyValues(Material material, ILilEmission2nd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilEmission2ndMaterialProxy(material)
            {
                UseEmission2nd = propertyBlock.UseEmission2nd,

                Emission2ndColor = propertyBlock.Emission2ndColor,
                Emission2ndMap = propertyBlock.Emission2ndMap,
                Emission2ndMap_ScrollRotate = propertyBlock.Emission2ndMap_ScrollRotate,
                Emission2ndMap_UVMode = propertyBlock.Emission2ndMap_UVMode,
#if LILTOON_1_3_0_OR_NEWER
                Emission2ndMainStrength = propertyBlock.Emission2ndMainStrength,  // v1.3.0
#endif
                Emission2ndBlend = propertyBlock.Emission2ndBlend,
                Emission2ndBlendMask = propertyBlock.Emission2ndBlendMask,
                Emission2ndBlendMask_ScrollRotate = propertyBlock.Emission2ndBlendMask_ScrollRotate,
#if LILTOON_1_3_0_OR_NEWER
                Emission2ndBlendMode = propertyBlock.Emission2ndBlendMode,  // v1.3.7
#endif
                Emission2ndBlink = propertyBlock.Emission2ndBlink,

                Emission2ndUseGrad = propertyBlock.Emission2ndUseGrad,
                Emission2ndGradTex = propertyBlock.Emission2ndGradTex,
                Emission2ndGradSpeed = propertyBlock.Emission2ndGradSpeed,

                Emission2ndParallaxDepth = propertyBlock.Emission2ndParallaxDepth,
                Emission2ndFluorescence = propertyBlock.Emission2ndFluorescence,
            };
        }

        /// <summary>
        /// Set the lilToon Emission 2nd Gradation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmission2ndGradationPropertyValues(Material material, ILilEmission2ndGradation? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilEmission2ndGradationMaterialProxy(material)
            {
                E2gci = propertyBlock.E2gci,
                E2gai = propertyBlock.E2gai,

                E2gc0 = propertyBlock.E2gc0,
                E2gc1 = propertyBlock.E2gc1,
                E2gc2 = propertyBlock.E2gc2,
                E2gc3 = propertyBlock.E2gc3,
                E2gc4 = propertyBlock.E2gc4,
                E2gc5 = propertyBlock.E2gc5,
                E2gc6 = propertyBlock.E2gc6,
                E2gc7 = propertyBlock.E2gc7,

                E2ga0 = propertyBlock.E2ga0,
                E2ga1 = propertyBlock.E2ga1,
                E2ga2 = propertyBlock.E2ga2,
                E2ga3 = propertyBlock.E2ga3,
                E2ga4 = propertyBlock.E2ga4,
                E2ga5 = propertyBlock.E2ga5,
                E2ga6 = propertyBlock.E2ga6,
                E2ga7 = propertyBlock.E2ga7,
            };
        }

        #endregion

        #region Parallax

        /// <summary>
        /// Set the lilToon Parallax property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilParallaxPropertyValues(Material material, ILilParallax? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilParallaxMaterialProxy(material)
            {
                UseParallax = propertyBlock.UseParallax,
#if LILTOON_1_3_0_OR_NEWER
                UsePOM = propertyBlock.UsePOM,  // v1.3.0
#endif
                ParallaxMap = propertyBlock.ParallaxMap,
                Parallax = propertyBlock.Parallax,
                ParallaxOffset = propertyBlock.ParallaxOffset,
            };
        }

        #endregion

        #region Distance Fade

        /// <summary>
        /// Set the lilToon Distance Fade property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilDistanceFadePropertyValues(Material material, ILilDistanceFade? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilDistanceFadeMaterialProxy(material)
            {
                DistanceFade = propertyBlock.DistanceFade,
                DistanceFadeColor = propertyBlock.DistanceFadeColor,
#if LILTOON_1_4_0_OR_NEWER
                DistanceFadeMode = propertyBlock.DistanceFadeMode,                        // v1.4.0
                DistanceFadeRimColor = propertyBlock.DistanceFadeRimColor,                // v1.4.0
                DistanceFadeRimFresnelPower = propertyBlock.DistanceFadeRimFresnelPower,  // v1.4.0
#endif
            };
        }

        #endregion

        #region Audio Link

        /// <summary>
        /// Set the lilToon Audio Link property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAudioLinkPropertyValues(Material material, ILilAudioLink? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilAudioLinkMaterialProxy(material)
            {
                UseAudioLink = propertyBlock.UseAudioLink,

                AudioLinkDefaultValue = propertyBlock.AudioLinkDefaultValue,
                AudioLinkUVMode = propertyBlock.AudioLinkUVMode,
                AudioLinkUVParams = propertyBlock.AudioLinkUVParams,
                AudioLinkStart = propertyBlock.AudioLinkStart,
                AudioLinkMask = propertyBlock.AudioLinkMask,
#if LILTOON_1_4_0_OR_NEWER
                AudioLinkMask_ScrollRotate = propertyBlock.AudioLinkMask_ScrollRotate,  // v1.4.0
                AudioLinkMask_UVMode = propertyBlock.AudioLinkMask_UVMode,  // v1.4.0
#endif

                AudioLink2Main2nd = propertyBlock.AudioLink2Main2nd,
                AudioLink2Main3rd = propertyBlock.AudioLink2Main3rd,
                AudioLink2Emission = propertyBlock.AudioLink2Emission,
                AudioLink2EmissionGrad = propertyBlock.AudioLink2EmissionGrad,
                AudioLink2Emission2nd = propertyBlock.AudioLink2Emission2nd,
                AudioLink2Emission2ndGrad = propertyBlock.AudioLink2Emission2ndGrad,

                AudioLink2Vertex = propertyBlock.AudioLink2Vertex,
                AudioLinkVertexUVMode = propertyBlock.AudioLinkVertexUVMode,
                AudioLinkVertexUVParams = propertyBlock.AudioLinkVertexUVParams,
                AudioLinkVertexStart = propertyBlock.AudioLinkVertexStart,
                AudioLinkVertexStrength = propertyBlock.AudioLinkVertexStrength,

                AudioLinkAsLocal = propertyBlock.AudioLinkAsLocal,
                AudioLinkLocalMap = propertyBlock.AudioLinkLocalMap,
                AudioLinkLocalMapParams = propertyBlock.AudioLinkLocalMapParams,
            };
        }

        #endregion

        #region Dissolve

        /// <summary>
        /// Set the lilToon Dissolve property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilDissolvePropertyValues(Material material, ILilDissolve? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilDissolveMaterialProxy(material)
            {
                DissolveMask = propertyBlock.DissolveMask,
                DissolveNoiseMask = propertyBlock.DissolveNoiseMask,
                DissolveNoiseMask_ScrollRotate = propertyBlock.DissolveNoiseMask_ScrollRotate,
                DissolveNoiseStrength = propertyBlock.DissolveNoiseStrength,
                DissolveColor = propertyBlock.DissolveColor,
                DissolveParams = propertyBlock.DissolveParams,
                DissolvePos = propertyBlock.DissolvePos,
            };
        }

        #endregion

        #region ID Mask

#if LILTOON_1_4_0_OR_NEWER
        /// <summary>
        /// Set the lilToon ID Mask property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilIDMaskPropertyValues(Material material, ILilIDMask? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilIDMaskMaterialProxy(material)
            {
#if LILTOON_1_5_0_OR_NEWER
                IDMaskCompile = propertyBlock.IDMaskCompile,  // v1.5.1
#endif
                IDMaskFrom = propertyBlock.IDMaskFrom,  // v1.4.0

                IDMask1 = propertyBlock.IDMask1,  // v1.4.0
                IDMask2 = propertyBlock.IDMask2,  // v1.4.0
                IDMask3 = propertyBlock.IDMask3,  // v1.4.0
                IDMask4 = propertyBlock.IDMask4,  // v1.4.0
                IDMask5 = propertyBlock.IDMask5,  // v1.4.0
                IDMask6 = propertyBlock.IDMask6,  // v1.4.0
                IDMask7 = propertyBlock.IDMask7,  // v1.4.0
                IDMask8 = propertyBlock.IDMask8,  // v1.4.0

#if LILTOON_1_5_0_OR_NEWER
                IDMaskIsBitmap = propertyBlock.IDMaskIsBitmap,  // v1.5.0
#endif
                IDMaskIndex1 = propertyBlock.IDMaskIndex1,  // v1.4.0
                IDMaskIndex2 = propertyBlock.IDMaskIndex2,  // v1.4.0
                IDMaskIndex3 = propertyBlock.IDMaskIndex3,  // v1.4.0
                IDMaskIndex4 = propertyBlock.IDMaskIndex4,  // v1.4.0
                IDMaskIndex5 = propertyBlock.IDMaskIndex5,  // v1.4.0
                IDMaskIndex6 = propertyBlock.IDMaskIndex6,  // v1.4.0
                IDMaskIndex7 = propertyBlock.IDMaskIndex7,  // v1.4.0
                IDMaskIndex8 = propertyBlock.IDMaskIndex8,  // v1.4.0

#if LILTOON_1_5_0_OR_NEWER
                IDMaskControlsDissolve = propertyBlock.IDMaskControlsDissolve,  // v1.5.0

                IDMaskPrior1 = propertyBlock.IDMaskPrior1,  // v1.5.0
                IDMaskPrior2 = propertyBlock.IDMaskPrior2,  // v1.5.0
                IDMaskPrior3 = propertyBlock.IDMaskPrior3,  // v1.5.0
                IDMaskPrior4 = propertyBlock.IDMaskPrior4,  // v1.5.0
                IDMaskPrior5 = propertyBlock.IDMaskPrior5,  // v1.5.0
                IDMaskPrior6 = propertyBlock.IDMaskPrior6,  // v1.5.0
                IDMaskPrior7 = propertyBlock.IDMaskPrior7,  // v1.5.0
                IDMaskPrior8 = propertyBlock.IDMaskPrior8,  // v1.5.0
#endif
            };
        }
#endif
        #endregion

        #region UDIM Discard

#if LILTOON_1_7_0_OR_NEWER
        /// <summary>
        /// Set the lilToon UDIM Discard property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilUdimDiscardPropertyValues(Material material, ILilUdimDiscard? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilUdimDiscardMaterialProxy(material)
            {
                UDIMDiscardCompile = propertyBlock.UDIMDiscardCompile,  // v1.7.0
                UDIMDiscardUV = propertyBlock.UDIMDiscardUV,            // v1.7.0
                UDIMDiscardMode = propertyBlock.UDIMDiscardMode,        // v1.7.0
                UDIMDiscardRow3_3 = propertyBlock.UDIMDiscardRow3_3,    // v1.7.0
                UDIMDiscardRow3_2 = propertyBlock.UDIMDiscardRow3_2,    // v1.7.0
                UDIMDiscardRow3_1 = propertyBlock.UDIMDiscardRow3_1,    // v1.7.0
                UDIMDiscardRow3_0 = propertyBlock.UDIMDiscardRow3_0,    // v1.7.0
                UDIMDiscardRow2_3 = propertyBlock.UDIMDiscardRow2_3,    // v1.7.0
                UDIMDiscardRow2_2 = propertyBlock.UDIMDiscardRow2_2,    // v1.7.0
                UDIMDiscardRow2_1 = propertyBlock.UDIMDiscardRow2_1,    // v1.7.0
                UDIMDiscardRow2_0 = propertyBlock.UDIMDiscardRow2_0,    // v1.7.0
                UDIMDiscardRow1_3 = propertyBlock.UDIMDiscardRow1_3,    // v1.7.0
                UDIMDiscardRow1_2 = propertyBlock.UDIMDiscardRow1_2,    // v1.7.0
                UDIMDiscardRow1_1 = propertyBlock.UDIMDiscardRow1_1,    // v1.7.0
                UDIMDiscardRow1_0 = propertyBlock.UDIMDiscardRow1_0,    // v1.7.0
                UDIMDiscardRow0_3 = propertyBlock.UDIMDiscardRow0_3,    // v1.7.0
                UDIMDiscardRow0_2 = propertyBlock.UDIMDiscardRow0_2,    // v1.7.0
                UDIMDiscardRow0_1 = propertyBlock.UDIMDiscardRow0_1,    // v1.7.0
                UDIMDiscardRow0_0 = propertyBlock.UDIMDiscardRow0_0,    // v1.7.0
            };
        }
#endif
        #endregion

        #region Encryption

        /// <summary>
        /// Set the lilToon Encryption property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEncryptionPropertyValues(Material material, ILilEncryption? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilEncryptionMaterialProxy(material)
            {
                IgnoreEncryption = propertyBlock.IgnoreEncryption,
                Keys = propertyBlock.Keys,
#if LILTOON_1_3_0_OR_NEWER
                BitKey0 = propertyBlock.BitKey0,  // v1.3.7
                BitKey1 = propertyBlock.BitKey1,  // v1.3.7
                BitKey2 = propertyBlock.BitKey2,  // v1.3.7
                BitKey3 = propertyBlock.BitKey3,  // v1.3.7
                BitKey4 = propertyBlock.BitKey4,  // v1.3.7
                BitKey5 = propertyBlock.BitKey5,  // v1.3.7
                BitKey6 = propertyBlock.BitKey6,  // v1.3.7
                BitKey7 = propertyBlock.BitKey7,  // v1.3.7
                BitKey8 = propertyBlock.BitKey8,  // v1.3.7
                BitKey9 = propertyBlock.BitKey9,  // v1.3.7
                BitKey10 = propertyBlock.BitKey10,  // v1.3.7
                BitKey11 = propertyBlock.BitKey11,  // v1.3.7
                BitKey12 = propertyBlock.BitKey12,  // v1.3.7
                BitKey13 = propertyBlock.BitKey13,  // v1.3.7
                BitKey14 = propertyBlock.BitKey14,  // v1.3.7
                BitKey15 = propertyBlock.BitKey15,  // v1.3.7
                BitKey16 = propertyBlock.BitKey16,  // v1.3.7
                BitKey17 = propertyBlock.BitKey17,  // v1.3.7
                BitKey18 = propertyBlock.BitKey18,  // v1.3.7
                BitKey19 = propertyBlock.BitKey19,  // v1.3.7
                BitKey20 = propertyBlock.BitKey20,  // v1.3.7
                BitKey21 = propertyBlock.BitKey21,  // v1.3.7
                BitKey22 = propertyBlock.BitKey22,  // v1.3.7
                BitKey23 = propertyBlock.BitKey23,  // v1.3.7
                BitKey24 = propertyBlock.BitKey24,  // v1.3.7
                BitKey25 = propertyBlock.BitKey25,  // v1.3.7
                BitKey26 = propertyBlock.BitKey26,  // v1.3.7
                BitKey27 = propertyBlock.BitKey27,  // v1.3.7
                BitKey28 = propertyBlock.BitKey28,  // v1.3.7
                BitKey29 = propertyBlock.BitKey29,  // v1.3.7
                BitKey30 = propertyBlock.BitKey30,  // v1.3.7
                BitKey31 = propertyBlock.BitKey31,  // v1.3.7
#endif
            };
        }

        #endregion

        #region Refraction

        /// <summary>
        /// Set the lilToon Refraction property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        /// <param name="isRefraction"></param>
        /// <param name="isGem"></param>
        public virtual void SetLilRefractionPropertyValues(Material material, ILilRefraction? propertyBlock, bool isRefraction = true, bool isGem = false)
        {
            if (propertyBlock is null)
            {
                return;
            }

            if (isRefraction || isGem)
            {
                _ = new LilRefractionMaterialProxy(material)
                {
                    RefractionStrength = propertyBlock.RefractionStrength,
                    RefractionFresnelPower = propertyBlock.RefractionFresnelPower,
                };
            }

            if (isRefraction)
            {
                _ = new LilRefractionMaterialProxy(material)
                {
                    RefractionStrength = propertyBlock.RefractionStrength,
                    RefractionFresnelPower = propertyBlock.RefractionFresnelPower,
                    RefractionColorFromMain = propertyBlock.RefractionColorFromMain,
                    RefractionColor = propertyBlock.RefractionColor,
                };
            }
        }

        #endregion

        #region Fur

        /// <summary>
        /// Set the lilToon Fur property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurPropertyValues(Material material, ILilFur? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFurMaterialProxy(material)
            {
                FurNoiseMask = propertyBlock.FurNoiseMask,
                FurMask = propertyBlock.FurMask,
                FurLengthMask = propertyBlock.FurLengthMask,
                FurVectorTex = propertyBlock.FurVectorTex,
                FurVectorScale = propertyBlock.FurVectorScale,
                FurVector = propertyBlock.FurVector,
                VertexColor2FurVector = propertyBlock.VertexColor2FurVector,
                FurGravity = propertyBlock.FurGravity,
                FurRandomize = propertyBlock.FurRandomize,
                FurAO = propertyBlock.FurAO,
#if LILTOON_1_3_0_OR_NEWER
                FurMeshType = propertyBlock.FurMeshType,  // v1.3.0
#endif
                FurLayerNum = propertyBlock.FurLayerNum,
                FurRootOffset = propertyBlock.FurRootOffset,
                FurCutoutLength = propertyBlock.FurCutoutLength,
                FurTouchStrength = propertyBlock.FurTouchStrength,
            };
        }

        #endregion

        #region Fur (Rendering)

        /// <summary>
        /// Set the lilToon Fur Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingPropertyValues(Material material, ILilFurRendering? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFurRenderingMaterialProxy(material)
            {
                FurCull = propertyBlock.FurCull,

                FurZClip = propertyBlock.FurZClip,
                FurZWrite = propertyBlock.FurZWrite,
                FurZTest = propertyBlock.FurZTest,

                FurOffsetFactor = propertyBlock.FurOffsetFactor,
                FurOffsetUnits = propertyBlock.FurOffsetUnits,

                FurColorMask = propertyBlock.FurColorMask,
                FurAlphaToMask = propertyBlock.FurAlphaToMask,
            };
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingForwardPropertyValues(Material material, ILilFurRenderingForward? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFurRenderingForwardMaterialProxy(material)
            {
                FurSrcBlend = propertyBlock.FurSrcBlend,
                FurDstBlend = propertyBlock.FurDstBlend,
                FurSrcBlendAlpha = propertyBlock.FurSrcBlendAlpha,
                FurDstBlendAlpha = propertyBlock.FurDstBlendAlpha,
                FurBlendOp = propertyBlock.FurBlendOp,
                FurBlendOpAlpha = propertyBlock.FurBlendOpAlpha,
            };
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingForwardAddPropertyValues(Material material, ILilFurRenderingForwardAdd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFurRenderingForwardAddMaterialProxy(material)
            {
                FurSrcBlendFA = propertyBlock.FurSrcBlendFA,
                FurDstBlendFA = propertyBlock.FurDstBlendFA,
                FurSrcBlendAlphaFA = propertyBlock.FurSrcBlendAlphaFA,
                FurDstBlendAlphaFA = propertyBlock.FurDstBlendAlphaFA,
                FurBlendOpFA = propertyBlock.FurBlendOpFA,
                FurBlendOpAlphaFA = propertyBlock.FurBlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingStencilPropertyValues(Material material, ILilFurRenderingStencil? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilFurRenderingStencilMaterialProxy(material)
            {
                FurStencilRef = propertyBlock.FurStencilRef,
                FurStencilReadMask = propertyBlock.FurStencilReadMask,
                FurStencilWriteMask = propertyBlock.FurStencilWriteMask,
                FurStencilComp = propertyBlock.FurStencilComp,
                FurStencilPass = propertyBlock.FurStencilPass,
                FurStencilFail = propertyBlock.FurStencilFail,
                FurStencilZFail = propertyBlock.FurStencilZFail,
            };
        }

        #endregion

        #region Gem

        /// <summary>
        /// Set the lilToon Gem property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilGemPropertyValues(Material material, ILilGem? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilGemMaterialProxy(material)
            {
                GemChromaticAberration = propertyBlock.GemChromaticAberration,
                GemEnvContrast = propertyBlock.GemEnvContrast,
                GemEnvColor = propertyBlock.GemEnvColor,
                GemParticleLoop = propertyBlock.GemParticleLoop,
                GemParticleColor = propertyBlock.GemParticleColor,
                GemVRParallaxStrength = propertyBlock.GemVRParallaxStrength,
            };
        }

        #endregion

        #region Tessellation

        /// <summary>
        /// Set the lilToon Tessellation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilTessellationPropertyValues(Material material, ILilTessellation? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilTessellationMaterialProxy(material)
            {
                TessEdge = propertyBlock.TessEdge,
                TessStrength = propertyBlock.TessStrength,
                TessShrink = propertyBlock.TessShrink,
                TessFactorMax = propertyBlock.TessFactorMax,
            };
        }

        #endregion

        #region Outline (Normal, Lite)

        /// <summary>
        /// Set the lilToon Outline property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlinePropertyValues(Material material, ILilOutline? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            var materialProxy = new LilOutlineMaterialProxy(material)
            {
                OutlineColor = propertyBlock.OutlineColor,
                OutlineTex = propertyBlock.OutlineTex,
                OutlineTex_ScrollRotate = propertyBlock.OutlineTex_ScrollRotate,
                OutlineTexHSVG = propertyBlock.OutlineTexHSVG,
#if LILTOON_1_3_0_OR_NEWER
                OutlineLitColor = propertyBlock.OutlineLitColor,        // v1.3.0
                OutlineLitApplyTex = propertyBlock.OutlineLitApplyTex,  // v1.3.0
                OutlineLitScale = propertyBlock.OutlineLitScale,        // v1.3.0
                OutlineLitOffset = propertyBlock.OutlineLitOffset,      // v1.3.0
                OutlineLitShadowReceive = propertyBlock.OutlineLitShadowReceive,  // v1.3.1
#endif
                OutlineWidth = propertyBlock.OutlineWidth,
                OutlineWidthMask = propertyBlock.OutlineWidthMask,
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = propertyBlock.OutlineFixWidth,  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = propertyBlock.OutlineVertexR2Width,
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = propertyBlock.OutlineDeleteMesh,  // v1.3.0
#endif
                OutlineVectorTex = propertyBlock.OutlineVectorTex,
#if LILTOON_1_3_0_OR_NEWER
                OutlineVectorUVMode = propertyBlock.OutlineVectorUVMode,  // v1.3.0
#endif
                OutlineVectorScale = propertyBlock.OutlineVectorScale,
                OutlineEnableLighting = propertyBlock.OutlineEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = propertyBlock.OutlineZBias,  // v1.3.0
                OutlineDisableInVR = propertyBlock.OutlineDisableInVR,  // v1.3.0
#endif
            };

#if LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0, 1, 1);  // v1.2.12
#endif
        }

        /// <summary>
        /// Set the lilToon Lite Outline property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteOutlinePropertyValues(Material material, ILilLiteOutline? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilLiteOutlineMaterialProxy(material)
            {
                OutlineColor = propertyBlock.OutlineColor,
                OutlineTex = propertyBlock.OutlineTex,
                OutlineTex_ScrollRotate = propertyBlock.OutlineTex_ScrollRotate,
                OutlineWidth = propertyBlock.OutlineWidth,
                OutlineWidthMask = propertyBlock.OutlineWidthMask,
#if LILTOON_1_3_0_OR_NEWER
                OutlineFixWidth = propertyBlock.OutlineFixWidth,  // v1.3.0 changed int to float
#endif
                OutlineVertexR2Width = propertyBlock.OutlineVertexR2Width,
#if LILTOON_1_3_0_OR_NEWER
                OutlineDeleteMesh = propertyBlock.OutlineDeleteMesh,  // v1.3.0
#endif
                OutlineEnableLighting = propertyBlock.OutlineEnableLighting,
#if LILTOON_1_3_0_OR_NEWER
                OutlineZBias = propertyBlock.OutlineZBias,  // v1.3.0
#endif
            };

#if LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0, 1, 1);  // v1.2.12
#endif
        }

        #endregion

        #region Outline (Rendering)

        /// <summary>
        /// Set the lilToon Outline Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingPropertyValues(Material material, ILilOutlineRendering? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilOutlineRenderingMaterialProxy(material)
            {
                OutlineCull = propertyBlock.OutlineCull,

                OutlineZClip = propertyBlock.OutlineZClip,
                OutlineZWrite = propertyBlock.OutlineZWrite,
                OutlineZTest = propertyBlock.OutlineZTest,

                OutlineOffsetFactor = propertyBlock.OutlineOffsetFactor,
                OutlineOffsetUnits = propertyBlock.OutlineOffsetUnits,

                OutlineColorMask = propertyBlock.OutlineColorMask,
                OutlineAlphaToMask = propertyBlock.OutlineAlphaToMask,
            };
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingForwardPropertyValues(Material material, ILilOutlineRenderingForward? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilOutlineRenderingForwardMaterialProxy(material)
            {
                OutlineSrcBlend = propertyBlock.OutlineSrcBlend,
                OutlineDstBlend = propertyBlock.OutlineDstBlend,
                OutlineSrcBlendAlpha = propertyBlock.OutlineSrcBlendAlpha,
                OutlineDstBlendAlpha = propertyBlock.OutlineDstBlendAlpha,
                OutlineBlendOp = propertyBlock.OutlineBlendOp,
                OutlineBlendOpAlpha = propertyBlock.OutlineBlendOpAlpha,
            };
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingForwardAddPropertyValues(Material material, ILilOutlineRenderingForwardAdd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilOutlineRenderingForwardAddMaterialProxy(material)
            {
                OutlineSrcBlendFA = propertyBlock.OutlineSrcBlendFA,
                OutlineDstBlendFA = propertyBlock.OutlineDstBlendFA,
                OutlineSrcBlendAlphaFA = propertyBlock.OutlineSrcBlendAlphaFA,
                OutlineDstBlendAlphaFA = propertyBlock.OutlineDstBlendAlphaFA,
                OutlineBlendOpFA = propertyBlock.OutlineBlendOpFA,
                OutlineBlendOpAlphaFA = propertyBlock.OutlineBlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingStencilPropertyValues(Material material, ILilOutlineRenderingStencil? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilOutlineRenderingStencilMaterialProxy(material)
            {
                OutlineStencilRef = propertyBlock.OutlineStencilRef,
                OutlineStencilReadMask = propertyBlock.OutlineStencilReadMask,
                OutlineStencilWriteMask = propertyBlock.OutlineStencilWriteMask,
                OutlineStencilComp = propertyBlock.OutlineStencilComp,
                OutlineStencilPass = propertyBlock.OutlineStencilPass,
                OutlineStencilFail = propertyBlock.OutlineStencilFail,
                OutlineStencilZFail = propertyBlock.OutlineStencilZFail,
            };
        }

        #endregion

        #region Multi

        /// <summary>
        /// Set the lilToon Multi Keywords to the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
#if LILTOON_1_3_0_OR_NEWER
        /// <param name="propertyBlock">A lilToon Normal propertyBlock.</param>
        public virtual void SetLilMultiKeywords(Material material, LilToonNormalPropertyEntity? propertyBlock)
#elif LILTOON_1_2_12_OR_OLDER
        /// <param name="propertyBlock">A lilToon Multi propertyBlock.</param>
        public virtual void SetLilMultiKeywords(Material material, LilToonMultiPropertyEntity propertyBlock)
#endif
        {
            if (propertyBlock is null)
            {
                return;
            }

            bool isGem = propertyBlock.Multi != null && propertyBlock.Multi.TransparentMode == LilRenderingMode.Gem;
            bool isOutline = propertyBlock.Multi != null && propertyBlock.Multi.UseOutline;

            material.SetKeyword(Keyword.UnityUIAlphaclip, propertyBlock.Multi != null && propertyBlock.Multi.TransparentMode == LilRenderingMode.Cutout);
            material.SetKeyword(Keyword.UnityUIClipRect, propertyBlock.Multi != null &&
                (
                    (propertyBlock.Multi.TransparentMode == LilRenderingMode.Transparent) ||
                    (propertyBlock.Multi.TransparentMode == LilRenderingMode.RefractionBlur)
                )
            );

            if (isGem)
            {
                material.SetKeyword(Keyword.RequireUV2, false);
                material.SetKeyword(Keyword.FadingOn, false);
            }
            else
            {
                material.SetKeyword(Keyword.RequireUV2, propertyBlock.Shadow != null && propertyBlock.Shadow.UseShadow);
                material.SetKeyword(Keyword.FadingOn, propertyBlock.DistanceFade != null && propertyBlock.DistanceFade.DistanceFade.z != 0.0f);
            }

            material.SetKeyword(Keyword.NormalMap, propertyBlock.NormalMap != null && propertyBlock.NormalMap.UseBumpMap);
            material.SetKeyword(Keyword.EffectBump, propertyBlock.NormalMap2nd != null && propertyBlock.NormalMap2nd.UseBump2ndMap);
            material.SetKeyword(Keyword.Emission, propertyBlock.Emission != null && propertyBlock.Emission.UseEmission);
            material.SetKeyword(Keyword.SourceGbuffer, propertyBlock.Anisotropy != null && propertyBlock.Anisotropy.UseAnisotropy);
            material.SetKeyword(Keyword.SmoothnessTextureAlbedoChannelA, propertyBlock.MatCap != null && propertyBlock.MatCap.UseMatCap);
            material.SetKeyword(Keyword.SpecularHighlightsOff, propertyBlock.MatCap2nd != null && propertyBlock.MatCap2nd.UseMatCap2nd);
            material.SetKeyword(Keyword.MetallicGlossMap, propertyBlock.Rim != null && propertyBlock.Rim.UseRim);
            material.SetKeyword(Keyword.SpecGlossmap, propertyBlock.Glitter != null && propertyBlock.Glitter.UseGlitter);
            material.SetKeyword(Keyword.Mapping6FramesLayout, propertyBlock.AudioLink != null && propertyBlock.AudioLink.UseAudioLink);

            // Sundisk
            material.SetKeyword(Keyword.SundiskSimple,
                (propertyBlock.Emission != null && propertyBlock.Emission.UseEmission && propertyBlock.Emission.EmissionBlendMask != null) ||
                (propertyBlock.Emission2nd != null && propertyBlock.Emission2nd.UseEmission2nd && propertyBlock.Emission2nd.Emission2ndBlendMask != null)
            );
            material.SetKeyword(Keyword.SundiskHighQuality, propertyBlock.AudioLink != null && propertyBlock.AudioLink.UseAudioLink && propertyBlock.AudioLink.AudioLinkAsLocal);

            // GEOM
            material.SetKeyword(Keyword.GeomTypeBranch, propertyBlock.Emission2nd != null && propertyBlock.Emission2nd.UseEmission2nd);
            material.SetKeyword(Keyword.GeomTypeBranchDetail, propertyBlock.Dissolve != null && propertyBlock.Dissolve.DissolveParams.x != 0.0f);
            material.SetKeyword(Keyword.GeomTypeMesh,
                (propertyBlock.MatCap != null && propertyBlock.MatCap.UseMatCap && propertyBlock.MatCap.MatCapCustomNormal) ||
                (propertyBlock.MatCap2nd != null && propertyBlock.MatCap2nd.UseMatCap2nd && propertyBlock.MatCap2nd.MatCap2ndCustomNormal)
            );
            material.SetKeyword(Keyword.GeomTypeLeaf, propertyBlock.Rim != null && propertyBlock.Rim.UseRim && propertyBlock.Rim.RimDirStrength != 0.0f);

            if (isGem)
            {
                material.SetKeyword(Keyword.EffectHueVariation, false);
                material.SetKeyword(Keyword.ColorAddSubDiffOn, false);
                material.SetKeyword(Keyword.ColorColorOn, false);
                material.SetKeyword(Keyword.SundiskNone, false);
                material.SetKeyword(Keyword.GeomTypeFrond, false);
                material.SetKeyword(Keyword.ColorOverlayOn, false);
                material.SetKeyword(Keyword.AntiFlicker, false);
                material.SetKeyword(Keyword.ParallaxMap, false);
                material.SetKeyword(Keyword.PixelSnapOn, false);
                material.SetKeyword(Keyword.GlossyReflectionsOff, false);
            }
            else
            {
                material.SetKeyword(Keyword.EffectHueVariation,
                    propertyBlock.Main != null &&
                    ((propertyBlock.Main.MainTexHSVG != DefaultHSVG) ||
                     (propertyBlock.Main.MainGradationStrength != 0.0f))
                );
                material.SetKeyword(Keyword.ColorAddSubDiffOn, propertyBlock.Main2nd != null && propertyBlock.Main2nd.UseMain2ndTex);
                material.SetKeyword(Keyword.ColorColorOn, propertyBlock.Main3rd != null && propertyBlock.Main3rd.UseMain3rdTex);
                material.SetKeyword(Keyword.SundiskNone,
                    (propertyBlock.Main2nd != null && propertyBlock.Main2nd.UseMain2ndTex && propertyBlock.Main2nd.Main2ndTexDecalAnimation != DefaultDecalAnimation) ||
                    (propertyBlock.Main3rd != null && propertyBlock.Main3rd.UseMain3rdTex && propertyBlock.Main3rd.Main3rdTexDecalAnimation != DefaultDecalAnimation)
                );
                material.SetKeyword(Keyword.GeomTypeFrond,
                    (propertyBlock.Main2nd != null && propertyBlock.Main2nd.UseMain2ndTex && propertyBlock.Main2nd.Main2ndDissolveParams.x != 0.0f) ||
                    (propertyBlock.Main3rd != null && propertyBlock.Main3rd.UseMain3rdTex && propertyBlock.Main3rd.Main3rdDissolveParams.x != 0.0f)
                );

                material.SetKeyword(Keyword.ColorOverlayOn,
                    (propertyBlock.Multi != null && propertyBlock.Multi.TransparentMode != LilRenderingMode.Opaque) &&
                    (propertyBlock.AlphaMask != null && propertyBlock.AlphaMask.AlphaMaskMode != 0.0f)
                );
                material.SetKeyword(Keyword.AntiFlicker, propertyBlock.Backlight != null && propertyBlock.Backlight.UseBacklight);
                material.SetKeyword(Keyword.ParallaxMap, propertyBlock.Parallax != null && propertyBlock.Parallax.UseParallax);

#if LILTOON_1_3_0_OR_NEWER
                material.SetKeyword(Keyword.PixelSnapOn,
                    (propertyBlock.Parallax != null && propertyBlock.Parallax.UseParallax) &&
                    (propertyBlock.Parallax != null && propertyBlock.Parallax.UsePOM)  // v1.3.0
                );
#elif LILTOON_1_2_12_OR_OLDER
                material.SetKeyword(Keyword.PixelSnapOn,
                    (propertyBlock.Parallax != null && propertyBlock.Parallax.UseParallax) &&
                    (propertyBlock.Multi != null && propertyBlock.Multi.UsePOM)  // v1.2.12
                );
#endif
                material.SetKeyword(Keyword.GlossyReflectionsOff, propertyBlock.Reflection != null && propertyBlock.Reflection.UseReflection);
            }

            material.SetKeyword(Keyword.Etc1ExternalAlpha, false);

            if (isOutline)
            {
                material.SetKeyword(Keyword.DetailMulx2, propertyBlock.Outline != null && propertyBlock.Outline.OutlineTexHSVG != DefaultHSVG);
            }
            else
            {
                material.SetKeyword(Keyword.DetailMulx2, false);
            }

            // Remove old keywords
            material.SetKeyword(Keyword.BillboardFaceCameraPos, false);
        }

        /// <summary>
        /// Set the lilToon Multi Passes to the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
#if LILTOON_1_3_0_OR_NEWER
        /// <param name="propertyBlock">A lilToon Normal propertyBlock.</param>
        public virtual void SetLilMultiPasses(Material material, LilToonNormalPropertyEntity? propertyBlock)
#elif LILTOON_1_2_12_OR_OLDER
        /// <param name="propertyBlock">A lilToon Multi propertyBlock.</param>
        public virtual void SetLilMultiPasses(Material material, LilToonMultiPropertyEntity? propertyBlock)
#endif
        {
            if (propertyBlock is null)
            {
                return;
            }

            bool enabled = propertyBlock.Multi != null && propertyBlock.Multi.AsOverlay == false;

            material.SetShaderPassEnabled(PassName.ShadowCaster, enabled);
            material.SetShaderPassEnabled(PassName.DepthOnly, enabled);
            material.SetShaderPassEnabled(PassName.DepthNormals, enabled);
            material.SetShaderPassEnabled(PassName.DepthForwardOnly, enabled);
            material.SetShaderPassEnabled(PassName.MotionVectors, enabled);

            material.SetShaderPassEnabled(PassName.SrpDefaultUnlit, true);
        }

        /// <summary>
        /// Set the lilToon Multi property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMultiPropertyValues(Material material, ILilMulti? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            var materialProxy = new LilMultiMaterialProxy(material)
            {
                UseOutline = propertyBlock.UseOutline,
                TransparentMode = propertyBlock.TransparentMode,
#if LILTOON_1_3_0_OR_NEWER
                // v1.3.0 deleted
#elif LILTOON_1_2_12_OR_OLDER
                UsePOM = propertyBlock.UsePOM,
#endif
                UseClippingCanceller = propertyBlock.UseClippingCanceller,
                AsOverlay = propertyBlock.AsOverlay,
            };

        }

        #endregion

        #region Rendering

        /// <summary>
        /// Set the lilToon Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFakeShadow"></param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingPropertyValues(Material material, ILilRendering? propertyBlock, bool isFakeShadow = false)
        {
            if (propertyBlock is null)
            {
                return;
            }

            var materialProxy = new LilRenderingMaterialProxy(material)
            {
                //Cutoff = propertyBlock.Cutoff,
                //SubpassCutoff = propertyBlock.SubpassCutoff,

                Cull = propertyBlock.Cull,

                ZClip = propertyBlock.ZClip,
                ZWrite = propertyBlock.ZWrite,
                ZTest = propertyBlock.ZTest,

                OffsetFactor = propertyBlock.OffsetFactor,
                OffsetUnits = propertyBlock.OffsetUnits,

                ColorMask = propertyBlock.ColorMask,
                AlphaToMask = propertyBlock.AlphaToMask,
#if LILTOON_1_3_0_OR_NEWER
                LilShadowCasterBias = propertyBlock.LilShadowCasterBias,  // v1.3.0
#endif
            };

            if (isFakeShadow == false)
            {
                materialProxy.Cutoff = propertyBlock.Cutoff;
                materialProxy.SubpassCutoff = propertyBlock.SubpassCutoff;
            }
        }

        /// <summary>
        /// Set the lilToon Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingForwardPropertyValues(Material material, ILilRenderingForward? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilRenderingForwardMaterialProxy(material)
            {
                SrcBlend = propertyBlock.SrcBlend,
                DstBlend = propertyBlock.DstBlend,
                SrcBlendAlpha = propertyBlock.SrcBlendAlpha,
                DstBlendAlpha = propertyBlock.DstBlendAlpha,
                BlendOp = propertyBlock.BlendOp,
                BlendOpAlpha = propertyBlock.BlendOpAlpha,
            };
        }

        /// <summary>
        /// Set the lilToon Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingForwardAddPropertyValues(Material material, ILilRenderingForwardAdd? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilRenderingForwardAddMaterialProxy(material)
            {
                SrcBlendFA = propertyBlock.SrcBlendFA,
                DstBlendFA = propertyBlock.DstBlendFA,
                SrcBlendAlphaFA = propertyBlock.SrcBlendAlphaFA,
                DstBlendAlphaFA = propertyBlock.DstBlendAlphaFA,
                BlendOpFA = propertyBlock.BlendOpFA,
                BlendOpAlphaFA = propertyBlock.BlendOpAlphaFA,
            };
        }

        /// <summary>
        /// Set the lilToon Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingStencilPropertyValues(Material material, ILilRenderingStencil? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilRenderingStencilMaterialProxy(material)
            {
                StencilRef = propertyBlock.StencilRef,
                StencilReadMask = propertyBlock.StencilReadMask,
                StencilWriteMask = propertyBlock.StencilWriteMask,
                StencilComp = propertyBlock.StencilComp,
                StencilPass = propertyBlock.StencilPass,
                StencilFail = propertyBlock.StencilFail,
                StencilZFail = propertyBlock.StencilZFail,
            };
        }

        #endregion

        #region Save

        /// <summary>
        /// Set the lilToon Save property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilSavePropertyValues(Material material, ILilSave? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new LilSaveMaterialProxy(material)
            {
                BaseColor = propertyBlock.BaseColor,
                BaseMap = propertyBlock.BaseMap,
                BaseColorMap = propertyBlock.BaseColorMap,

                LilToonVersion = propertyBlock.LilToonVersion,
            };
        }

        #endregion

        #endregion
    }
}