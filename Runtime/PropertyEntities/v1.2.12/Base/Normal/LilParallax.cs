// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilParallax
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Parallax
    /// </summary>
    public class LilParallax : ILilParallax
    {
        /// <summary>Use Parallax</summary>
        //[DefaultValue(false)]
        public bool UseParallax { get; set; }

        /// <summary>Parallax Map</summary>
        public Texture2D ParallaxMap { get; set; }

        /// <summary>Parallax Scale</summary>
        //[DefaultValue(0.02f)]
        public float Parallax { get; set; }

        /// <summary>Parallax Offset</summary>
        //[DefaultValue(0.5f)]
        public float ParallaxOffset { get; set; }
    }
}