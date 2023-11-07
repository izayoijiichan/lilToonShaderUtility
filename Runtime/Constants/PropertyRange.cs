// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
#nullable enable
#pragma warning disable IDE0090
namespace LilToonShader
{
    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        #region Base

        /// <summary>Anti-Aliasing Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        public static FloatRangeDefault AAStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Lighting

        /// <summary>Light Min Limit</summary>
        public static FloatRangeDefault LightMinLimit = new FloatRangeDefault(0.0f, 1.0f, 0.05f);

        /// <summary>Light Max Limit</summary>
        public static FloatRangeDefault LightMaxLimit = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Monochrome Lighting</summary>
        public static FloatRangeDefault MonochromeLighting = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Vertex Light Strength</summary>
        public static FloatRangeDefault VertexLightStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Alpha Boost Forward Add</summary>
        public static FloatRangeDefault AlphaBoostFA = new FloatRangeDefault(1f, 100f, 10f);

        /// <summary>Directional Light Strength</summary>
        public static FloatRangeDefault LilDirectionalLightStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Main

        /// <summary>Main Gradation Strength</summary>
        public static FloatRangeDefault MainGradationStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region NormalMap

        /// <summary>Bump Scale</summary>
        public static FloatRangeDefault BumpScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        /// <summary>Bump 2nd Scale</summary>
        public static FloatRangeDefault Bump2ndScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        #endregion

        #region Anisotropy

        /// <summary>Anisotropy Scale</summary>
        public static FloatRangeDefault AnisotropyScale = new FloatRangeDefault(-1.0f, 1.0f, 1.0f);

        /// <summary>Anisotropy Tangent Width</summary>
        public static FloatRangeDefault AnisotropyTangentWidth = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Anisotropy Bitangent Width</summary>
        public static FloatRangeDefault AnisotropyBitangentWidth = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Anisotropy Shift</summary>
        public static FloatRangeDefault AnisotropyShift = new FloatRangeDefault(-10.0f, 10.0f, 0.0f);

        /// <summary>Anisotropy Shift Noise Scale</summary>
        public static FloatRangeDefault AnisotropyShiftNoiseScale = new FloatRangeDefault(-1.0f, 1.0f, 0.0f);

        /// <summary>Anisotropy Specular Strength</summary>
        public static FloatRangeDefault AnisotropySpecularStrength = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        public static FloatRangeDefault Anisotropy2ndTangentWidth = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        public static FloatRangeDefault Anisotropy2ndBitangentWidth = new FloatRangeDefault(0.0f, 10.0f, 1.0f);

        /// <summary>Anisotropy 2nd Shift</summary>
        public static FloatRangeDefault Anisotropy2ndShift = new FloatRangeDefault(-10.0f, 10.0f, 0.0f);

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        public static FloatRangeDefault Anisotropy2ndShiftNoiseScale = new FloatRangeDefault(-1.0f, 1.0f, 0.0f);

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        public static FloatRangeDefault Anisotropy2ndSpecularStrength = new FloatRangeDefault(0.0f, 10.0f, 0.0f);

        #endregion

        #region Backlight

        /// <summary>Backlight Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault BacklightMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Backlight Normal Strength</summary>
        public static FloatRangeDefault BacklightNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Backlight Border</summary>
        public static FloatRangeDefault BacklightBorder = new FloatRangeDefault(0.0f, 1.0f, 0.35f);

        /// <summary>Backlight Blur</summary>
        public static FloatRangeDefault BacklightBlur = new FloatRangeDefault(0.0f, 1.0f, 0.05f);

        /// <summary>Backlight View Strength</summary>
        public static FloatRangeDefault BacklightViewStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Shadow

        /// <summary>Shadow Strength</summary>
        public static FloatRangeDefault ShadowStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Strength Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault ShadowStrengthMaskLOD = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Border Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault ShadowBorderMaskLOD = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Blur Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault ShadowBlurMaskLOD = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Normal Strength</summary>
        public static FloatRangeDefault ShadowNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Shadow Border</summary>
        public static FloatRangeDefault ShadowBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Shadow Blur</summary>
        public static FloatRangeDefault ShadowBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Shadow 2nd Normal Strength</summary>
        public static FloatRangeDefault Shadow2ndNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Shadow 2nd Border</summary>
        public static FloatRangeDefault Shadow2ndBorder = new FloatRangeDefault(0.0f, 1.0f, 0.15f);

        /// <summary>Shadow 2nd Blur</summary>
        public static FloatRangeDefault Shadow2ndBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Shadow 3rd Normal Strength</summary>
        public static FloatRangeDefault Shadow3rdNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Shadow 3rd Border</summary>
        public static FloatRangeDefault Shadow3rdBorder = new FloatRangeDefault(0.0f, 1.0f, 0.25f);

        /// <summary>Shadow 3rd Blur</summary>
        public static FloatRangeDefault Shadow3rdBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Shadow Border Range</summary>
        public static FloatRangeDefault ShadowBorderRange = new FloatRangeDefault(0.0f, 1.0f, 0.08f);

