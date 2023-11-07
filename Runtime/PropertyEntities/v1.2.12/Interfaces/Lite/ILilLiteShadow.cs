// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteShadow
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Shadow Interface
    /// </summary>
    public interface ILilLiteShadow
    {
        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        bool UseShadow { get; set; }

        /// <summary>Shadow Color Texture</summary>
        Texture2D? ShadowColorTex { get; set; }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float ShadowBorder { get; set; }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float ShadowBlur { get; set; }

        /// <summary>Shadow 2nd Color Texture</summary>
        Texture2D? Shadow2ndColorTex { get; set; }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float Shadow2ndBorder { get; set; }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        float Shadow2ndBlur { get; set; }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0,0,1)]
        Color ShadowBorderColor { get; set; }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float ShadowBorderRange { get; set; }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float ShadowEnvStrength { get; set; }
    }
}