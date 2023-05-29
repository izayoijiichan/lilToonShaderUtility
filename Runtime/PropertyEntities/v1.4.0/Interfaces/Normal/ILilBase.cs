// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : ILilBase
// ----------------------------------------------------------------------
namespace LilToonShader.v1_4_0
{
    using UnityEngine;

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

        /// <summary>Backface Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0,0,0,0)]
        Color BackfaceColor { get; set; }

        /// <summary>AA Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        float AAStrength { get; set; }

        /// <summary>Use Dither</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool UseDither { get; set; }

        /// <summary>Dither Texture</summary>
        /// <remarks>v1.4.0 added</remarks>
        Texture2D DitherTex { get; set; }

        /// <summary>Dither Max Value</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(255)]
        float DitherMaxValue { get; set; }
    }
}