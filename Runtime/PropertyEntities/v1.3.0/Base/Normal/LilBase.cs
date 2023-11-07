// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
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

        /// <summary>Anti-Aliasing Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        public float AAStrength { get; set; }
    }
}