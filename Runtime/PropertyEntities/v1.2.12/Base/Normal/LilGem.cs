// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilGem
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Gem
    /// </summary>
    public class LilGem : ILilGem
    {
        /// <summary>Gem Chromatic Aberration</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.02f)]
        public float GemChromaticAberration { get; set; }

        /// <summary>Gem Environment Contrast</summary>
        //[DefaultValue(2.0f)]
        public float GemEnvContrast { get; set; }

        /// <summary>Gem Environment Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color GemEnvColor { get; set; }

        /// <summary>Gem Particle Loop</summary>
        //[DefaultValue(8)]
        public float GemParticleLoop { get; set; }

        /// <summary>Gem Particle Color</summary>
        //[DefaultValue(4,4,4,1)]
        public Color GemParticleColor { get; set; }

        /// <summary>Gem VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GemVRParallaxStrength { get; set; }
    }
}