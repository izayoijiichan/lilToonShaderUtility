// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilMulti
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Multi
    /// </summary>
    public class LilMulti : ILilMulti
    {
        /// <summary>Use Outline</summary>
        //[DefaultValue(false)]
        public bool UseOutline { get; set; }

        /// <summary>Transparent Mode</summary>
        //[DefaultValue(LilRenderingMode.Opaque)]
        public LilRenderingMode TransparentMode { get; set; }

        /// <summary>Use Parallax Occlusion Mapping (POM)</summary>
        //[DefaultValue(false)]
        public bool UsePOM { get; set; }

        /// <summary>Use Clipping Canceller</summary>
        //[DefaultValue(false)]
        public bool UseClippingCanceller { get; set; }

        /// <summary>As Overlay</summary>
        //[DefaultValue(false)]
        public bool AsOverlay { get; set; }
    }
}