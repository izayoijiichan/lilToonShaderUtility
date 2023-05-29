// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialSetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER && !LILTOON_1_4_0_OR_NEWER
#define LILTOON_1_4_0_OR_NEWER
#endif
namespace LilToonShader
{
    using System;
    using UnityEngine;
    using LilToonShader.Extensions;

#if LILTOON_1_4_0_OR_NEWER
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

        /// <summary>Default Texture Offset</summary>
        protected readonly Vector2 DefaultTextureOffset = new Vector2(0.0f, 0.0f);

        /// <summary>Default Texture Scale</summary>
        protected readonly Vector2 DefaultTextureScale = new Vector2(1.0f, 1.0f);

        /// <summary>Default Scroll Rotate</summary>
        protected readonly Vector4 DefaultScrollRotate = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

        /// <summary>Default HSVG</summary>
        protected readonly Vector4 DefaultHSVG = new Vector4(0.0f, 1.0f, 1.0f, 1.0f);

        /// <summary>Default Keys</summary>
        protected readonly Vector4 DefaultKeys = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

        /// <summary>Default Decal Animation</summary>
        protected readonly Vector4 DefaultDecalAnimation = new Vector4(1.0f, 1.0f, 1.0f, 30.0f);

        /// <summary>Default Dissolve Parameters</summary>
        protected readonly Vector4 DefaultDissolveParams = new Vector4(0.0f, 0.0f, 0.5f, 0.1f);

        /// <summary>Default Distance Fade Parameters</summary>
        protected readonly Vector4 DefaultDistanceFadeParams = new Vector4(0.1f, 0.01f, 0.0f, 0.0f);

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
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            LilToonNormalPropertyEntity multiPropertyEntity = propertyContainer.NormalProperty;
#elif LILTOON_1_2_12_OR_OLDER
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
        public virtual void SetLilBasePropertyValues(Material material, ILilBase propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.Invisible, propertyBlock.Invisible);
            material.SetSafeBool(PropertyNameID.FlipNormal, propertyBlock.FlipNormal);
            material.SetSafeBool(PropertyNameID.ShiftBackfaceUV, propertyBlock.ShiftBackfaceUV);
            material.SetSafeBool(PropertyNameID.BackfaceForceShadow, propertyBlock.BackfaceForceShadow);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeColor(PropertyNameID.BackfaceColor, propertyBlock.BackfaceColor);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.AAStrength, propertyBlock.AAStrength, 0.0f, 1.0f, 1.0f);  // v1.3.7
#endif
#if LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.UseDither, propertyBlock.UseDither);  // v1.4.0
            material.SetSafeTexture(PropertyNameID.DitherTex, propertyBlock.DitherTex);  // v1.4.0
            material.SetSafeFloat(PropertyNameID.DitherMaxValue, propertyBlock.DitherMaxValue, null, null, 255.0f);  // v1.4.0
#endif
        }

        /// <summary>
        /// Set the lilToon Lite Base property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteBasePropertyValues(Material material, ILilLiteBase propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.Invisible, propertyBlock.Invisible);
            material.SetSafeBool(PropertyNameID.FlipNormal, propertyBlock.FlipNormal);
            material.SetSafeBool(PropertyNameID.ShiftBackfaceUV, propertyBlock.ShiftBackfaceUV);
            material.SetSafeBool(PropertyNameID.BackfaceForceShadow, propertyBlock.BackfaceForceShadow);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.AAStrength, propertyBlock.AAStrength, 0.0f, 1.0f, 1.0f);  // v1.3.7
#endif
            material.SetSafeTexture(PropertyNameID.TriMask, propertyBlock.TriMask);  // Lite only
        }

        /// <summary>
        /// Set the lilToon Fake Shadow Base property values to the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFakeShadowBasePropertyValues(Material material, ILilFakeShadowBase propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.Invisible, propertyBlock.Invisible);
        }

        #endregion

        #region Lighting

        /// <summary>
        /// Set the lilToon Lighting property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLightingPropertyValues(Material material, ILilLighting propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeFloat(PropertyNameID.LightMinLimit, propertyBlock.LightMinLimit, 0f, 1f, 0.05f);
            material.SetSafeFloat(PropertyNameID.LightMaxLimit, propertyBlock.LightMaxLimit, 0f, 10f, 1f);
            material.SetSafeFloat(PropertyNameID.MonochromeLighting, propertyBlock.MonochromeLighting, 0f, 1f, 0f);
        }

        /// <summary>
        /// Set the lilToon Lighting Advanced property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLightingAdvancedPropertyValues(Material material, ILilLightingAdvanced propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.AsUnlit, propertyBlock.AsUnlit);
            material.SetSafeFloat(PropertyNameID.VertexLightStrength, propertyBlock.VertexLightStrength, 0f, 1f, 0f);
            material.SetSafeVector(PropertyNameID.LightDirectionOverride, propertyBlock.LightDirectionOverride);
            material.SetSafeFloat(PropertyNameID.AlphaBoostFA, propertyBlock.AlphaBoostFA, 1f, 100f, 10f);
            material.SetSafeFloat(PropertyNameID.BeforeExposureLimit, propertyBlock.BeforeExposureLimit, null, null, 10000f);
            material.SetSafeFloat(PropertyNameID.LilDirectionalLightStrength, propertyBlock.LilDirectionalLightStrength, 0f, 1f, 1f);
        }

        #endregion

        #region Main (Normal, Lite, FakeShadow)

        /// <summary>
        /// Set the lilToon Fake Shadow Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon FakeShadow material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFakeShadowMainPropertyValues(Material material, ILilFakeShadowMain propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyNameID.MainTex, propertyBlock.MainTex);

            material.SetSafeVector(PropertyNameID.FakeShadowVector, propertyBlock.FakeShadowVector);
        }

        /// <summary>
        /// Set the lilToon Lite Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteMainPropertyValues(Material material, ILilLiteMain propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyNameID.MainTex, propertyBlock.MainTex);
            material.SetSafeVector(PropertyNameID.MainTex_ScrollRotate, propertyBlock.MainTex_ScrollRotate);
        }

        /// <summary>
        /// Set the lilToon Main property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMainPropertyValues(Material material, ILilMain propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyNameID.MainTex, propertyBlock.MainTex);
            material.SetSafeVector(PropertyNameID.MainTex_ScrollRotate, propertyBlock.MainTex_ScrollRotate);
            material.SetSafeVector(PropertyNameID.MainTexHSVG, propertyBlock.MainTexHSVG);
            material.SetSafeFloat(PropertyNameID.MainGradationStrength, propertyBlock.MainGradationStrength, 0f, 1f, 0f);
            material.SetSafeTexture(PropertyNameID.MainGradationTex, propertyBlock.MainGradationTex);
            material.SetSafeTexture(PropertyNameID.MainColorAdjustMask, propertyBlock.MainColorAdjustMask);
        }

        /// <summary>
        /// Set the lilToon Main 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMain2ndPropertyValues(Material material, ILilMain2nd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseMain2ndTex, propertyBlock.UseMain2ndTex);

            material.SetSafeColor(PropertyNameID.Color2nd, propertyBlock.Color2nd);
            material.SetSafeTexture(PropertyNameID.Main2ndTex, propertyBlock.Main2ndTex);
            material.SetSafeFloat(PropertyNameID.Main2ndTexAngle, propertyBlock.Main2ndTexAngle, null, null, 0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeVector(PropertyNameID.Main2ndTex_ScrollRotate, propertyBlock.Main2ndTex_ScrollRotate);  // v1.3.7
#endif
            material.SetSafeInt(PropertyNameID.Main2ndTex_UVMode, (int)propertyBlock.Main2ndTex_UVMode);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Main2ndTex_Cull, (int)propertyBlock.Main2ndTex_Cull);  // v1.3.1
#endif
            material.SetSafeVector(PropertyNameID.Main2ndTexDecalAnimation, propertyBlock.Main2ndTexDecalAnimation);
            material.SetSafeVector(PropertyNameID.Main2ndTexDecalSubParam, propertyBlock.Main2ndTexDecalSubParam);
            material.SetSafeBool(PropertyNameID.Main2ndTexIsDecal, propertyBlock.Main2ndTexIsDecal);
            material.SetSafeBool(PropertyNameID.Main2ndTexIsLeftOnly, propertyBlock.Main2ndTexIsLeftOnly);
            material.SetSafeBool(PropertyNameID.Main2ndTexIsRightOnly, propertyBlock.Main2ndTexIsRightOnly);
            material.SetSafeBool(PropertyNameID.Main2ndTexShouldCopy, propertyBlock.Main2ndTexShouldCopy);
            material.SetSafeBool(PropertyNameID.Main2ndTexShouldFlipMirror, propertyBlock.Main2ndTexShouldFlipMirror);
            material.SetSafeBool(PropertyNameID.Main2ndTexShouldFlipCopy, propertyBlock.Main2ndTexShouldFlipCopy);
            material.SetSafeBool(PropertyNameID.Main2ndTexIsMSDF, propertyBlock.Main2ndTexIsMSDF);
            material.SetSafeTexture(PropertyNameID.Main2ndBlendMask, propertyBlock.Main2ndBlendMask);
            material.SetSafeInt(PropertyNameID.Main2ndTexBlendMode, (int)propertyBlock.Main2ndTexBlendMode);
