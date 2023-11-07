// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteRim
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Rim Interface
    /// </summary>
    public interface ILilLiteRim
    {
        /// <summary>Use Rim</summary>
        //[DefaultValue(false)]
        bool UseRim { get; set; }

        /// <summary>Rim Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color RimColor { get; set; }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float RimBorder { get; set; }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float RimBlur { get; set; }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.0f)]
        float RimFresnelPower { get; set; }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimShadowMask { get; set; }
    }
}