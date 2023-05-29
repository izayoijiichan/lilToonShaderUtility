// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : LilToonLitePropertyEntity
// ----------------------------------------------------------------------
namespace LilToonShader.v1_4_0
{
    /// <summary>
    /// lilToon Lite Property Entity
    /// </summary>
    /// <remarks>
    /// ltsl.shader
    /// </remarks>
    public class LilToonLitePropertyEntity : LilToonPropertyEntityBase
    {
        /// <summary>Base</summary>
        public LilLiteBase Base { get; set; }

        /// <summary>Lighting</summary>
        public LilLighting Lighting { get; set; }

        /// <summary>Lighting Advanced</summary>
        public LilLightingAdvanced LightingAdvanced { get; set; }
 
        /// <summary>Main</summary>
        public LilLiteMain Main { get; set; }

        /// <summary>Shadow</summary>
        public LilLiteShadow Shadow { get; set; }

        /// <summary>MatCap</summary>
        public LilLiteMatCap MatCap { get; set; }

        /// <summary>Rim</summary>
        public LilLiteRim Rim { get; set; }

        /// <summary>Emission</summary>
        public LilLiteEmission Emission { get; set; }

        /// <summary>Outline</summary>
        public LilLiteOutline Outline { get; set; }

        /// <summary>Outline Rendering</summary>
        public LilOutlineRendering OutlineRendering { get; set; }

        /// <summary>Outline AdvaRenderingnced Forward</summary>
        public LilOutlineRenderingForward OutlineRenderingForward { get; set; }

        /// <summary>Outline Rendering Forward Add</summary>
        public LilOutlineRenderingForwardAdd OutlineRenderingForwardAdd { get; set; }

        /// <summary>Outline Rendering Stencil</summary>
        public LilOutlineRenderingStencil OutlineRenderingStencil { get; set; }

        /// <summary>Rendering</summary>
        public LilRendering Rendering { get; set; }

        /// <summary>Rendering Forward</summary>
        public LilRenderingForward RenderingForward { get; set; }

        /// <summary>Rendering Forward Add</summary>
        public LilRenderingForwardAdd RenderingForwardAdd { get; set; }

        /// <summary>Rendering Stencil</summary>
        public LilRenderingStencil RenderingStencil { get; set; }
    }
}