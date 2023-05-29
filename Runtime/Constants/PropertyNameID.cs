// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : PropertyNameID
// ----------------------------------------------------------------------
namespace LilToonShader
{
    using UnityEngine;

    /// <summary>
    /// Property Name ID
    /// </summary>
    public class PropertyNameID
    {
        #region Base

        /// <summary>Invisible</summary>
        public static readonly int Invisible = Shader.PropertyToID(PropertyName.Invisible);

        ///// <summary>As Unlit</summary>
        ///// <remarks>Lighting Advanced</remarks>
        //public static readonly int AsUnlit = Shader.PropertyToID(PropertyName.AsUnlit);

        ///// <summary>Alpha Cutoff</summary>
        ///// <remarks>Rendering</remarks>
        //public static readonly int Cutoff = Shader.PropertyToID(PropertyName.Cutoff);

        ///// <summary>Subpass Alpha Cutoff</summary>
        ///// <remarks>Rendering</remarks>
        //public static readonly int SubpassCutoff = Shader.PropertyToID(PropertyName.SubpassCutoff);

        /// <summary>Flip Backface Normal</summary>
        public static readonly int FlipNormal = Shader.PropertyToID(PropertyName.FlipNormal);

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        public static readonly int ShiftBackfaceUV = Shader.PropertyToID(PropertyName.ShiftBackfaceUV);

        /// <summary>Backface Force Shadow</summary>
        public static readonly int BackfaceForceShadow = Shader.PropertyToID(PropertyName.BackfaceForceShadow);

        /// <summary>Backface Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int BackfaceColor = Shader.PropertyToID(PropertyName.BackfaceColor);

        /// <summary>AA Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int AAStrength = Shader.PropertyToID(PropertyName.AAStrength);

        #endregion

        #region Base (Cutout)

        /// <summary>Use Dither</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int UseDither = Shader.PropertyToID(PropertyName.UseDither);

        /// <summary>Dither Texture</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int DitherTex = Shader.PropertyToID(PropertyName.DitherTex);

        /// <summary>Dither Max Value</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int DitherMaxValue = Shader.PropertyToID(PropertyName.DitherMaxValue);

        #endregion

        #region Lighting

        /// <summary>Light Min Limit</summary>
        public static readonly int LightMinLimit = Shader.PropertyToID(PropertyName.LightMinLimit);

        /// <summary>Light Max Limit</summary>
        public static readonly int LightMaxLimit = Shader.PropertyToID(PropertyName.LightMaxLimit);

        /// <summary>Monochrome Lighting</summary>
        public static readonly int MonochromeLighting = Shader.PropertyToID(PropertyName.MonochromeLighting);

        #endregion

        #region Lighting Advanced

        /// <summary>As Unlit</summary>
        /// <remarks>Base</remarks>
        public static readonly int AsUnlit = Shader.PropertyToID(PropertyName.AsUnlit);

        /// <summary>Cutoff</summary>
        public static readonly int VertexLightStrength = Shader.PropertyToID(PropertyName.VertexLightStrength);

        /// <summary>Light Direction Override</summary>
        public static readonly int LightDirectionOverride = Shader.PropertyToID(PropertyName.LightDirectionOverride);

        /// <summary>Alpha Boost ForwardAdd</summary>
        public static readonly int AlphaBoostFA = Shader.PropertyToID(PropertyName.AlphaBoostFA);

        /// <summary>Before Exposure Limit</summary>
        public static readonly int BeforeExposureLimit = Shader.PropertyToID(PropertyName.BeforeExposureLimit);

        /// <summary>Directional Light Strength</summary>
        public static readonly int LilDirectionalLightStrength = Shader.PropertyToID(PropertyName.LilDirectionalLightStrength);

        #endregion

        #region Main

        /// <summary>Color</summary>
        public static readonly int Color = Shader.PropertyToID(PropertyName.Color);

        /// <summary>Main Texture</summary>
        public static readonly int MainTex = Shader.PropertyToID(PropertyName.MainTex);

        /// <summary>Main Tex Scroll Rotate</summary>
        public static readonly int MainTex_ScrollRotate = Shader.PropertyToID(PropertyName.MainTex_ScrollRotate);

        /// <summary>Main Tex HSVG</summary>
        public static readonly int MainTexHSVG = Shader.PropertyToID(PropertyName.MainTexHSVG);

        /// <summary>Main Gradation Strength</summary>
        public static readonly int MainGradationStrength = Shader.PropertyToID(PropertyName.MainGradationStrength);

        /// <summary>Main Gradation Texture</summary>
        public static readonly int MainGradationTex = Shader.PropertyToID(PropertyName.MainGradationTex);

        /// <summary>Main Color Adjust Mask</summary>
        public static readonly int MainColorAdjustMask = Shader.PropertyToID(PropertyName.MainColorAdjustMask);

        #endregion

        #region Main 2nd

        /// <summary>Use Main 2nd Texture</summary>
        public static readonly int UseMain2ndTex = Shader.PropertyToID(PropertyName.UseMain2ndTex);

        /// <summary>Main 2nd Color</summary>
        public static readonly int Color2nd = Shader.PropertyToID(PropertyName.Color2nd);

        /// <summary>Main 2nd Texture</summary>
        public static readonly int Main2ndTex = Shader.PropertyToID(PropertyName.Main2ndTex);

        /// <summary>Main 2nd Texture Angle</summary>
        public static readonly int Main2ndTexAngle = Shader.PropertyToID(PropertyName.Main2ndTexAngle);

        /// <summary>Main 2nd Texture Scroll Rotate</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int Main2ndTex_ScrollRotate = Shader.PropertyToID(PropertyName.Main2ndTex_ScrollRotate);

        /// <summary>Main 2nd Texture UV Mode</summary>
        public static readonly int Main2ndTex_UVMode = Shader.PropertyToID(PropertyName.Main2ndTex_UVMode);

        /// <summary>Main 2nd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        public static readonly int Main2ndTex_Cull = Shader.PropertyToID(PropertyName.Main2ndTex_Cull);

        /// <summary>Main 2nd Texture Decal Animation</summary>
        public static readonly int Main2ndTexDecalAnimation = Shader.PropertyToID(PropertyName.Main2ndTexDecalAnimation);

        /// <summary>Main 2nd Texture Decal Sub Param</summary>
        public static readonly int Main2ndTexDecalSubParam = Shader.PropertyToID(PropertyName.Main2ndTexDecalSubParam);

        /// <summary>Main 2nd Texture Is Decal</summary>
        public static readonly int Main2ndTexIsDecal = Shader.PropertyToID(PropertyName.Main2ndTexIsDecal);

        /// <summary>Main 2nd Texture Is Left Only</summary>
        public static readonly int Main2ndTexIsLeftOnly = Shader.PropertyToID(PropertyName.Main2ndTexIsLeftOnly);

        /// <summary>Main 2nd Texture Is Right Only</summary>
        public static readonly int Main2ndTexIsRightOnly = Shader.PropertyToID(PropertyName.Main2ndTexIsRightOnly);

        /// <summary>Main 2nd Texture Should Copy</summary>
        public static readonly int Main2ndTexShouldCopy = Shader.PropertyToID(PropertyName.Main2ndTexShouldCopy);

        /// <summary>Main 2nd Texture Should Flip Mirror</summary>
        public static readonly int Main2ndTexShouldFlipMirror = Shader.PropertyToID(PropertyName.Main2ndTexShouldFlipMirror);

        /// <summary>Main 2nd Texture Should Flip Copy</summary>
        public static readonly int Main2ndTexShouldFlipCopy = Shader.PropertyToID(PropertyName.Main2ndTexShouldFlipCopy);

        /// <summary>Main 2nd Texture Is MSDF</summary>
        public static readonly int Main2ndTexIsMSDF = Shader.PropertyToID(PropertyName.Main2ndTexIsMSDF);

        /// <summary>Main 2nd Blend Mask</summary>
        public static readonly int Main2ndBlendMask = Shader.PropertyToID(PropertyName.Main2ndBlendMask);

        /// <summary>Main 2nd Texture Blend Mode</summary>
        public static readonly int Main2ndTexBlendMode = Shader.PropertyToID(PropertyName.Main2ndTexBlendMode);

        /// <summary>Main 2nd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int Main2ndTexAlphaMode = Shader.PropertyToID(PropertyName.Main2ndTexAlphaMode);

        /// <summary>Main 2nd Enable Lighting</summary>
        public static readonly int Main2ndEnableLighting = Shader.PropertyToID(PropertyName.Main2ndEnableLighting);

        /// <summary>Main 2nd Dissolve Mask</summary>
        public static readonly int Main2ndDissolveMask = Shader.PropertyToID(PropertyName.Main2ndDissolveMask);

        /// <summary>Main 2nd Dissolve Noise Mask</summary>
        public static readonly int Main2ndDissolveNoiseMask = Shader.PropertyToID(PropertyName.Main2ndDissolveNoiseMask);

        /// <summary>Main 2nd Dissolve Noise Mask Scroll Rotate</summary>
        public static readonly int Main2ndDissolveNoiseMask_ScrollRotate = Shader.PropertyToID(PropertyName.Main2ndDissolveNoiseMask_ScrollRotate);

        /// <summary>Main 2nd Dissolve Noise Strength</summary>
        public static readonly int Main2ndDissolveNoiseStrength = Shader.PropertyToID(PropertyName.Main2ndDissolveNoiseStrength);

        /// <summary>Main 2nd Dissolve Color</summary>
        public static readonly int Main2ndDissolveColor = Shader.PropertyToID(PropertyName.Main2ndDissolveColor);

        /// <summary>Main 2nd Dissolve Params</summary>
        public static readonly int Main2ndDissolveParams = Shader.PropertyToID(PropertyName.Main2ndDissolveParams);

        /// <summary>Main 2nd Dissolve Position</summary>
        public static readonly int Main2ndDissolvePos = Shader.PropertyToID(PropertyName.Main2ndDissolvePos);

        /// <summary>Main 2nd Distance Fade</summary>
        public static readonly int Main2ndDistanceFade = Shader.PropertyToID(PropertyName.Main2ndDistanceFade);

        #endregion

        #region Main 3rd

        /// <summary>Use Main 3rd Texture</summary>
        public static readonly int UseMain3rdTex = Shader.PropertyToID(PropertyName.UseMain3rdTex);

        /// <summary>Main 3rd Color</summary>
        public static readonly int Color3rd = Shader.PropertyToID(PropertyName.Color3rd);

        /// <summary>Main 3rd Texture</summary>
        public static readonly int Main3rdTex = Shader.PropertyToID(PropertyName.Main3rdTex);

        /// <summary>Main 3rd Texture Angle</summary>
        public static readonly int Main3rdTexAngle = Shader.PropertyToID(PropertyName.Main3rdTexAngle);

        /// <summary>Main 3rd Texture Scroll Rotate</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int Main3rdTex_ScrollRotate = Shader.PropertyToID(PropertyName.Main3rdTex_ScrollRotate);

        /// <summary>Main 3rd Texture UV Mode</summary>
        public static readonly int Main3rdTex_UVMode = Shader.PropertyToID(PropertyName.Main3rdTex_UVMode);

        /// <summary>Main 3rd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        public static readonly int Main3rdTex_Cull = Shader.PropertyToID(PropertyName.Main3rdTex_Cull);

        /// <summary>Main 3rd Texture Decal Animation</summary>
        public static readonly int Main3rdTexDecalAnimation = Shader.PropertyToID(PropertyName.Main3rdTexDecalAnimation);

