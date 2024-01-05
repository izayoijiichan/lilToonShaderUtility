// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_6_0
// @Class     : LilToonNormalPropertyEntity
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_6_0
{
    /// <summary>
    /// lilToon Normal Property Entity
    /// </summary>
    /// <remarks>
    /// lts.shader
    /// ltsmulti.shader
    /// </remarks>
    public class LilToonNormalPropertyEntity : LilToonPropertyEntityBase
    {
        /// <summary>Base</summary>
        public LilBase? Base { get; set; }

        /// <summary>Lighting</summary>
        public LilLighting? Lighting { get; set; }

        /// <summary>Lighting Advanced</summary>
        public LilLightingAdvanced? LightingAdvanced { get; set; }

        /// <summary>Main</summary>
        public LilMain? Main { get; set; }

        /// <summary>Main 2nd</summary>
        public LilMain2nd? Main2nd { get; set; }

        /// <summary>Main 3rd</summary>
        public LilMain3rd? Main3rd { get; set; }

        /// <summary>Alpha Mask</summary>
        public LilAlphaMask? AlphaMask { get; set; }

        /// <summary>NormalMap</summary>
        public LilNormalMap? NormalMap { get; set; }

        /// <summary>NormalMap 2nd</summary>
        public LilNormalMap2nd? NormalMap2nd { get; set; }

        /// <summary>Anisotropy</summary>
        public LilAnisotropy? Anisotropy { get; set; }

        /// <summary>Backlight</summary>
        public LilBacklight? Backlight { get; set; }

        /// <summary>Shadow</summary>
        public LilShadow? Shadow { get; set; }

        /// <summary>Rim Shade</summary>
        /// <remarks>v1.6.0 added</remarks>
        public LilRimShade? RimShade { get; set; }

        /// <summary>Reflection</summary>
        public LilReflection? Reflection { get; set; }

        /// <summary>MatCap</summary>
        public LilMatCap? MatCap { get; set; }

        /// <summary>MatCap 2nd</summary>
        public LilMatCap2nd? MatCap2nd { get; set; }

        /// <summary>Rim</summary>
        public LilRim? Rim { get; set; }

        /// <summary>Glitter</summary>
        public LilGlitter? Glitter { get; set; }

        /// <summary>Emission</summary>
        public LilEmission? Emission { get; set; }

        /// <summary>Emission Gradation</summary>
        public LilEmissionGradation? EmissionGradation { get; set; }

        /// <summary>Emission 2nd</summary>
        public LilEmission2nd? Emission2nd { get; set; }

        /// <summary>Emission 2nd Gradation</summary>
        public LilEmission2ndGradation? Emission2ndGradation { get; set; }

        /// <summary>Parallax</summary>
        public LilParallax? Parallax { get; set; }

        /// <summary>Distance Fade</summary>
        public LilDistanceFade? DistanceFade { get; set; }

        /// <summary>Audio Link</summary>
        public LilAudioLink? AudioLink { get; set; }

        /// <summary>Dissolve</summary>
        public LilDissolve? Dissolve { get; set; }

        /// <summary>ID Mask</summary>
        /// <remarks>v1.4.0 added</remarks>
        public LilIDMask? IDMask { get; set; }

        /// <summary>Encryption</summary>
        public LilEncryption? Encryption { get; set; }

        /// <summary>Refraction</summary>
        /// <remarks>RenderingMode is Refraction or Gem</remarks>
        public LilRefraction? Refraction { get; set; }

        /// <summary>Fur</summary>
        /// <remarks>RenderingMode is Fur</remarks>
        public LilFur? Fur { get; set; }

        /// <summary>Fur Rendering</summary>
        /// <remarks>RenderingMode is Fur</remarks>
        public LilFurRendering? FurRendering { get; set; }

        /// <summary>Fur Rendering Forward</summary>
        /// <remarks>RenderingMode is Fur</remarks>
        public LilFurRenderingForward? FurRenderingForward { get; set; }

        /// <summary>Fur Rendering Forward Add</summary>
        /// <remarks>RenderingMode is Fur</remarks>
        public LilFurRenderingForwardAdd? FurRenderingForwardAdd { get; set; }

        /// <summary>Fur Rendering Stencil</summary>
        /// <remarks>RenderingMode is Fur</remarks>
        public LilFurRenderingStencil? FurRenderingStencil { get; set; }

        /// <summary>Gem</summary>
        /// <remarks>RenderingMode is Gem</remarks>
        public LilGem? Gem { get; set; }

        /// <summary>Tessellation</summary>
        public LilTessellation? Tessellation { get; set; }

        /// <summary>Outline</summary>
        public LilOutline? Outline { get; set; }

        /// <summary>Outline Rendering</summary>
        public LilOutlineRendering? OutlineRendering { get; set; }

        /// <summary>Outline Rendering Forward</summary>
        public LilOutlineRenderingForward? OutlineRenderingForward { get; set; }

        /// <summary>Outline Rendering Forward Add</summary>
        public LilOutlineRenderingForwardAdd? OutlineRenderingForwardAdd { get; set; }

        /// <summary>Outline Rendering Stencil</summary>
        public LilOutlineRenderingStencil? OutlineRenderingStencil { get; set; }

        /// <summary>Multi</summary>
        /// <remarks>v1.3.0 added</remarks>
        public LilMulti? Multi { get; set; }

        /// <summary>Rendering</summary>
        public LilRendering? Rendering { get; set; }

        /// <summary>Rendering Forward</summary>
        public LilRenderingForward? RenderingForward { get; set; }

        /// <summary>Rendering Forward Add</summary>
        public LilRenderingForwardAdd? RenderingForwardAdd { get; set; }

        /// <summary>Rendering Stencil</summary>
        public LilRenderingStencil? RenderingStencil { get; set; }
    }
}