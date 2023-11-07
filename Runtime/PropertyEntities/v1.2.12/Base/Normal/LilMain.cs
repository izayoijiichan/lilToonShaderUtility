// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilMain
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Main
    /// </summary>
    public class LilMain : ILilMain
    {
        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Color { get; set; }

        /// <summary>Main Texture</summary>
        public Texture2D? MainTex { get; set; }

        /// <summary>Main Tex Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MainTex_ScrollRotate { get; set; }

        /// <summary>Main Tex HSVG</summary>
        /// <remarks>Hue|Saturation|Value|Gamma</remarks>
        //[DefaultValue(0,1,1,1)]
        public Vector4 MainTexHSVG { get; set; }

        /// <summary>Main Gradation Strength</summary>
        //[Range(0, 1)]
        //[DefaultValue(0)]
        public float MainGradationStrength { get; set; }

        /// <summary>Main Gradation Texture</summary>
        public Texture2D? MainGradationTex { get; set; }

        /// <summary>Main Color Adjust Mask</summary>
        public Texture2D? MainColorAdjustMask { get; set; }
    }
}