// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilBase
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Base
    /// </summary>
    public class LilBase : ILilBase
    {
        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        public bool Invisible { get; set; }

        /// <summary>Flip Backface Normal</summary>
        //[DefaultValue(false)]
        public bool FlipNormal { get; set; }

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        //[DefaultValue(false)]
        public bool ShiftBackfaceUV { get; set; }

        /// <summary>Backface Force Shadow</summary>
        //[DefaultValue(false)]
        public bool BackfaceForceShadow { get; set; }
    }
}