#if LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Main2ndTexAlphaMode, (int)propertyBlock.Main2ndTexAlphaMode);  // v1.4.0
#endif
            material.SetSafeBool(PropertyNameID.Main2ndEnableLighting, propertyBlock.Main2ndEnableLighting);

            material.SetSafeTexture(PropertyNameID.Main2ndDissolveMask, propertyBlock.Main2ndDissolveMask);
            material.SetSafeTexture(PropertyNameID.Main2ndDissolveNoiseMask, propertyBlock.Main2ndDissolveNoiseMask);
            material.SetSafeVector(PropertyNameID.Main2ndDissolveNoiseMask_ScrollRotate, propertyBlock.Main2ndDissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyNameID.Main2ndDissolveNoiseStrength, propertyBlock.Main2ndDissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyNameID.Main2ndDissolveColor, propertyBlock.Main2ndDissolveColor);
            material.SetSafeVector(PropertyNameID.Main2ndDissolveParams, propertyBlock.Main2ndDissolveParams);
            material.SetSafeVector(PropertyNameID.Main2ndDissolvePos, propertyBlock.Main2ndDissolvePos);
            material.SetSafeVector(PropertyNameID.Main2ndDistanceFade, propertyBlock.Main2ndDistanceFade);
        }

        /// <summary>
        /// Set the lilToon Main 3rd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMain3rdPropertyValues(Material material, ILilMain3rd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseMain3rdTex, propertyBlock.UseMain3rdTex);

            material.SetSafeColor(PropertyNameID.Color3rd, propertyBlock.Color3rd);
            material.SetSafeTexture(PropertyNameID.Main3rdTex, propertyBlock.Main3rdTex);
            material.SetSafeFloat(PropertyNameID.Main3rdTexAngle, propertyBlock.Main3rdTexAngle, null, null, 0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeVector(PropertyNameID.Main3rdTex_ScrollRotate, propertyBlock.Main3rdTex_ScrollRotate);  // v1.3.7
#endif
            material.SetSafeInt(PropertyNameID.Main3rdTex_UVMode, (int)propertyBlock.Main3rdTex_UVMode);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Main3rdTex_Cull, (int)propertyBlock.Main3rdTex_Cull);  // v1.3.1
#endif
            material.SetSafeVector(PropertyNameID.Main3rdTexDecalAnimation, propertyBlock.Main3rdTexDecalAnimation);
            material.SetSafeVector(PropertyNameID.Main3rdTexDecalSubParam, propertyBlock.Main3rdTexDecalSubParam);
            material.SetSafeBool(PropertyNameID.Main3rdTexIsDecal, propertyBlock.Main3rdTexIsDecal);
            material.SetSafeBool(PropertyNameID.Main3rdTexIsLeftOnly, propertyBlock.Main3rdTexIsLeftOnly);
            material.SetSafeBool(PropertyNameID.Main3rdTexIsRightOnly, propertyBlock.Main3rdTexIsRightOnly);
            material.SetSafeBool(PropertyNameID.Main3rdTexShouldCopy, propertyBlock.Main3rdTexShouldCopy);
            material.SetSafeBool(PropertyNameID.Main3rdTexShouldFlipMirror, propertyBlock.Main3rdTexShouldFlipMirror);
            material.SetSafeBool(PropertyNameID.Main3rdTexShouldFlipCopy, propertyBlock.Main3rdTexShouldFlipCopy);
            material.SetSafeBool(PropertyNameID.Main3rdTexIsMSDF, propertyBlock.Main3rdTexIsMSDF);
            material.SetSafeTexture(PropertyNameID.Main3rdBlendMask, propertyBlock.Main3rdBlendMask);
            material.SetSafeInt(PropertyNameID.Main3rdTexBlendMode, (int)propertyBlock.Main3rdTexBlendMode);
#if LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Main3rdTexAlphaMode, (int)propertyBlock.Main3rdTexAlphaMode);  // v1.4.0
#endif
            material.SetSafeBool(PropertyNameID.Main3rdEnableLighting, propertyBlock.Main3rdEnableLighting);

            material.SetSafeTexture(PropertyNameID.Main3rdDissolveMask, propertyBlock.Main3rdDissolveMask);
            material.SetSafeTexture(PropertyNameID.Main3rdDissolveNoiseMask, propertyBlock.Main3rdDissolveNoiseMask);
            material.SetSafeVector(PropertyNameID.Main3rdDissolveNoiseMask_ScrollRotate, propertyBlock.Main3rdDissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyNameID.Main3rdDissolveNoiseStrength, propertyBlock.Main3rdDissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyNameID.Main3rdDissolveColor, propertyBlock.Main3rdDissolveColor);
            material.SetSafeVector(PropertyNameID.Main3rdDissolveParams, propertyBlock.Main3rdDissolveParams);
            material.SetSafeVector(PropertyNameID.Main3rdDissolvePos, propertyBlock.Main3rdDissolvePos);
            material.SetSafeVector(PropertyNameID.Main3rdDistanceFade, propertyBlock.Main3rdDistanceFade);
        }

        #endregion

        #region Alpha Mask

        /// <summary>
        /// Set the lilToon Alpha Mask property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAlphaMaskPropertyValues(Material material, ILilAlphaMask propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.AlphaMaskMode, (int)propertyBlock.AlphaMaskMode);
            material.SetSafeTexture(PropertyNameID.AlphaMask, propertyBlock.AlphaMask);
            material.SetSafeFloat(PropertyNameID.AlphaMaskScale, propertyBlock.AlphaMaskScale, null, null, 1.0f);
            material.SetSafeFloat(PropertyNameID.AlphaMaskValue, propertyBlock.AlphaMaskValue, null, null, 0.0f);
        }

        #endregion

        #region NormalMap

        /// <summary>
        /// Set the lilToon NormalMap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilNormalMapPropertyValues(Material material, ILilNormalMap propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseBumpMap, propertyBlock.UseBumpMap);

            material.SetSafeTexture(PropertyNameID.BumpMap, propertyBlock.BumpMap);
            material.SetSafeFloat(PropertyNameID.BumpScale, propertyBlock.BumpScale, -10.0f, 10.0f, 1.0f);
        }

        /// <summary>
        /// Set the lilToon NormalMap 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilNormalMap2ndPropertyValues(Material material, ILilNormalMap2nd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseBump2ndMap, propertyBlock.UseBump2ndMap);

            material.SetSafeTexture(PropertyNameID.Bump2ndMap, propertyBlock.Bump2ndMap);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Bump2ndMap_UVMode, (int)propertyBlock.Bump2ndMap_UVMode);  // v1.3.1
