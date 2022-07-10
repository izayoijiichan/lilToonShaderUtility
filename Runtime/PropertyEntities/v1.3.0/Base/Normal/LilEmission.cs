// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilEmission
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Emission
    /// </summary>
    public class LilEmission : ILilEmission
    {
        /// <summary>Use Emission</summary>
        //[DefaultValue(false)]
        public bool UseEmission { get; set; }

        /// <summary>Emission Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Emission Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 EmissionMap_ScrollRotate { get; set; }

        /// <summary>Emission Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilEmissionUVMode EmissionMap_UVMode { get; set; }

        /// <summary>Emission Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float EmissionMainStrength { get; set; }

        /// <summary>Emission Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float EmissionBlend { get; set; }

        /// <summary>Emission Blend Mask</summary>
        public Texture2D EmissionBlendMask { get; set; }

        /// <summary>Emission Blend Mask Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 EmissionBlendMask_ScrollRotate { get; set; }

        /// <summary>Emission Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        public Vector4 EmissionBlink { get; set; }

        /// <summary>Emission Use Gradation</summary>
        //[DefaultValue(false)]
        public bool EmissionUseGrad { get; set; }

        /// <summary>Emission Gradation Texture</summary>
        public Texture2D EmissionGradTex { get; set; }

        /// <summary>Emission Gradation Speed</summary>
        //[DefaultValue(1.0f)]
        public float EmissionGradSpeed { get; set; }

        /// <summary>Emission Parallax Depth</summary>
        //[DefaultValue(0.0f)]
        public float EmissionParallaxDepth { get; set; }

        /// <summary>Emission Fluorescence</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float EmissionFluorescence { get; set; }
    }
}