        /// <summary>Main 3rd Texture Decal Sub Param</summary>
        public static readonly int Main3rdTexDecalSubParam = Shader.PropertyToID(PropertyName.Main3rdTexDecalSubParam);

        /// <summary>Main 3rd Texture Is Decal</summary>
        public static readonly int Main3rdTexIsDecal = Shader.PropertyToID(PropertyName.Main3rdTexIsDecal);

        /// <summary>Main 3rd Texture Is Left Only</summary>
        public static readonly int Main3rdTexIsLeftOnly = Shader.PropertyToID(PropertyName.Main3rdTexIsLeftOnly);

        /// <summary>Main 3rd Texture Is Right Only</summary>
        public static readonly int Main3rdTexIsRightOnly = Shader.PropertyToID(PropertyName.Main3rdTexIsRightOnly);

        /// <summary>Main 3rd Texture Should Copy</summary>
        public static readonly int Main3rdTexShouldCopy = Shader.PropertyToID(PropertyName.Main3rdTexShouldCopy);

        /// <summary>Main 3rd Texture Should Flip Mirror</summary>
        public static readonly int Main3rdTexShouldFlipMirror = Shader.PropertyToID(PropertyName.Main3rdTexShouldFlipMirror);

        /// <summary>Main 3rd Texture Should Flip Copy</summary>
        public static readonly int Main3rdTexShouldFlipCopy = Shader.PropertyToID(PropertyName.Main3rdTexShouldFlipCopy);

        /// <summary>Main 3rd Texture Is MSDF</summary>
        public static readonly int Main3rdTexIsMSDF = Shader.PropertyToID(PropertyName.Main3rdTexIsMSDF);

        /// <summary>Main 3rd Blend Mask</summary>
        public static readonly int Main3rdBlendMask = Shader.PropertyToID(PropertyName.Main3rdBlendMask);

        /// <summary>Main 3rd Texture Blend Mode</summary>
        public static readonly int Main3rdTexBlendMode = Shader.PropertyToID(PropertyName.Main3rdTexBlendMode);

        /// <summary>Main 3rd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int Main3rdTexAlphaMode = Shader.PropertyToID(PropertyName.Main3rdTexAlphaMode);

        /// <summary>Main 3rd Enable Lighting</summary>
        public static readonly int Main3rdEnableLighting = Shader.PropertyToID(PropertyName.Main3rdEnableLighting);

        /// <summary>Main 3rd Dissolve Mask</summary>
        public static readonly int Main3rdDissolveMask = Shader.PropertyToID(PropertyName.Main3rdDissolveMask);

        /// <summary>Main 3rd Dissolve Noise Mask</summary>
        public static readonly int Main3rdDissolveNoiseMask = Shader.PropertyToID(PropertyName.Main3rdDissolveNoiseMask);

        /// <summary>Main 3rd Dissolve Noise Mask Scroll Rotate</summary>
        public static readonly int Main3rdDissolveNoiseMask_ScrollRotate = Shader.PropertyToID(PropertyName.Main3rdDissolveNoiseMask_ScrollRotate);

        /// <summary>Main 3rd Dissolve Noise Strength</summary>
        public static readonly int Main3rdDissolveNoiseStrength = Shader.PropertyToID(PropertyName.Main3rdDissolveNoiseStrength);

        /// <summary>Main 3rd Dissolve Color</summary>
        public static readonly int Main3rdDissolveColor = Shader.PropertyToID(PropertyName.Main3rdDissolveColor);

        /// <summary>Main 3rd Dissolve Params</summary>
        public static readonly int Main3rdDissolveParams = Shader.PropertyToID(PropertyName.Main3rdDissolveParams);

        /// <summary>Main 3rd Dissolve Position</summary>
        public static readonly int Main3rdDissolvePos = Shader.PropertyToID(PropertyName.Main3rdDissolvePos);

        /// <summary>Main 3rd Distance Fade</summary>
        public static readonly int Main3rdDistanceFade = Shader.PropertyToID(PropertyName.Main3rdDistanceFade);

        #endregion

        #region Alpha Mask

        /// <summary>Alpha Mask Mode</summary>
        public static readonly int AlphaMaskMode = Shader.PropertyToID(PropertyName.AlphaMaskMode);

        /// <summary>Alpha Mask</summary>
        public static readonly int AlphaMask = Shader.PropertyToID(PropertyName.AlphaMask);

        /// <summary>Alpha Mask Scale</summary>
        public static readonly int AlphaMaskScale = Shader.PropertyToID(PropertyName.AlphaMaskScale);

        /// <summary>Alpha Mask Offset</summary>
        public static readonly int AlphaMaskValue = Shader.PropertyToID(PropertyName.AlphaMaskValue);

        #endregion

        #region Normal Map

        /// <summary>Use Bump Map</summary>
        public static readonly int UseBumpMap = Shader.PropertyToID(PropertyName.UseBumpMap);

        /// <summary>Bump Map</summary>
        public static readonly int BumpMap = Shader.PropertyToID(PropertyName.BumpMap);

        /// <summary>Bump Scale</summary>
        public static readonly int BumpScale = Shader.PropertyToID(PropertyName.BumpScale);

        #endregion

        #region Normal Map 2nd

        /// <summary>UseBump 2nd Map</summary>
        public static readonly int UseBump2ndMap = Shader.PropertyToID(PropertyName.UseBump2ndMap);

        /// <summary>Bump 2nd Map</summary>
        public static readonly int Bump2ndMap = Shader.PropertyToID(PropertyName.Bump2ndMap);

        /// <summary>Bump 2nd Map UV Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        public static readonly int Bump2ndMap_UVMode = Shader.PropertyToID(PropertyName.Bump2ndMap_UVMode);

        /// <summary>Bump 2nd Scale</summary>
        public static readonly int Bump2ndScale = Shader.PropertyToID(PropertyName.Bump2ndScale);

        /// <summary>Bump 2nd Scale Mask</summary>
        public static readonly int Bump2ndScaleMask = Shader.PropertyToID(PropertyName.Bump2ndScaleMask);

        #endregion

        #region Anisotropy

        /// <summary>Use Anisotropy</summary>
        public static readonly int UseAnisotropy = Shader.PropertyToID(PropertyName.UseAnisotropy);

        /// <summary>Anisotropy Tangent Map</summary>
        public static readonly int AnisotropyTangentMap = Shader.PropertyToID(PropertyName.AnisotropyTangentMap);

        /// <summary>Anisotropy Scale</summary>
        public static readonly int AnisotropyScale = Shader.PropertyToID(PropertyName.AnisotropyScale);

        /// <summary>Anisotropy Scale Mask</summary>
        public static readonly int AnisotropyScaleMask = Shader.PropertyToID(PropertyName.AnisotropyScaleMask);

        /// <summary>Anisotropy Tangent Width</summary>
        public static readonly int AnisotropyTangentWidth = Shader.PropertyToID(PropertyName.AnisotropyTangentWidth);

        /// <summary>Anisotropy Bitangent Width</summary>
        public static readonly int AnisotropyBitangentWidth = Shader.PropertyToID(PropertyName.AnisotropyBitangentWidth);

        /// <summary>Anisotropy Shift</summary>
        public static readonly int AnisotropyShift = Shader.PropertyToID(PropertyName.AnisotropyShift);

        /// <summary>Anisotropy Shift Noise Scale</summary>
        public static readonly int AnisotropyShiftNoiseScale = Shader.PropertyToID(PropertyName.AnisotropyShiftNoiseScale);

        /// <summary>Anisotropy Specular Strength</summary>
        public static readonly int AnisotropySpecularStrength = Shader.PropertyToID(PropertyName.AnisotropySpecularStrength);

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        public static readonly int Anisotropy2ndTangentWidth = Shader.PropertyToID(PropertyName.Anisotropy2ndTangentWidth);

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        public static readonly int Anisotropy2ndBitangentWidth = Shader.PropertyToID(PropertyName.Anisotropy2ndBitangentWidth);

        /// <summary>Anisotropy 2nd Shift</summary>
        public static readonly int Anisotropy2ndShift = Shader.PropertyToID(PropertyName.Anisotropy2ndShift);

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        public static readonly int Anisotropy2ndShiftNoiseScale = Shader.PropertyToID(PropertyName.Anisotropy2ndShiftNoiseScale);

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        public static readonly int Anisotropy2ndSpecularStrength = Shader.PropertyToID(PropertyName.Anisotropy2ndSpecularStrength);

        /// <summary>Anisotropy Shift Noise Mask</summary>
        public static readonly int AnisotropyShiftNoiseMask = Shader.PropertyToID(PropertyName.AnisotropyShiftNoiseMask);

        /// <summary>Anisotropy 2 Reflection</summary>
        public static readonly int Anisotropy2Reflection = Shader.PropertyToID(PropertyName.Anisotropy2Reflection);

        /// <summary>Anisotropy 2 Mat Cap</summary>
        public static readonly int Anisotropy2MatCap = Shader.PropertyToID(PropertyName.Anisotropy2MatCap);

        /// <summary>Anisotropy 2 Mat Cap 2nd</summary>
        public static readonly int Anisotropy2MatCap2nd = Shader.PropertyToID(PropertyName.Anisotropy2MatCap2nd);

        #endregion

        #region Backlight

        /// <summary>Use Backlight</summary>
        public static readonly int UseBacklight = Shader.PropertyToID(PropertyName.UseBacklight);

        /// <summary>Backlight Color</summary>
        public static readonly int BacklightColor = Shader.PropertyToID(PropertyName.BacklightColor);

        /// <summary>Backlight Color Tex</summary>
        public static readonly int BacklightColorTex = Shader.PropertyToID(PropertyName.BacklightColorTex);

        /// <summary>Backlight Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int BacklightMainStrength = Shader.PropertyToID(PropertyName.BacklightMainStrength);

        /// <summary>Backlight Normal Strength</summary>
        public static readonly int BacklightNormalStrength = Shader.PropertyToID(PropertyName.BacklightNormalStrength);

        /// <summary>Backlight Border</summary>
        public static readonly int BacklightBorder = Shader.PropertyToID(PropertyName.BacklightBorder);

        /// <summary>Backlight Blur</summary>
        public static readonly int BacklightBlur = Shader.PropertyToID(PropertyName.BacklightBlur);

        /// <summary>Backlight Directivity</summary>
        public static readonly int BacklightDirectivity = Shader.PropertyToID(PropertyName.BacklightDirectivity);

        /// <summary>Backlight View Strength</summary>
        public static readonly int BacklightViewStrength = Shader.PropertyToID(PropertyName.BacklightViewStrength);

        /// <summary>Backlight Receive Shadow</summary>
        public static readonly int BacklightReceiveShadow = Shader.PropertyToID(PropertyName.BacklightReceiveShadow);

        /// <summary>Backlight Backface Mask</summary>
        public static readonly int BacklightBackfaceMask = Shader.PropertyToID(PropertyName.BacklightBackfaceMask);

        #endregion

        #region Shadow

        /// <summary>Use Shadow</summary>
        public static readonly int UseShadow = Shader.PropertyToID(PropertyName.UseShadow);

        /// <summary>Shadow Strength</summary>
        public static readonly int ShadowStrength = Shader.PropertyToID(PropertyName.ShadowStrength);

        /// <summary>Shadow Strength Mask</summary>
        public static readonly int ShadowStrengthMask = Shader.PropertyToID(PropertyName.ShadowStrengthMask);

        /// <summary>Shadow Strength Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowStrengthMaskLOD = Shader.PropertyToID(PropertyName.ShadowStrengthMaskLOD);

