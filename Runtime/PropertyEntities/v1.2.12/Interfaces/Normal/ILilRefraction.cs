// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRefraction
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Refraction Interface
    /// </summary>
    public interface ILilRefraction
    {
        /// <summary>Refraction Strength</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float RefractionStrength { get; set; }

        /// <summary>Refraction Fresnel Power</summary>
        //[Range(0.01f, 10.0f)]
        //[DefaultValue(0.5f)]
        float RefractionFresnelPower { get; set; }

        /// <summary>Refraction Color from Main</summary>
        //[DefaultValue(false)]
        bool RefractionColorFromMain { get; set; }

        /// <summary>Refraction Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color RefractionColor { get; set; }
    }
}