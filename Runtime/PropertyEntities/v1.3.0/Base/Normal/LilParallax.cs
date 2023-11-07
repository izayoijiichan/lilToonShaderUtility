// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilParallax
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
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

        /// <summary>Use Parallax Occlusion Mapping (POM)</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool UsePOM { get; set; }

        /// <summary>Parallax Map</summary>
        public Texture2D? ParallaxMap { get; set; }

        /// <summary>Parallax Scale</summary>
        //[DefaultValue(0.02f)]
        public float Parallax { get; set; }

        /// <summary>Parallax Offset</summary>
        //[DefaultValue(0.5f)]
        public float ParallaxOffset { get; set; }
    }
}