        /// <summary>Shadow Main Strength</summary>
        public static FloatRangeDefault ShadowMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Environment Strength</summary>
        public static FloatRangeDefault ShadowEnvStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Flat Border</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault ShadowFlatBorder = new FloatRangeDefault(-2.0f, 2.0f, 1.0f);

        /// <summary>Shadow Flat Blur</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault ShadowFlatBlur = new FloatRangeDefault(0.001f, 2.0f, 1.0f);

        #endregion

        #region Reflection

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Smoothness = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Reflectance</summary>
        public static FloatRangeDefault Reflectance = new FloatRangeDefault(0.0f, 1.0f, 0.04f);

        /// <summary>Geometric Specular Anti-Aliasing (GSAA) Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault GSAAStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Specular Normal Strength</summary>
        public static FloatRangeDefault SpecularNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Specular Border</summary>
        public static FloatRangeDefault SpecularBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Specular Blur</summary>
        public static FloatRangeDefault SpecularBlur = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Reflection Normal Strength</summary>
        public static FloatRangeDefault ReflectionNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Reflection Cube Enable Lighting</summary>
        public static FloatRangeDefault ReflectionCubeEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region MatCap

        /// <summary>Mat Cap Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault MatCapMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Mat Cap VR Parallax Strength</summary>
        public static FloatRangeDefault MatCapVRParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap Blend</summary>
        public static FloatRangeDefault MatCapBlend = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap Enable Lighting</summary>
        public static FloatRangeDefault MatCapEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap Shadow Mask</summary>
        public static FloatRangeDefault MatCapShadowMask = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Mat Cap Lod</summary>
        public static FloatRangeDefault MatCapLod = new FloatRangeDefault(0.0f, 10.0f, 0.0f);

        /// <summary>Mat Cap Normal Strength</summary>
        public static FloatRangeDefault MatCapNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap Bump Scale</summary>
        public static FloatRangeDefault MatCapBumpScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        /// <summary>Mat Cap 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault MatCap2ndMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Mat Cap 2nd VR Parallax Strength</summary>
        public static FloatRangeDefault MatCap2ndVRParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap 2nd Blend</summary>
        public static FloatRangeDefault MatCap2ndBlend = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap 2nd Enable Lighting</summary>
        public static FloatRangeDefault MatCap2ndEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap 2nd Shadow Mask</summary>
        public static FloatRangeDefault MatCap2ndShadowMask = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Mat Cap 2nd Lod</summary>
        public static FloatRangeDefault MatCap2ndLod = new FloatRangeDefault(0.0f, 10.0f, 0.0f);

        /// <summary>Mat Cap 2nd Normal Strength</summary>
        public static FloatRangeDefault MatCap2ndNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Mat Cap 2nd Bump Scale</summary>
        public static FloatRangeDefault MatCap2ndBumpScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        #endregion

        #region Rim

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault RimMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Rim Normal Strength</summary>
        public static FloatRangeDefault RimNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Rim Border</summary>
        public static FloatRangeDefault RimBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Rim Blur</summary>
        public static FloatRangeDefault RimBlur = new FloatRangeDefault(0.0f, 1.0f, 0.65f);

        /// <summary>Rim Fresnel Power</summary>
        public static FloatRangeDefault RimFresnelPower = new FloatRangeDefault(0.01f, 50.0f, 3.5f);

        /// <summary>Rim Enable Lighting</summary>
        public static FloatRangeDefault RimEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Rim Shadow Mask</summary>
        public static FloatRangeDefault RimShadowMask = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Rim VR Parallax Strength</summary>
        public static FloatRangeDefault RimVRParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Rim Direction Strength</summary>
        public static FloatRangeDefault RimDirStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Rim Direction Range</summary>
        public static FloatRangeDefault RimDirRange = new FloatRangeDefault(-1.0f, 1.0f, 0.0f);

        /// <summary>Rim Indirection Range</summary>
        public static FloatRangeDefault RimIndirRange = new FloatRangeDefault(-1.0f, 1.0f, 0.0f);

        /// <summary>Rim Indirection Border</summary>
        public static FloatRangeDefault RimIndirBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Rim Indirection Blur</summary>
        public static FloatRangeDefault RimIndirBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        #endregion

        #region Glitter

        /// <summary>Glitter Main Strength</summary>
        public static FloatRangeDefault GlitterMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Glitter Normal Strength</summary>
        public static FloatRangeDefault GlitterNormalStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Glitter Scale Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault GlitterScaleRandomize = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Glitter Enable Lighting</summary>
        public static FloatRangeDefault GlitterEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Glitter Shadow Mask</summary>
        public static FloatRangeDefault GlitterShadowMask = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Glitter VR Parallax Strength</summary>
        public static FloatRangeDefault GlitterVRParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Emission