        /// <summary>Shadow Border Mask</summary>
        public static readonly int ShadowBorderMask = Shader.PropertyToID(PropertyName.ShadowBorderMask);

        /// <summary>Shadow Border Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowBorderMaskLOD = Shader.PropertyToID(PropertyName.ShadowBorderMaskLOD);

        /// <summary>Shadow Blur Mask</summary>
        public static readonly int ShadowBlurMask = Shader.PropertyToID(PropertyName.ShadowBlurMask);

        /// <summary>Shadow Blur Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowBlurMaskLOD = Shader.PropertyToID(PropertyName.ShadowBlurMaskLOD);

        /// <summary>Shadow AO Shift</summary>
        public static readonly int ShadowAOShift = Shader.PropertyToID(PropertyName.ShadowAOShift);

        /// <summary>Shadow AO Shift2</summary>
        public static readonly int ShadowAOShift2 = Shader.PropertyToID(PropertyName.ShadowAOShift2);

        /// <summary>Shadow Post AO</summary>
        public static readonly int ShadowPostAO = Shader.PropertyToID(PropertyName.ShadowPostAO);

        /// <summary>Shadow Color Type</summary>
        /// <remarks>v1.3.5 added</remarks>
        public static readonly int ShadowColorType = Shader.PropertyToID(PropertyName.ShadowColorType);

        /// <summary>Shadow Color</summary>
        public static readonly int ShadowColor = Shader.PropertyToID(PropertyName.ShadowColor);

        /// <summary>Shadow Color Tex</summary>
        public static readonly int ShadowColorTex = Shader.PropertyToID(PropertyName.ShadowColorTex);

        /// <summary>Shadow Normal Strength</summary>
        public static readonly int ShadowNormalStrength = Shader.PropertyToID(PropertyName.ShadowNormalStrength);

        /// <summary>Shadow Border</summary>
        public static readonly int ShadowBorder = Shader.PropertyToID(PropertyName.ShadowBorder);

        /// <summary>Shadow Blur</summary>
        public static readonly int ShadowBlur = Shader.PropertyToID(PropertyName.ShadowBlur);

        /// <summary>Shadow Receive</summary>
        public static readonly int ShadowReceive = Shader.PropertyToID(PropertyName.ShadowReceive);

        /// <summary>Shadow 2nd Color</summary>
        public static readonly int Shadow2ndColor = Shader.PropertyToID(PropertyName.Shadow2ndColor);

        /// <summary>Shadow 2nd Color Tex</summary>
        public static readonly int Shadow2ndColorTex = Shader.PropertyToID(PropertyName.Shadow2ndColorTex);

        /// <summary>Shadow 2nd Normal Strength</summary>
        public static readonly int Shadow2ndNormalStrength = Shader.PropertyToID(PropertyName.Shadow2ndNormalStrength);

        /// <summary>Shadow 2nd Border</summary>
        public static readonly int Shadow2ndBorder = Shader.PropertyToID(PropertyName.Shadow2ndBorder);

        /// <summary>Shadow 2nd Blur</summary>
        public static readonly int Shadow2ndBlur = Shader.PropertyToID(PropertyName.Shadow2ndBlur);

        /// <summary>Receive Shadow 2nd</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int Shadow2ndReceive = Shader.PropertyToID(PropertyName.Shadow2ndReceive);

        /// <summary>Shadow 3rd Color</summary>
        public static readonly int Shadow3rdColor = Shader.PropertyToID(PropertyName.Shadow3rdColor);

        /// <summary>Shadow 3rd ColorTex</summary>
        public static readonly int Shadow3rdColorTex = Shader.PropertyToID(PropertyName.Shadow3rdColorTex);

        /// <summary>Shadow 3rd Normal Strength</summary>
        public static readonly int Shadow3rdNormalStrength = Shader.PropertyToID(PropertyName.Shadow3rdNormalStrength);

        /// <summary>Shadow 3rd Border</summary>
        public static readonly int Shadow3rdBorder = Shader.PropertyToID(PropertyName.Shadow3rdBorder);

        /// <summary>Shadow 3rd Blur</summary>
        public static readonly int Shadow3rdBlur = Shader.PropertyToID(PropertyName.Shadow3rdBlur);

        /// <summary>Receive Shadow 3rd</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int Shadow3rdReceive = Shader.PropertyToID(PropertyName.Shadow3rdReceive);

        /// <summary>Shadow Main Strength</summary>
        public static readonly int ShadowMainStrength = Shader.PropertyToID(PropertyName.ShadowMainStrength);

        /// <summary>Shadow Environment Strength</summary>
        public static readonly int ShadowEnvStrength = Shader.PropertyToID(PropertyName.ShadowEnvStrength);

        /// <summary>Shadow Border Color</summary>
        public static readonly int ShadowBorderColor = Shader.PropertyToID(PropertyName.ShadowBorderColor);

        /// <summary>Shadow Border Range</summary>
        public static readonly int ShadowBorderRange = Shader.PropertyToID(PropertyName.ShadowBorderRange);

        /// <summary>Shadow Mask Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowMaskType = Shader.PropertyToID(PropertyName.ShadowMaskType);

        /// <summary>Shadow Flat Border</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowFlatBorder = Shader.PropertyToID(PropertyName.ShadowFlatBorder);

        /// <summary>Shadow Flat Blur</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ShadowFlatBlur = Shader.PropertyToID(PropertyName.ShadowFlatBlur);

        #endregion

        #region Reflection

        /// <summary>Use Reflection</summary>
        public static readonly int UseReflection = Shader.PropertyToID(PropertyName.UseReflection);

        /// <summary>Smoothness</summary>
        public static readonly int Smoothness = Shader.PropertyToID(PropertyName.Smoothness);

        /// <summary>Smoothness Texture</summary>
        public static readonly int SmoothnessTex = Shader.PropertyToID(PropertyName.SmoothnessTex);

        /// <summary>Metallic</summary>
        public static readonly int Metallic = Shader.PropertyToID(PropertyName.Metallic);

        /// <summary>Metallic Gloss Map</summary>
        public static readonly int MetallicGlossMap = Shader.PropertyToID(PropertyName.MetallicGlossMap);

        /// <summary>Reflectance</summary>
        public static readonly int Reflectance = Shader.PropertyToID(PropertyName.Reflectance);

        /// <summary>GSAA Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GSAAStrength = Shader.PropertyToID(PropertyName.GSAAStrength);

        /// <summary>Apply Specular</summary>
        public static readonly int ApplySpecular = Shader.PropertyToID(PropertyName.ApplySpecular);

        /// <summary>Apply Specular in ForwardAdd</summary>
        public static readonly int ApplySpecularFA = Shader.PropertyToID(PropertyName.ApplySpecularFA);

        /// <summary>Specular Toon</summary>
        public static readonly int SpecularToon = Shader.PropertyToID(PropertyName.SpecularToon);

        /// <summary>Specular Normal Strength</summary>
        public static readonly int SpecularNormalStrength = Shader.PropertyToID(PropertyName.SpecularNormalStrength);

        /// <summary>Specular Border</summary>
        public static readonly int SpecularBorder = Shader.PropertyToID(PropertyName.SpecularBorder);

        /// <summary>Specular Blur</summary>
        public static readonly int SpecularBlur = Shader.PropertyToID(PropertyName.SpecularBlur);

        /// <summary>Apply Reflection</summary>
        public static readonly int ApplyReflection = Shader.PropertyToID(PropertyName.ApplyReflection);

        /// <summary>Reflection Normal Strength</summary>
        public static readonly int ReflectionNormalStrength = Shader.PropertyToID(PropertyName.ReflectionNormalStrength);

        /// <summary>Reflection Color</summary>
        public static readonly int ReflectionColor = Shader.PropertyToID(PropertyName.ReflectionColor);

        /// <summary>Reflection Color Texture</summary>
        public static readonly int ReflectionColorTex = Shader.PropertyToID(PropertyName.ReflectionColorTex);

        /// <summary>Reflection Apply Transparency</summary>
        public static readonly int ReflectionApplyTransparency = Shader.PropertyToID(PropertyName.ReflectionApplyTransparency);

        /// <summary>Reflection Cube Tex</summary>
        public static readonly int ReflectionCubeTex = Shader.PropertyToID(PropertyName.ReflectionCubeTex);

        /// <summary>Reflection Cube Color</summary>
        public static readonly int ReflectionCubeColor = Shader.PropertyToID(PropertyName.ReflectionCubeColor);

        /// <summary>Reflection Cube Override</summary>
        public static readonly int ReflectionCubeOverride = Shader.PropertyToID(PropertyName.ReflectionCubeOverride);

        /// <summary>Reflection Cube Enable Lighting</summary>
        public static readonly int ReflectionCubeEnableLighting = Shader.PropertyToID(PropertyName.ReflectionCubeEnableLighting);

        /// <summary>Reflection Blend Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int ReflectionBlendMode = Shader.PropertyToID(PropertyName.ReflectionBlendMode);

        #endregion

        #region MatCap

        /// <summary>Use Mat Cap</summary>
        public static readonly int UseMatCap = Shader.PropertyToID(PropertyName.UseMatCap);

        /// <summary>Mat Cap Color</summary>
        public static readonly int MatCapColor = Shader.PropertyToID(PropertyName.MatCapColor);

        /// <summary>Mat Cap Texture</summary>
        public static readonly int MatCapTex = Shader.PropertyToID(PropertyName.MatCapTex);

        /// <summary>Mat Cap Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int MatCapMainStrength = Shader.PropertyToID(PropertyName.MatCapMainStrength);

        /// <summary>Mat Cap Blend UV1</summary>
        public static readonly int MatCapBlendUV1 = Shader.PropertyToID(PropertyName.MatCapBlendUV1);

        /// <summary>Mat Cap Z-axis Rotation Cancel</summary>
        public static readonly int MatCapZRotCancel = Shader.PropertyToID(PropertyName.MatCapZRotCancel);

        /// <summary>Mat Cap Perspective</summary>
        public static readonly int MatCapPerspective = Shader.PropertyToID(PropertyName.MatCapPerspective);

        /// <summary>Mat Cap VR Parallax Strength</summary>
        public static readonly int MatCapVRParallaxStrength = Shader.PropertyToID(PropertyName.MatCapVRParallaxStrength);

        /// <summary>Mat Cap Blend</summary>
        public static readonly int MatCapBlend = Shader.PropertyToID(PropertyName.MatCapBlend);

        /// <summary>Mat Cap Blend Mask</summary>
        public static readonly int MatCapBlendMask = Shader.PropertyToID(PropertyName.MatCapBlendMask);

        /// <summary>Mat Cap Enable Lighting</summary>
        public static readonly int MatCapEnableLighting = Shader.PropertyToID(PropertyName.MatCapEnableLighting);

        /// <summary>Mat Cap Shadow Mask</summary>
        public static readonly int MatCapShadowMask = Shader.PropertyToID(PropertyName.MatCapShadowMask);

        /// <summary>Mat Cap Backface Mask</summary>
        public static readonly int MatCapBackfaceMask = Shader.PropertyToID(PropertyName.MatCapBackfaceMask);

        /// <summary>Mat Cap Lod</summary>
        public static readonly int MatCapLod = Shader.PropertyToID(PropertyName.MatCapLod);

        /// <summary>Mat Cap Blend Mode</summary>
        public static readonly int MatCapBlendMode = Shader.PropertyToID(PropertyName.MatCapBlendMode);

