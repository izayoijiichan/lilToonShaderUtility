// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilNormalMap2nd
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Normal Map 2nd
    /// </summary>
    public class LilNormalMap2nd : ILilNormalMap2nd
    {
        /// <summary>Use Bump 2nd Map</summary>
        //[DefaultValue(false)]
        public bool UseBump2ndMap { get; set; }

        /// <summary>Bump 2nd Map</summary>
        public Texture2D? Bump2ndMap { get; set; }

        /// <summary>Bump 2nd Map UV Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(LilNormalMapUVMode.UV0)]
        public LilNormalMapUVMode Bump2ndMap_UVMode { get; set; }

        /// <summary>Bump 2nd Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Bump2ndScale { get; set; }

        /// <summary>Bump 2nd Scale Mask</summary>
        public Texture2D? Bump2ndScaleMask { get; set; }
    }
}