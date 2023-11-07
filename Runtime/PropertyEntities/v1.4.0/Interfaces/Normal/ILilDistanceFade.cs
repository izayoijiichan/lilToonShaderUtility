// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : ILilDistanceFade
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_4_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Distance Fade Interface
    /// </summary>
    public interface ILilDistanceFade
    {
        /// <summary>Distance Fade Settings</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        //[DefaultValue(0.1,0.01,0,0)]
        Vector4 DistanceFade { get; set; }

        /// <summary>Distance Fade Color</summary>
        //[DefaultValue(0,0,0,1)]
        Color DistanceFadeColor { get; set; }

        /// <summary>Distance Fade Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        LilDistanceFadeMode DistanceFadeMode { get; set; }

        /// <summary>Distance Fade Rim Color</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0,0,0,0)]
        Color DistanceFadeRimColor { get; set; }

        /// <summary>Distance Fade Rim Fresnel Power</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[Range(0.01,50.0)]
        //[DefaultValue(5.0)]
        float DistanceFadeRimFresnelPower { get; set; }
    }
}