// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilNormalMap
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Normal Map
    /// </summary>
    public class LilNormalMap : ILilNormalMap
    {
        /// <summary>Use Bump Map</summary>
        //[DefaultValue(false)]
        public bool UseBumpMap { get; set; }

        /// <summary>Bump Map</summary>
        public Texture2D? BumpMap { get; set; }

        /// <summary>Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float BumpScale { get; set; }
    }
}