#endif
            material.SetSafeFloat(PropertyNameID.Bump2ndScale, propertyBlock.Bump2ndScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.Bump2ndScaleMask, propertyBlock.Bump2ndScaleMask);
        }

        #endregion

        #region Anisotropy

        /// <summary>
        /// Set the lilToon Anisotropy property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAnisotropyPropertyValues(Material material, ILilAnisotropy propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseAnisotropy, propertyBlock.UseAnisotropy);

            material.SetSafeTexture(PropertyNameID.AnisotropyTangentMap, propertyBlock.AnisotropyTangentMap);
            material.SetSafeFloat(PropertyNameID.AnisotropyScale, propertyBlock.AnisotropyScale, -1.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.AnisotropyScaleMask, propertyBlock.AnisotropyScaleMask);

            material.SetSafeFloat(PropertyNameID.AnisotropyTangentWidth, propertyBlock.AnisotropyTangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.AnisotropyBitangentWidth, propertyBlock.AnisotropyBitangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.AnisotropyShift, propertyBlock.AnisotropyShift, -10.0f, 10.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.AnisotropyShiftNoiseScale, propertyBlock.AnisotropyShiftNoiseScale, -1.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.AnisotropySpecularStrength, propertyBlock.AnisotropySpecularStrength, 0.0f, 10.0f, 1.0f);

            material.SetSafeFloat(PropertyNameID.Anisotropy2ndTangentWidth, propertyBlock.Anisotropy2ndTangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.Anisotropy2ndBitangentWidth, propertyBlock.Anisotropy2ndBitangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.Anisotropy2ndShift, propertyBlock.Anisotropy2ndShift, -10.0f, 10.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.Anisotropy2ndShiftNoiseScale, propertyBlock.Anisotropy2ndShiftNoiseScale, -1.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.Anisotropy2ndSpecularStrength, propertyBlock.Anisotropy2ndSpecularStrength, 0.0f, 10.0f, 0.0f);

            material.SetSafeTexture(PropertyNameID.AnisotropyShiftNoiseMask, propertyBlock.AnisotropyShiftNoiseMask);
            material.SetSafeBool(PropertyNameID.Anisotropy2Reflection, propertyBlock.Anisotropy2Reflection);
            material.SetSafeBool(PropertyNameID.Anisotropy2MatCap, propertyBlock.Anisotropy2MatCap);
            material.SetSafeBool(PropertyNameID.Anisotropy2MatCap2nd, propertyBlock.Anisotropy2MatCap2nd);
        }

        #endregion

        #region Backlight

        /// <summary>
        /// Set the lilToon Backlight property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilBacklightPropertyValues(Material material, ILilBacklight propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseBacklight, propertyBlock.UseBacklight);

            material.SetSafeColor(PropertyNameID.BacklightColor, propertyBlock.BacklightColor);
            material.SetSafeTexture(PropertyNameID.BacklightColorTex, propertyBlock.BacklightColorTex);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.BacklightMainStrength, (int)propertyBlock.BacklightMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyNameID.BacklightNormalStrength, propertyBlock.BacklightNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.BacklightBorder, propertyBlock.BacklightBorder, 0.0f, 1.0f, 0.35f);
            material.SetSafeFloat(PropertyNameID.BacklightBlur, propertyBlock.BacklightBlur, 0.0f, 1.0f, 0.05f);
            material.SetSafeFloat(PropertyNameID.BacklightDirectivity, propertyBlock.BacklightDirectivity, null, null, 5.0f);
            material.SetSafeFloat(PropertyNameID.BacklightViewStrength, propertyBlock.BacklightViewStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyNameID.BacklightReceiveShadow, propertyBlock.BacklightReceiveShadow);
            material.SetSafeBool(PropertyNameID.BacklightBackfaceMask, propertyBlock.BacklightBackfaceMask);
        }

        #endregion

        #region Shadow (Mormal, Lite)

        /// <summary>
        /// Set the lilToon Lite Shadow property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteShadowPropertyValues(Material material, ILilLiteShadow propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseShadow, propertyBlock.UseShadow);
            material.SetSafeTexture(PropertyNameID.ShadowColorTex, propertyBlock.ShadowColorTex);
            material.SetSafeFloat(PropertyNameID.ShadowBorder, propertyBlock.ShadowBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.ShadowBlur, propertyBlock.ShadowBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeTexture(PropertyNameID.Shadow2ndColorTex, propertyBlock.Shadow2ndColorTex);
            material.SetSafeFloat(PropertyNameID.Shadow2ndBorder, propertyBlock.Shadow2ndBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.Shadow2ndBlur, propertyBlock.Shadow2ndBlur, 0.0f, 1.0f, 0.3f);
            material.SetSafeColor(PropertyNameID.ShadowBorderColor, propertyBlock.ShadowBorderColor);
            material.SetSafeFloat(PropertyNameID.ShadowBorderRange, propertyBlock.ShadowBorderRange, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.ShadowEnvStrength, propertyBlock.ShadowEnvStrength, 0.0f, 1.0f, 0.0f);
        }

        /// <summary>
        /// Set the lilToon Shadow property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilShadowPropertyValues(Material material, ILilShadow propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseShadow, propertyBlock.UseShadow);

            //material.SetSafeBool(PropertyNameID.ShadowReceive, propertyBlock.ShadowReceive);
            material.SetSafeFloat(PropertyNameID.ShadowStrength, propertyBlock.ShadowStrength, 0.0f, 1.0f, 0.0f);

            material.SetSafeTexture(PropertyNameID.ShadowStrengthMask, propertyBlock.ShadowStrengthMask);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.ShadowStrengthMaskLOD, propertyBlock.ShadowStrengthMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeTexture(PropertyNameID.ShadowBorderMask, propertyBlock.ShadowBorderMask);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.ShadowBorderMaskLOD, propertyBlock.ShadowBorderMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeTexture(PropertyNameID.ShadowBlurMask, propertyBlock.ShadowBlurMask);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.ShadowBlurMaskLOD, propertyBlock.ShadowBlurMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeVector(PropertyNameID.ShadowAOShift, propertyBlock.ShadowAOShift);
            material.SetSafeVector(PropertyNameID.ShadowAOShift2, propertyBlock.ShadowAOShift2);
            material.SetSafeBool(PropertyNameID.ShadowPostAO, propertyBlock.ShadowPostAO);

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.ShadowColorType, (int)propertyBlock.ShadowColorType);  // v1.3.5
#endif
            material.SetSafeColor(PropertyNameID.ShadowColor, propertyBlock.ShadowColor);
            material.SetSafeTexture(PropertyNameID.ShadowColorTex, propertyBlock.ShadowColorTex);
            material.SetSafeFloat(PropertyNameID.ShadowNormalStrength, propertyBlock.ShadowNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.ShadowBorder, propertyBlock.ShadowBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.ShadowBlur, propertyBlock.ShadowBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeBool(PropertyNameID.ShadowReceive, propertyBlock.ShadowReceive);

            material.SetSafeColor(PropertyNameID.Shadow2ndColor, propertyBlock.Shadow2ndColor);
            material.SetSafeTexture(PropertyNameID.Shadow2ndColorTex, propertyBlock.Shadow2ndColorTex);
            material.SetSafeFloat(PropertyNameID.Shadow2ndNormalStrength, propertyBlock.Shadow2ndNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.Shadow2ndBorder, propertyBlock.Shadow2ndBorder, 0.0f, 1.0f, 0.15f);
            material.SetSafeFloat(PropertyNameID.Shadow2ndBlur, propertyBlock.Shadow2ndBlur, 0.0f, 1.0f, 0.1f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.Shadow2ndReceive, propertyBlock.Shadow2ndReceive);  // v1.3.0
#endif

            material.SetSafeColor(PropertyNameID.Shadow3rdColor, propertyBlock.Shadow3rdColor);
            material.SetSafeTexture(PropertyNameID.Shadow3rdColorTex, propertyBlock.Shadow3rdColorTex);
            material.SetSafeFloat(PropertyNameID.Shadow3rdNormalStrength, propertyBlock.Shadow3rdNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.Shadow3rdBorder, propertyBlock.Shadow3rdBorder, 0.0f, 1.0f, 0.25f);
            material.SetSafeFloat(PropertyNameID.Shadow3rdBlur, propertyBlock.Shadow3rdBlur, 0.0f, 1.0f, 0.1f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.Shadow3rdReceive, propertyBlock.Shadow3rdReceive);  // v1.3.0
#endif

            material.SetSafeColor(PropertyNameID.ShadowBorderColor, propertyBlock.ShadowBorderColor);
            material.SetSafeFloat(PropertyNameID.ShadowBorderRange, propertyBlock.ShadowBorderRange, 0.0f, 1.0f, 0.08f);

            material.SetSafeFloat(PropertyNameID.ShadowMainStrength, propertyBlock.ShadowMainStrength, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.ShadowEnvStrength, propertyBlock.ShadowEnvStrength, 0.0f, 1.0f, 0.0f);

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.ShadowMaskType, (int)propertyBlock.ShadowMaskType);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.ShadowFlatBorder, (int)propertyBlock.ShadowFlatBorder, -2.0f, 2.0f, 1.0f);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.ShadowFlatBlur, (int)propertyBlock.ShadowFlatBlur, 0.001f, 2.0f, 1.0f);  // v1.3.0
#endif
        }

        #endregion

        #region Reflection

        /// <summary>
        /// Set the lilToon Reflection property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilReflectionPropertyValues(Material material, ILilReflection propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseReflection, propertyBlock.UseReflection);

            material.SetSafeFloat(PropertyNameID.Smoothness, propertyBlock.Smoothness, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.SmoothnessTex, propertyBlock.SmoothnessTex);

            material.SetSafeFloat(PropertyNameID.Metallic, propertyBlock.Metallic, 0.0f, 1.0f, 0.0f);
            material.SetSafeTexture(PropertyNameID.MetallicGlossMap, propertyBlock.MetallicGlossMap);

            material.SetSafeFloat(PropertyNameID.Reflectance, propertyBlock.Reflectance, 0.0f, 1.0f, 0.04f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.GSAAStrength, propertyBlock.GSAAStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeBool(PropertyNameID.ApplySpecular, propertyBlock.ApplySpecular);
            material.SetSafeBool(PropertyNameID.ApplySpecularFA, propertyBlock.ApplySpecularFA);
            material.SetSafeBool(PropertyNameID.SpecularToon, propertyBlock.SpecularToon);
            material.SetSafeFloat(PropertyNameID.SpecularNormalStrength, propertyBlock.SpecularNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.SpecularBorder, propertyBlock.SpecularBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.SpecularBlur, propertyBlock.SpecularBlur, 0.0f, 1.0f, 0.0f);

            material.SetSafeBool(PropertyNameID.ApplyReflection, propertyBlock.ApplyReflection);
            material.SetSafeFloat(PropertyNameID.ReflectionNormalStrength, propertyBlock.ReflectionNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeColor(PropertyNameID.ReflectionColor, propertyBlock.ReflectionColor);
            material.SetSafeTexture(PropertyNameID.ReflectionColorTex, propertyBlock.ReflectionColorTex);

            material.SetSafeBool(PropertyNameID.ReflectionApplyTransparency, propertyBlock.ReflectionApplyTransparency);
            material.SetSafeTexture(PropertyNameID.ReflectionCubeTex, propertyBlock.ReflectionCubeTex);
            material.SetSafeColor(PropertyNameID.ReflectionCubeColor, propertyBlock.ReflectionCubeColor);
            material.SetSafeBool(PropertyNameID.ReflectionCubeOverride, propertyBlock.ReflectionCubeOverride);
            material.SetSafeFloat(PropertyNameID.ReflectionCubeEnableLighting, propertyBlock.ReflectionCubeEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.ReflectionBlendMode, (int)propertyBlock.ReflectionBlendMode, null, null, (int)LilBlendMode.Add);  // v1.3.0
#endif
        }

        #endregion

        #region MatCap (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite MatCap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteMatCapPropertyValues(Material material, ILilLiteMatCap propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseMatCap, propertyBlock.UseMatCap);
            material.SetSafeTexture(PropertyNameID.MatCapTex, propertyBlock.MatCapTex);
            material.SetSafeVector(PropertyNameID.MatCapBlendUV1, propertyBlock.MatCapBlendUV1);
            material.SetSafeBool(PropertyNameID.MatCapZRotCancel, propertyBlock.MatCapZRotCancel);
            material.SetSafeBool(PropertyNameID.MatCapPerspective, propertyBlock.MatCapPerspective);
            material.SetSafeBool(PropertyNameID.MatCapBlend, propertyBlock.MatCapMul);  // Lite only
        }

        /// <summary>
        /// Set the lilToon MatCap property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMatCapPropertyValues(Material material, ILilMatCap propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseMatCap, propertyBlock.UseMatCap);

            material.SetSafeColor(PropertyNameID.MatCapColor, propertyBlock.MatCapColor);
            material.SetSafeTexture(PropertyNameID.MatCapTex, propertyBlock.MatCapTex);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.MatCapMainStrength, propertyBlock.MatCapMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeVector(PropertyNameID.MatCapBlendUV1, propertyBlock.MatCapBlendUV1);
            material.SetSafeBool(PropertyNameID.MatCapZRotCancel, propertyBlock.MatCapZRotCancel);
            material.SetSafeBool(PropertyNameID.MatCapPerspective, propertyBlock.MatCapPerspective);
            material.SetSafeFloat(PropertyNameID.MatCapVRParallaxStrength, propertyBlock.MatCapVRParallaxStrength, 0.0f, 1.0f, 1.0f);

            material.SetSafeFloat(PropertyNameID.MatCapBlend, propertyBlock.MatCapBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.MatCapBlendMask, propertyBlock.MatCapBlendMask);

            material.SetSafeFloat(PropertyNameID.MatCapEnableLighting, propertyBlock.MatCapEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.MatCapShadowMask, propertyBlock.MatCapShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyNameID.MatCapBackfaceMask, propertyBlock.MatCapBackfaceMask);
            material.SetSafeFloat(PropertyNameID.MatCapLod, propertyBlock.MatCapLod, 0.0f, 10.0f, 0.0f);
            material.SetSafeInt(PropertyNameID.MatCapBlendMode, (int)propertyBlock.MatCapBlendMode);
            material.SetSafeBool(PropertyNameID.MatCapApplyTransparency, propertyBlock.MatCapApplyTransparency);

            material.SetSafeFloat(PropertyNameID.MatCapNormalStrength, propertyBlock.MatCapNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyNameID.MatCapCustomNormal, propertyBlock.MatCapCustomNormal);
            material.SetSafeTexture(PropertyNameID.MatCapBumpMap, propertyBlock.MatCapBumpMap);
            material.SetSafeFloat(PropertyNameID.MatCapBumpScale, propertyBlock.MatCapBumpScale, -10.0f, 10.0f, 1.0f);
        }

        /// <summary>
        /// Set the lilToon MatCap 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilMatCap2ndPropertyValues(Material material, ILilMatCap2nd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseMatCap2nd, propertyBlock.UseMatCap2nd);

            material.SetSafeColor(PropertyNameID.MatCap2ndColor, propertyBlock.MatCap2ndColor);
            material.SetSafeTexture(PropertyNameID.MatCap2ndTex, propertyBlock.MatCap2ndTex);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.MatCap2ndMainStrength, propertyBlock.MatCap2ndMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeVector(PropertyNameID.MatCap2ndBlendUV1, propertyBlock.MatCap2ndBlendUV1);
            material.SetSafeBool(PropertyNameID.MatCap2ndZRotCancel, propertyBlock.MatCap2ndZRotCancel);
            material.SetSafeBool(PropertyNameID.MatCap2ndPerspective, propertyBlock.MatCap2ndPerspective);
            material.SetSafeFloat(PropertyNameID.MatCap2ndVRParallaxStrength, propertyBlock.MatCap2ndVRParallaxStrength, 0.0f, 1.0f, 1.0f);

            material.SetSafeFloat(PropertyNameID.MatCap2ndBlend, propertyBlock.MatCap2ndBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.MatCap2ndBlendMask, propertyBlock.MatCap2ndBlendMask);

            material.SetSafeFloat(PropertyNameID.MatCap2ndEnableLighting, propertyBlock.MatCap2ndEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.MatCap2ndShadowMask, propertyBlock.MatCap2ndShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyNameID.MatCap2ndBackfaceMask, propertyBlock.MatCap2ndBackfaceMask);
            material.SetSafeFloat(PropertyNameID.MatCap2ndLod, propertyBlock.MatCap2ndLod, 0.0f, 10.0f, 0.0f);
            material.SetSafeInt(PropertyNameID.MatCap2ndBlendMode, (int)propertyBlock.MatCap2ndBlendMode);
            material.SetSafeBool(PropertyNameID.MatCap2ndApplyTransparency, propertyBlock.MatCap2ndApplyTransparency);

            material.SetSafeFloat(PropertyNameID.MatCap2ndNormalStrength, propertyBlock.MatCap2ndNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyNameID.MatCap2ndCustomNormal, propertyBlock.MatCap2ndCustomNormal);
            material.SetSafeTexture(PropertyNameID.MatCap2ndBumpMap, propertyBlock.MatCap2ndBumpMap);
            material.SetSafeFloat(PropertyNameID.MatCap2ndBumpScale, propertyBlock.MatCap2ndBumpScale, -10.0f, 10.0f, 1.0f);
        }

        #endregion

        #region Rim (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite Rim property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteRimPropertyValues(Material material, ILilLiteRim propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseRim, propertyBlock.UseRim);
            material.SetSafeColor(PropertyNameID.RimColor, propertyBlock.RimColor);
            material.SetSafeFloat(PropertyNameID.RimBorder, propertyBlock.RimBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.RimBlur, propertyBlock.RimBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeFloat(PropertyNameID.RimFresnelPower, propertyBlock.RimFresnelPower, 0.01f, 50.0f, 3.0f);
            material.SetSafeFloat(PropertyNameID.RimShadowMask, propertyBlock.RimShadowMask, 0.0f, 1.0f, 0.0f);
        }

        /// <summary>
        /// Set the lilToon Rim property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRimPropertyValues(Material material, ILilRim propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseRim, propertyBlock.UseRim);

            material.SetSafeColor(PropertyNameID.RimColor, propertyBlock.RimColor);
            material.SetSafeTexture(PropertyNameID.RimColorTex, propertyBlock.RimColorTex);

            material.SetSafeFloat(PropertyNameID.RimMainStrength, propertyBlock.RimNormalStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.RimNormalStrength, propertyBlock.RimNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.RimBorder, propertyBlock.RimBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.RimBlur, propertyBlock.RimBlur, 0.0f, 1.0f, 0.65f);
            material.SetSafeFloat(PropertyNameID.RimFresnelPower, propertyBlock.RimFresnelPower, 0.01f, 50.0f, 3.5f);
            material.SetSafeFloat(PropertyNameID.RimEnableLighting, propertyBlock.RimEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.RimShadowMask, propertyBlock.RimShadowMask, 0.0f, 1.0f, 0.5f);
            material.SetSafeBool(PropertyNameID.RimBackfaceMask, propertyBlock.RimBackfaceMask);
            material.SetSafeFloat(PropertyNameID.RimVRParallaxStrength, propertyBlock.RimVRParallaxStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyNameID.RimApplyTransparency, propertyBlock.RimApplyTransparency);

            material.SetSafeFloat(PropertyNameID.RimDirStrength, propertyBlock.RimDirStrength, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.RimDirRange, propertyBlock.RimDirRange, -1.0f, 1.0f, 0.0f);

            material.SetSafeFloat(PropertyNameID.RimIndirRange, propertyBlock.RimIndirRange, -1.0f, 1.0f, 0.0f);
            material.SetSafeColor(PropertyNameID.RimIndirColor, propertyBlock.RimIndirColor);
            material.SetSafeFloat(PropertyNameID.RimIndirBorder, propertyBlock.RimIndirBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.RimIndirBlur, propertyBlock.RimIndirBlur, 0.0f, 1.0f, 0.1f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.RimBlendMode, (int)propertyBlock.RimBlendMode);  // v1.3.7
