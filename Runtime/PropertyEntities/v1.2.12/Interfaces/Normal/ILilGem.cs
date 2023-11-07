// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilGem
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Gem Interface
    /// </summary>
    public interface ILilGem
    {
        /// <summary>Gem Chromatic Aberration</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.02f)]
        float GemChromaticAberration { get; set; }

        /// <summary>Gem Environment Contrast</summary>
        //[DefaultValue(2.0f)]
        float GemEnvContrast { get; set; }

        /// <summary>Gem Environment Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color GemEnvColor { get; set; }

        /// <summary>Gem Particle Loop</summary>
        //[DefaultValue(8)]
        float GemParticleLoop { get; set; }

        /// <summary>Gem Particle Color</summary>
        //[DefaultValue(4,4,4,1)]
        Color GemParticleColor { get; set; }

        /// <summary>Gem VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float GemVRParallaxStrength { get; set; }
    }
}