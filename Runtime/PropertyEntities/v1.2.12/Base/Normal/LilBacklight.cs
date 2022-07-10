// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilBacklight
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Backlight
    /// </summary>
    public class LilBacklight : ILilBacklight
    {
        /// <summary>Use Backlight</summary>
        //[DefaultValue(false)]
        public bool UseBacklight { get; set; }

        /// <summary>Backlight Color</summary>
        //[DefaultValue(0.85,0.8,0.7,1.0)]
        public Color BacklightColor { get; set; }

        /// <summary>Backlight Color Tex</summary>
        public Texture2D BacklightColorTex { get; set; }

        /// <summary>Backlight Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BacklightNormalStrength { get; set; }

        /// <summary>Backlight Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.35f)]
        public float BacklightBorder { get; set; }

        /// <summary>Backlight Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        public float BacklightBlur { get; set; }

        /// <summary>Backlight Directivity</summary>
        //[DefaultValue(5.0f)]
        public float BacklightDirectivity { get; set; }

        /// <summary>Backlight View Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BacklightViewStrength { get; set; }

        /// <summary>Backlight Receive Shadow</summary>
        //[DefaultValue(true)]
        public bool BacklightReceiveShadow { get; set; }

        /// <summary>Backlight Backface Mask</summary>
        //[DefaultValue(true)]
        public bool BacklightBackfaceMask { get; set; }
    }
}