#endif
        }

        #endregion

        #region Glitter

        /// <summary>
        /// Set the lilToon Glitter property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilGlitterPropertyValues(Material material, ILilGlitter propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseGlitter, propertyBlock.UseGlitter);

            material.SetSafeInt(PropertyNameID.GlitterUVMode, (int)propertyBlock.GlitterUVMode);
            material.SetSafeColor(PropertyNameID.GlitterColor, propertyBlock.GlitterColor);
            material.SetSafeTexture(PropertyNameID.GlitterColorTex, propertyBlock.GlitterColorTex);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.GlitterColorTex_UVMode, (int)propertyBlock.GlitterColorTex_UVMode);  // v1.3.2
#endif
            material.SetSafeFloat(PropertyNameID.GlitterMainStrength, propertyBlock.GlitterMainStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.GlitterNormalStrength, propertyBlock.GlitterNormalStrength, 0.0f, 1.0f, 1.0f);

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.GlitterScaleRandomize, propertyBlock.GlitterScaleRandomize, 0.0f, 1.0f, 0.0f);  // v1.3.0
            material.SetSafeBool(PropertyNameID.GlitterApplyShape, propertyBlock.GlitterApplyShape);  // v1.3.0
            material.SetSafeTexture(PropertyNameID.GlitterShapeTex, propertyBlock.GlitterShapeTex);  // v1.3.0
            material.SetSafeVector(PropertyNameID.GlitterAtras, propertyBlock.GlitterAtras);  // v1.3.0
            material.SetSafeBool(PropertyNameID.GlitterAngleRandomize, propertyBlock.GlitterAngleRandomize);  // v1.3.0
