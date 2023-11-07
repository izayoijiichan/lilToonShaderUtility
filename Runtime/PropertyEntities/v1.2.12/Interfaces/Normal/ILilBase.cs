// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Base Interface
    /// </summary>
    public interface ILilBase
    {
        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        bool Invisible { get; set; }

        /// <summary>Flip Backface Normal</summary>
        //[DefaultValue(false)]
        bool FlipNormal { get; set; }

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        //[DefaultValue(false)]
        bool ShiftBackfaceUV { get; set; }

        /// <summary>Backface Force Shadow</summary>
        //[DefaultValue(false)]
        bool BackfaceForceShadow { get; set; }
    }
}