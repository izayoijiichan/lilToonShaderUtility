// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilShadow
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Shadow Interface
    /// </summary>
    public interface ILilShadow
    {
        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        bool UseShadow { get; set; }

        /// <summary>Receive Shadow</summary>
        //[DefaultValue(false)]
        bool ShadowReceive { get; set; }

        /// <summary>Shadow Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float ShadowStrength { get; set; }

        /// <summary>Shadow Strength Mask</summary>
        Texture2D ShadowStrengthMask { get; set; }

        /// <summary>Shadow Border Mask</summary>
        Texture2D ShadowBorderMask { get; set; }

        /// <summary>Shadow Blur Mask</summary>
        Texture2D ShadowBlurMask { get; set; }

        /// <summary>Shadow Ambient Occlusion Shift</summary>
        /// <remarks>1st Scale|1st Offset|2nd Scale|2nd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        Vector4 ShadowAOShift { get; set; }

        /// <summary>Shadow Ambient Occlusion Shift 2</summary>
        /// <remarks>3rd Scale|3rd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        Vector4 ShadowAOShift2 { get; set; }

        /// <summary>Shadow Post Ambient Occlusion</summary>
        //[DefaultValue(false)]
        bool ShadowPostAO { get; set; }

        /// <summary>Shadow Color</summary>
        //[DefaultValue(0.7,0.75,0.85,1.0)]
        Color ShadowColor { get; set; }

        /// <summary>Shadow Color Texture</summary>
        Texture2D ShadowColorTex { get; set; }

        /// <summary>Shadow Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float ShadowNormalStrength { get; set; }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float ShadowBorder { get; set; }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float ShadowBlur { get; set; }

        /// <summary>Shadow 2nd Color</summary>
        //[DefaultValue(0,0,0,0)]
        Color Shadow2ndColor { get; set; }

        /// <summary>Shadow 2nd Color Texture</summary>
        Texture2D Shadow2ndColorTex { get; set; }

        /// <summary>Shadow 2nd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float Shadow2ndNormalStrength { get; set; }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float Shadow2ndBorder { get; set; }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        float Shadow2ndBlur { get; set; }

        /// <summary>Shadow 3rd Color</summary>
        //[DefaultValue(0,0,0,0)]
        Color Shadow3rdColor { get; set; }

        /// <summary>Shadow 3rd Color Texture</summary>
        Texture2D Shadow3rdColorTex { get; set; }

        /// <summary>Shadow 3rd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float Shadow3rdNormalStrength { get; set; }

        /// <summary>Shadow 3rd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        float Shadow3rdBorder { get; set; }

        /// <summary>Shadow 3rd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float Shadow3rdBlur { get; set; }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0,0,1)]
        Color ShadowBorderColor { get; set; }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float ShadowBorderRange { get; set; }

        /// <summary>Shadow Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float ShadowMainStrength { get; set; }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float ShadowEnvStrength { get; set; }
    }
}