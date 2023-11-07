// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonPropertyContainerBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    /// <summary>
    /// lilToon Basic Property Container
    /// </summary>
    public abstract class LilToonPropertyContainerBase : ILilToonPropertyContainerBase
    {
        /// <summary>lilToon Version</summary>
        public int LilToonVersion { get; set; }

        /// <summary>Property Entity Type</summary>
        public LilPropertyEntityType PropertyEntityType { get; set; }

        /// <summary>Rendering Mode</summary>
        public LilRenderingMode RenderingMode { get; set; }

        /// <summary>Transparent Mode</summary>
        public LilTransparentMode TransparentMode { get; set; }

        /// <summary>Whether the shader is overlay.</summary>
        public bool IsOverlay { get; set; }

        /// <summary>Whether the shader outline is enabled.</summary>
        public bool IsOutline { get; set; }

        /// <summary>Whether the shader tessellation is enabled.</summary>
        public bool IsTessellation { get; set; }

#pragma warning disable IDE0078
        /// <summary>Whether the shader refraction is enabled.</summary>
        public bool IsRefraction =>
            (RenderingMode == LilRenderingMode.Refraction) ||
            (RenderingMode == LilRenderingMode.RefractionBlur);

        /// <summary>Whether the shader rendering mode is fur.</summary>
        public bool IsFur =>
            (RenderingMode == LilRenderingMode.Fur) ||
            (RenderingMode == LilRenderingMode.FurCutout) ||
            (RenderingMode == LilRenderingMode.FurTwoPass);
#pragma warning restore IDE0078

        /// <summary>Whether the shader rendering mode is gem.</summary>
        public bool IsGem => RenderingMode == LilRenderingMode.Gem;
    }
}