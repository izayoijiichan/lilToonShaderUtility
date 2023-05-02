// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilEmission2nd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Emission 2nd Interface
    /// </summary>
    public interface ILilEmission2nd
    {
        /// <summary>Use Emission 2nd</summary>
        //[DefaultValue(false)]
        bool UseEmission2nd { get; set; }

        /// <summary>Emission 2nd Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color Emission2ndColor { get; set; }

        /// <summary>Emission 2nd Map</summary>
        Texture2D Emission2ndMap { get; set; }

        /// <summary>Emission 2nd Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 Emission2ndMap_ScrollRotate { get; set; }

        /// <summary>Emission 2nd Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        LilEmissionUVMode Emission2ndMap_UVMode { get; set; }

        /// <summary>Emission 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float Emission2ndMainStrength { get; set; }

        /// <summary>Emission 2nd Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float Emission2ndBlend { get; set; }

        /// <summary>Emission 2nd Blend Mask</summary>
        Texture2D Emission2ndBlendMask { get; set; }

        /// <summary>Emission 2nd BlendMask Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 Emission2ndBlendMask_ScrollRotate { get; set; }

        /// <summary>Emission 2nd Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        LilBlendMode Emission2ndBlendMode { get; set; }

        /// <summary>Emission 2nd Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        Vector4 Emission2ndBlink { get; set; }

        /// <summary>Emission 2nd Use Gradation</summary>
        //[DefaultValue(false)]
        bool Emission2ndUseGrad { get; set; }

        /// <summary>Emission 2nd Gradation Texture</summary>
        Texture2D Emission2ndGradTex { get; set; }

        /// <summary>Emission 2nd Gradation Speed</summary>
        //[DefaultValue(1.0f)]
        float Emission2ndGradSpeed { get; set; }

        /// <summary>Emission 2nd Parallax Depth</summary>
        //[DefaultValue(0.0f)]
        float Emission2ndParallaxDepth { get; set; }

        /// <summary>Emission 2nd Fluorescence</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float Emission2ndFluorescence { get; set; }
    }
}