        /// <summary>Mat Cap Apply Transparency</summary>
        public static readonly int MatCapApplyTransparency = Shader.PropertyToID(PropertyName.MatCapApplyTransparency);

        /// <summary>Mat Cap Normal Strength</summary>
        public static readonly int MatCapNormalStrength = Shader.PropertyToID(PropertyName.MatCapNormalStrength);

        /// <summary>Mat Cap Custom Normal Map</summary>
        public static readonly int MatCapCustomNormal = Shader.PropertyToID(PropertyName.MatCapCustomNormal);

        /// <summary>Mat Cap Bump Map</summary>
        public static readonly int MatCapBumpMap = Shader.PropertyToID(PropertyName.MatCapBumpMap);

        /// <summary>Mat Cap Bump Scale</summary>
        public static readonly int MatCapBumpScale = Shader.PropertyToID(PropertyName.MatCapBumpScale);

        #endregion

        #region MatCap 2nd

        /// <summary>Use Mat Cap 2nd</summary>
        public static readonly int UseMatCap2nd = Shader.PropertyToID(PropertyName.UseMatCap2nd);

        /// <summary>Mat Cap 2nd Color</summary>
        public static readonly int MatCap2ndColor = Shader.PropertyToID(PropertyName.MatCap2ndColor);

        /// <summary>Mat Cap 2nd Texture</summary>
        public static readonly int MatCap2ndTex = Shader.PropertyToID(PropertyName.MatCap2ndTex);

        /// <summary>Mat Cap 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int MatCap2ndMainStrength = Shader.PropertyToID(PropertyName.MatCap2ndMainStrength);

        /// <summary>Mat Cap 2nd Blend UV1</summary>
        public static readonly int MatCap2ndBlendUV1 = Shader.PropertyToID(PropertyName.MatCap2ndBlendUV1);

        /// <summary>Mat Cap 2nd Z-axis rotation Cancel</summary>
        public static readonly int MatCap2ndZRotCancel = Shader.PropertyToID(PropertyName.MatCap2ndZRotCancel);

        /// <summary>Mat Cap 2nd Perspective</summary>
        public static readonly int MatCap2ndPerspective = Shader.PropertyToID(PropertyName.MatCap2ndPerspective);

        /// <summary>Mat Ca p2nd VR Parallax Strength</summary>
        public static readonly int MatCap2ndVRParallaxStrength = Shader.PropertyToID(PropertyName.MatCap2ndVRParallaxStrength);

        /// <summary>Mat Cap 2nd Blend</summary>
        public static readonly int MatCap2ndBlend = Shader.PropertyToID(PropertyName.MatCap2ndBlend);

        /// <summary>Mat Cap 2nd Blend Mask</summary>
        public static readonly int MatCap2ndBlendMask = Shader.PropertyToID(PropertyName.MatCap2ndBlendMask);

        /// <summary>Mat Cap 2nd Enable Lighting</summary>
        public static readonly int MatCap2ndEnableLighting = Shader.PropertyToID(PropertyName.MatCap2ndEnableLighting);

        /// <summary>Mat Cap 2nd Shadow Mask</summary>
        public static readonly int MatCap2ndShadowMask = Shader.PropertyToID(PropertyName.MatCap2ndShadowMask);

        /// <summary>Mat Cap 2nd Backface Mask</summary>
        public static readonly int MatCap2ndBackfaceMask = Shader.PropertyToID(PropertyName.MatCap2ndBackfaceMask);

        /// <summary>Mat Cap 2nd Lod</summary>
        public static readonly int MatCap2ndLod = Shader.PropertyToID(PropertyName.MatCap2ndLod);

        /// <summary>Mat Cap 2nd Blend Mode</summary>
        public static readonly int MatCap2ndBlendMode = Shader.PropertyToID(PropertyName.MatCap2ndBlendMode);

        /// <summary>Mat Cap 2nd Apply Transparency</summary>
        public static readonly int MatCap2ndApplyTransparency = Shader.PropertyToID(PropertyName.MatCap2ndApplyTransparency);

        /// <summary>Mat Cap 2nd Normal Strength</summary>
        public static readonly int MatCap2ndNormalStrength = Shader.PropertyToID(PropertyName.MatCap2ndNormalStrength);

        /// <summary>Mat Cap 2nd Custom Normal Map</summary>
        public static readonly int MatCap2ndCustomNormal = Shader.PropertyToID(PropertyName.MatCap2ndCustomNormal);

        /// <summary>Mat Cap 2nd Bump Map</summary>
        public static readonly int MatCap2ndBumpMap = Shader.PropertyToID(PropertyName.MatCap2ndBumpMap);

        /// <summary>Mat Cap 2nd Bump Scale</summary>
        public static readonly int MatCap2ndBumpScale = Shader.PropertyToID(PropertyName.MatCap2ndBumpScale);

        #endregion

        #region Rim

        /// <summary>Use Rim</summary>
        public static readonly int UseRim = Shader.PropertyToID(PropertyName.UseRim);

        /// <summary>Rim Color</summary>
        public static readonly int RimColor = Shader.PropertyToID(PropertyName.RimColor);

        /// <summary>Rim Color Tex</summary>
        public static readonly int RimColorTex = Shader.PropertyToID(PropertyName.RimColorTex);

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int RimMainStrength = Shader.PropertyToID(PropertyName.RimMainStrength);

        /// <summary>Rim Normal Strength</summary>
        public static readonly int RimNormalStrength = Shader.PropertyToID(PropertyName.RimNormalStrength);

        /// <summary>Rim Border</summary>
        public static readonly int RimBorder = Shader.PropertyToID(PropertyName.RimBorder);

        /// <summary>Rim Blur</summary>
        public static readonly int RimBlur = Shader.PropertyToID(PropertyName.RimBlur);

        /// <summary>Rim Fresnel Power</summary>
        public static readonly int RimFresnelPower = Shader.PropertyToID(PropertyName.RimFresnelPower);

        /// <summary>Rim Enable Lighting</summary>
        public static readonly int RimEnableLighting = Shader.PropertyToID(PropertyName.RimEnableLighting);

        /// <summary>Rim Shadow Mask</summary>
        public static readonly int RimShadowMask = Shader.PropertyToID(PropertyName.RimShadowMask);

        /// <summary>Rim Backface Mask</summary>
        public static readonly int RimBackfaceMask = Shader.PropertyToID(PropertyName.RimBackfaceMask);

        /// <summary>Rim VR Parallax Strength</summary>
        public static readonly int RimVRParallaxStrength = Shader.PropertyToID(PropertyName.RimVRParallaxStrength);

        /// <summary>Rim Apply Transparency</summary>
        public static readonly int RimApplyTransparency = Shader.PropertyToID(PropertyName.RimApplyTransparency);

        /// <summary>Rim Direction Strength</summary>
        public static readonly int RimDirStrength = Shader.PropertyToID(PropertyName.RimDirStrength);

        /// <summary>Rim Direction Range</summary>
        public static readonly int RimDirRange = Shader.PropertyToID(PropertyName.RimDirRange);

        /// <summary>Rim Indirection Range</summary>
        public static readonly int RimIndirRange = Shader.PropertyToID(PropertyName.RimIndirRange);

        /// <summary>Rim Indirection Color</summary>
        public static readonly int RimIndirColor = Shader.PropertyToID(PropertyName.RimIndirColor);

        /// <summary>Rim Indirection Border</summary>
        public static readonly int RimIndirBorder = Shader.PropertyToID(PropertyName.RimIndirBorder);

        /// <summary>Rim Indir Blur</summary>
        public static readonly int RimIndirBlur = Shader.PropertyToID(PropertyName.RimIndirBlur);

        /// <summary>Rim Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int RimBlendMode = Shader.PropertyToID(PropertyName.RimBlendMode);

        #endregion

        #region Glitter

        /// <summary>Use Glitter</summary>
        public static readonly int UseGlitter = Shader.PropertyToID(PropertyName.UseGlitter);

        /// <summary>Glitter UV Mode</summary>
        public static readonly int GlitterUVMode = Shader.PropertyToID(PropertyName.GlitterUVMode);

        /// <summary>Glitter Color</summary>
        public static readonly int GlitterColor = Shader.PropertyToID(PropertyName.GlitterColor);

        /// <summary>Glitter Color Texture</summary>
        public static readonly int GlitterColorTex = Shader.PropertyToID(PropertyName.GlitterColorTex);

        /// <summary>Glitter Color Texture UV Mode</summary>
        /// <remarks>v1.3.2 added</remarks>
        public static readonly int GlitterColorTex_UVMode = Shader.PropertyToID(PropertyName.GlitterColorTex_UVMode);

        /// <summary>Glitter Main Strength</summary>
        public static readonly int GlitterMainStrength = Shader.PropertyToID(PropertyName.GlitterMainStrength);

        /// <summary>Glitter Normal Strength</summary>
        public static readonly int GlitterNormalStrength = Shader.PropertyToID(PropertyName.GlitterNormalStrength);

        /// <summary>Glitter Scale Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterScaleRandomize = Shader.PropertyToID(PropertyName.GlitterScaleRandomize);

        /// <summary>Glitter Apply Shape</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterApplyShape = Shader.PropertyToID(PropertyName.GlitterApplyShape);

        /// <summary>Glitter Shape Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterShapeTex = Shader.PropertyToID(PropertyName.GlitterShapeTex);

        /// <summary>Glitter Atras</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterAtras = Shader.PropertyToID(PropertyName.GlitterAtras);

        /// <summary>Glitter Angle Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterAngleRandomize = Shader.PropertyToID(PropertyName.GlitterAngleRandomize);

        /// <summary>Glitter Params1</summary>
        public static readonly int GlitterParams1 = Shader.PropertyToID(PropertyName.GlitterParams1);

        /// <summary>Glitter Params2</summary>
        public static readonly int GlitterParams2 = Shader.PropertyToID(PropertyName.GlitterParams2);

        /// <summary>Glitter Post Contrast</summary>
        public static readonly int GlitterPostContrast = Shader.PropertyToID(PropertyName.GlitterPostContrast);

        /// <summary>Glitter Sensitivity</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int GlitterSensitivity = Shader.PropertyToID(PropertyName.GlitterSensitivity);

        /// <summary>Glitter Enable Lighting</summary>
        public static readonly int GlitterEnableLighting = Shader.PropertyToID(PropertyName.GlitterEnableLighting);

        /// <summary>Glitter Shadow Mask</summary>
        public static readonly int GlitterShadowMask = Shader.PropertyToID(PropertyName.GlitterShadowMask);

        /// <summary>Glitter Backface Mask</summary>
        public static readonly int GlitterBackfaceMask = Shader.PropertyToID(PropertyName.GlitterBackfaceMask);

        /// <summary>Glitter Apply Transparency</summary>
        public static readonly int GlitterApplyTransparency = Shader.PropertyToID(PropertyName.GlitterApplyTransparency);

        /// <summary>Glitter VR Parallax Strength</summary>
        public static readonly int GlitterVRParallaxStrength = Shader.PropertyToID(PropertyName.GlitterVRParallaxStrength);

        #endregion

        #region Emission

        /// <summary>Use Emission</summary>
        public static readonly int UseEmission = Shader.PropertyToID(PropertyName.UseEmission);

        /// <summary>Emission Color</summary>
        public static readonly int EmissionColor = Shader.PropertyToID(PropertyName.EmissionColor);

        /// <summary>Emission Map</summary>
        public static readonly int EmissionMap = Shader.PropertyToID(PropertyName.EmissionMap);

