// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLiteShadow
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Shadow
    /// </summary>
    public class LilLiteShadow : ILilLiteShadow
    {
        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        public bool UseShadow { get; set; }

        /// <summary>Shadow Color Tex</summary>
        public Texture2D ShadowColorTex { get; set; }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float ShadowBorder { get; set; }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float ShadowBlur { get; set; }

        /// <summary>Shadow 2nd Color Tex</summary>
        public Texture2D Shadow2ndColorTex { get; set; }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Shadow2ndBorder { get; set; }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        public float Shadow2ndBlur { get; set; }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0,0,1)]
        public Color ShadowBorderColor { get; set; }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBorderRange { get; set; }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowEnvStrength { get; set; }
    }
}