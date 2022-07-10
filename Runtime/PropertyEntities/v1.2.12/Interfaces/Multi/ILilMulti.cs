// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilMulti
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
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

        /// <summary>Use POM</summary>
        //[DefaultValue(false)]
        bool UsePOM { get; set; }

        /// <summary>Use Clipping Canceller</summary>
        //[DefaultValue(false)]
        bool UseClippingCanceller { get; set; }

        /// <summary>As Overlay</summary>
        //[DefaultValue(false)]
        bool AsOverlay { get; set; }
    }
}