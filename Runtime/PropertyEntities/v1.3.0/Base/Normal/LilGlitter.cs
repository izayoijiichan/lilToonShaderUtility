// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilGlitter
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Glitter
    /// </summary>
    public class LilGlitter : ILilGlitter
    {
        /// <summary>Use Glitter</summary>
        //[DefaultValue(false)]
        public bool UseGlitter { get; set; }

        /// <summary>Glitter UV Mode</summary>
        //[DefaultValue(LilGlitterUVMode.UV0)]
        public LilGlitterUVMode GlitterUVMode { get; set; }

        /// <summary>Glitter Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color GlitterColor { get; set; }

        /// <summary>Glitter Color Texture</summary>
        public Texture2D? GlitterColorTex { get; set; }

        /// <summary>Glitter Color Texture UV Mode</summary>
        /// <remarks>v1.3.2 added</remarks>
        public LilGlitterColorTextureUVMode GlitterColorTex_UVMode { get; set; }

        /// <summary>Glitter Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterMainStrength { get; set; }

        /// <summary>Glitter Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlitterNormalStrength { get; set; }

        /// <summary>Glitter Scale Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterScaleRandomize { get; set; }

        /// <summary>Glitter Apply Shape</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool GlitterApplyShape { get; set; }

        /// <summary>Glitter Shape Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public Texture2D? GlitterShapeTex { get; set; }

        /// <summary>Glitter Atras</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(1,1,0,0)]
        public Vector4 GlitterAtras { get; set; }

        /// <summary>Glitter Angle Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool GlitterAngleRandomize { get; set; }

        /// <summary>Glitter Parameters 1</summary>
        /// <remarks>Tiling|Particle Size|Contrast</remarks>
        //[DefaultValue(256,256,0.16f,50)]
        public Vector4 GlitterParams1 { get; set; }

        /// <summary>Glitter Parameters 2</summary>
        /// <remarks>Blink Speed|Angle|Blend Light Direction|Color Randomness</remarks>
        //[DefaultValue(0.25f,0,0,0)]
        public Vector4 GlitterParams2 { get; set; }

        /// <summary>Glitter Post Contrast</summary>
        //[DefaultValue(1.0f)]
        public float GlitterPostContrast { get; set; }

        /// <summary>Glitter Sensitivity</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0.25f)]
        public float GlitterSensitivity { get; set; }

        /// <summary>Glitter Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlitterEnableLighting { get; set; }

        /// <summary>Glitter Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterShadowMask { get; set; }

        /// <summary>Glitter Backface Mask</summary>
        //[DefaultValue(false)]
        public bool GlitterBackfaceMask { get; set; }

        /// <summary>Glitter Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool GlitterApplyTransparency { get; set; }

        /// <summary>Glitter VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterVRParallaxStrength { get; set; }
    }
}