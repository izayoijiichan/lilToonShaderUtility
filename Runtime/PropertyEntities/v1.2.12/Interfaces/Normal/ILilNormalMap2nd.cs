// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilNormalMap2nd
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon NormalMap 2nd Interface
    /// </summary>
    public interface ILilNormalMap2nd
    {
        /// <summary>UseBump 2nd Map</summary>
        //[DefaultValue(false)]
        bool UseBump2ndMap { get; set; }

        /// <summary>Bump 2nd Map</summary>
        Texture2D? Bump2ndMap { get; set; }

        /// <summary>Bump 2nd Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float Bump2ndScale { get; set; }

        /// <summary>Bump 2nd Scale Mask</summary>
        Texture2D? Bump2ndScaleMask { get; set; }
    }
}