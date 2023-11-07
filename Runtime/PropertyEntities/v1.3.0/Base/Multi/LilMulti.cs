// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilMulti
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
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

        ///// <summary>Use Parallax Occlusion Mapping (POM)</summary>
        ///// <remarks>v1.3.0 to Parallax</remarks>
        ////[DefaultValue(false)]
        //public bool UsePOM { get; set; }

        /// <summary>Use Clipping Canceller</summary>
        //[DefaultValue(false)]
        public bool UseClippingCanceller { get; set; }

        /// <summary>As Overlay</summary>
        //[DefaultValue(false)]
        public bool AsOverlay { get; set; }
    }
}