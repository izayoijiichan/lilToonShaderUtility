// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilRim
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
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
        //[DefaultValue(0.66,0.5,0.48,1)]
        Color RimColor { get; set; }

        /// <summary>Rim Color Texture</summary>
        Texture2D? RimColorTex { get; set; }

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float RimMainStrength { get; set; }

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
        //[DefaultValue(0.65f)]
        float RimBlur { get; set; }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.5f)]
        float RimFresnelPower { get; set; }

        /// <summary>Rim Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimEnableLighting { get; set; }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float RimShadowMask { get; set; }

        /// <summary>Rim Backface Mask</summary>
        //[DefaultValue(true)]
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

        /// <summary>Rim Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        LilBlendMode RimBlendMode { get; set; }
    }
}