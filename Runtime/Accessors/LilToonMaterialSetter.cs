// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonMaterialSetter
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER
#define LILTOON_1_3_0_OR_NEWER
#endif
namespace LilToonShader
{
    using System;
    using UnityEngine;
    using LilToonShader.Extensions;

#if LILTOON_1_3_0_OR_NEWER
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

            material.SetSafeBool(PropertyName.Invisible, propertyBlock.Invisible);
            material.SetSafeBool(PropertyName.FlipNormal, propertyBlock.FlipNormal);
            material.SetSafeBool(PropertyName.ShiftBackfaceUV, propertyBlock.ShiftBackfaceUV);
            material.SetSafeBool(PropertyName.BackfaceForceShadow, propertyBlock.BackfaceForceShadow);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeColor(PropertyName.BackfaceColor, propertyBlock.BackfaceColor);  // v1.3.0
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

            material.SetSafeBool(PropertyName.Invisible, propertyBlock.Invisible);
            material.SetSafeBool(PropertyName.FlipNormal, propertyBlock.FlipNormal);
            material.SetSafeBool(PropertyName.ShiftBackfaceUV, propertyBlock.ShiftBackfaceUV);
            material.SetSafeBool(PropertyName.BackfaceForceShadow, propertyBlock.BackfaceForceShadow);
            material.SetSafeTexture(PropertyName.TriMask, propertyBlock.TriMask);  // Lite only
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

            material.SetSafeBool(PropertyName.Invisible, propertyBlock.Invisible);
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

            material.SetSafeFloat(PropertyName.LightMinLimit, propertyBlock.LightMinLimit, 0f, 1f, 0.05f);
            material.SetSafeFloat(PropertyName.LightMaxLimit, propertyBlock.LightMaxLimit, 0f, 10f, 1f);
            material.SetSafeFloat(PropertyName.MonochromeLighting, propertyBlock.MonochromeLighting, 0f, 1f, 0f);
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

            material.SetSafeBool(PropertyName.AsUnlit, propertyBlock.AsUnlit);
            material.SetSafeFloat(PropertyName.VertexLightStrength, propertyBlock.VertexLightStrength, 0f, 1f, 0f);
            material.SetSafeVector(PropertyName.LightDirectionOverride, propertyBlock.LightDirectionOverride);
            material.SetSafeFloat(PropertyName.AlphaBoostFA, propertyBlock.AlphaBoostFA, 1f, 100f, 10f);
            material.SetSafeFloat(PropertyName.BeforeExposureLimit, propertyBlock.BeforeExposureLimit, null, null, 10000f);
            material.SetSafeFloat(PropertyName.LilDirectionalLightStrength, propertyBlock.LilDirectionalLightStrength, 0f, 1f, 1f);
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

            material.SetSafeColor(PropertyName.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyName.MainTex, propertyBlock.MainTex);

            material.SetSafeVector(PropertyName.FakeShadowVector, propertyBlock.FakeShadowVector);
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

            material.SetSafeColor(PropertyName.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyName.MainTex, propertyBlock.MainTex);
            material.SetSafeVector(PropertyName.MainTex_ScrollRotate, propertyBlock.MainTex_ScrollRotate);
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

            material.SetSafeColor(PropertyName.Color, propertyBlock.Color);
            material.SetSafeTexture(PropertyName.MainTex, propertyBlock.MainTex);
            material.SetSafeVector(PropertyName.MainTex_ScrollRotate, propertyBlock.MainTex_ScrollRotate);
            material.SetSafeVector(PropertyName.MainTexHSVG, propertyBlock.MainTexHSVG);
            material.SetSafeFloat(PropertyName.MainGradationStrength, propertyBlock.MainGradationStrength, 0f, 1f, 0f);
            material.SetSafeTexture(PropertyName.MainGradationTex, propertyBlock.MainGradationTex);
            material.SetSafeTexture(PropertyName.MainColorAdjustMask, propertyBlock.MainColorAdjustMask);
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

            material.SetSafeBool(PropertyName.UseMain2ndTex, propertyBlock.UseMain2ndTex);

            material.SetSafeColor(PropertyName.Color2nd, propertyBlock.Color2nd);
            material.SetSafeTexture(PropertyName.Main2ndTex, propertyBlock.Main2ndTex);
            material.SetSafeInt(PropertyName.Main2ndTex_UVMode, (int)propertyBlock.Main2ndTex_UVMode);
            material.SetSafeFloat(PropertyName.Main2ndTexAngle, propertyBlock.Main2ndTexAngle, null, null, 0f); ;
            material.SetSafeVector(PropertyName.Main2ndTexDecalAnimation, propertyBlock.Main2ndTexDecalAnimation);
            material.SetSafeVector(PropertyName.Main2ndTexDecalSubParam, propertyBlock.Main2ndTexDecalSubParam);
            material.SetSafeBool(PropertyName.Main2ndTexIsDecal, propertyBlock.Main2ndTexIsDecal);
            material.SetSafeBool(PropertyName.Main2ndTexIsLeftOnly, propertyBlock.Main2ndTexIsLeftOnly);
            material.SetSafeBool(PropertyName.Main2ndTexIsRightOnly, propertyBlock.Main2ndTexIsRightOnly);
            material.SetSafeBool(PropertyName.Main2ndTexShouldCopy, propertyBlock.Main2ndTexShouldCopy);
            material.SetSafeBool(PropertyName.Main2ndTexShouldFlipMirror, propertyBlock.Main2ndTexShouldFlipMirror);
            material.SetSafeBool(PropertyName.Main2ndTexShouldFlipCopy, propertyBlock.Main2ndTexShouldFlipCopy);
            material.SetSafeBool(PropertyName.Main2ndTexIsMSDF, propertyBlock.Main2ndTexIsMSDF);
            material.SetSafeTexture(PropertyName.Main2ndBlendMask, propertyBlock.Main2ndBlendMask);
            material.SetSafeInt(PropertyName.Main2ndTexBlendMode, (int)propertyBlock.Main2ndTexBlendMode);
            material.SetSafeBool(PropertyName.Main2ndEnableLighting, propertyBlock.Main2ndEnableLighting);

            material.SetSafeTexture(PropertyName.Main2ndDissolveMask, propertyBlock.Main2ndDissolveMask);
            material.SetSafeTexture(PropertyName.Main2ndDissolveNoiseMask, propertyBlock.Main2ndDissolveNoiseMask);
            material.SetSafeVector(PropertyName.Main2ndDissolveNoiseMask_ScrollRotate, propertyBlock.Main2ndDissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyName.Main2ndDissolveNoiseStrength, propertyBlock.Main2ndDissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyName.Main2ndDissolveColor, propertyBlock.Main2ndDissolveColor);
            material.SetSafeVector(PropertyName.Main2ndDissolveParams, propertyBlock.Main2ndDissolveParams);
            material.SetSafeVector(PropertyName.Main2ndDissolvePos, propertyBlock.Main2ndDissolvePos);
            material.SetSafeVector(PropertyName.Main2ndDistanceFade, propertyBlock.Main2ndDistanceFade);
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

            material.SetSafeBool(PropertyName.UseMain3rdTex, propertyBlock.UseMain3rdTex);

