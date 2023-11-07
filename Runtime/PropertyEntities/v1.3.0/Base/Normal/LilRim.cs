// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilRim
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Rim
    /// </summary>
    public class LilRim : ILilRim
    {
        /// <summary>Use Rim</summary>
        //[DefaultValue(false)]
        public bool UseRim { get; set; }

        /// <summary>Rim Color</summary>
        //[DefaultValue(0.66,0.5,0.48,1)]
        public Color RimColor { get; set; }

        /// <summary>Rim Color Texture</summary>
        public Texture2D? RimColorTex { get; set; }

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimMainStrength { get; set; }

        /// <summary>Rim Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimNormalStrength { get; set; }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimBorder { get; set; }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.65f)]
        public float RimBlur { get; set; }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.5f)]
        public float RimFresnelPower { get; set; }

        /// <summary>Rim Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimEnableLighting { get; set; }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimShadowMask { get; set; }

        /// <summary>Rim Backface Mask</summary>
        //[DefaultValue(true)]
        public bool RimBackfaceMask { get; set; }

        /// <summary>Rim VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimVRParallaxStrength { get; set; }

        /// <summary>Rim Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool RimApplyTransparency { get; set; }

        /// <summary>Rim Direction Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimDirStrength { get; set; }

        /// <summary>Rim Direction Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimDirRange { get; set; }

        /// <summary>Rim Indirection Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimIndirRange { get; set; }

        /// <summary>Rim Indirection Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color RimIndirColor { get; set; }

        /// <summary>Rim Indirection Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimIndirBorder { get; set; }

        /// <summary>Rim Indirection Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float RimIndirBlur { get; set; }

        /// <summary>Rim Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode RimBlendMode { get; set; }
    }
}