#endif

            material.SetSafeVector(PropertyNameID.GlitterParams1, propertyBlock.GlitterParams1);
            material.SetSafeVector(PropertyNameID.GlitterParams2, propertyBlock.GlitterParams2);
            material.SetSafeFloat(PropertyNameID.GlitterPostContrast, propertyBlock.GlitterPostContrast, null, null, 1.0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.GlitterSensitivity, propertyBlock.GlitterSensitivity, null, null, 0.25f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyNameID.GlitterEnableLighting, propertyBlock.GlitterEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.GlitterShadowMask, propertyBlock.GlitterShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyNameID.GlitterBackfaceMask, propertyBlock.GlitterBackfaceMask);
            material.SetSafeBool(PropertyNameID.GlitterApplyTransparency, propertyBlock.GlitterApplyTransparency);
            material.SetSafeFloat(PropertyNameID.GlitterVRParallaxStrength, propertyBlock.GlitterVRParallaxStrength, 0.0f, 1.0f, 0.0f);
        }

        #endregion

        #region Emission (Normal, Lite)

        /// <summary>
        /// Set the lilToon Lite Emission property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteEmissionPropertyValues(Material material, ILilLiteEmission propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseEmission, propertyBlock.UseEmission);
            material.SetSafeColor(PropertyNameID.EmissionColor, propertyBlock.EmissionColor);
            material.SetSafeTexture(PropertyNameID.EmissionMap, propertyBlock.EmissionMap);
            material.SetSafeVector(PropertyNameID.EmissionMap_ScrollRotate, propertyBlock.EmissionMap_ScrollRotate);
            material.SetSafeFloat(PropertyNameID.EmissionMap_UVMode, (int)propertyBlock.EmissionMap_UVMode);
            material.SetSafeVector(PropertyNameID.EmissionBlink, propertyBlock.EmissionBlink);
        }

        /// <summary>
        /// Set the lilToon Emission property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmissionPropertyValues(Material material, ILilEmission propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseEmission, propertyBlock.UseEmission);

            material.SetSafeColor(PropertyNameID.EmissionColor, propertyBlock.EmissionColor);
            material.SetSafeTexture(PropertyNameID.EmissionMap, propertyBlock.EmissionMap);
            material.SetSafeVector(PropertyNameID.EmissionMap_ScrollRotate, propertyBlock.EmissionMap_ScrollRotate);
            material.SetSafeInt(PropertyNameID.EmissionMap_UVMode, (int)propertyBlock.EmissionMap_UVMode);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.EmissionMainStrength, (int)propertyBlock.EmissionMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyNameID.EmissionBlend, propertyBlock.EmissionBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.EmissionBlendMask, propertyBlock.EmissionBlendMask);
            material.SetSafeVector(PropertyNameID.EmissionBlendMask_ScrollRotate, propertyBlock.EmissionBlendMask_ScrollRotate);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.EmissionBlendMode, (int)propertyBlock.EmissionBlendMode);  // v1.3.7
#endif
            material.SetSafeVector(PropertyNameID.EmissionBlink, propertyBlock.EmissionBlink);

            material.SetSafeBool(PropertyNameID.EmissionUseGrad, propertyBlock.EmissionUseGrad);
            material.SetSafeTexture(PropertyNameID.EmissionGradTex, propertyBlock.EmissionGradTex);
            material.SetSafeFloat(PropertyNameID.EmissionGradSpeed, propertyBlock.EmissionGradSpeed, null, null, 1.0f);

            material.SetSafeFloat(PropertyNameID.EmissionParallaxDepth, propertyBlock.EmissionParallaxDepth, null, null, 0.0f);
            material.SetSafeFloat(PropertyNameID.EmissionFluorescence, propertyBlock.EmissionFluorescence, 0.0f, 1.0f, 0.0f);
        }

        /// <summary>
        /// Set the lilToon Emission Gradation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmissionGradationPropertyValues(Material material, ILilEmissionGradation propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.Egci, propertyBlock.Egci, null, null, 2);
            material.SetSafeInt(PropertyNameID.Egai, propertyBlock.Egai, null, null, 2);

            material.SetSafeColor(PropertyNameID.Egc0, propertyBlock.Egc0);
            material.SetSafeColor(PropertyNameID.Egc1, propertyBlock.Egc1);
            material.SetSafeColor(PropertyNameID.Egc2, propertyBlock.Egc2);
            material.SetSafeColor(PropertyNameID.Egc3, propertyBlock.Egc3);
            material.SetSafeColor(PropertyNameID.Egc4, propertyBlock.Egc4);
            material.SetSafeColor(PropertyNameID.Egc5, propertyBlock.Egc5);
            material.SetSafeColor(PropertyNameID.Egc6, propertyBlock.Egc6);
            material.SetSafeColor(PropertyNameID.Egc7, propertyBlock.Egc7);

            material.SetSafeColor(PropertyNameID.Ega0, propertyBlock.Ega0);
            material.SetSafeColor(PropertyNameID.Ega1, propertyBlock.Ega1);
            material.SetSafeColor(PropertyNameID.Ega2, propertyBlock.Ega2);
            material.SetSafeColor(PropertyNameID.Ega3, propertyBlock.Ega3);
            material.SetSafeColor(PropertyNameID.Ega4, propertyBlock.Ega4);
            material.SetSafeColor(PropertyNameID.Ega5, propertyBlock.Ega5);
            material.SetSafeColor(PropertyNameID.Ega6, propertyBlock.Ega6);
            material.SetSafeColor(PropertyNameID.Ega7, propertyBlock.Ega7);
        }

        /// <summary>
        /// Set the lilToon Emission 2nd property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmission2ndPropertyValues(Material material, ILilEmission2nd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseEmission2nd, propertyBlock.UseEmission2nd);

            material.SetSafeColor(PropertyNameID.Emission2ndColor, propertyBlock.Emission2ndColor);
            material.SetSafeTexture(PropertyNameID.Emission2ndMap, propertyBlock.Emission2ndMap);
            material.SetSafeVector(PropertyNameID.Emission2ndMap_ScrollRotate, propertyBlock.Emission2ndMap_ScrollRotate);
            material.SetSafeInt(PropertyNameID.Emission2ndMap_UVMode, (int)propertyBlock.Emission2ndMap_UVMode);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.Emission2ndMainStrength, (int)propertyBlock.Emission2ndMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyNameID.Emission2ndBlend, propertyBlock.Emission2ndBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyNameID.Emission2ndBlendMask, propertyBlock.Emission2ndBlendMask);
            material.SetSafeVector(PropertyNameID.Emission2ndBlendMask_ScrollRotate, propertyBlock.Emission2ndBlendMask_ScrollRotate);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.Emission2ndBlendMode, (int)propertyBlock.Emission2ndBlendMode);  // v1.3.7
#endif
            material.SetSafeVector(PropertyNameID.Emission2ndBlink, propertyBlock.Emission2ndBlink);

            material.SetSafeBool(PropertyNameID.Emission2ndUseGrad, propertyBlock.Emission2ndUseGrad);
            material.SetSafeTexture(PropertyNameID.Emission2ndGradTex, propertyBlock.Emission2ndGradTex);
            material.SetSafeFloat(PropertyNameID.Emission2ndGradSpeed, propertyBlock.Emission2ndGradSpeed, null, null, 1.0f);

            material.SetSafeFloat(PropertyNameID.Emission2ndParallaxDepth, propertyBlock.Emission2ndParallaxDepth, null, null, 0.0f);
            material.SetSafeFloat(PropertyNameID.Emission2ndFluorescence, propertyBlock.Emission2ndFluorescence, 0.0f, 1.0f, 0.0f);

        }

        /// <summary>
        /// Set the lilToon Emission 2nd Gradation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEmission2ndGradationPropertyValues(Material material, ILilEmission2ndGradation propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.E2gci, propertyBlock.E2gci, null, null, 2);
            material.SetSafeInt(PropertyNameID.E2gai, propertyBlock.E2gai, null, null, 2);

            material.SetSafeColor(PropertyNameID.E2gc0, propertyBlock.E2gc0);
            material.SetSafeColor(PropertyNameID.E2gc1, propertyBlock.E2gc1);
            material.SetSafeColor(PropertyNameID.E2gc2, propertyBlock.E2gc2);
            material.SetSafeColor(PropertyNameID.E2gc3, propertyBlock.E2gc3);
            material.SetSafeColor(PropertyNameID.E2gc4, propertyBlock.E2gc4);
            material.SetSafeColor(PropertyNameID.E2gc5, propertyBlock.E2gc5);
            material.SetSafeColor(PropertyNameID.E2gc6, propertyBlock.E2gc6);
            material.SetSafeColor(PropertyNameID.E2gc7, propertyBlock.E2gc7);

            material.SetSafeColor(PropertyNameID.E2ga0, propertyBlock.E2ga0);
            material.SetSafeColor(PropertyNameID.E2ga1, propertyBlock.E2ga1);
            material.SetSafeColor(PropertyNameID.E2ga2, propertyBlock.E2ga2);
            material.SetSafeColor(PropertyNameID.E2ga3, propertyBlock.E2ga3);
            material.SetSafeColor(PropertyNameID.E2ga4, propertyBlock.E2ga4);
            material.SetSafeColor(PropertyNameID.E2ga5, propertyBlock.E2ga5);
            material.SetSafeColor(PropertyNameID.E2ga6, propertyBlock.E2ga6);
            material.SetSafeColor(PropertyNameID.E2ga7, propertyBlock.E2ga7);
        }

        #endregion

        #region Parallax

        /// <summary>
        /// Set the lilToon Parallax property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilParallaxPropertyValues(Material material, ILilParallax propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseParallax, propertyBlock.UseParallax);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.UsePOM, propertyBlock.UsePOM);  // v1.3.0
#endif
            material.SetSafeTexture(PropertyNameID.ParallaxMap, propertyBlock.ParallaxMap);
            material.SetSafeFloat(PropertyNameID.Parallax, propertyBlock.Parallax, null, null, 0.02f);
            material.SetSafeFloat(PropertyNameID.ParallaxOffset, propertyBlock.ParallaxOffset, null, null, 0.5f);
        }

        #endregion

        #region Distance

        /// <summary>
        /// Set the lilToon Distance Fade property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilDistanceFadePropertyValues(Material material, ILilDistanceFade propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeVector(PropertyNameID.DistanceFade, propertyBlock.DistanceFade);
            material.SetSafeColor(PropertyNameID.DistanceFadeColor, propertyBlock.DistanceFadeColor);
#if LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.DistanceFadeMode, (int)propertyBlock.DistanceFadeMode);       // v1.4.0
            material.SetSafeColor(PropertyNameID.DistanceFadeRimColor, propertyBlock.DistanceFadeRimColor);  // v1.4.0
            material.SetSafeFloat(PropertyNameID.DistanceFadeRimFresnelPower, propertyBlock.DistanceFadeRimFresnelPower);  // v1.4.0