        /// <summary>Emission Map Scroll Rotate</summary>
        public static readonly int EmissionMap_ScrollRotate = Shader.PropertyToID(PropertyName.EmissionMap_ScrollRotate);

        /// <summary>Emission Map UV Mode</summary>
        public static readonly int EmissionMap_UVMode = Shader.PropertyToID(PropertyName.EmissionMap_UVMode);

        /// <summary>Emission Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int EmissionMainStrength = Shader.PropertyToID(PropertyName.EmissionMainStrength);

        /// <summary>Emission Blend</summary>
        public static readonly int EmissionBlend = Shader.PropertyToID(PropertyName.EmissionBlend);

        /// <summary>Emission Blend Mask</summary>
        public static readonly int EmissionBlendMask = Shader.PropertyToID(PropertyName.EmissionBlendMask);

        /// <summary>Emission Blend Mask Scroll Rotate</summary>
        public static readonly int EmissionBlendMask_ScrollRotate = Shader.PropertyToID(PropertyName.EmissionBlendMask_ScrollRotate);

        /// <summary>Emission Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int EmissionBlendMode = Shader.PropertyToID(PropertyName.EmissionBlendMode);

        /// <summary>Emission Blink</summary>
        public static readonly int EmissionBlink = Shader.PropertyToID(PropertyName.EmissionBlink);

        /// <summary>Emission Use Gradation</summary>
        public static readonly int EmissionUseGrad = Shader.PropertyToID(PropertyName.EmissionUseGrad);

        /// <summary>Emission Gradation Texture</summary>
        public static readonly int EmissionGradTex = Shader.PropertyToID(PropertyName.EmissionGradTex);

        /// <summary>Emission Gradation Speed</summary>
        public static readonly int EmissionGradSpeed = Shader.PropertyToID(PropertyName.EmissionGradSpeed);

        /// <summary>Emission Parallax Depth</summary>
        public static readonly int EmissionParallaxDepth = Shader.PropertyToID(PropertyName.EmissionParallaxDepth);

        /// <summary>Emission Fluorescence</summary>
        public static readonly int EmissionFluorescence = Shader.PropertyToID(PropertyName.EmissionFluorescence);

        #endregion

        #region Emission Gradation

        /// <summary>Egci</summary>
        public static readonly int Egci = Shader.PropertyToID(PropertyName.Egci);

        /// <summary>Egai</summary>
        public static readonly int Egai = Shader.PropertyToID(PropertyName.Egai);

        /// <summary>Egc0</summary>
        public static readonly int Egc0 = Shader.PropertyToID(PropertyName.Egc0);

        /// <summary>Egc1</summary>
        public static readonly int Egc1 = Shader.PropertyToID(PropertyName.Egc1);

        /// <summary>Egc2</summary>
        public static readonly int Egc2 = Shader.PropertyToID(PropertyName.Egc2);

        /// <summary>Egc3</summary>
        public static readonly int Egc3 = Shader.PropertyToID(PropertyName.Egc3);

        /// <summary>Egc4</summary>
        public static readonly int Egc4 = Shader.PropertyToID(PropertyName.Egc4);

        /// <summary>Egc5</summary>
        public static readonly int Egc5 = Shader.PropertyToID(PropertyName.Egc5);

        /// <summary>Egc6</summary>
        public static readonly int Egc6 = Shader.PropertyToID(PropertyName.Egc6);

        /// <summary>Egc7</summary>
        public static readonly int Egc7 = Shader.PropertyToID(PropertyName.Egc7);

        /// <summary>Ega0</summary>
        public static readonly int Ega0 = Shader.PropertyToID(PropertyName.Ega0);

        /// <summary>Ega1</summary>
        public static readonly int Ega1 = Shader.PropertyToID(PropertyName.Ega1);

        /// <summary>Ega2</summary>
        public static readonly int Ega2 = Shader.PropertyToID(PropertyName.Ega2);

        /// <summary>Ega3</summary>
        public static readonly int Ega3 = Shader.PropertyToID(PropertyName.Ega3);

        /// <summary>Ega4</summary>
        public static readonly int Ega4 = Shader.PropertyToID(PropertyName.Ega4);

        /// <summary>Ega5</summary>
        public static readonly int Ega5 = Shader.PropertyToID(PropertyName.Ega5);

        /// <summary>Ega6</summary>
        public static readonly int Ega6 = Shader.PropertyToID(PropertyName.Ega6);

        /// <summary>Ega7</summary>
        public static readonly int Ega7 = Shader.PropertyToID(PropertyName.Ega7);

        #endregion

        #region Emission 2nd

        /// <summary>Use Emission 2nd</summary>
        public static readonly int UseEmission2nd = Shader.PropertyToID(PropertyName.UseEmission2nd);

        /// <summary>Emission 2nd Color</summary>
        public static readonly int Emission2ndColor = Shader.PropertyToID(PropertyName.Emission2ndColor);

        /// <summary>Emission 2nd Map</summary>
        public static readonly int Emission2ndMap = Shader.PropertyToID(PropertyName.Emission2ndMap);

        /// <summary>Emission 2nd Map Scroll Rotate</summary>
        public static readonly int Emission2ndMap_ScrollRotate = Shader.PropertyToID(PropertyName.Emission2ndMap_ScrollRotate);

        /// <summary>Emission 2nd Map UV Mode</summary>
        public static readonly int Emission2ndMap_UVMode = Shader.PropertyToID(PropertyName.Emission2ndMap_UVMode);

        /// <summary>Emission 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int Emission2ndMainStrength = Shader.PropertyToID(PropertyName.Emission2ndMainStrength);

        /// <summary>Emission 2nd Blend</summary>
        public static readonly int Emission2ndBlend = Shader.PropertyToID(PropertyName.Emission2ndBlend);

        /// <summary>Emission 2nd Blend Mask</summary>
        public static readonly int Emission2ndBlendMask = Shader.PropertyToID(PropertyName.Emission2ndBlendMask);

        /// <summary>Emission 2nd BlendMask Scroll Rotate</summary>
        public static readonly int Emission2ndBlendMask_ScrollRotate = Shader.PropertyToID(PropertyName.Emission2ndBlendMask_ScrollRotate);

        /// <summary>Emission 2nd Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int Emission2ndBlendMode = Shader.PropertyToID(PropertyName.Emission2ndBlendMode);

        /// <summary>Emission 2nd Blink</summary>
        public static readonly int Emission2ndBlink = Shader.PropertyToID(PropertyName.Emission2ndBlink);

        /// <summary>Emission 2nd Use Gradation</summary>
        public static readonly int Emission2ndUseGrad = Shader.PropertyToID(PropertyName.Emission2ndUseGrad);

        /// <summary>Emission 2nd Gradation Texture</summary>
        public static readonly int Emission2ndGradTex = Shader.PropertyToID(PropertyName.Emission2ndGradTex);

        /// <summary>Emission 2nd Gradation Speed</summary>
        public static readonly int Emission2ndGradSpeed = Shader.PropertyToID(PropertyName.Emission2ndGradSpeed);

        /// <summary>Emission 2nd Parallax Depth</summary>
        public static readonly int Emission2ndParallaxDepth = Shader.PropertyToID(PropertyName.Emission2ndParallaxDepth);

        /// <summary>Emission 2nd Fluorescence</summary>
        public static readonly int Emission2ndFluorescence = Shader.PropertyToID(PropertyName.Emission2ndFluorescence);

        #endregion

        #region Emission 2nd Gradation

        /// <summary>E2gci</summary>
        public static readonly int E2gci = Shader.PropertyToID(PropertyName.E2gci);

        /// <summary>E2gai</summary>
        public static readonly int E2gai = Shader.PropertyToID(PropertyName.E2gai);

        /// <summary>E2gc0</summary>
        public static readonly int E2gc0 = Shader.PropertyToID(PropertyName.E2gc0);

        /// <summary>E2gc1</summary>
        public static readonly int E2gc1 = Shader.PropertyToID(PropertyName.E2gc1);

        /// <summary>E2gc2</summary>
        public static readonly int E2gc2 = Shader.PropertyToID(PropertyName.E2gc2);

        /// <summary>E2gc3</summary>
        public static readonly int E2gc3 = Shader.PropertyToID(PropertyName.E2gc3);

        /// <summary>E2gc4</summary>
        public static readonly int E2gc4 = Shader.PropertyToID(PropertyName.E2gc4);

        /// <summary>E2gc5</summary>
        public static readonly int E2gc5 = Shader.PropertyToID(PropertyName.E2gc5);

        /// <summary>E2gc6</summary>
        public static readonly int E2gc6 = Shader.PropertyToID(PropertyName.E2gc6);

        /// <summary>E2gc7</summary>
        public static readonly int E2gc7 = Shader.PropertyToID(PropertyName.E2gc7);

        /// <summary>E2ga0</summary>
        public static readonly int E2ga0 = Shader.PropertyToID(PropertyName.E2ga0);

        /// <summary>E2ga1</summary>
        public static readonly int E2ga1 = Shader.PropertyToID(PropertyName.E2ga1);

        /// <summary>E2ga2</summary>
        public static readonly int E2ga2 = Shader.PropertyToID(PropertyName.E2ga2);

        /// <summary>E2ga3</summary>
        public static readonly int E2ga3 = Shader.PropertyToID(PropertyName.E2ga3);

        /// <summary>E2ga4</summary>
        public static readonly int E2ga4 = Shader.PropertyToID(PropertyName.E2ga4);

        /// <summary>E2ga5</summary>
        public static readonly int E2ga5 = Shader.PropertyToID(PropertyName.E2ga5);

        /// <summary>E2ga6</summary>
        public static readonly int E2ga6 = Shader.PropertyToID(PropertyName.E2ga6);

        /// <summary>E2ga7</summary>
        public static readonly int E2ga7 = Shader.PropertyToID(PropertyName.E2ga7);

        #endregion

        #region Parallax

        /// <summary>Use Parallax</summary>
        public static readonly int UseParallax = Shader.PropertyToID(PropertyName.UseParallax);

        /// <summary>Use POM</summary>
        /// <remarks>v1.3.0 from Multi</remarks>
        public static readonly int UsePOM = Shader.PropertyToID(PropertyName.UsePOM);

        /// <summary>Parallax Map</summary>
        public static readonly int ParallaxMap = Shader.PropertyToID(PropertyName.ParallaxMap);

        /// <summary>Parallax Scale</summary>
        public static readonly int Parallax = Shader.PropertyToID(PropertyName.Parallax);

        /// <summary>Parallax Offset</summary>
        public static readonly int ParallaxOffset = Shader.PropertyToID(PropertyName.ParallaxOffset);

        #endregion

        #region Distance Fade

        /// <summary>Distance Fade</summary>
        public static readonly int DistanceFade = Shader.PropertyToID(PropertyName.DistanceFade);

        /// <summary>Distance Fade Color</summary>
        public static readonly int DistanceFadeColor = Shader.PropertyToID(PropertyName.DistanceFadeColor);

        /// <summary>Distance Fade Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int DistanceFadeMode = Shader.PropertyToID(PropertyName.DistanceFadeMode);

        /// <summary>Distance Fade Rim Color</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int DistanceFadeRimColor = Shader.PropertyToID(PropertyName.DistanceFadeRimColor);

        /// <summary>Distance Fade Rim Fresnel Power</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int DistanceFadeRimFresnelPower = Shader.PropertyToID(PropertyName.DistanceFadeRimFresnelPower);

        #endregion

        #region Audio Link

        /// <summary>Use Audio Link</summary>
        public static readonly int UseAudioLink = Shader.PropertyToID(PropertyName.UseAudioLink);

