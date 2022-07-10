// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRim
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Rim Interface
    /// </summary>
    public interface ILilRim
    {
        /// <summary>Use Rim</summary>
        //[DefaultValue(false)]
        bool UseRim { get; set; }

        /// <summary>Rim Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color RimColor { get; set; }

        /// <summary>Rim Color Texture</summary>
        Texture2D RimColorTex { get; set; }

        /// <summary>Rim Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimNormalStrength { get; set; }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float RimBorder { get; set; }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float RimBlur { get; set; }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.0f)]
        float RimFresnelPower { get; set; }

        /// <summary>Rim Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimEnableLighting { get; set; }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimShadowMask { get; set; }

        /// <summary>Rim Backface Mask</summary>
        //[DefaultValue(false)]
        bool RimBackfaceMask { get; set; }

        /// <summary>Rim VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimVRParallaxStrength { get; set; }

        /// <summary>Rim Apply Transparency</summary>
        //[DefaultValue(true)]
        bool RimApplyTransparency { get; set; }

        /// <summary>Rim Direction Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimDirStrength { get; set; }

        /// <summary>Rim Direction Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimDirRange { get; set; }

        /// <summary>Rim Indirection Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimIndirRange { get; set; }

        /// <summary>Rim Indirection Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color RimIndirColor { get; set; }

        /// <summary>Rim Indirection Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float RimIndirBorder { get; set; }

        /// <summary>Rim Indirection Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        float RimIndirBlur { get; set; }
    }
}