#endif
        }

        #endregion

        #region Audio Link

        /// <summary>
        /// Set the lilToon Audio Link property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilAudioLinkPropertyValues(Material material, ILilAudioLink propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseAudioLink, propertyBlock.UseAudioLink);

            material.SetSafeVector(PropertyNameID.AudioLinkDefaultValue, propertyBlock.AudioLinkDefaultValue);
            material.SetSafeInt(PropertyNameID.AudioLinkUVMode, (int)propertyBlock.AudioLinkUVMode);
            material.SetSafeVector(PropertyNameID.AudioLinkUVParams, propertyBlock.AudioLinkUVParams);
            material.SetSafeVector(PropertyNameID.AudioLinkStart, propertyBlock.AudioLinkStart);
            material.SetSafeTexture(PropertyNameID.AudioLinkMask, propertyBlock.AudioLinkMask);
#if LILTOON_1_4_0_OR_NEWER
            material.SetSafeVector(PropertyNameID.AudioLinkMask_ScrollRotate, propertyBlock.AudioLinkMask_ScrollRotate);  // v1.4.0
            material.SetSafeInt(PropertyNameID.AudioLinkMask_UVMode, (int)propertyBlock.AudioLinkMask_UVMode);            // v1.4.0
#endif

            material.SetSafeBool(PropertyNameID.AudioLink2Main2nd, propertyBlock.AudioLink2Main2nd);
            material.SetSafeBool(PropertyNameID.AudioLink2Main3rd, propertyBlock.AudioLink2Main3rd);
            material.SetSafeBool(PropertyNameID.AudioLink2Emission, propertyBlock.AudioLink2Emission);
            material.SetSafeBool(PropertyNameID.AudioLink2EmissionGrad, propertyBlock.AudioLink2EmissionGrad);
            material.SetSafeBool(PropertyNameID.AudioLink2Emission2nd, propertyBlock.AudioLink2Emission2nd);
            material.SetSafeBool(PropertyNameID.AudioLink2Emission2ndGrad, propertyBlock.AudioLink2Emission2ndGrad);
            material.SetSafeBool(PropertyNameID.AudioLink2Vertex, propertyBlock.AudioLink2Vertex);

            material.SetSafeInt(PropertyNameID.AudioLinkVertexUVMode, (int)propertyBlock.AudioLinkVertexUVMode);
            material.SetSafeVector(PropertyNameID.AudioLinkVertexUVParams, propertyBlock.AudioLinkVertexUVParams);
            material.SetSafeVector(PropertyNameID.AudioLinkVertexStart, propertyBlock.AudioLinkVertexStart);
            material.SetSafeVector(PropertyNameID.AudioLinkVertexStrength, propertyBlock.AudioLinkVertexStrength);

            material.SetSafeBool(PropertyNameID.AudioLinkAsLocal, propertyBlock.AudioLinkAsLocal);
            material.SetSafeTexture(PropertyNameID.AudioLinkLocalMap, propertyBlock.AudioLinkLocalMap);
            material.SetSafeVector(PropertyNameID.AudioLinkLocalMapParams, propertyBlock.AudioLinkLocalMapParams);
        }

        #endregion

        #region Dissolve

        /// <summary>
        /// Set the lilToon Dissolve property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilDissolvePropertyValues(Material material, ILilDissolve propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeTexture(PropertyNameID.DissolveMask, propertyBlock.DissolveMask);
            material.SetSafeTexture(PropertyNameID.DissolveNoiseMask, propertyBlock.DissolveNoiseMask);
            material.SetSafeVector(PropertyNameID.DissolveNoiseMask_ScrollRotate, propertyBlock.DissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyNameID.DissolveNoiseStrength, propertyBlock.DissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyNameID.DissolveColor, propertyBlock.DissolveColor);
            material.SetSafeVector(PropertyNameID.DissolveParams, propertyBlock.DissolveParams);
            material.SetSafeVector(PropertyNameID.DissolvePos, propertyBlock.DissolvePos);
        }

        #endregion

        #region ID Mask

#if LILTOON_1_4_0_OR_NEWER
        /// <summary>
        /// Set the lilToon ID Mask property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilIDMaskPropertyValues(Material material, ILilIDMask propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.IDMaskFrom, (int)propertyBlock.IDMaskFrom);  // v1.4.0

            material.SetSafeBool(PropertyNameID.IDMask1, propertyBlock.IDMask1);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask2, propertyBlock.IDMask2);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask3, propertyBlock.IDMask3);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask4, propertyBlock.IDMask4);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask5, propertyBlock.IDMask5);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask6, propertyBlock.IDMask6);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask7, propertyBlock.IDMask7);  // v1.4.0
            material.SetSafeBool(PropertyNameID.IDMask8, propertyBlock.IDMask8);  // v1.4.0

            material.SetSafeInt(PropertyNameID.IDMaskIndex1, propertyBlock.IDMaskIndex1);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex2, propertyBlock.IDMaskIndex2);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex3, propertyBlock.IDMaskIndex3);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex4, propertyBlock.IDMaskIndex4);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex5, propertyBlock.IDMaskIndex5);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex6, propertyBlock.IDMaskIndex6);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex7, propertyBlock.IDMaskIndex7);  // v1.4.0
            material.SetSafeInt(PropertyNameID.IDMaskIndex8, propertyBlock.IDMaskIndex8);  // v1.4.0
        }
