// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilBacklight
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Backlight Interface
    /// </summary>
    public interface ILilBacklight
    {
        /// <summary>Use Backlight</summary>
        //[DefaultValue(false)]
        bool UseBacklight { get; set; }

        /// <summary>Backlight Color</summary>
        //[DefaultValue(0.85,0.8,0.7,1.0)]
        Color BacklightColor { get; set; }

        /// <summary>Backlight Color Texture</summary>
        Texture2D? BacklightColorTex { get; set; }

        /// <summary>Backlight Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float BacklightMainStrength { get; set; }

        /// <summary>Backlight Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float BacklightNormalStrength { get; set; }

        /// <summary>Backlight Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.35f)]
        float BacklightBorder { get; set; }

        /// <summary>Backlight Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        float BacklightBlur { get; set; }

        /// <summary>Backlight Directivity</summary>
        //[DefaultValue(5.0f)]
        float BacklightDirectivity { get; set; }

        /// <summary>Backlight View Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float BacklightViewStrength { get; set; }

        /// <summary>Backlight Receive Shadow</summary>
        //[DefaultValue(true)]
        bool BacklightReceiveShadow { get; set; }

        /// <summary>Backlight Backface Mask</summary>
        //[DefaultValue(true)]
        bool BacklightBackfaceMask { get; set; }
    }
}