        /// <summary>Audio Link Default Value</summary>
        public static readonly int AudioLinkDefaultValue = Shader.PropertyToID(PropertyName.AudioLinkDefaultValue);

        /// <summary>Audio Link UV Mode</summary>
        public static readonly int AudioLinkUVMode = Shader.PropertyToID(PropertyName.AudioLinkUVMode);

        /// <summary>Audio Link UV Params</summary>
        public static readonly int AudioLinkUVParams = Shader.PropertyToID(PropertyName.AudioLinkUVParams);

        /// <summary>Audio Link Start Position</summary>
        public static readonly int AudioLinkStart = Shader.PropertyToID(PropertyName.AudioLinkStart);

        /// <summary>Audio Link Mask</summary>
        public static readonly int AudioLinkMask = Shader.PropertyToID(PropertyName.AudioLinkMask);

        /// <summary>Audio Link Mask Scroll Rotate</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int AudioLinkMask_ScrollRotate = Shader.PropertyToID(PropertyName.AudioLinkMask_ScrollRotate);

        /// <summary>Audio Link Mask UV Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int AudioLinkMask_UVMode = Shader.PropertyToID(PropertyName.AudioLinkMask_UVMode);

        /// <summary>Audio Link 2 Main 2nd</summary>
        public static readonly int AudioLink2Main2nd = Shader.PropertyToID(PropertyName.AudioLink2Main2nd);

        /// <summary>Audio Link 2 Main 3rd</summary>
        public static readonly int AudioLink2Main3rd = Shader.PropertyToID(PropertyName.AudioLink2Main3rd);

        /// <summary>Audio Link 2 Emission</summary>
        public static readonly int AudioLink2Emission = Shader.PropertyToID(PropertyName.AudioLink2Emission);

        /// <summary>Audio Link 2 Emission Gradation</summary>
        public static readonly int AudioLink2EmissionGrad = Shader.PropertyToID(PropertyName.AudioLink2EmissionGrad);

        /// <summary>Audio Link 2 Emission 2nd</summary>
        public static readonly int AudioLink2Emission2nd = Shader.PropertyToID(PropertyName.AudioLink2Emission2nd);

        /// <summary>Audio Link 2 Emission 2nd Gradation</summary>
        public static readonly int AudioLink2Emission2ndGrad = Shader.PropertyToID(PropertyName.AudioLink2Emission2ndGrad);

        /// <summary>Audio Link 2 Vertex</summary>
        public static readonly int AudioLink2Vertex = Shader.PropertyToID(PropertyName.AudioLink2Vertex);

        /// <summary>Audio Link Vertex UV Mode</summary>
        public static readonly int AudioLinkVertexUVMode = Shader.PropertyToID(PropertyName.AudioLinkVertexUVMode);

        /// <summary>Audio Link Vertex UV Params</summary>
        public static readonly int AudioLinkVertexUVParams = Shader.PropertyToID(PropertyName.AudioLinkVertexUVParams);

        /// <summary>Audio Link Vertex Start Position</summary>
        public static readonly int AudioLinkVertexStart = Shader.PropertyToID(PropertyName.AudioLinkVertexStart);

        /// <summary>Audio Link Vertex Strength</summary>
        public static readonly int AudioLinkVertexStrength = Shader.PropertyToID(PropertyName.AudioLinkVertexStrength);

        /// <summary>Audio Link As Local</summary>
        public static readonly int AudioLinkAsLocal = Shader.PropertyToID(PropertyName.AudioLinkAsLocal);

        /// <summary>Audio Link Local Map</summary>
        public static readonly int AudioLinkLocalMap = Shader.PropertyToID(PropertyName.AudioLinkLocalMap);

        /// <summary>Audio Link Local Map Params</summary>
        public static readonly int AudioLinkLocalMapParams = Shader.PropertyToID(PropertyName.AudioLinkLocalMapParams);

        #endregion

        #region Dissolve

        /// <summary>Dissolve Mask</summary>
        public static readonly int DissolveMask = Shader.PropertyToID(PropertyName.DissolveMask);

        /// <summary>Dissolve Noise Mask</summary>
        public static readonly int DissolveNoiseMask = Shader.PropertyToID(PropertyName.DissolveNoiseMask);

        /// <summary>Dissolve Noise Mask Scroll Rotate</summary>
        public static readonly int DissolveNoiseMask_ScrollRotate = Shader.PropertyToID(PropertyName.DissolveNoiseMask_ScrollRotate);

        /// <summary>Dissolve Noise Strength</summary>
        public static readonly int DissolveNoiseStrength = Shader.PropertyToID(PropertyName.DissolveNoiseStrength);

        /// <summary>Dissolve Color</summary>
        public static readonly int DissolveColor = Shader.PropertyToID(PropertyName.DissolveColor);

        /// <summary>Dissolve Params</summary>
        public static readonly int DissolveParams = Shader.PropertyToID(PropertyName.DissolveParams);

        /// <summary>Dissolve Position</summary>
        public static readonly int DissolvePos = Shader.PropertyToID(PropertyName.DissolvePos);

        #endregion

        #region IDMask

        /// <summary>ID Mask From</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskFrom = Shader.PropertyToID(PropertyName.IDMaskFrom);

        /// <summary>ID Mask 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask1 = Shader.PropertyToID(PropertyName.IDMask1);

        /// <summary>ID Mask 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask2 = Shader.PropertyToID(PropertyName.IDMask2);

        /// <summary>ID Mask 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask3 = Shader.PropertyToID(PropertyName.IDMask3);

        /// <summary>ID Mask 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask4 = Shader.PropertyToID(PropertyName.IDMask4);

        /// <summary>ID Mask 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask5 = Shader.PropertyToID(PropertyName.IDMask5);

        /// <summary>ID Mask 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask6 = Shader.PropertyToID(PropertyName.IDMask6);

        /// <summary>ID Mask 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask7 = Shader.PropertyToID(PropertyName.IDMask7);

        /// <summary>ID Mask 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMask8 = Shader.PropertyToID(PropertyName.IDMask8);

        /// <summary>ID Mask Index 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex1 = Shader.PropertyToID(PropertyName.IDMaskIndex1);

        /// <summary>ID Mask Index 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex2 = Shader.PropertyToID(PropertyName.IDMaskIndex2);

        /// <summary>ID Mask Index 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex3 = Shader.PropertyToID(PropertyName.IDMaskIndex3);

        /// <summary>ID Mask Index 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex4 = Shader.PropertyToID(PropertyName.IDMaskIndex4);

        /// <summary>ID Mask Index 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex5 = Shader.PropertyToID(PropertyName.IDMaskIndex5);

        /// <summary>ID Mask Index 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex6 = Shader.PropertyToID(PropertyName.IDMaskIndex6);

        /// <summary>ID Mask Index 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex7 = Shader.PropertyToID(PropertyName.IDMaskIndex7);

        /// <summary>ID Mask Index 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static readonly int IDMaskIndex8 = Shader.PropertyToID(PropertyName.IDMaskIndex8);

        #endregion

        #region Encryption

        /// <summary>IgnoreEncryption</summary>
        public static readonly int IgnoreEncryption = Shader.PropertyToID(PropertyName.IgnoreEncryption);

        /// <summary>Keys</summary>
        public static readonly int Keys = Shader.PropertyToID(PropertyName.Keys);

        /// <summary>Bit Key 0</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey0 = Shader.PropertyToID(PropertyName.BitKey0);

        /// <summary>Bit Key 1</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey1 = Shader.PropertyToID(PropertyName.BitKey1);

        /// <summary>Bit Key 2</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey2 = Shader.PropertyToID(PropertyName.BitKey2);

        /// <summary>Bit Key 3</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey3 = Shader.PropertyToID(PropertyName.BitKey3);

        /// <summary>Bit Key 4</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey4 = Shader.PropertyToID(PropertyName.BitKey4);

        /// <summary>Bit Key 5</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey5 = Shader.PropertyToID(PropertyName.BitKey5);

        /// <summary>Bit Key 6</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey6 = Shader.PropertyToID(PropertyName.BitKey6);

        /// <summary>Bit Key 7</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey7 = Shader.PropertyToID(PropertyName.BitKey7);

        /// <summary>Bit Key 8</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey8 = Shader.PropertyToID(PropertyName.BitKey8);

        /// <summary>Bit Key 9</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey9 = Shader.PropertyToID(PropertyName.BitKey9);

        /// <summary>Bit Key 10</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey10 = Shader.PropertyToID(PropertyName.BitKey10);

        /// <summary>Bit Key 11</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey11 = Shader.PropertyToID(PropertyName.BitKey11);

        /// <summary>Bit Key 12</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey12 = Shader.PropertyToID(PropertyName.BitKey12);

        /// <summary>Bit Key 13</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey13 = Shader.PropertyToID(PropertyName.BitKey13);

        /// <summary>Bit Key 14</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey14 = Shader.PropertyToID(PropertyName.BitKey14);

        /// <summary>Bit Key 15</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey15 = Shader.PropertyToID(PropertyName.BitKey15);

        /// <summary>Bit Key 16</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey16 = Shader.PropertyToID(PropertyName.BitKey16);

        /// <summary>Bit Key 17</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey17 = Shader.PropertyToID(PropertyName.BitKey17);

        /// <summary>Bit Key 18</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey18 = Shader.PropertyToID(PropertyName.BitKey18);

        /// <summary>Bit Key 19</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey19 = Shader.PropertyToID(PropertyName.BitKey19);

        /// <summary>Bit Key 20</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey20 = Shader.PropertyToID(PropertyName.BitKey20);

        /// <summary>Bit Key 21</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey21 = Shader.PropertyToID(PropertyName.BitKey21);

        /// <summary>Bit Key 22</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey22 = Shader.PropertyToID(PropertyName.BitKey22);

        /// <summary>Bit Key 23</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey23 = Shader.PropertyToID(PropertyName.BitKey23);

        /// <summary>Bit Key 24</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey24 = Shader.PropertyToID(PropertyName.BitKey24);

        /// <summary>Bit Key 25</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey25 = Shader.PropertyToID(PropertyName.BitKey25);

        /// <summary>Bit Key 26</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey26 = Shader.PropertyToID(PropertyName.BitKey26);

        /// <summary>Bit Key 27</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey27 = Shader.PropertyToID(PropertyName.BitKey27);

        /// <summary>Bit Key 28</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey28 = Shader.PropertyToID(PropertyName.BitKey28);

        /// <summary>Bit Key 29</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey29 = Shader.PropertyToID(PropertyName.BitKey29);

        /// <summary>Bit Key 30</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey30 = Shader.PropertyToID(PropertyName.BitKey30);

        /// <summary>Bit Key 31</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static readonly int BitKey31 = Shader.PropertyToID(PropertyName.BitKey31);

        #endregion

        #region Refraction

        /// <summary>Refraction Strength</summary>
        public static readonly int RefractionStrength = Shader.PropertyToID(PropertyName.RefractionStrength);

        /// <summary>Refraction Fresnel Power</summary>
        public static readonly int RefractionFresnelPower = Shader.PropertyToID(PropertyName.RefractionFresnelPower);

        /// <summary>Refraction Color From Main</summary>
        public static readonly int RefractionColorFromMain = Shader.PropertyToID(PropertyName.RefractionColorFromMain);

        /// <summary>Refraction Color</summary>
        public static readonly int RefractionColor = Shader.PropertyToID(PropertyName.RefractionColor);

