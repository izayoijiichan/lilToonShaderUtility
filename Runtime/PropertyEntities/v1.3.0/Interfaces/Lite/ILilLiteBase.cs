// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilLiteBase
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Base Interface
    /// </summary>
    public interface ILilLiteBase
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

        /// <summary>Tri Mask</summary>
        /// <remarks>Mat/Rim/Emission</remarks>
        Texture2D TriMask { get; set; }
    }
}