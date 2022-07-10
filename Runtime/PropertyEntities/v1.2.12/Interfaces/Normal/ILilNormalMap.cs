// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilNormalMap
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon NormalMap Interface
    /// </summary>
    public interface ILilNormalMap
    {
        /// <summary>Use Bump Map</summary>
        //[DefaultValue(false)]
        bool UseBumpMap { get; set; }

        /// <summary>Bump Map</summary>
        Texture2D BumpMap { get; set; }

        /// <summary>Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float BumpScale { get; set; }
    }
}