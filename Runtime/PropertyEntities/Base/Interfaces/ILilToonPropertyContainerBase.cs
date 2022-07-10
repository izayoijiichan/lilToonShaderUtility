// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : ILilToonPropertyContainerBase
// ----------------------------------------------------------------------
namespace LilToonShader
{
    /// <summary>
    /// lilToon Basic Property Container Interface
    /// </summary>
    public interface ILilToonPropertyContainerBase
    {
        /// <summary>lilToon Version</summary>
        int LilToonVersion { get; set; }

        /// <summary>Property Entity Type</summary>
        LilPropertyEntityType PropertyEntityType { get; set; }

        /// <summary>Rendering Mode</summary>
        LilRenderingMode RenderingMode { get; set; }

        /// <summary>Transparent Mode</summary>
        LilTransparentMode TransparentMode { get; set; }

        /// <summary>Whether the shader is overlay.</summary>
        bool IsOverlay { get; set; }

        /// <summary>Whether the shader outline is enabled.</summary>
        bool IsOutline { get; set; }

        /// <summary>Whether the shader tessellation is enabled.</summary>
        bool IsTessellation { get; set; }

        /// <summary>Whether the shader refraction is enabled.</summary>
        bool IsRefraction { get; }

        /// <summary>Whether the shader rendering mode is fur.</summary>
        bool IsFur { get; }

        /// <summary>Whether the shader rendering mode is gem.</summary>
        bool IsGem { get; }
    }
}