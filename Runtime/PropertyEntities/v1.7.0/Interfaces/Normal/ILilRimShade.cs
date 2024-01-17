// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_7_0
// @Class     : ILilRimShade
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_7_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Rim Shade Interface
    /// </summary>
    public interface ILilRimShade
    {
        /// <summary>Use Rim Shade</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(false)]
        bool UseRimShade { get; set; }

        /// <summary>Rim Shade Color</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(0.5,0.5,0.5,1.0)]
        Color RimShadeColor { get; set; }

        /// <summary>Rim Shade Mask</summary>
        /// <remarks>v1.6.0 added</remarks>
        Texture2D? RimShadeMask { get; set; }

        /// <summary>Rim Shade Normal Strength</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimShadeNormalStrength { get; set; }

        /// <summary>Rim Shade Border</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float RimShadeBorder { get; set; }

        /// <summary>Rim Shade Blur</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float RimShadeBlur { get; set; }

        /// <summary>Rim Shade Fresnel Power</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(1.0f)]
        float RimShadeFresnelPower { get; set; }
    }
}