            material.SetSafeColor(PropertyName.Color3rd, propertyBlock.Color3rd);
            material.SetSafeTexture(PropertyName.Main3rdTex, propertyBlock.Main3rdTex);
            material.SetSafeInt(PropertyName.Main3rdTex_UVMode, (int)propertyBlock.Main3rdTex_UVMode);
            material.SetSafeFloat(PropertyName.Main3rdTexAngle, propertyBlock.Main3rdTexAngle, null, null, 0f); ;
            material.SetSafeVector(PropertyName.Main3rdTexDecalAnimation, propertyBlock.Main3rdTexDecalAnimation);
            material.SetSafeVector(PropertyName.Main3rdTexDecalSubParam, propertyBlock.Main3rdTexDecalSubParam);
            material.SetSafeBool(PropertyName.Main3rdTexIsDecal, propertyBlock.Main3rdTexIsDecal);
            material.SetSafeBool(PropertyName.Main3rdTexIsLeftOnly, propertyBlock.Main3rdTexIsLeftOnly);
            material.SetSafeBool(PropertyName.Main3rdTexIsRightOnly, propertyBlock.Main3rdTexIsRightOnly);
            material.SetSafeBool(PropertyName.Main3rdTexShouldCopy, propertyBlock.Main3rdTexShouldCopy);
            material.SetSafeBool(PropertyName.Main3rdTexShouldFlipMirror, propertyBlock.Main3rdTexShouldFlipMirror);
            material.SetSafeBool(PropertyName.Main3rdTexShouldFlipCopy, propertyBlock.Main3rdTexShouldFlipCopy);
            material.SetSafeBool(PropertyName.Main3rdTexIsMSDF, propertyBlock.Main3rdTexIsMSDF);
            material.SetSafeTexture(PropertyName.Main3rdBlendMask, propertyBlock.Main3rdBlendMask);
            material.SetSafeInt(PropertyName.Main3rdTexBlendMode, (int)propertyBlock.Main3rdTexBlendMode);
            material.SetSafeBool(PropertyName.Main3rdEnableLighting, propertyBlock.Main3rdEnableLighting);

            material.SetSafeTexture(PropertyName.Main3rdDissolveMask, propertyBlock.Main3rdDissolveMask);
            material.SetSafeTexture(PropertyName.Main3rdDissolveNoiseMask, propertyBlock.Main3rdDissolveNoiseMask);
            material.SetSafeVector(PropertyName.Main3rdDissolveNoiseMask_ScrollRotate, propertyBlock.Main3rdDissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyName.Main3rdDissolveNoiseStrength, propertyBlock.Main3rdDissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyName.Main3rdDissolveColor, propertyBlock.Main3rdDissolveColor);
            material.SetSafeVector(PropertyName.Main3rdDissolveParams, propertyBlock.Main3rdDissolveParams);
            material.SetSafeVector(PropertyName.Main3rdDissolvePos, propertyBlock.Main3rdDissolvePos);
            material.SetSafeVector(PropertyName.Main3rdDistanceFade, propertyBlock.Main3rdDistanceFade);
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

            material.SetSafeInt(PropertyName.AlphaMaskMode, (int)propertyBlock.AlphaMaskMode);
            material.SetSafeTexture(PropertyName.AlphaMask, propertyBlock.AlphaMask);
            material.SetSafeFloat(PropertyName.AlphaMaskScale, propertyBlock.AlphaMaskScale, null, null, 1.0f);
            material.SetSafeFloat(PropertyName.AlphaMaskValue, propertyBlock.AlphaMaskValue, null, null, 0.0f);
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

            material.SetSafeBool(PropertyName.UseBumpMap, propertyBlock.UseBumpMap);

            material.SetSafeTexture(PropertyName.BumpMap, propertyBlock.BumpMap);
            material.SetSafeFloat(PropertyName.BumpScale, propertyBlock.BumpScale, -10.0f, 10.0f, 1.0f);
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

            material.SetSafeBool(PropertyName.UseBump2ndMap, propertyBlock.UseBump2ndMap);

            material.SetSafeTexture(PropertyName.Bump2ndMap, propertyBlock.Bump2ndMap);
            material.SetSafeFloat(PropertyName.Bump2ndScale, propertyBlock.Bump2ndScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeTexture(PropertyName.Bump2ndScaleMask, propertyBlock.Bump2ndScaleMask);
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

            material.SetSafeBool(PropertyName.UseAnisotropy, propertyBlock.UseAnisotropy);

            material.SetSafeTexture(PropertyName.AnisotropyTangentMap, propertyBlock.AnisotropyTangentMap);
            material.SetSafeFloat(PropertyName.AnisotropyScale, propertyBlock.AnisotropyScale, -1.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.AnisotropyScaleMask, propertyBlock.AnisotropyScaleMask);

            material.SetSafeFloat(PropertyName.AnisotropyTangentWidth, propertyBlock.AnisotropyTangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyName.AnisotropyBitangentWidth, propertyBlock.AnisotropyBitangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyName.AnisotropyShift, propertyBlock.AnisotropyShift, -10.0f, 10.0f, 0.0f);
            material.SetSafeFloat(PropertyName.AnisotropyShiftNoiseScale, propertyBlock.AnisotropyShiftNoiseScale, -1.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyName.AnisotropySpecularStrength, propertyBlock.AnisotropySpecularStrength, 0.0f, 10.0f, 1.0f);

            material.SetSafeFloat(PropertyName.Anisotropy2ndTangentWidth, propertyBlock.Anisotropy2ndTangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyName.Anisotropy2ndBitangentWidth, propertyBlock.Anisotropy2ndBitangentWidth, 0.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyName.Anisotropy2ndShift, propertyBlock.Anisotropy2ndShift, -10.0f, 10.0f, 0.0f);
            material.SetSafeFloat(PropertyName.Anisotropy2ndShiftNoiseScale, propertyBlock.Anisotropy2ndShiftNoiseScale, -1.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyName.Anisotropy2ndSpecularStrength, propertyBlock.Anisotropy2ndSpecularStrength, 0.0f, 10.0f, 0.0f);

            material.SetSafeTexture(PropertyName.AnisotropyShiftNoiseMask, propertyBlock.AnisotropyShiftNoiseMask);
            material.SetSafeBool(PropertyName.Anisotropy2Reflection, propertyBlock.Anisotropy2Reflection);
            material.SetSafeBool(PropertyName.Anisotropy2MatCap, propertyBlock.Anisotropy2MatCap);
            material.SetSafeBool(PropertyName.Anisotropy2MatCap2nd, propertyBlock.Anisotropy2MatCap2nd);
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

            material.SetSafeBool(PropertyName.UseBacklight, propertyBlock.UseBacklight);

            material.SetSafeColor(PropertyName.BacklightColor, propertyBlock.BacklightColor);
            material.SetSafeTexture(PropertyName.BacklightColorTex, propertyBlock.BacklightColorTex);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.BacklightMainStrength, (int)propertyBlock.BacklightMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.BacklightNormalStrength, propertyBlock.BacklightNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.BacklightBorder, propertyBlock.BacklightBorder, 0.0f, 1.0f, 0.35f);
            material.SetSafeFloat(PropertyName.BacklightBlur, propertyBlock.BacklightBlur, 0.0f, 1.0f, 0.05f);
            material.SetSafeFloat(PropertyName.BacklightDirectivity, propertyBlock.BacklightDirectivity, null, null, 5.0f);
            material.SetSafeFloat(PropertyName.BacklightViewStrength, propertyBlock.BacklightViewStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyName.BacklightReceiveShadow, propertyBlock.BacklightReceiveShadow);
            material.SetSafeBool(PropertyName.BacklightBackfaceMask, propertyBlock.BacklightBackfaceMask);
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

