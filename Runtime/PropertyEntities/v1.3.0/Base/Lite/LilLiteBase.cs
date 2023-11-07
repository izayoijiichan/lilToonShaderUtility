// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilLiteBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Base
    /// </summary>
    public class LilLiteBase : ILilLiteBase
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

        /// <summary>Anti-Aliasing Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        public float AAStrength { get; set; }

        /// <summary>Tri Mask</summary>
        /// <remarks>Mat/Rim/Emission</remarks>
        public Texture2D? TriMask { get; set; }
    }
}