#endif
        #endregion

        #region Encryption

        /// <summary>
        /// Set the lilToon Encryption property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilEncryptionPropertyValues(Material material, ILilEncryption propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.IgnoreEncryption, propertyBlock.IgnoreEncryption);
            material.SetSafeVector(PropertyNameID.Keys, propertyBlock.Keys);

            material.SetSafeFloat(PropertyNameID.BitKey0, propertyBlock.BitKey0, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey1, propertyBlock.BitKey1, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey2, propertyBlock.BitKey2, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey3, propertyBlock.BitKey3, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey4, propertyBlock.BitKey4, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey5, propertyBlock.BitKey5, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey6, propertyBlock.BitKey6, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey7, propertyBlock.BitKey7, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey8, propertyBlock.BitKey8, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey9, propertyBlock.BitKey9, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey10, propertyBlock.BitKey10, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey11, propertyBlock.BitKey11, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey12, propertyBlock.BitKey12, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey13, propertyBlock.BitKey13, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey14, propertyBlock.BitKey14, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey15, propertyBlock.BitKey15, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey16, propertyBlock.BitKey16, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey17, propertyBlock.BitKey17, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey18, propertyBlock.BitKey18, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey19, propertyBlock.BitKey19, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey20, propertyBlock.BitKey20, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey21, propertyBlock.BitKey21, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey22, propertyBlock.BitKey22, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey23, propertyBlock.BitKey23, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey24, propertyBlock.BitKey24, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey25, propertyBlock.BitKey25, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey26, propertyBlock.BitKey26, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey27, propertyBlock.BitKey27, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey28, propertyBlock.BitKey28, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey29, propertyBlock.BitKey29, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey30, propertyBlock.BitKey30, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.BitKey31, propertyBlock.BitKey31, null, null, 0f);
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
        public virtual void SetLilRefractionPropertyValues(Material material, ILilRefraction propertyBlock, bool isRefraction = true, bool isGem = false)
        {
            if (propertyBlock is null)
            {
                return;
            }

            if (isRefraction || isGem)
            {
                material.SetSafeFloat(PropertyNameID.RefractionStrength, propertyBlock.RefractionStrength, -1.0f, 1.0f, 0.1f);
                material.SetSafeFloat(PropertyNameID.RefractionFresnelPower, propertyBlock.RefractionFresnelPower, 0.01f, 10.0f, 0.5f);
            }

            if (isRefraction)
            {
                material.SetSafeBool(PropertyNameID.RefractionColorFromMain, propertyBlock.RefractionColorFromMain);
                material.SetSafeColor(PropertyNameID.RefractionColor, propertyBlock.RefractionColor);
            }
        }

        #endregion

        #region Fur

        /// <summary>
        /// Set the lilToon Fur property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurPropertyValues(Material material, ILilFur propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeTexture(PropertyNameID.FurNoiseMask, propertyBlock.FurNoiseMask);
            material.SetSafeTexture(PropertyNameID.FurMask, propertyBlock.FurMask);
            material.SetSafeTexture(PropertyNameID.FurLengthMask, propertyBlock.FurLengthMask);
            material.SetSafeTexture(PropertyNameID.FurVectorTex, propertyBlock.FurVectorTex);
            material.SetSafeFloat(PropertyNameID.FurVectorScale, propertyBlock.FurVectorScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeVector(PropertyNameID.FurVector, propertyBlock.FurVector);
            material.SetSafeBool(PropertyNameID.VertexColor2FurVector, propertyBlock.VertexColor2FurVector);
            material.SetSafeFloat(PropertyNameID.FurGravity, propertyBlock.FurGravity, 0.0f, 1.0f, 0.25f);
            material.SetSafeFloat(PropertyNameID.FurRandomize, propertyBlock.FurRandomize, null, null, 0.0f);
            material.SetSafeFloat(PropertyNameID.FurAO, propertyBlock.FurAO, 0.0f, 1.0f, 0.0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeInt(PropertyNameID.FurMeshType, (int)propertyBlock.FurMeshType);  // v1.3.0
#endif
            material.SetSafeInt(PropertyNameID.FurLayerNum, propertyBlock.FurLayerNum, 1, 6, 2);
            material.SetSafeFloat(PropertyNameID.FurRootOffset, propertyBlock.FurRootOffset, -1.0f, 0.0f, 0.0f);
            material.SetSafeFloat(PropertyNameID.FurCutoutLength, propertyBlock.FurCutoutLength, null, null, 0.8f);
            material.SetSafeFloat(PropertyNameID.FurTouchStrength, propertyBlock.FurTouchStrength, 0.0f, 1.0f, 0.0f);
        }

        #endregion

        #region Fur (Rendering)

        /// <summary>
        /// Set the lilToon Fur Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingPropertyValues(Material material, ILilFurRendering propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.FurCull, (int)propertyBlock.FurCull);

            material.SetSafeBool(PropertyNameID.FurZClip, propertyBlock.FurZClip);
            material.SetSafeBool(PropertyNameID.FurZWrite, propertyBlock.FurZWrite);
            material.SetSafeInt(PropertyNameID.FurZTest, (int)propertyBlock.FurZTest);

            material.SetSafeFloat(PropertyNameID.FurOffsetFactor, propertyBlock.FurOffsetFactor, null, null, 0.0f);
            material.SetSafeFloat(PropertyNameID.FurOffsetUnits, propertyBlock.FurOffsetUnits, null, null, 0.0f);

            material.SetSafeInt(PropertyNameID.FurColorMask, propertyBlock.FurColorMask, null, null, 15);
            material.SetSafeBool(PropertyNameID.FurAlphaToMask, propertyBlock.FurAlphaToMask);
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingForwardPropertyValues(Material material, ILilFurRenderingForward propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.FurSrcBlend, (int)propertyBlock.FurSrcBlend);
            material.SetSafeInt(PropertyNameID.FurDstBlend, (int)propertyBlock.FurDstBlend);
            material.SetSafeInt(PropertyNameID.FurSrcBlendAlpha, (int)propertyBlock.FurSrcBlendAlpha);
            material.SetSafeInt(PropertyNameID.FurDstBlendAlpha, (int)propertyBlock.FurDstBlendAlpha);
            material.SetSafeInt(PropertyNameID.FurBlendOp, (int)propertyBlock.FurBlendOp);
            material.SetSafeInt(PropertyNameID.FurBlendOpAlpha, (int)propertyBlock.FurBlendOpAlpha);
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingForwardAddPropertyValues(Material material, ILilFurRenderingForwardAdd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.FurSrcBlendFA, (int)propertyBlock.FurSrcBlendFA);
            material.SetSafeInt(PropertyNameID.FurDstBlendFA, (int)propertyBlock.FurDstBlendFA);
            material.SetSafeInt(PropertyNameID.FurSrcBlendAlphaFA, (int)propertyBlock.FurSrcBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.FurDstBlendAlphaFA, (int)propertyBlock.FurDstBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.FurBlendOpFA, (int)propertyBlock.FurBlendOpFA);
            material.SetSafeInt(PropertyNameID.FurBlendOpAlphaFA, (int)propertyBlock.FurBlendOpAlphaFA);
        }

        /// <summary>
        /// Set the lilToon Fur Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilFurRenderingStencilPropertyValues(Material material, ILilFurRenderingStencil propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.FurStencilRef, propertyBlock.FurStencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyNameID.FurStencilReadMask, propertyBlock.FurStencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.FurStencilWriteMask, propertyBlock.FurStencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.FurStencilComp, (int)propertyBlock.FurStencilComp);
            material.SetSafeInt(PropertyNameID.FurStencilPass, (int)propertyBlock.FurStencilPass);
            material.SetSafeInt(PropertyNameID.FurStencilFail, (int)propertyBlock.FurStencilFail);
            material.SetSafeInt(PropertyNameID.FurStencilZFail, (int)propertyBlock.FurStencilZFail);
        }

        #endregion

        #region Gem

        /// <summary>
        /// Set the lilToon Gem property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilGemPropertyValues(Material material, ILilGem propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeFloat(PropertyNameID.GemChromaticAberration, propertyBlock.GemChromaticAberration, 0.0f, 1.0f, 0.02f);
            material.SetSafeFloat(PropertyNameID.GemEnvContrast, propertyBlock.GemEnvContrast, null, null, 2.0f);
            material.SetSafeColor(PropertyNameID.GemEnvColor, propertyBlock.GemEnvColor);
            material.SetSafeFloat(PropertyNameID.GemParticleLoop, propertyBlock.GemParticleLoop, null, null, 8);
            material.SetSafeColor(PropertyNameID.GemParticleColor, propertyBlock.GemParticleColor);
            material.SetSafeFloat(PropertyNameID.GemVRParallaxStrength, propertyBlock.GemVRParallaxStrength, 0.0f, 1.0f, 1.0f);
        }

        #endregion

        #region Tessellation

        /// <summary>
        /// Set the lilToon Tessellation property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilTessellationPropertyValues(Material material, ILilTessellation propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeFloat(PropertyNameID.TessEdge, propertyBlock.TessEdge, 0, 100, 0);
            material.SetSafeFloat(PropertyNameID.TessStrength, propertyBlock.TessStrength, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyNameID.TessShrink, propertyBlock.TessShrink, 0.0f, 1.0f, 0.0f);
            material.SetSafeInt(PropertyNameID.TessFactorMax, propertyBlock.TessFactorMax, 1, 8, 3);
        }

        #endregion

        #region Outline (Normal, Lite)

        /// <summary>
        /// Set the lilToon Outline property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlinePropertyValues(Material material, ILilOutline propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.OutlineColor, propertyBlock.OutlineColor);
            material.SetSafeTexture(PropertyNameID.OutlineTex, propertyBlock.OutlineTex);
            material.SetSafeVector(PropertyNameID.OutlineTex_ScrollRotate, propertyBlock.OutlineTex_ScrollRotate);
            material.SetSafeVector(PropertyNameID.OutlineTexHSVG, propertyBlock.OutlineTexHSVG);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeColor(PropertyNameID.OutlineLitColor, propertyBlock.OutlineLitColor);  // v1.3.0
            material.SetSafeBool(PropertyNameID.OutlineLitApplyTex, propertyBlock.OutlineLitApplyTex);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.OutlineLitScale, propertyBlock.OutlineLitScale, null, null, 10);  // v1.3.0
            material.SetSafeFloat(PropertyNameID.OutlineLitOffset, propertyBlock.OutlineLitOffset, null, null, -8);  // v1.3.0
            material.SetSafeBool(PropertyNameID.OutlineLitShadowReceive, propertyBlock.OutlineLitShadowReceive);  // v1.3.1
#endif
            material.SetSafeFloat(PropertyNameID.OutlineWidth, propertyBlock.OutlineWidth, 0.0f, 1.0f, 0.08f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0.0f, 1.0f, 0.5f);  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, null, null, 1);  // v1.2.12
#endif
            material.SetSafeTexture(PropertyNameID.OutlineWidthMask, propertyBlock.OutlineWidthMask);
            material.SetSafeInt(PropertyNameID.OutlineVertexR2Width, (int)propertyBlock.OutlineVertexR2Width);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.OutlineDeleteMesh, propertyBlock.OutlineDeleteMesh);  // v1.3.0
#endif
            material.SetSafeTexture(PropertyNameID.OutlineVectorTex, propertyBlock.OutlineVectorTex);
            material.SetSafeFloat(PropertyNameID.OutlineVectorScale, propertyBlock.OutlineVectorScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyNameID.OutlineEnableLighting, propertyBlock.OutlineEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.OutlineZBias, propertyBlock.OutlineZBias, null, null, 0);  // v1.3.0
            material.SetSafeBool(PropertyNameID.OutlineDisableInVR, propertyBlock.OutlineDisableInVR);  // v1.3.0
#endif
        }

        /// <summary>
        /// Set the lilToon Lite Outline property values to the material.
        /// </summary>
        /// <param name="material">A lilToon Lite material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilLiteOutlinePropertyValues(Material material, ILilLiteOutline propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.OutlineColor, propertyBlock.OutlineColor);
            material.SetSafeTexture(PropertyNameID.OutlineTex, propertyBlock.OutlineTex);
            material.SetSafeFloat(PropertyNameID.OutlineWidth, propertyBlock.OutlineWidth, 0.0f, 1.0f, 0.05f);
            material.SetSafeTexture(PropertyNameID.OutlineWidthMask, propertyBlock.OutlineWidthMask);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0.0f, 1.0f, 0.5f);  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyNameID.OutlineFixWidth, propertyBlock.OutlineFixWidth, null, null, 1);  // v1.2.12
#endif
            material.SetSafeInt(PropertyNameID.OutlineVertexR2Width, (int)propertyBlock.OutlineVertexR2Width);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeBool(PropertyNameID.OutlineDeleteMesh, propertyBlock.OutlineDeleteMesh);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyNameID.OutlineEnableLighting, propertyBlock.OutlineEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.OutlineZBias, propertyBlock.OutlineZBias, null, null, 0);  // v1.3.0
