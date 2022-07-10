// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilMulti
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    /// <summary>
    /// lilToon Multi Interface
    /// </summary>
    public interface ILilMulti
    {
        /// <summary>Use Outline</summary>
        //[DefaultValue(false)]
        bool UseOutline { get; set; }

        /// <summary>Transparent Mode</summary>
        //[DefaultValue(LilRenderingMode.Opaque)]
        LilRenderingMode TransparentMode { get; set; }

        ///// <summary>Use POM</summary>
        ///// <remarks>v1.3.0 to Parallax</remarks>
        ////[DefaultValue(false)]
        //bool UsePOM { get; set; }

        /// <summary>Use Clipping Canceller</summary>
        //[DefaultValue(false)]
        bool UseClippingCanceller { get; set; }

        /// <summary>As Overlay</summary>
        //[DefaultValue(false)]
        bool AsOverlay { get; set; }
    }
}