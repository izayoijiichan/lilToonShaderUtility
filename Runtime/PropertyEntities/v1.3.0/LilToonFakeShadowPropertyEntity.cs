// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilToonFakeShadowPropertyEntity
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    /// <summary>
    /// lilToon Fake Shadow Property Entity
    /// </summary>
    /// <remarks>
    /// lts_fakeshadow.shader
    /// </remarks>
    public class LilToonFakeShadowPropertyEntity : LilToonPropertyEntityBase
    {
        /// <summary>Base</summary>
        public LilFakeShadowBase? Base { get; set; }

        /// <summary>Main</summary>
        public LilFakeShadowMain? Main { get; set; }

        /// <summary>Encryption</summary>
        public LilEncryption? Encryption { get; set; }
        
        /// <summary>Rendering</summary>
        public LilRendering? Rendering { get; set; }

        /// <summary>Rendering Forward</summary>
        public LilRenderingForward? RenderingForward { get; set; }

        /// <summary>Rendering Stencil</summary>
        public LilRenderingStencil? RenderingStencil { get; set; }
    }
}