            material.SetSafeBool(PropertyName.UseShadow, propertyBlock.UseShadow);
            material.SetSafeTexture(PropertyName.ShadowColorTex, propertyBlock.ShadowColorTex);
            material.SetSafeFloat(PropertyName.ShadowBorder, propertyBlock.ShadowBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.ShadowBlur, propertyBlock.ShadowBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeTexture(PropertyName.Shadow2ndColorTex, propertyBlock.Shadow2ndColorTex);
            material.SetSafeFloat(PropertyName.Shadow2ndBorder, propertyBlock.Shadow2ndBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.Shadow2ndBlur, propertyBlock.Shadow2ndBlur, 0.0f, 1.0f, 0.3f);
            material.SetSafeColor(PropertyName.ShadowBorderColor, propertyBlock.ShadowBorderColor);
            material.SetSafeFloat(PropertyName.ShadowBorderRange, propertyBlock.ShadowBorderRange, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyName.ShadowEnvStrength, propertyBlock.ShadowEnvStrength, 0.0f, 1.0f, 0.0f);
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

            material.SetSafeBool(PropertyName.UseShadow, propertyBlock.UseShadow);

            //material.SetSafeBool(PropertyName.ShadowReceive, propertyBlock.ShadowReceive);
            material.SetSafeFloat(PropertyName.ShadowStrength, propertyBlock.ShadowStrength, 0.0f, 1.0f, 0.0f);

            material.SetSafeTexture(PropertyName.ShadowStrengthMask, propertyBlock.ShadowStrengthMask);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.ShadowStrengthMaskLOD, propertyBlock.ShadowStrengthMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeTexture(PropertyName.ShadowBorderMask, propertyBlock.ShadowBorderMask);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.ShadowBorderMaskLOD, propertyBlock.ShadowBorderMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeTexture(PropertyName.ShadowBlurMask, propertyBlock.ShadowBlurMask);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.ShadowBlurMaskLOD, propertyBlock.ShadowBlurMaskLOD, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif

            material.SetSafeVector(PropertyName.ShadowAOShift, propertyBlock.ShadowAOShift);
            material.SetSafeVector(PropertyName.ShadowAOShift2, propertyBlock.ShadowAOShift2);
            material.SetSafeBool(PropertyName.ShadowPostAO, propertyBlock.ShadowPostAO);

            material.SetSafeColor(PropertyName.ShadowColor, propertyBlock.ShadowColor);
            material.SetSafeTexture(PropertyName.ShadowColorTex, propertyBlock.ShadowColorTex);
            material.SetSafeFloat(PropertyName.ShadowNormalStrength, propertyBlock.ShadowNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.ShadowBorder, propertyBlock.ShadowBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.ShadowBlur, propertyBlock.ShadowBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeBool(PropertyName.ShadowReceive, propertyBlock.ShadowReceive);

            material.SetSafeColor(PropertyName.Shadow2ndColor, propertyBlock.Shadow2ndColor);
            material.SetSafeTexture(PropertyName.Shadow2ndColorTex, propertyBlock.Shadow2ndColorTex);
            material.SetSafeFloat(PropertyName.Shadow2ndNormalStrength, propertyBlock.Shadow2ndNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.Shadow2ndBorder, propertyBlock.Shadow2ndBorder, 0.0f, 1.0f, 0.15f);
            material.SetSafeFloat(PropertyName.Shadow2ndBlur, propertyBlock.Shadow2ndBlur, 0.0f, 1.0f, 0.1f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeBool(PropertyName.Shadow2ndReceive, propertyBlock.Shadow2ndReceive);  // v1.3.0
#endif

            material.SetSafeColor(PropertyName.Shadow3rdColor, propertyBlock.Shadow3rdColor);
            material.SetSafeTexture(PropertyName.Shadow3rdColorTex, propertyBlock.Shadow3rdColorTex);
            material.SetSafeFloat(PropertyName.Shadow3rdNormalStrength, propertyBlock.Shadow3rdNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.Shadow3rdBorder, propertyBlock.Shadow3rdBorder, 0.0f, 1.0f, 0.25f);
            material.SetSafeFloat(PropertyName.Shadow3rdBlur, propertyBlock.Shadow3rdBlur, 0.0f, 1.0f, 0.1f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeBool(PropertyName.Shadow3rdReceive, propertyBlock.Shadow3rdReceive);  // v1.3.0
#endif

            material.SetSafeColor(PropertyName.ShadowBorderColor, propertyBlock.ShadowBorderColor);
            material.SetSafeFloat(PropertyName.ShadowBorderRange, propertyBlock.ShadowBorderRange, 0.0f, 1.0f, 0.08f);

            material.SetSafeFloat(PropertyName.ShadowMainStrength, propertyBlock.ShadowMainStrength, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyName.ShadowEnvStrength, propertyBlock.ShadowEnvStrength, 0.0f, 1.0f, 0.0f);

#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeInt(PropertyName.ShadowMaskType, (int)propertyBlock.ShadowMaskType);  // v1.3.0
            material.SetSafeFloat(PropertyName.ShadowFlatBorder, (int)propertyBlock.ShadowFlatBorder, -2.0f, 2.0f, 1.0f);  // v1.3.0
            material.SetSafeFloat(PropertyName.ShadowFlatBlur, (int)propertyBlock.ShadowFlatBlur, 0.001f, 2.0f, 1.0f);  // v1.3.0
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

            material.SetSafeBool(PropertyName.UseReflection, propertyBlock.UseReflection);

            material.SetSafeFloat(PropertyName.Smoothness, propertyBlock.Smoothness, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.SmoothnessTex, propertyBlock.SmoothnessTex);

            material.SetSafeFloat(PropertyName.Metallic, propertyBlock.Metallic, 0.0f, 1.0f, 0.0f);
            material.SetSafeTexture(PropertyName.MetallicGlossMap, propertyBlock.MetallicGlossMap);

            material.SetSafeFloat(PropertyName.Reflectance, propertyBlock.Reflectance, 0.0f, 1.0f, 0.04f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.GSAAStrength, propertyBlock.GSAAStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeBool(PropertyName.ApplySpecular, propertyBlock.ApplySpecular);
            material.SetSafeBool(PropertyName.ApplySpecularFA, propertyBlock.ApplySpecularFA);
            material.SetSafeBool(PropertyName.SpecularToon, propertyBlock.SpecularToon);
            material.SetSafeFloat(PropertyName.SpecularNormalStrength, propertyBlock.SpecularNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.SpecularBorder, propertyBlock.SpecularBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.SpecularBlur, propertyBlock.SpecularBlur, 0.0f, 1.0f, 0.0f);

            material.SetSafeBool(PropertyName.ApplyReflection, propertyBlock.ApplyReflection);
            material.SetSafeFloat(PropertyName.ReflectionNormalStrength, propertyBlock.ReflectionNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeColor(PropertyName.ReflectionColor, propertyBlock.ReflectionColor);
            material.SetSafeTexture(PropertyName.ReflectionColorTex, propertyBlock.ReflectionColorTex);

            material.SetSafeBool(PropertyName.ReflectionApplyTransparency, propertyBlock.ReflectionApplyTransparency);
            material.SetSafeTexture(PropertyName.ReflectionCubeTex, propertyBlock.ReflectionCubeTex);
            material.SetSafeColor(PropertyName.ReflectionCubeColor, propertyBlock.ReflectionCubeColor);
            material.SetSafeBool(PropertyName.ReflectionCubeOverride, propertyBlock.ReflectionCubeOverride);
            material.SetSafeFloat(PropertyName.ReflectionCubeEnableLighting, propertyBlock.ReflectionCubeEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeInt(PropertyName.ReflectionBlendMode, (int)propertyBlock.ReflectionBlendMode, null, null, (int)LilBlendMode.Add);  // v1.3.0
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

            material.SetSafeBool(PropertyName.UseMatCap, propertyBlock.UseMatCap);
            material.SetSafeTexture(PropertyName.MatCapTex, propertyBlock.MatCapTex);
            material.SetSafeVector(PropertyName.MatCapBlendUV1, propertyBlock.MatCapBlendUV1);
            material.SetSafeBool(PropertyName.MatCapZRotCancel, propertyBlock.MatCapZRotCancel);
            material.SetSafeBool(PropertyName.MatCapPerspective, propertyBlock.MatCapPerspective);
            material.SetSafeBool(PropertyName.MatCapBlend, propertyBlock.MatCapMul);  // Lite only
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

            material.SetSafeBool(PropertyName.UseMatCap, propertyBlock.UseMatCap);

            material.SetSafeColor(PropertyName.MatCapColor, propertyBlock.MatCapColor);
            material.SetSafeTexture(PropertyName.MatCapTex, propertyBlock.MatCapTex);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.MatCapMainStrength, propertyBlock.MatCapMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeVector(PropertyName.MatCapBlendUV1, propertyBlock.MatCapBlendUV1);
            material.SetSafeBool(PropertyName.MatCapZRotCancel, propertyBlock.MatCapZRotCancel);
            material.SetSafeBool(PropertyName.MatCapPerspective, propertyBlock.MatCapPerspective);
            material.SetSafeFloat(PropertyName.MatCapVRParallaxStrength, propertyBlock.MatCapVRParallaxStrength, 0.0f, 1.0f, 1.0f);

            material.SetSafeFloat(PropertyName.MatCapBlend, propertyBlock.MatCapBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.MatCapBlendMask, propertyBlock.MatCapBlendMask);

            material.SetSafeFloat(PropertyName.MatCapEnableLighting, propertyBlock.MatCapEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.MatCapShadowMask, propertyBlock.MatCapShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyName.MatCapBackfaceMask, propertyBlock.MatCapBackfaceMask);
            material.SetSafeFloat(PropertyName.MatCapLod, propertyBlock.MatCapLod, 0.0f, 10.0f, 0.0f);
            material.SetSafeInt(PropertyName.MatCapBlendMode, (int)propertyBlock.MatCapBlendMode);
            material.SetSafeBool(PropertyName.MatCapApplyTransparency, propertyBlock.MatCapApplyTransparency);

            material.SetSafeFloat(PropertyName.MatCapNormalStrength, propertyBlock.MatCapNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyName.MatCapCustomNormal, propertyBlock.MatCapCustomNormal);
            material.SetSafeTexture(PropertyName.MatCapBumpMap, propertyBlock.MatCapBumpMap);
            material.SetSafeFloat(PropertyName.MatCapBumpScale, propertyBlock.MatCapBumpScale, -10.0f, 10.0f, 1.0f);
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

            material.SetSafeBool(PropertyName.UseMatCap2nd, propertyBlock.UseMatCap2nd);

            material.SetSafeColor(PropertyName.MatCap2ndColor, propertyBlock.MatCap2ndColor);
            material.SetSafeTexture(PropertyName.MatCap2ndTex, propertyBlock.MatCap2ndTex);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.MatCap2ndMainStrength, propertyBlock.MatCap2ndMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeVector(PropertyName.MatCap2ndBlendUV1, propertyBlock.MatCap2ndBlendUV1);
            material.SetSafeBool(PropertyName.MatCap2ndZRotCancel, propertyBlock.MatCap2ndZRotCancel);
            material.SetSafeBool(PropertyName.MatCap2ndPerspective, propertyBlock.MatCap2ndPerspective);
            material.SetSafeFloat(PropertyName.MatCap2ndVRParallaxStrength, propertyBlock.MatCap2ndVRParallaxStrength, 0.0f, 1.0f, 1.0f);

            material.SetSafeFloat(PropertyName.MatCap2ndBlend, propertyBlock.MatCap2ndBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.MatCap2ndBlendMask, propertyBlock.MatCap2ndBlendMask);

            material.SetSafeFloat(PropertyName.MatCap2ndEnableLighting, propertyBlock.MatCap2ndEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.MatCap2ndShadowMask, propertyBlock.MatCap2ndShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyName.MatCap2ndBackfaceMask, propertyBlock.MatCap2ndBackfaceMask);
            material.SetSafeFloat(PropertyName.MatCap2ndLod, propertyBlock.MatCap2ndLod, 0.0f, 10.0f, 0.0f);
            material.SetSafeInt(PropertyName.MatCap2ndBlendMode, (int)propertyBlock.MatCap2ndBlendMode);
            material.SetSafeBool(PropertyName.MatCap2ndApplyTransparency, propertyBlock.MatCap2ndApplyTransparency);

            material.SetSafeFloat(PropertyName.MatCap2ndNormalStrength, propertyBlock.MatCap2ndNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyName.MatCap2ndCustomNormal, propertyBlock.MatCap2ndCustomNormal);
            material.SetSafeTexture(PropertyName.MatCap2ndBumpMap, propertyBlock.MatCap2ndBumpMap);
            material.SetSafeFloat(PropertyName.MatCap2ndBumpScale, propertyBlock.MatCap2ndBumpScale, -10.0f, 10.0f, 1.0f);
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

            material.SetSafeBool(PropertyName.UseRim, propertyBlock.UseRim);
            material.SetSafeColor(PropertyName.RimColor, propertyBlock.RimColor);
            material.SetSafeFloat(PropertyName.RimBorder, propertyBlock.RimBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.RimBlur, propertyBlock.RimBlur, 0.0f, 1.0f, 0.1f);
            material.SetSafeFloat(PropertyName.RimFresnelPower, propertyBlock.RimFresnelPower, 0.01f, 50.0f, 3.0f);
            material.SetSafeFloat(PropertyName.RimShadowMask, propertyBlock.RimShadowMask, 0.0f, 1.0f, 0.0f);
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

            material.SetSafeBool(PropertyName.UseRim, propertyBlock.UseRim);

            material.SetSafeColor(PropertyName.RimColor, propertyBlock.RimColor);
            material.SetSafeTexture(PropertyName.RimColorTex, propertyBlock.RimColorTex);

            material.SetSafeFloat(PropertyName.RimMainStrength, propertyBlock.RimNormalStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
            material.SetSafeFloat(PropertyName.RimNormalStrength, propertyBlock.RimNormalStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.RimBorder, propertyBlock.RimBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.RimBlur, propertyBlock.RimBlur, 0.0f, 1.0f, 0.65f);
            material.SetSafeFloat(PropertyName.RimFresnelPower, propertyBlock.RimFresnelPower, 0.01f, 50.0f, 3.5f);
            material.SetSafeFloat(PropertyName.RimEnableLighting, propertyBlock.RimEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.RimShadowMask, propertyBlock.RimShadowMask, 0.0f, 1.0f, 0.5f);
            material.SetSafeBool(PropertyName.RimBackfaceMask, propertyBlock.RimBackfaceMask);
            material.SetSafeFloat(PropertyName.RimVRParallaxStrength, propertyBlock.RimVRParallaxStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeBool(PropertyName.RimApplyTransparency, propertyBlock.RimApplyTransparency);

            material.SetSafeFloat(PropertyName.RimDirStrength, propertyBlock.RimDirStrength, 0.0f, 1.0f, 0.0f);
            material.SetSafeFloat(PropertyName.RimDirRange, propertyBlock.RimDirRange, -1.0f, 1.0f, 0.0f);

            material.SetSafeFloat(PropertyName.RimIndirRange, propertyBlock.RimIndirRange, -1.0f, 1.0f, 0.0f);
            material.SetSafeColor(PropertyName.RimIndirColor, propertyBlock.RimIndirColor);
            material.SetSafeFloat(PropertyName.RimIndirBorder, propertyBlock.RimIndirBorder, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.RimIndirBlur, propertyBlock.RimIndirBlur, 0.0f, 1.0f, 0.1f);
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

            material.SetSafeBool(PropertyName.UseGlitter, propertyBlock.UseGlitter);

            material.SetSafeInt(PropertyName.GlitterUVMode, (int)propertyBlock.GlitterUVMode);
            material.SetSafeColor(PropertyName.GlitterColor, propertyBlock.GlitterColor);
            material.SetSafeTexture(PropertyName.GlitterColorTex, propertyBlock.GlitterColorTex);
            material.SetSafeFloat(PropertyName.GlitterMainStrength, propertyBlock.GlitterMainStrength, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.GlitterNormalStrength, propertyBlock.GlitterNormalStrength, 0.0f, 1.0f, 1.0f);

#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.GlitterScaleRandomize, propertyBlock.GlitterScaleRandomize, 0.0f, 1.0f, 0.0f);  // v1.3.0
            material.SetSafeBool(PropertyName.GlitterApplyShape, propertyBlock.GlitterApplyShape);  // v1.3.0
            material.SetSafeTexture(PropertyName.GlitterShapeTex, propertyBlock.GlitterShapeTex);  // v1.3.0
            material.SetSafeVector(PropertyName.GlitterAtras, propertyBlock.GlitterAtras);  // v1.3.0
            material.SetSafeBool(PropertyName.GlitterAngleRandomize, propertyBlock.GlitterAngleRandomize);  // v1.3.0
#endif

            material.SetSafeVector(PropertyName.GlitterParams1, propertyBlock.GlitterParams1);
            material.SetSafeVector(PropertyName.GlitterParams2, propertyBlock.GlitterParams2);
            material.SetSafeFloat(PropertyName.GlitterPostContrast, propertyBlock.GlitterPostContrast, null, null, 1.0f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.GlitterSensitivity, propertyBlock.GlitterSensitivity, null, null, 0.25f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.GlitterEnableLighting, propertyBlock.GlitterEnableLighting, 0.0f, 1.0f, 1.0f);
            material.SetSafeFloat(PropertyName.GlitterShadowMask, propertyBlock.GlitterShadowMask, 0.0f, 1.0f, 0.0f);
            material.SetSafeBool(PropertyName.GlitterBackfaceMask, propertyBlock.GlitterBackfaceMask);
            material.SetSafeBool(PropertyName.GlitterApplyTransparency, propertyBlock.GlitterApplyTransparency);
            material.SetSafeFloat(PropertyName.GlitterVRParallaxStrength, propertyBlock.GlitterVRParallaxStrength, 0.0f, 1.0f, 0.0f);
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

            material.SetSafeBool(PropertyName.UseEmission, propertyBlock.UseEmission);
            material.SetSafeColor(PropertyName.EmissionColor, propertyBlock.EmissionColor);
            material.SetSafeTexture(PropertyName.EmissionMap, propertyBlock.EmissionMap);
            material.SetSafeVector(PropertyName.EmissionMap_ScrollRotate, propertyBlock.EmissionMap_ScrollRotate);
            material.SetSafeFloat(PropertyName.EmissionMap_UVMode, (int)propertyBlock.EmissionMap_UVMode);
            material.SetSafeVector(PropertyName.EmissionBlink, propertyBlock.EmissionBlink);
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

            material.SetSafeBool(PropertyName.UseEmission, propertyBlock.UseEmission);

            material.SetSafeColor(PropertyName.EmissionColor, propertyBlock.EmissionColor);
            material.SetSafeTexture(PropertyName.EmissionMap, propertyBlock.EmissionMap);
            material.SetSafeVector(PropertyName.EmissionMap_ScrollRotate, propertyBlock.EmissionMap_ScrollRotate);
            material.SetSafeInt(PropertyName.EmissionMap_UVMode, (int)propertyBlock.EmissionMap_UVMode);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.EmissionMainStrength, (int)propertyBlock.EmissionMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.EmissionBlend, propertyBlock.EmissionBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.EmissionBlendMask, propertyBlock.EmissionBlendMask);
            material.SetSafeVector(PropertyName.EmissionBlendMask_ScrollRotate, propertyBlock.EmissionBlendMask_ScrollRotate);
            material.SetSafeVector(PropertyName.EmissionBlink, propertyBlock.EmissionBlink);

            material.SetSafeBool(PropertyName.EmissionUseGrad, propertyBlock.EmissionUseGrad);
            material.SetSafeTexture(PropertyName.EmissionGradTex, propertyBlock.EmissionGradTex);
            material.SetSafeFloat(PropertyName.EmissionGradSpeed, propertyBlock.EmissionGradSpeed, null, null, 1.0f);

            material.SetSafeFloat(PropertyName.EmissionParallaxDepth, propertyBlock.EmissionParallaxDepth, null, null, 0.0f);
            material.SetSafeFloat(PropertyName.EmissionFluorescence, propertyBlock.EmissionFluorescence, 0.0f, 1.0f, 0.0f);
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

            material.SetSafeInt(PropertyName.Egci, propertyBlock.Egci, null, null, 2);
            material.SetSafeInt(PropertyName.Egai, propertyBlock.Egai, null, null, 2);

            material.SetSafeColor(PropertyName.Egc0, propertyBlock.Egc0);
            material.SetSafeColor(PropertyName.Egc1, propertyBlock.Egc1);
            material.SetSafeColor(PropertyName.Egc2, propertyBlock.Egc2);
            material.SetSafeColor(PropertyName.Egc3, propertyBlock.Egc3);
            material.SetSafeColor(PropertyName.Egc4, propertyBlock.Egc4);
            material.SetSafeColor(PropertyName.Egc5, propertyBlock.Egc5);
            material.SetSafeColor(PropertyName.Egc6, propertyBlock.Egc6);
            material.SetSafeColor(PropertyName.Egc7, propertyBlock.Egc7);

            material.SetSafeColor(PropertyName.Ega0, propertyBlock.Ega0);
            material.SetSafeColor(PropertyName.Ega1, propertyBlock.Ega1);
            material.SetSafeColor(PropertyName.Ega2, propertyBlock.Ega2);
            material.SetSafeColor(PropertyName.Ega3, propertyBlock.Ega3);
            material.SetSafeColor(PropertyName.Ega4, propertyBlock.Ega4);
            material.SetSafeColor(PropertyName.Ega5, propertyBlock.Ega5);
            material.SetSafeColor(PropertyName.Ega6, propertyBlock.Ega6);
            material.SetSafeColor(PropertyName.Ega7, propertyBlock.Ega7);
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

            material.SetSafeBool(PropertyName.UseEmission2nd, propertyBlock.UseEmission2nd);

            material.SetSafeColor(PropertyName.Emission2ndColor, propertyBlock.Emission2ndColor);
            material.SetSafeTexture(PropertyName.Emission2ndMap, propertyBlock.Emission2ndMap);
            material.SetSafeVector(PropertyName.Emission2ndMap_ScrollRotate, propertyBlock.Emission2ndMap_ScrollRotate);
            material.SetSafeInt(PropertyName.Emission2ndMap_UVMode, (int)propertyBlock.Emission2ndMap_UVMode);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.Emission2ndMainStrength, (int)propertyBlock.Emission2ndMainStrength, 0.0f, 1.0f, 0.0f);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.Emission2ndBlend, propertyBlock.Emission2ndBlend, 0.0f, 1.0f, 1.0f);
            material.SetSafeTexture(PropertyName.Emission2ndBlendMask, propertyBlock.Emission2ndBlendMask);
            material.SetSafeVector(PropertyName.Emission2ndBlendMask_ScrollRotate, propertyBlock.Emission2ndBlendMask_ScrollRotate);
            material.SetSafeVector(PropertyName.Emission2ndBlink, propertyBlock.Emission2ndBlink);

            material.SetSafeBool(PropertyName.Emission2ndUseGrad, propertyBlock.Emission2ndUseGrad);
            material.SetSafeTexture(PropertyName.Emission2ndGradTex, propertyBlock.Emission2ndGradTex);
            material.SetSafeFloat(PropertyName.Emission2ndGradSpeed, propertyBlock.Emission2ndGradSpeed, null, null, 1.0f);

            material.SetSafeFloat(PropertyName.Emission2ndParallaxDepth, propertyBlock.Emission2ndParallaxDepth, null, null, 0.0f);
            material.SetSafeFloat(PropertyName.Emission2ndFluorescence, propertyBlock.Emission2ndFluorescence, 0.0f, 1.0f, 0.0f);

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

            material.SetSafeInt(PropertyName.E2gci, propertyBlock.E2gci, null, null, 2);
            material.SetSafeInt(PropertyName.E2gai, propertyBlock.E2gai, null, null, 2);

            material.SetSafeColor(PropertyName.E2gc0, propertyBlock.E2gc0);
            material.SetSafeColor(PropertyName.E2gc1, propertyBlock.E2gc1);
            material.SetSafeColor(PropertyName.E2gc2, propertyBlock.E2gc2);
            material.SetSafeColor(PropertyName.E2gc3, propertyBlock.E2gc3);
            material.SetSafeColor(PropertyName.E2gc4, propertyBlock.E2gc4);
            material.SetSafeColor(PropertyName.E2gc5, propertyBlock.E2gc5);
            material.SetSafeColor(PropertyName.E2gc6, propertyBlock.E2gc6);
            material.SetSafeColor(PropertyName.E2gc7, propertyBlock.E2gc7);

            material.SetSafeColor(PropertyName.E2ga0, propertyBlock.E2ga0);
            material.SetSafeColor(PropertyName.E2ga1, propertyBlock.E2ga1);
            material.SetSafeColor(PropertyName.E2ga2, propertyBlock.E2ga2);
            material.SetSafeColor(PropertyName.E2ga3, propertyBlock.E2ga3);
            material.SetSafeColor(PropertyName.E2ga4, propertyBlock.E2ga4);
            material.SetSafeColor(PropertyName.E2ga5, propertyBlock.E2ga5);
            material.SetSafeColor(PropertyName.E2ga6, propertyBlock.E2ga6);
            material.SetSafeColor(PropertyName.E2ga7, propertyBlock.E2ga7);
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

            material.SetSafeBool(PropertyName.UseParallax, propertyBlock.UseParallax);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeBool(PropertyName.UsePOM, propertyBlock.UsePOM);  // v1.3.0
#endif
            material.SetSafeTexture(PropertyName.ParallaxMap, propertyBlock.ParallaxMap);
            material.SetSafeFloat(PropertyName.Parallax, propertyBlock.Parallax, null, null, 0.02f);
            material.SetSafeFloat(PropertyName.ParallaxOffset, propertyBlock.ParallaxOffset, null, null, 0.5f);
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

            material.SetSafeVector(PropertyName.DistanceFade, propertyBlock.DistanceFade);
            material.SetSafeColor(PropertyName.DistanceFadeColor, propertyBlock.DistanceFadeColor);
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

            material.SetSafeBool(PropertyName.UseAudioLink, propertyBlock.UseAudioLink);

            material.SetSafeVector(PropertyName.AudioLinkDefaultValue, propertyBlock.AudioLinkDefaultValue);
            material.SetSafeInt(PropertyName.AudioLinkUVMode, (int)propertyBlock.AudioLinkUVMode);
            material.SetSafeVector(PropertyName.AudioLinkUVParams, propertyBlock.AudioLinkUVParams);
            material.SetSafeVector(PropertyName.AudioLinkStart, propertyBlock.AudioLinkStart);
            material.SetSafeTexture(PropertyName.AudioLinkMask, propertyBlock.AudioLinkMask);

            material.SetSafeBool(PropertyName.AudioLink2Main2nd, propertyBlock.AudioLink2Main2nd);
            material.SetSafeBool(PropertyName.AudioLink2Main3rd, propertyBlock.AudioLink2Main3rd);
            material.SetSafeBool(PropertyName.AudioLink2Emission, propertyBlock.AudioLink2Emission);
            material.SetSafeBool(PropertyName.AudioLink2EmissionGrad, propertyBlock.AudioLink2EmissionGrad);
            material.SetSafeBool(PropertyName.AudioLink2Emission2nd, propertyBlock.AudioLink2Emission2nd);
            material.SetSafeBool(PropertyName.AudioLink2Emission2ndGrad, propertyBlock.AudioLink2Emission2ndGrad);
            material.SetSafeBool(PropertyName.AudioLink2Vertex, propertyBlock.AudioLink2Vertex);

            material.SetSafeInt(PropertyName.AudioLinkVertexUVMode, (int)propertyBlock.AudioLinkVertexUVMode);
            material.SetSafeVector(PropertyName.AudioLinkVertexUVParams, propertyBlock.AudioLinkVertexUVParams);
            material.SetSafeVector(PropertyName.AudioLinkVertexStart, propertyBlock.AudioLinkVertexStart);
            material.SetSafeVector(PropertyName.AudioLinkVertexStrength, propertyBlock.AudioLinkVertexStrength);

            material.SetSafeBool(PropertyName.AudioLinkAsLocal, propertyBlock.AudioLinkAsLocal);
            material.SetSafeTexture(PropertyName.AudioLinkLocalMap, propertyBlock.AudioLinkLocalMap);
            material.SetSafeVector(PropertyName.AudioLinkLocalMapParams, propertyBlock.AudioLinkLocalMapParams);
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

            material.SetSafeTexture(PropertyName.DissolveMask, propertyBlock.DissolveMask);
            material.SetSafeTexture(PropertyName.DissolveNoiseMask, propertyBlock.DissolveNoiseMask);
            material.SetSafeVector(PropertyName.DissolveNoiseMask_ScrollRotate, propertyBlock.DissolveNoiseMask_ScrollRotate);
            material.SetSafeFloat(PropertyName.DissolveNoiseStrength, propertyBlock.DissolveNoiseStrength, null, null, 0.1f);
            material.SetSafeColor(PropertyName.DissolveColor, propertyBlock.DissolveColor);
            material.SetSafeVector(PropertyName.DissolveParams, propertyBlock.DissolveParams);
            material.SetSafeVector(PropertyName.DissolvePos, propertyBlock.DissolvePos);
        }

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

            material.SetSafeBool(PropertyName.IgnoreEncryption, propertyBlock.IgnoreEncryption);
            material.SetSafeVector(PropertyName.Keys, propertyBlock.Keys);
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
                material.SetSafeFloat(PropertyName.RefractionStrength, propertyBlock.RefractionStrength, -1.0f, 1.0f, 0.1f);
                material.SetSafeFloat(PropertyName.RefractionFresnelPower, propertyBlock.RefractionFresnelPower, 0.01f, 10.0f, 0.5f);
            }

            if (isRefraction)
            {
                material.SetSafeBool(PropertyName.RefractionColorFromMain, propertyBlock.RefractionColorFromMain);
                material.SetSafeColor(PropertyName.RefractionColor, propertyBlock.RefractionColor);
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

            material.SetSafeTexture(PropertyName.FurNoiseMask, propertyBlock.FurNoiseMask);
            material.SetSafeTexture(PropertyName.FurMask, propertyBlock.FurMask);
            material.SetSafeTexture(PropertyName.FurLengthMask, propertyBlock.FurLengthMask);
            material.SetSafeTexture(PropertyName.FurVectorTex, propertyBlock.FurVectorTex);
            material.SetSafeFloat(PropertyName.FurVectorScale, propertyBlock.FurVectorScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeVector(PropertyName.FurVector, propertyBlock.FurVector);
            material.SetSafeBool(PropertyName.VertexColor2FurVector, propertyBlock.VertexColor2FurVector);
            material.SetSafeFloat(PropertyName.FurGravity, propertyBlock.FurGravity, 0.0f, 1.0f, 0.25f);
            material.SetSafeFloat(PropertyName.FurRandomize, propertyBlock.FurRandomize, null, null, 0.0f);
            material.SetSafeFloat(PropertyName.FurAO, propertyBlock.FurAO, 0.0f, 1.0f, 0.0f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeInt(PropertyName.FurMeshType, (int)propertyBlock.FurMeshType);  // v1.3.0
#endif
            material.SetSafeInt(PropertyName.FurLayerNum, propertyBlock.FurLayerNum, 1, 6, 2);
            material.SetSafeFloat(PropertyName.FurRootOffset, propertyBlock.FurRootOffset, -1.0f, 0.0f, 0.0f);
            material.SetSafeFloat(PropertyName.FurCutoutLength, propertyBlock.FurCutoutLength, null, null, 0.8f);
            material.SetSafeFloat(PropertyName.FurTouchStrength, propertyBlock.FurTouchStrength, 0.0f, 1.0f, 0.0f);
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

            material.SetSafeInt(PropertyName.FurCull, (int)propertyBlock.FurCull);

            material.SetSafeBool(PropertyName.FurZClip, propertyBlock.FurZClip);
            material.SetSafeBool(PropertyName.FurZWrite, propertyBlock.FurZWrite);
            material.SetSafeInt(PropertyName.FurZTest, (int)propertyBlock.FurZTest);

            material.SetSafeFloat(PropertyName.FurOffsetFactor, propertyBlock.FurOffsetFactor, null, null, 0.0f);
            material.SetSafeFloat(PropertyName.FurOffsetUnits, propertyBlock.FurOffsetUnits, null, null, 0.0f);

            material.SetSafeInt(PropertyName.FurColorMask, propertyBlock.FurColorMask, null, null, 15);
            material.SetSafeBool(PropertyName.FurAlphaToMask, propertyBlock.FurAlphaToMask);
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

            material.SetSafeInt(PropertyName.FurSrcBlend, (int)propertyBlock.FurSrcBlend);
            material.SetSafeInt(PropertyName.FurDstBlend, (int)propertyBlock.FurDstBlend);
            material.SetSafeInt(PropertyName.FurSrcBlendAlpha, (int)propertyBlock.FurSrcBlendAlpha);
            material.SetSafeInt(PropertyName.FurDstBlendAlpha, (int)propertyBlock.FurDstBlendAlpha);
            material.SetSafeInt(PropertyName.FurBlendOp, (int)propertyBlock.FurBlendOp);
            material.SetSafeInt(PropertyName.FurBlendOpAlpha, (int)propertyBlock.FurBlendOpAlpha);
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

            material.SetSafeInt(PropertyName.FurSrcBlendFA, (int)propertyBlock.FurSrcBlendFA);
            material.SetSafeInt(PropertyName.FurDstBlendFA, (int)propertyBlock.FurDstBlendFA);
            material.SetSafeInt(PropertyName.FurSrcBlendAlphaFA, (int)propertyBlock.FurSrcBlendAlphaFA);
            material.SetSafeInt(PropertyName.FurDstBlendAlphaFA, (int)propertyBlock.FurDstBlendAlphaFA);
            material.SetSafeInt(PropertyName.FurBlendOpFA, (int)propertyBlock.FurBlendOpFA);
            material.SetSafeInt(PropertyName.FurBlendOpAlphaFA, (int)propertyBlock.FurBlendOpAlphaFA);
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

            material.SetSafeInt(PropertyName.FurStencilRef, propertyBlock.FurStencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyName.FurStencilReadMask, propertyBlock.FurStencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.FurStencilWriteMask, propertyBlock.FurStencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.FurStencilComp, (int)propertyBlock.FurStencilComp);
            material.SetSafeInt(PropertyName.FurStencilPass, (int)propertyBlock.FurStencilPass);
            material.SetSafeInt(PropertyName.FurStencilFail, (int)propertyBlock.FurStencilFail);
            material.SetSafeInt(PropertyName.FurStencilZFail, (int)propertyBlock.FurStencilZFail);
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

            material.SetSafeFloat(PropertyName.GemChromaticAberration, propertyBlock.GemChromaticAberration, 0.0f, 1.0f, 0.02f);
            material.SetSafeFloat(PropertyName.GemEnvContrast, propertyBlock.GemEnvContrast, null, null, 2.0f);
            material.SetSafeColor(PropertyName.GemEnvColor, propertyBlock.GemEnvColor);
            material.SetSafeFloat(PropertyName.GemParticleLoop, propertyBlock.GemParticleLoop, null, null, 8);
            material.SetSafeColor(PropertyName.GemParticleColor, propertyBlock.GemParticleColor);
            material.SetSafeFloat(PropertyName.GemVRParallaxStrength, propertyBlock.GemVRParallaxStrength, 0.0f, 1.0f, 1.0f);
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

            material.SetSafeFloat(PropertyName.TessEdge, propertyBlock.TessEdge, 0, 100, 0);
            material.SetSafeFloat(PropertyName.TessStrength, propertyBlock.TessStrength, 0.0f, 1.0f, 0.5f);
            material.SetSafeFloat(PropertyName.TessShrink, propertyBlock.TessShrink, 0.0f, 1.0f, 0.0f);
            material.SetSafeInt(PropertyName.TessFactorMax, propertyBlock.TessFactorMax, 1, 8, 3);
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

            material.SetSafeColor(PropertyName.OutlineColor, propertyBlock.OutlineColor);
            material.SetSafeTexture(PropertyName.OutlineTex, propertyBlock.OutlineTex);
            material.SetSafeVector(PropertyName.OutlineTex_ScrollRotate, propertyBlock.OutlineTex_ScrollRotate);
            material.SetSafeVector(PropertyName.OutlineTexHSVG, propertyBlock.OutlineTexHSVG);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeColor(PropertyName.OutlineLitColor, propertyBlock.OutlineLitColor);  // v1.3.0
            material.SetSafeBool(PropertyName.OutlineLitApplyTex, propertyBlock.OutlineLitApplyTex);  // v1.3.0
            material.SetSafeFloat(PropertyName.OutlineLitScale, propertyBlock.OutlineLitScale, null, null, 10);  // v1.3.0
            material.SetSafeFloat(PropertyName.OutlineLitOffset, propertyBlock.OutlineLitOffset, null, null, -8);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.OutlineWidth, propertyBlock.OutlineWidth, 0.0f, 1.0f, 0.08f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0.0f, 1.0f, 0.5f);  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyName.OutlineFixWidth, propertyBlock.OutlineFixWidth, null, null, 1);  // v1.2.12
#endif
            material.SetSafeTexture(PropertyName.OutlineWidthMask, propertyBlock.OutlineWidthMask);
            material.SetSafeInt(PropertyName.OutlineVertexR2Width, (int)propertyBlock.OutlineVertexR2Width);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeBool(PropertyName.OutlineDeleteMesh, propertyBlock.OutlineDeleteMesh);  // v1.3.0
#endif
            material.SetSafeTexture(PropertyName.OutlineVectorTex, propertyBlock.OutlineVectorTex);
            material.SetSafeFloat(PropertyName.OutlineVectorScale, propertyBlock.OutlineVectorScale, -10.0f, 10.0f, 1.0f);
            material.SetSafeFloat(PropertyName.OutlineEnableLighting, propertyBlock.OutlineEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.OutlineZBias, propertyBlock.OutlineZBias, null, null, 0);  // v1.3.0
            material.SetSafeBool(PropertyName.OutlineDisableInVR, propertyBlock.OutlineDisableInVR);  // v1.3.0
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

            material.SetSafeColor(PropertyName.OutlineColor, propertyBlock.OutlineColor);
            material.SetSafeTexture(PropertyName.OutlineTex, propertyBlock.OutlineTex);
            material.SetSafeFloat(PropertyName.OutlineWidth, propertyBlock.OutlineWidth, 0.0f, 1.0f, 0.05f);
            material.SetSafeTexture(PropertyName.OutlineWidthMask, propertyBlock.OutlineWidthMask);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.OutlineFixWidth, propertyBlock.OutlineFixWidth, 0.0f, 1.0f, 0.5f);  // v1.3.0 changed int to float
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeInt(PropertyName.OutlineFixWidth, propertyBlock.OutlineFixWidth, null, null, 1);  // v1.2.12
#endif
            material.SetSafeInt(PropertyName.OutlineVertexR2Width, (int)propertyBlock.OutlineVertexR2Width);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeBool(PropertyName.OutlineDeleteMesh, propertyBlock.OutlineDeleteMesh);  // v1.3.0
#endif
            material.SetSafeFloat(PropertyName.OutlineEnableLighting, propertyBlock.OutlineEnableLighting, 0.0f, 1.0f, 1.0f);
#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.OutlineZBias, propertyBlock.OutlineZBias, null, null, 0);  // v1.3.0
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

            material.SetSafeInt(PropertyName.OutlineCull, (int)propertyBlock.OutlineCull);

            material.SetSafeBool(PropertyName.OutlineZClip, propertyBlock.OutlineZClip);
            material.SetSafeBool(PropertyName.OutlineZWrite, propertyBlock.OutlineZWrite);
            material.SetSafeInt(PropertyName.OutlineZTest, (int)propertyBlock.OutlineZTest);

            material.SetSafeFloat(PropertyName.OutlineOffsetFactor, propertyBlock.OutlineOffsetFactor, null, null, 0.0f);
            material.SetSafeFloat(PropertyName.OutlineOffsetUnits, propertyBlock.OutlineOffsetUnits, null, null, 0.0f);

            material.SetSafeInt(PropertyName.OutlineColorMask, propertyBlock.OutlineColorMask, null, null, 15);
            material.SetSafeBool(PropertyName.OutlineAlphaToMask, propertyBlock.OutlineAlphaToMask);
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

            material.SetSafeInt(PropertyName.OutlineSrcBlend, (int)propertyBlock.OutlineSrcBlend);
            material.SetSafeInt(PropertyName.OutlineDstBlend, (int)propertyBlock.OutlineDstBlend);
            material.SetSafeInt(PropertyName.OutlineSrcBlendAlpha, (int)propertyBlock.OutlineSrcBlendAlpha);
            material.SetSafeInt(PropertyName.OutlineDstBlendAlpha, (int)propertyBlock.OutlineDstBlendAlpha);
            material.SetSafeInt(PropertyName.OutlineBlendOp, (int)propertyBlock.OutlineBlendOp);
            material.SetSafeInt(PropertyName.OutlineBlendOpAlpha, (int)propertyBlock.OutlineBlendOpAlpha);
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

            material.SetSafeInt(PropertyName.OutlineSrcBlendFA, (int)propertyBlock.OutlineSrcBlendFA);
            material.SetSafeInt(PropertyName.OutlineDstBlendFA, (int)propertyBlock.OutlineDstBlendFA);
            material.SetSafeInt(PropertyName.OutlineSrcBlendAlphaFA, (int)propertyBlock.OutlineSrcBlendAlphaFA);
            material.SetSafeInt(PropertyName.OutlineDstBlendAlphaFA, (int)propertyBlock.OutlineDstBlendAlphaFA);
            material.SetSafeInt(PropertyName.OutlineBlendOpFA, (int)propertyBlock.OutlineBlendOpFA);
            material.SetSafeInt(PropertyName.OutlineBlendOpAlphaFA, (int)propertyBlock.OutlineBlendOpAlphaFA);
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

            material.SetSafeInt(PropertyName.OutlineStencilRef, propertyBlock.OutlineStencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyName.OutlineStencilReadMask, propertyBlock.OutlineStencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.OutlineStencilWriteMask, propertyBlock.OutlineStencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.OutlineStencilComp, (int)propertyBlock.OutlineStencilComp);
            material.SetSafeInt(PropertyName.OutlineStencilPass, (int)propertyBlock.OutlineStencilPass);
            material.SetSafeInt(PropertyName.OutlineStencilFail, (int)propertyBlock.OutlineStencilFail);
            material.SetSafeInt(PropertyName.OutlineStencilZFail, (int)propertyBlock.OutlineStencilZFail);
        }

        #endregion

        #region Multi

        /// <summary>
        /// Set the lilToon Multi Keywords to the material.
        /// </summary>
        /// <param name="material">A lilToon Multi material.</param>
#if LILTOON_1_3_0_OR_NEWER
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
#if LILTOON_1_3_0_OR_NEWER
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

            material.SetSafeBool(PropertyName.UseOutline, propertyBlock.UseOutline);
            material.SetSafeInt(PropertyName.TransparentMode, (int)propertyBlock.TransparentMode);

#if LILTOON_1_3_0_OR_NEWER
            // v1.3.0 deleted
#elif LILTOON_1_2_12_OR_OLDER
            material.SetSafeBool(PropertyName.UsePOM, propertyBlock.UsePOM);
#endif

            material.SetSafeBool(PropertyName.UseClippingCanceller, propertyBlock.UseClippingCanceller);
            material.SetSafeBool(PropertyName.AsOverlay, propertyBlock.AsOverlay);
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
                material.SetSafeFloat(PropertyName.Cutoff, propertyBlock.Cutoff, -0.001f, 1.001f, 0.5f);
                material.SetSafeFloat(PropertyName.SubpassCutoff, propertyBlock.SubpassCutoff, 0f, 1f, 0.5f);
            }

            material.SetSafeInt(PropertyName.Cull, (int)propertyBlock.Cull);

            material.SetSafeBool(PropertyName.ZClip, propertyBlock.ZClip);
            material.SetSafeBool(PropertyName.ZWrite, propertyBlock.ZWrite);
            material.SetSafeInt(PropertyName.ZTest, (int)propertyBlock.ZTest);

            material.SetSafeFloat(PropertyName.OffsetFactor, propertyBlock.OffsetFactor, null, null, 0f);
            material.SetSafeFloat(PropertyName.OffsetUnits, propertyBlock.OffsetUnits, null, null, 0f);

            material.SetSafeInt(PropertyName.ColorMask, propertyBlock.ColorMask, null, null, 15);
            material.SetSafeBool(PropertyName.AlphaToMask, propertyBlock.AlphaToMask);

#if LILTOON_1_3_0_OR_NEWER
            material.SetSafeFloat(PropertyName.LilShadowCasterBias, propertyBlock.LilShadowCasterBias, null, null, 0.0f);  // v1.3.0
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

            material.SetSafeInt(PropertyName.SrcBlend, (int)propertyBlock.SrcBlend);
            material.SetSafeInt(PropertyName.DstBlend, (int)propertyBlock.DstBlend);
            material.SetSafeInt(PropertyName.SrcBlendAlpha, (int)propertyBlock.SrcBlendAlpha);
            material.SetSafeInt(PropertyName.DstBlendAlpha, (int)propertyBlock.DstBlendAlpha);
            material.SetSafeInt(PropertyName.BlendOp, (int)propertyBlock.BlendOp);
            material.SetSafeInt(PropertyName.BlendOpAlpha, (int)propertyBlock.BlendOpAlpha);
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

            material.SetSafeInt(PropertyName.SrcBlendFA, (int)propertyBlock.SrcBlendFA);
            material.SetSafeInt(PropertyName.DstBlendFA, (int)propertyBlock.DstBlendFA);
            material.SetSafeInt(PropertyName.SrcBlendAlphaFA, (int)propertyBlock.SrcBlendAlphaFA);
            material.SetSafeInt(PropertyName.DstBlendAlphaFA, (int)propertyBlock.DstBlendAlphaFA);
            material.SetSafeInt(PropertyName.BlendOpFA, (int)propertyBlock.BlendOpFA);
            material.SetSafeInt(PropertyName.BlendOpAlphaFA, (int)propertyBlock.BlendOpAlphaFA);
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

            material.SetSafeInt(PropertyName.StencilRef, propertyBlock.StencilRef, 0, 255, 0);
            material.SetSafeInt(PropertyName.StencilReadMask, propertyBlock.StencilReadMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.StencilWriteMask, propertyBlock.StencilWriteMask, 0, 255, 255);
            material.SetSafeInt(PropertyName.StencilComp, (int)propertyBlock.StencilComp);
            material.SetSafeInt(PropertyName.StencilPass, (int)propertyBlock.StencilPass);
            material.SetSafeInt(PropertyName.StencilFail, (int)propertyBlock.StencilFail);
            material.SetSafeInt(PropertyName.StencilZFail, (int)propertyBlock.StencilZFail);
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

            material.SetSafeColor(PropertyName.BaseColor, propertyBlock.BaseColor);
            material.SetSafeTexture(PropertyName.BaseMap, propertyBlock.BaseMap);
            material.SetSafeTexture(PropertyName.BaseColorMap, propertyBlock.BaseColorMap);

            material.SetSafeInt(PropertyName.LilToonVersion, propertyBlock.LilToonVersion);
        }

        #endregion

        #endregion
    }
}