        /// <summary>Emission Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault EmissionMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Emission Blend</summary>
        public static FloatRangeDefault EmissionBlend = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Emission Fluorescence</summary>
        public static FloatRangeDefault EmissionFluorescence = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Emission 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public static FloatRangeDefault Emission2ndMainStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Emission 2nd Blend</summary>
        public static FloatRangeDefault Emission2ndBlend = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Emission 2nd Fluorescence</summary>
        public static FloatRangeDefault Emission2ndFluorescence = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Distance Fade

        /// <summary>Distance Fade Rim Fresnel Power</summary>
        /// <remarks>v1.4.0 added</remarks>
        public static FloatRangeDefault DistanceFadeRimFresnelPower = new FloatRangeDefault(0.01f, 50.0f, 5.0f);

        #endregion

        #region Refraction

        /// <summary>Refraction Strength</summary>
        public static FloatRangeDefault RefractionStrength = new FloatRangeDefault(-1.0f, 1.0f, 0.1f);

        /// <summary>Refraction Fresnel Power</summary>
        public static FloatRangeDefault RefractionFresnelPower = new FloatRangeDefault(0.01f, 10.0f, 0.5f);

        #endregion

        #region Fur

        /// <summary>Fur Vector Scale</summary>
        public static FloatRangeDefault FurVectorScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        /// <summary>Fur Gravity</summary>
        public static FloatRangeDefault FurGravity = new FloatRangeDefault(0.0f, 1.0f, 0.25f);

        /// <summary>Fur Ambient Occlusion</summary>
        public static FloatRangeDefault FurAO = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Fur Layer Number</summary>
        public static IntRangeDefault FurLayerNum = new IntRangeDefault(1, 6, 2);

        /// <summary>Fur Root Offset</summary>
        public static FloatRangeDefault FurRootOffset = new FloatRangeDefault(-1.0f, 0.0f, 0.0f);

        /// <summary>Fur Touch Strength</summary>
        public static FloatRangeDefault FurTouchStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Fur (Rendering)

        /// <summary>Fur Stencil Reference</summary>
        public static IntRangeDefault FurStencilRef = new IntRangeDefault(0, 255, 0);

        /// <summary>Fur Stencil Read Mask</summary>
        public static IntRangeDefault FurStencilReadMask = new IntRangeDefault(0, 255, 255);

        /// <summary>Fur Stencil Write Mask</summary>
        public static IntRangeDefault FurStencilWriteMask = new IntRangeDefault(0, 255, 255);

        #endregion

        #region Gem

        /// <summary>Gem Chromatic Aberration</summary>
        public static FloatRangeDefault GemChromaticAberration = new FloatRangeDefault(0.0f, 1.0f, 0.02f);

        /// <summary>Gem VR Parallax Strength</summary>
        public static FloatRangeDefault GemVRParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Tessellation

        /// <summary>Tessellation Edge</summary>
        public static FloatRangeDefault TessEdge = new FloatRangeDefault(0.0f, 100.0f, 10.0f);

        /// <summary>Tessellation Strength</summary>
        public static FloatRangeDefault TessStrength = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Tessellation Shrink</summary>
        public static FloatRangeDefault TessShrink = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Tessellation Factor Max</summary>
        public static IntRangeDefault TessFactorMax = new IntRangeDefault(1, 8, 3);

        #endregion

        #region Outline

        /// <summary>Outline Width</summary>
        public static FloatRangeDefault OutlineWidth = new FloatRangeDefault(0.0f, 1.0f, 0.05f);

        /// <summary>Outline Fix Width</summary>
        /// <remarks>v1.3.0 changed int to float</remarks>
        //public static IntRangeDefault OutlineFixWidth = new IntRangeDefault(0, 1, 1);
        public static FloatRangeDefault OutlineFixWidth = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Outline Vector Scale</summary>
        public static FloatRangeDefault OutlineVectorScale = new FloatRangeDefault(-10.0f, 10.0f, 1.0f);

        /// <summary>Outline Enable Lighting</summary>
        public static FloatRangeDefault OutlineEnableLighting = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Outline (Rendering)

        /// <summary>Stencil Ref</summary>
        public static IntRangeDefault OutlineStencilRef = new IntRangeDefault(0, 255, 0);

        /// <summary>Stencil Read Mask</summary>
        public static IntRangeDefault OutlineStencilReadMask = new IntRangeDefault(0, 255, 255);

        /// <summary>Stencil Write Mask</summary>
        public static IntRangeDefault OutlineStencilWriteMask = new IntRangeDefault(0, 255, 255);

        #endregion

        #region Rendering

        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(-0.001f, 1.001f, 0.5f);

        /// <summary>Subpass Alpha Cutoff</summary>
        public static FloatRangeDefault SubpassCutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Stencil Ref</summary>
        public static IntRangeDefault StencilRef = new IntRangeDefault(0, 255, 0);

        /// <summary>Stencil Read Mask</summary>
        public static IntRangeDefault StencilReadMask = new IntRangeDefault(0, 255, 255);

        /// <summary>Stencil Write Mask</summary>
        public static IntRangeDefault StencilWriteMask = new IntRangeDefault(0, 255, 255);

        #endregion
    }
}
#pragma warning restore IDE0090