        #endregion

        #region Fur

        /// <summary>Fur Noise Mask</summary>
        public static readonly int FurNoiseMask = Shader.PropertyToID(PropertyName.FurNoiseMask);

        /// <summary>Fur Mask</summary>
        public static readonly int FurMask = Shader.PropertyToID(PropertyName.FurMask);

        /// <summary>Fur Length Mask</summary>
        public static readonly int FurLengthMask = Shader.PropertyToID(PropertyName.FurLengthMask);

        /// <summary>Fur Vector Texture</summary>
        public static readonly int FurVectorTex = Shader.PropertyToID(PropertyName.FurVectorTex);

        /// <summary>Fur Vector Scale</summary>
        public static readonly int FurVectorScale = Shader.PropertyToID(PropertyName.FurVectorScale);

        /// <summary>Fur Vector</summary>
        public static readonly int FurVector = Shader.PropertyToID(PropertyName.FurVector);

        /// <summary>Vertex Color to Fur Vector</summary>
        public static readonly int VertexColor2FurVector = Shader.PropertyToID(PropertyName.VertexColor2FurVector);

        /// <summary>Fur Gravity</summary>
        public static readonly int FurGravity = Shader.PropertyToID(PropertyName.FurGravity);

        /// <summary>Fur Randomize</summary>
        public static readonly int FurRandomize = Shader.PropertyToID(PropertyName.FurRandomize);

        /// <summary>Fur AO</summary>
        public static readonly int FurAO = Shader.PropertyToID(PropertyName.FurAO);

        /// <summary>Fur Mesh Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int FurMeshType = Shader.PropertyToID(PropertyName.FurMeshType);

        /// <summary>Fur Layer Num</summary>
        public static readonly int FurLayerNum = Shader.PropertyToID(PropertyName.FurLayerNum);

        /// <summary>Fur Root Offset</summary>
        public static readonly int FurRootOffset = Shader.PropertyToID(PropertyName.FurRootOffset);

        /// <summary>Fur Cutout Length</summary>
        public static readonly int FurCutoutLength = Shader.PropertyToID(PropertyName.FurCutoutLength);

        /// <summary>Fur Touch Strength</summary>
        public static readonly int FurTouchStrength = Shader.PropertyToID(PropertyName.FurTouchStrength);

        #endregion

        #region Fur Rendering

        /// <summary>Fur Cull</summary>
        public static readonly int FurCull = Shader.PropertyToID(PropertyName.FurCull);

        /// <summary>Fur Z Clip</summary>
        public static readonly int FurZClip = Shader.PropertyToID(PropertyName.FurZClip);

        /// <summary>Fur Z Write</summary>
        public static readonly int FurZWrite = Shader.PropertyToID(PropertyName.FurZWrite);

        /// <summary>Fur Z Test</summary>
        public static readonly int FurZTest = Shader.PropertyToID(PropertyName.FurZTest);

        /// <summary>Fur Offset Factor</summary>
        public static readonly int FurOffsetFactor = Shader.PropertyToID(PropertyName.FurOffsetFactor);

        /// <summary>Fur Offset Units</summary>
        public static readonly int FurOffsetUnits = Shader.PropertyToID(PropertyName.FurOffsetUnits);

        /// <summary>Fur Color Mask</summary>
        public static readonly int FurColorMask = Shader.PropertyToID(PropertyName.FurColorMask);

        /// <summary>Fur Alpha To Mask</summary>
        public static readonly int FurAlphaToMask = Shader.PropertyToID(PropertyName.FurAlphaToMask);

        #endregion

        #region Fur Rendering Forward

        /// <summary>Fur Src Blend</summary>
        public static readonly int FurSrcBlend = Shader.PropertyToID(PropertyName.FurSrcBlend);

        /// <summary>Fur Dst Blend</summary>
        public static readonly int FurDstBlend = Shader.PropertyToID(PropertyName.FurDstBlend);

        /// <summary>Fur Src Blend Alpha</summary>
        public static readonly int FurSrcBlendAlpha = Shader.PropertyToID(PropertyName.FurSrcBlendAlpha);

        /// <summary>Fur Dst Blend Alpha</summary>
        public static readonly int FurDstBlendAlpha = Shader.PropertyToID(PropertyName.FurDstBlendAlpha);

        /// <summary>Fur Blend Op</summary>
        public static readonly int FurBlendOp = Shader.PropertyToID(PropertyName.FurBlendOp);

        /// <summary>Fur Blend Op Alpha</summary>
        public static readonly int FurBlendOpAlpha = Shader.PropertyToID(PropertyName.FurBlendOpAlpha);

        #endregion

        #region Fur Rendering Forward Add

        /// <summary>Fur Src Blend ForwardAdd</summary>
        public static readonly int FurSrcBlendFA = Shader.PropertyToID(PropertyName.FurSrcBlendFA);

        /// <summary>Fur Dst Blend ForwardAdd</summary>
        public static readonly int FurDstBlendFA = Shader.PropertyToID(PropertyName.FurDstBlendFA);

        /// <summary>Fur Src Blend Alpha ForwardAdd</summary>
        public static readonly int FurSrcBlendAlphaFA = Shader.PropertyToID(PropertyName.FurSrcBlendAlphaFA);

        /// <summary>Fur Dst Blend Alpha ForwardAdd</summary>
        public static readonly int FurDstBlendAlphaFA = Shader.PropertyToID(PropertyName.FurDstBlendAlphaFA);

        /// <summary>Fur Blend Op ForwardAdd</summary>
        public static readonly int FurBlendOpFA = Shader.PropertyToID(PropertyName.FurBlendOpFA);

        /// <summary>Fur Blend Op Alpha ForwardAdd</summary>
        public static readonly int FurBlendOpAlphaFA = Shader.PropertyToID(PropertyName.FurBlendOpAlphaFA);

        #endregion

        #region Fur Rendering Stencil

        /// <summary>Fur Stencil Reference</summary>
        public static readonly int FurStencilRef = Shader.PropertyToID(PropertyName.FurStencilRef);

        /// <summary>Fur Stencil Read Mask</summary>
        public static readonly int FurStencilReadMask = Shader.PropertyToID(PropertyName.FurStencilReadMask);

        /// <summary>Fur Stencil Write Mask</summary>
        public static readonly int FurStencilWriteMask = Shader.PropertyToID(PropertyName.FurStencilWriteMask);

        /// <summary>Fur Stencil Compare Function</summary>
        public static readonly int FurStencilComp = Shader.PropertyToID(PropertyName.FurStencilComp);

        /// <summary>Fur Stencil Pass</summary>
        public static readonly int FurStencilPass = Shader.PropertyToID(PropertyName.FurStencilPass);

        /// <summary>Fur StencilFail</summary>
        public static readonly int FurStencilFail = Shader.PropertyToID(PropertyName.FurStencilFail);

        /// <summary>Fur Stencil Z Fail</summary>
        public static readonly int FurStencilZFail = Shader.PropertyToID(PropertyName.FurStencilZFail);

        #endregion

        #region Gem

        /// <summary>Gem Chromatic Aberration</summary>
        public static readonly int GemChromaticAberration = Shader.PropertyToID(PropertyName.GemChromaticAberration);

        /// <summary>Gem Environment Contrast</summary>
        public static readonly int GemEnvContrast = Shader.PropertyToID(PropertyName.GemEnvContrast);

        /// <summary>Gem Environment Color</summary>
        public static readonly int GemEnvColor = Shader.PropertyToID(PropertyName.GemEnvColor);

        /// <summary>Gem Particle Loop</summary>
        public static readonly int GemParticleLoop = Shader.PropertyToID(PropertyName.GemParticleLoop);

        /// <summary>Gem Particle Color</summary>
        public static readonly int GemParticleColor = Shader.PropertyToID(PropertyName.GemParticleColor);

        /// <summary>Gem VR Parallax Strength</summary>
        public static readonly int GemVRParallaxStrength = Shader.PropertyToID(PropertyName.GemVRParallaxStrength);

        #endregion

        #region Tessellation

        /// <summary>Tessellation Edge</summary>
        public static readonly int TessEdge = Shader.PropertyToID(PropertyName.TessEdge);

        /// <summary>Tessellation Strength</summary>
        public static readonly int TessStrength = Shader.PropertyToID(PropertyName.TessStrength);

        /// <summary>Tessellation Shrink</summary>
        public static readonly int TessShrink = Shader.PropertyToID(PropertyName.TessShrink);

        /// <summary>Tessellation Factor Max</summary>
        public static readonly int TessFactorMax = Shader.PropertyToID(PropertyName.TessFactorMax);

        #endregion

        #region Outline

        /// <summary>Outline Color</summary>
        public static readonly int OutlineColor = Shader.PropertyToID(PropertyName.OutlineColor);

        /// <summary>Outline Texture</summary>
        public static readonly int OutlineTex = Shader.PropertyToID(PropertyName.OutlineTex);

        /// <summary>Outline Texture Scroll Rotate</summary>
        public static readonly int OutlineTex_ScrollRotate = Shader.PropertyToID(PropertyName.OutlineTex_ScrollRotate);

        /// <summary>Outline Texture HSVG</summary>
        public static readonly int OutlineTexHSVG = Shader.PropertyToID(PropertyName.OutlineTexHSVG);

        /// <summary>Outline Lit Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineLitColor = Shader.PropertyToID(PropertyName.OutlineLitColor);

        /// <summary>Outline Lit Apply Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineLitApplyTex = Shader.PropertyToID(PropertyName.OutlineLitApplyTex);

        /// <summary>Outline Lit Scale</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineLitScale = Shader.PropertyToID(PropertyName.OutlineLitScale);

        /// <summary>Outline Lit Offset</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineLitOffset = Shader.PropertyToID(PropertyName.OutlineLitOffset);

        /// <summary>Outline Lit Receive Shadow</summary>
        /// <remarks>v1.3.1 added</remarks>
        public static readonly int OutlineLitShadowReceive = Shader.PropertyToID(PropertyName.OutlineLitShadowReceive);

        /// <summary>Outline Width</summary>
        public static readonly int OutlineWidth = Shader.PropertyToID(PropertyName.OutlineWidth);

        /// <summary>Outline Width Mask</summary>
        public static readonly int OutlineWidthMask = Shader.PropertyToID(PropertyName.OutlineWidthMask);

        /// <summary>Outline Fix Width</summary>
        public static readonly int OutlineFixWidth = Shader.PropertyToID(PropertyName.OutlineFixWidth);

        /// <summary>Outline Vertex R2 Width</summary>
        public static readonly int OutlineVertexR2Width = Shader.PropertyToID(PropertyName.OutlineVertexR2Width);

        /// <summary>Outline Delete Mesh</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineDeleteMesh = Shader.PropertyToID(PropertyName.OutlineDeleteMesh);

        /// <summary>Outline Vector Texture</summary>
        public static readonly int OutlineVectorTex = Shader.PropertyToID(PropertyName.OutlineVectorTex);

        /// <summary>Outline Vector UV Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineVectorUVMode = Shader.PropertyToID(PropertyName.OutlineVectorUVMode);

        /// <summary>Outline Vector Scale</summary>
        public static readonly int OutlineVectorScale = Shader.PropertyToID(PropertyName.OutlineVectorScale);

        /// <summary>Outline Enable Lighting</summary>
        public static readonly int OutlineEnableLighting = Shader.PropertyToID(PropertyName.OutlineEnableLighting);

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineZBias = Shader.PropertyToID(PropertyName.OutlineZBias);

