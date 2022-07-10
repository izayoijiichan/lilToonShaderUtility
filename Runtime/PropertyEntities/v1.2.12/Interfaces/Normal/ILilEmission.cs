// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilEmission
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Emission Interface
    /// </summary>
    public interface ILilEmission
    {
        /// <summary>Use Emission</summary>
        //[DefaultValue(false)]
        bool UseEmission { get; set; }

        /// <summary>Emission Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        Texture2D EmissionMap { get; set; }

        /// <summary>Emission Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 EmissionMap_ScrollRotate { get; set; }

        /// <summary>Emission Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        LilEmissionUVMode EmissionMap_UVMode { get; set; }

        /// <summary>Emission Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float EmissionBlend { get; set; }

        /// <summary>Emission Blend Mask</summary>
        Texture2D EmissionBlendMask { get; set; }

        /// <summary>Emission Blend Mask Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 EmissionBlendMask_ScrollRotate { get; set; }

        /// <summary>Emission Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        Vector4 EmissionBlink { get; set; }

        /// <summary>Emission Use Gradation</summary>
        //[DefaultValue(false)]
        bool EmissionUseGrad { get; set; }

        /// <summary>Emission Gradation Texture</summary>
        Texture2D EmissionGradTex { get; set; }

        /// <summary>Emission Gradation Speed</summary>
        //[DefaultValue(1.0f)]
        float EmissionGradSpeed { get; set; }

        /// <summary>Emission Parallax Depth</summary>
        //[DefaultValue(0.0f)]
        float EmissionParallaxDepth { get; set; }

        /// <summary>Emission Fluorescence</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float EmissionFluorescence { get; set; }
    }
}