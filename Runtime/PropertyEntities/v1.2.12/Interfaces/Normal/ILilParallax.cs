// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilParallax
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Parallax Interface
    /// </summary>
    public interface ILilParallax
    {
        /// <summary>Use Parallax</summary>
        //[DefaultValue(false)]
        bool UseParallax { get; set; }

        /// <summary>Parallax Map</summary>
        Texture2D ParallaxMap { get; set; }

        /// <summary>Parallax Scale</summary>
        //[DefaultValue(0.02f)]
        float Parallax { get; set; }

        /// <summary>Parallax Offset</summary>
        //[DefaultValue(0.5f)]
        float ParallaxOffset { get; set; }
    }
}