// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_6_0
// @Class     : LilRimShade
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_6_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Rim Shade
    /// </summary>
    /// <remarks>v1.6.0 added</remarks>
    public class LilRimShade : ILilRimShade
    {
        /// <summary>Use Rim Shade</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(false)]
        public bool UseRimShade { get; set; }

        /// <summary>Rim Shade Color</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(0.5,0.5,0.5,1.0)]
        public Color RimShadeColor { get; set; }

        /// <summary>Rim Shade Mask</summary>
        /// <remarks>v1.6.0 added</remarks>
        public Texture2D? RimShadeMask { get; set; }

        /// <summary>Rim Shade Normal Strength</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeNormalStrength { get; set; }

        /// <summary>Rim Shade Border</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimShadeBorder { get; set; }

        /// <summary>Rim Shade Blur</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeBlur { get; set; }

        /// <summary>Rim Shade Fresnel Power</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeFresnelPower { get; set; }
    }
}