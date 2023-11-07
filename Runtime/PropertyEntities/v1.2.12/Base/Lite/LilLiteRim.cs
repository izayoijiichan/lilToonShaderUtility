// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLiteRim
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Rim
    /// </summary>
    public class LilLiteRim : ILilLiteRim
    {
        /// <summary>Use Rim</summary>
        //[DefaultValue(false)]
        public bool UseRim { get; set; }

        /// <summary>Rim Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color RimColor { get; set; }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimBorder { get; set; }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float RimBlur { get; set; }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.0f)]
        public float RimFresnelPower { get; set; }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimShadowMask { get; set; }
    }
}