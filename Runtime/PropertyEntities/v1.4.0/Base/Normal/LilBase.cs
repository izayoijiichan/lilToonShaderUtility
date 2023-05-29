// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : LilBase
// ----------------------------------------------------------------------
namespace LilToonShader.v1_4_0
{
    using UnityEngine;

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

        /// <summary>Backface Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0,0,0,0)]
        public Color BackfaceColor { get; set; }

        /// <summary>AA Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        public float AAStrength { get; set; }

        /// <summary>Use Dither</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool UseDither { get; set; }

        /// <summary>Dither Texture</summary>
        /// <remarks>v1.4.0 added</remarks>
        public Texture2D DitherTex { get; set; }

        /// <summary>Dither Max Value</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(255)]
        public float DitherMaxValue { get; set; }
    }
}