#endif
        }

        #endregion

        #region Outline (Rendering)

        /// <summary>
        /// Set the lilToon Outline Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingPropertyValues(Material material, ILilOutlineRendering propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.OutlineCull, (int)propertyBlock.OutlineCull);

            material.SetSafeBool(PropertyNameID.OutlineZClip, propertyBlock.OutlineZClip);
            material.SetSafeBool(PropertyNameID.OutlineZWrite, propertyBlock.OutlineZWrite);
            material.SetSafeInt(PropertyNameID.OutlineZTest, (int)propertyBlock.OutlineZTest);

            material.SetSafeFloat(PropertyNameID.OutlineOffsetFactor, propertyBlock.OutlineOffsetFactor, null, null, 0.0f);
            material.SetSafeFloat(PropertyNameID.OutlineOffsetUnits, propertyBlock.OutlineOffsetUnits, null, null, 0.0f);

            material.SetSafeInt(PropertyNameID.OutlineColorMask, propertyBlock.OutlineColorMask, null, null, 15);
            material.SetSafeBool(PropertyNameID.OutlineAlphaToMask, propertyBlock.OutlineAlphaToMask);
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingForwardPropertyValues(Material material, ILilOutlineRenderingForward propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.OutlineSrcBlend, (int)propertyBlock.OutlineSrcBlend);
            material.SetSafeInt(PropertyNameID.OutlineDstBlend, (int)propertyBlock.OutlineDstBlend);
            material.SetSafeInt(PropertyNameID.OutlineSrcBlendAlpha, (int)propertyBlock.OutlineSrcBlendAlpha);
            material.SetSafeInt(PropertyNameID.OutlineDstBlendAlpha, (int)propertyBlock.OutlineDstBlendAlpha);
            material.SetSafeInt(PropertyNameID.OutlineBlendOp, (int)propertyBlock.OutlineBlendOp);
            material.SetSafeInt(PropertyNameID.OutlineBlendOpAlpha, (int)propertyBlock.OutlineBlendOpAlpha);
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingForwardAddPropertyValues(Material material, ILilOutlineRenderingForwardAdd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.OutlineSrcBlendFA, (int)propertyBlock.OutlineSrcBlendFA);
            material.SetSafeInt(PropertyNameID.OutlineDstBlendFA, (int)propertyBlock.OutlineDstBlendFA);
            material.SetSafeInt(PropertyNameID.OutlineSrcBlendAlphaFA, (int)propertyBlock.OutlineSrcBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.OutlineDstBlendAlphaFA, (int)propertyBlock.OutlineDstBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.OutlineBlendOpFA, (int)propertyBlock.OutlineBlendOpFA);
            material.SetSafeInt(PropertyNameID.OutlineBlendOpAlphaFA, (int)propertyBlock.OutlineBlendOpAlphaFA);
        }

        /// <summary>
        /// Set the lilToon Outline Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilOutlineRenderingStencilPropertyValues(Material material, ILilOutlineRenderingStencil propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.OutlineStencilRef, propertyBlock.OutlineStencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyNameID.OutlineStencilReadMask, propertyBlock.OutlineStencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.OutlineStencilWriteMask, propertyBlock.OutlineStencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.OutlineStencilComp, (int)propertyBlock.OutlineStencilComp);
            material.SetSafeInt(PropertyNameID.OutlineStencilPass, (int)propertyBlock.OutlineStencilPass);
            material.SetSafeInt(PropertyNameID.OutlineStencilFail, (int)propertyBlock.OutlineStencilFail);
            material.SetSafeInt(PropertyNameID.OutlineStencilZFail, (int)propertyBlock.OutlineStencilZFail);
        }

        #endregion

        #region Multi

        /// <summary>
        /// Set the lilToon Multi Keywords to the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
        /// <param name="propertyBlock">A lilToon Normal propertyBlock.</param>
        public virtual void SetLilMultiKeywords(Material material, LilToonNormalPropertyEntity propertyBlock)
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
                material.SetKeyword(Keyword.GlossyReflectinsOff, false);
            }
            else
            {
                material.SetKeyword(Keyword.EffectHueVariation,
                    propertyBlock.Main != null &&
                    (propertyBlock.Main.MainTexHSVG != DefaultHSVG) ||
                    (propertyBlock.Main.MainGradationStrength != 0.0f)
                );
                material.SetKeyword(Keyword.ColorAddSubDiffOn, propertyBlock.Main2nd.UseMain2ndTex);
                material.SetKeyword(Keyword.ColorColorOn, propertyBlock.Main3rd.UseMain3rdTex);
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

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
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
                material.SetKeyword(Keyword.GlossyReflectinsOff, propertyBlock.Reflection != null && propertyBlock.Reflection.UseReflection);
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
#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
        /// <param name="propertyBlock">A lilToon Normal propertyBlock.</param>
        public virtual void SetLilMultiPasses(Material material, LilToonNormalPropertyEntity propertyBlock)
#elif LILTOON_1_2_12_OR_OLDER
        /// <param name="propertyBlock">A lilToon Multi propertyBlock.</param>
        public virtual void SetLilMultiPasses(Material material, LilToonMultiPropertyEntity propertyBlock)
#endif
        {
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
        public virtual void SetLilMultiPropertyValues(Material material, ILilMulti propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeBool(PropertyNameID.UseOutline, propertyBlock.UseOutline);
            material.SetSafeInt(PropertyNameID.TransparentMode, (int)propertyBlock.TransparentMode);

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            // v1.3.0 deleted
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeBool(PropertyNameID.UsePOM, propertyBlock.UsePOM);
#endif

            material.SetSafeBool(PropertyNameID.UseClippingCanceller, propertyBlock.UseClippingCanceller);
            material.SetSafeBool(PropertyNameID.AsOverlay, propertyBlock.AsOverlay);
        }

        #endregion

        #region Rendering

        /// <summary>
        /// Set the lilToon Rendering property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="isFakeShadow"></param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingPropertyValues(Material material, ILilRendering propertyBlock, bool isFakeShadow = false)
        {
            if (propertyBlock is null)
            {
                return;
            }

            if (isFakeShadow == false)
            {
                material.SetSafeFloat(PropertyNameID.Cutoff, propertyBlock.Cutoff, -0.001f, 1.001f, 0.5f);
                material.SetSafeFloat(PropertyNameID.SubpassCutoff, propertyBlock.SubpassCutoff, 0f, 1f, 0.5f);
            }

            material.SetSafeInt(PropertyNameID.Cull, (int)propertyBlock.Cull);

            material.SetSafeBool(PropertyNameID.ZClip, propertyBlock.ZClip);
            material.SetSafeBool(PropertyNameID.ZWrite, propertyBlock.ZWrite);
            material.SetSafeInt(PropertyNameID.ZTest, (int)propertyBlock.ZTest);

            material.SetSafeFloat(PropertyNameID.OffsetFactor, propertyBlock.OffsetFactor, null, null, 0f);
            material.SetSafeFloat(PropertyNameID.OffsetUnits, propertyBlock.OffsetUnits, null, null, 0f);

            material.SetSafeInt(PropertyNameID.ColorMask, propertyBlock.ColorMask, null, null, 15);
            material.SetSafeBool(PropertyNameID.AlphaToMask, propertyBlock.AlphaToMask);

#if LILTOON_1_3_0_OR_NEWER || LILTOON_1_4_0_OR_NEWER
            material.SetSafeFloat(PropertyNameID.LilShadowCasterBias, propertyBlock.LilShadowCasterBias, null, null, 0.0f);  // v1.3.0
#endif
        }

        /// <summary>
        /// Set the lilToon Rendering Forward property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingForwardPropertyValues(Material material, ILilRenderingForward propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.SrcBlend, (int)propertyBlock.SrcBlend);
            material.SetSafeInt(PropertyNameID.DstBlend, (int)propertyBlock.DstBlend);
            material.SetSafeInt(PropertyNameID.SrcBlendAlpha, (int)propertyBlock.SrcBlendAlpha);
            material.SetSafeInt(PropertyNameID.DstBlendAlpha, (int)propertyBlock.DstBlendAlpha);
            material.SetSafeInt(PropertyNameID.BlendOp, (int)propertyBlock.BlendOp);
            material.SetSafeInt(PropertyNameID.BlendOpAlpha, (int)propertyBlock.BlendOpAlpha);
        }

        /// <summary>
        /// Set the lilToon Rendering Forward Add property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingForwardAddPropertyValues(Material material, ILilRenderingForwardAdd propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.SrcBlendFA, (int)propertyBlock.SrcBlendFA);
            material.SetSafeInt(PropertyNameID.DstBlendFA, (int)propertyBlock.DstBlendFA);
            material.SetSafeInt(PropertyNameID.SrcBlendAlphaFA, (int)propertyBlock.SrcBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.DstBlendAlphaFA, (int)propertyBlock.DstBlendAlphaFA);
            material.SetSafeInt(PropertyNameID.BlendOpFA, (int)propertyBlock.BlendOpFA);
            material.SetSafeInt(PropertyNameID.BlendOpAlphaFA, (int)propertyBlock.BlendOpAlphaFA);
        }

        /// <summary>
        /// Set the lilToon Rendering Stencil property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilRenderingStencilPropertyValues(Material material, ILilRenderingStencil propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeInt(PropertyNameID.StencilRef, propertyBlock.StencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyNameID.StencilReadMask, propertyBlock.StencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.StencilWriteMask, propertyBlock.StencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyNameID.StencilComp, (int)propertyBlock.StencilComp);
            material.SetSafeInt(PropertyNameID.StencilPass, (int)propertyBlock.StencilPass);
            material.SetSafeInt(PropertyNameID.StencilFail, (int)propertyBlock.StencilFail);
            material.SetSafeInt(PropertyNameID.StencilZFail, (int)propertyBlock.StencilZFail);
        }

        #endregion

        #region Save

        /// <summary>
        /// Set the lilToon Save property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetLilSavePropertyValues(Material material, ILilSave propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            material.SetSafeColor(PropertyNameID.BaseColor, propertyBlock.BaseColor);
            material.SetSafeTexture(PropertyNameID.BaseMap, propertyBlock.BaseMap);
            material.SetSafeTexture(PropertyNameID.BaseColorMap, propertyBlock.BaseColorMap);

            material.SetSafeInt(PropertyNameID.LilToonVersion, propertyBlock.LilToonVersion);
        }

        #endregion

        #endregion
    }
}