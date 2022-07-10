// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilShadow
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Shadow
    /// </summary>
    public class LilShadow : ILilShadow
    {
        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        public bool UseShadow { get; set; }

        /// <summary>Shadow Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowStrength { get; set; }

        /// <summary>Shadow Strength Mask</summary>
        public Texture2D ShadowStrengthMask { get; set; }

        /// <summary>Shadow Strength Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowStrengthMaskLOD { get; set; }

        /// <summary>Shadow Border Mask</summary>
        public Texture2D ShadowBorderMask { get; set; }

        /// <summary>Shadow Border Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBorderMaskLOD { get; set; }

        /// <summary>Shadow Blur Mask</summary>
        public Texture2D ShadowBlurMask { get; set; }

        /// <summary>Shadow Blur Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBlurMaskLOD { get; set; }

        /// <summary>Shadow AO Shift</summary>
        /// <remarks>1st Scale|1st Offset|2nd Scale|2nd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        public Vector4 ShadowAOShift { get; set; }

        /// <summary>Shadow AO Shift2</summary>
        /// <remarks>3rd Scale|3rd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        public Vector4 ShadowAOShift2 { get; set; }

        /// <summary>Shadow Post AO</summary>
        //[DefaultValue(false)]
        public bool ShadowPostAO { get; set; }

        /// <summary>Shadow Color</summary>
        //[DefaultValue(0.82,0.76,0.85,1.0)]
        public Color ShadowColor { get; set; }

        /// <summary>Shadow Color Tex</summary>
        public Texture2D ShadowColorTex { get; set; }

        /// <summary>Shadow Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowNormalStrength { get; set; }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float ShadowBorder { get; set; }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float ShadowBlur { get; set; }

        /// <summary>Receive Shadow</summary>
        //[DefaultValue(false)]
        public bool ShadowReceive { get; set; }

        /// <summary>Shadow 2nd Color</summary>
        //[DefaultValue(0.68,0.66,0.79,1)]
        public Color Shadow2ndColor { get; set; }

        /// <summary>Shadow 2nd Color Tex</summary>
        public Texture2D Shadow2ndColorTex { get; set; }

        /// <summary>Shadow 2nd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Shadow2ndNormalStrength { get; set; }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.15f)]
        public float Shadow2ndBorder { get; set; }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float Shadow2ndBlur { get; set; }

        /// <summary>Receive Shadow 2nd</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool Shadow2ndReceive { get; set; }

        /// <summary>Shadow 3rd Color</summary>
        //[DefaultValue(0,0,0,0)]
        public Color Shadow3rdColor { get; set; }

        /// <summary>Shadow 3rd ColorTex</summary>
        public Texture2D Shadow3rdColorTex { get; set; }

        /// <summary>Shadow 3rd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Shadow3rdNormalStrength { get; set; }

        /// <summary>Shadow 3rd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        public float Shadow3rdBorder { get; set; }

        /// <summary>Shadow 3rd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float Shadow3rdBlur { get; set; }

        /// <summary>Receive Shadow 3rd</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool Shadow3rdReceive { get; set; }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0.1,0,1)]
        public Color ShadowBorderColor { get; set; }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.08f)]
        public float ShadowBorderRange { get; set; }

        /// <summary>Shadow Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowMainStrength { get; set; }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowEnvStrength { get; set; }

        /// <summary>Shadow Mask Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilShadowMaskType.Strength)]
        public LilShadowMaskType ShadowMaskType { get; set; }

        /// <summary>Shadow Flat Border</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(-2.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowFlatBorder { get; set; }

        /// <summary>Shadow Flat Blur</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.001f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowFlatBlur { get; set; }
    }
}