        /// <summary>Outline Disable in VR</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int OutlineDisableInVR = Shader.PropertyToID(PropertyName.OutlineDisableInVR);

        #endregion

        #region Outline Rendering

        /// <summary>Outline Cull</summary>
        public static readonly int OutlineCull = Shader.PropertyToID(PropertyName.OutlineCull);

        /// <summary>Outline Z Clip</summary>
        public static readonly int OutlineZClip = Shader.PropertyToID(PropertyName.OutlineZClip);

        /// <summary>Outline Z Write</summary>
        public static readonly int OutlineZWrite = Shader.PropertyToID(PropertyName.OutlineZWrite);

        /// <summary>Outline Z Test</summary>
        public static readonly int OutlineZTest = Shader.PropertyToID(PropertyName.OutlineZTest);

        /// <summary>Outline Offset Factor</summary>
        public static readonly int OutlineOffsetFactor = Shader.PropertyToID(PropertyName.OutlineOffsetFactor);

        /// <summary>Outline Offset Units</summary>
        public static readonly int OutlineOffsetUnits = Shader.PropertyToID(PropertyName.OutlineOffsetUnits);

        /// <summary>Outline Color Mask</summary>
        public static readonly int OutlineColorMask = Shader.PropertyToID(PropertyName.OutlineColorMask);

        /// <summary>Outline Alpha To Mask</summary>
        public static readonly int OutlineAlphaToMask = Shader.PropertyToID(PropertyName.OutlineAlphaToMask);

        #endregion

        #region Outline Rendering Forward

        /// <summary>Outline SrcBlend</summary>
        public static readonly int OutlineSrcBlend = Shader.PropertyToID(PropertyName.OutlineSrcBlend);

        /// <summary>Outline Dst Blend</summary>
        public static readonly int OutlineDstBlend = Shader.PropertyToID(PropertyName.OutlineDstBlend);

        /// <summary>Outline Src Blend Alpha</summary>
        public static readonly int OutlineSrcBlendAlpha = Shader.PropertyToID(PropertyName.OutlineSrcBlendAlpha);

        /// <summary>Outline Dst Blend Alpha</summary>
        public static readonly int OutlineDstBlendAlpha = Shader.PropertyToID(PropertyName.OutlineDstBlendAlpha);

        /// <summary>Outline Blend Op</summary>
        public static readonly int OutlineBlendOp = Shader.PropertyToID(PropertyName.OutlineBlendOp);

        /// <summary>Outline Blend Op Alpha</summary>
        public static readonly int OutlineBlendOpAlpha = Shader.PropertyToID(PropertyName.OutlineBlendOpAlpha);

        #endregion

        #region Outline Rendering Forward Add

        /// <summary>Outline Src Blend FA</summary>
        public static readonly int OutlineSrcBlendFA = Shader.PropertyToID(PropertyName.OutlineSrcBlendFA);

        /// <summary>Outline Dst Blend FA</summary>
        public static readonly int OutlineDstBlendFA = Shader.PropertyToID(PropertyName.OutlineDstBlendFA);

        /// <summary>Outline Src Blend Alpha FA</summary>
        public static readonly int OutlineSrcBlendAlphaFA = Shader.PropertyToID(PropertyName.OutlineSrcBlendAlphaFA);

        /// <summary>Outline Dst Blend Alpha FA</summary>
        public static readonly int OutlineDstBlendAlphaFA = Shader.PropertyToID(PropertyName.OutlineDstBlendAlphaFA);

        /// <summary>Outline Blend Op FA</summary>
        public static readonly int OutlineBlendOpFA = Shader.PropertyToID(PropertyName.OutlineBlendOpFA);

        /// <summary>Outline Blend Op Alpha FA</summary>
        public static readonly int OutlineBlendOpAlphaFA = Shader.PropertyToID(PropertyName.OutlineBlendOpAlphaFA);

        #endregion

        #region Outline Rendering Stencil

        /// <summary>Outline Stencil Ref</summary>
        public static readonly int OutlineStencilRef = Shader.PropertyToID(PropertyName.OutlineStencilRef);

        /// <summary>Outline Stencil Read Mask</summary>
        public static readonly int OutlineStencilReadMask = Shader.PropertyToID(PropertyName.OutlineStencilReadMask);

        /// <summary>Outline Stencil Write Mask</summary>
        public static readonly int OutlineStencilWriteMask = Shader.PropertyToID(PropertyName.OutlineStencilWriteMask);

        /// <summary>Outline Stencil Comp</summary>
        public static readonly int OutlineStencilComp = Shader.PropertyToID(PropertyName.OutlineStencilComp);

        /// <summary>Outline Stencil Pass</summary>
        public static readonly int OutlineStencilPass = Shader.PropertyToID(PropertyName.OutlineStencilPass);

        /// <summary>Outline Stencil Fail</summary>
        public static readonly int OutlineStencilFail = Shader.PropertyToID(PropertyName.OutlineStencilFail);

        /// <summary>Outline Stencil Z Fail</summary>
        public static readonly int OutlineStencilZFail = Shader.PropertyToID(PropertyName.OutlineStencilZFail);

        #endregion

        #region Multi

        /// <summary>Use Outline</summary>
        public static readonly int UseOutline = Shader.PropertyToID(PropertyName.UseOutline);

        /// <summary>Transparent Mode</summary>
        public static readonly int TransparentMode = Shader.PropertyToID(PropertyName.TransparentMode);

        ///// <summary>Use POM</summary>
        ///// <remarks>v1.3.0 to Parallax</remarks>
        //public static readonly int UsePOM = Shader.PropertyToID(PropertyName.UsePOM);

        /// <summary>Use Clipping Canceller</summary>
        public static readonly int UseClippingCanceller = Shader.PropertyToID(PropertyName.UseClippingCanceller);

        /// <summary>As Overlay</summary>
        public static readonly int AsOverlay = Shader.PropertyToID(PropertyName.AsOverlay);

        #endregion

        #region Lite

        /// <summary>Tri Mask</summary>
        public static readonly int TriMask = Shader.PropertyToID(PropertyName.TriMask);

        /// <summary>Mat Cap Mul</summary>
        public static readonly int MatCapMul = Shader.PropertyToID(PropertyName.MatCapMul);

        #endregion

        #region Fake Shadow

        /// <summary>Fake Shadow Vector</summary>
        public static readonly int FakeShadowVector = Shader.PropertyToID(PropertyName.FakeShadowVector);

        #endregion

        #region Rendering

        /// <summary>Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        public static readonly int Cutoff = Shader.PropertyToID(PropertyName.Cutoff);

        /// <summary>Subpass Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        public static readonly int SubpassCutoff = Shader.PropertyToID(PropertyName.SubpassCutoff);

        /// <summary>Cull Mode</summary>
        public static readonly int Cull = Shader.PropertyToID(PropertyName.Cull);

        /// <summary>Z Clip</summary>
        public static readonly int ZClip = Shader.PropertyToID(PropertyName.ZClip);

        /// <summary>Z Write</summary>
        public static readonly int ZWrite = Shader.PropertyToID(PropertyName.ZWrite);

        /// <summary>Z Test</summary>
        public static readonly int ZTest = Shader.PropertyToID(PropertyName.ZTest);

        /// <summary>Offset Factor</summary>
        public static readonly int OffsetFactor = Shader.PropertyToID(PropertyName.OffsetFactor);

        /// <summary>Offset Units</summary>
        public static readonly int OffsetUnits = Shader.PropertyToID(PropertyName.OffsetUnits);

        /// <summary>Color Mask</summary>
        public static readonly int ColorMask = Shader.PropertyToID(PropertyName.ColorMask);

        /// <summary>Alpha To Mask</summary>
        public static readonly int AlphaToMask = Shader.PropertyToID(PropertyName.AlphaToMask);

        /// <summary>Shadow Caster Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static readonly int LilShadowCasterBias = Shader.PropertyToID(PropertyName.LilShadowCasterBias);

        #endregion

        #region Rendering Forward

        /// <summary>Src Blend</summary>
        public static readonly int SrcBlend = Shader.PropertyToID(PropertyName.SrcBlend);

        /// <summary>Dst Blend</summary>
        public static readonly int DstBlend = Shader.PropertyToID(PropertyName.DstBlend);

        /// <summary>Src Blend Alpha</summary>
        public static readonly int SrcBlendAlpha = Shader.PropertyToID(PropertyName.SrcBlendAlpha);

        /// <summary>Dst Blend Alpha</summary>
        public static readonly int DstBlendAlpha = Shader.PropertyToID(PropertyName.DstBlendAlpha);

        /// <summary>Blend Op</summary>
        public static readonly int BlendOp = Shader.PropertyToID(PropertyName.BlendOp);

        /// <summary>Blend Op Alpha</summary>
        public static readonly int BlendOpAlpha = Shader.PropertyToID(PropertyName.BlendOpAlpha);

        #endregion

        #region Rendering Forward Add

        /// <summary>Src Blend FA</summary>
        public static readonly int SrcBlendFA = Shader.PropertyToID(PropertyName.SrcBlendFA);

        /// <summary>Dst Blend FA</summary>
        public static readonly int DstBlendFA = Shader.PropertyToID(PropertyName.DstBlendFA);

        /// <summary>Src Blend Alpha FA</summary>
        public static readonly int SrcBlendAlphaFA = Shader.PropertyToID(PropertyName.SrcBlendAlphaFA);

        /// <summary>Dst Blend Alpha FA</summary>
        public static readonly int DstBlendAlphaFA = Shader.PropertyToID(PropertyName.DstBlendAlphaFA);

        /// <summary>Blend Op FA</summary>
        public static readonly int BlendOpFA = Shader.PropertyToID(PropertyName.BlendOpFA);

        /// <summary>Blend Op Alpha FA</summary>
        public static readonly int BlendOpAlphaFA = Shader.PropertyToID(PropertyName.BlendOpAlphaFA);

        #endregion

        #region Rendering Stencil

        /// <summary>Stencil Ref</summary>
        public static readonly int StencilRef = Shader.PropertyToID(PropertyName.StencilRef);

        /// <summary>Stencil Read Mask</summary>
        public static readonly int StencilReadMask = Shader.PropertyToID(PropertyName.StencilReadMask);

        /// <summary>Stencil Write Mask</summary>
        public static readonly int StencilWriteMask = Shader.PropertyToID(PropertyName.StencilWriteMask);

        /// <summary>Stencil Comp</summary>
        public static readonly int StencilComp = Shader.PropertyToID(PropertyName.StencilComp);

        /// <summary>Stencil Pass</summary>
        public static readonly int StencilPass = Shader.PropertyToID(PropertyName.StencilPass);

        /// <summary>Stencil Fail</summary>
        public static readonly int StencilFail = Shader.PropertyToID(PropertyName.StencilFail);

        /// <summary>Stencil Z Fail</summary>
        public static readonly int StencilZFail = Shader.PropertyToID(PropertyName.StencilZFail);

        #endregion

        #region Save

        /// <summary>Base Map</summary>
        public static readonly int BaseMap = Shader.PropertyToID(PropertyName.BaseMap);

        /// <summary>Base Color</summary>
        public static readonly int BaseColor = Shader.PropertyToID(PropertyName.BaseColor);

        /// <summary>Base Color Map</summary>
        public static readonly int BaseColorMap = Shader.PropertyToID(PropertyName.BaseColorMap);

        /// <summary>LilToon Version</summary>
        public static readonly int LilToonVersion = Shader.PropertyToID(PropertyName.LilToonVersion);

        #endregion
    }
}