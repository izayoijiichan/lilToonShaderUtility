// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilGemMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Gem Material Proxy
    /// </summary>
    public class LilGemMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Gem Chromatic Aberration</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.02f)]
        public float GemChromaticAberration
        {
            get => _Material.GetSafeFloat(PropertyNameID.GemChromaticAberration, PropertyRange.GemChromaticAberration.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GemChromaticAberration, PropertyRange.GemChromaticAberration, value);
        }

        /// <summary>Gem Environment Contrast</summary>
        //[DefaultValue(2.0f)]
        public float GemEnvContrast
        {
            get => _Material.GetSafeFloat(PropertyNameID.GemEnvContrast, 2.0f);
            set => _Material.SetSafeFloat(PropertyNameID.GemEnvContrast, value);
        }

        /// <summary>Gem Environment Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color GemEnvColor
        {
            get => _Material.GetSafeColor(PropertyNameID.GemEnvColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.GemEnvColor, value);
        }

        /// <summary>Gem Particle Loop</summary>
        //[DefaultValue(8)]
        public float GemParticleLoop
        {
            get => _Material.GetSafeFloat(PropertyNameID.GemParticleLoop, 8);
            set => _Material.SetSafeFloat(PropertyNameID.GemParticleLoop, value);
        }

        /// <summary>Gem Particle Color</summary>
        //[DefaultValue(4,4,4,1)]
        public Color GemParticleColor
        {
            get => _Material.GetSafeColor(PropertyNameID.GemParticleColor, new Color(4.0f, 4.0f, 4.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.GemParticleColor, value);
        }

        /// <summary>Gem VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GemVRParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.GemVRParallaxStrength, PropertyRange.GemVRParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GemVRParallaxStrength, PropertyRange.GemVRParallaxStrength, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilGemMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        /// <remarks>RenderingMode is Gem or Gem</remarks>
        public LilGemMaterialProxy(Material material) : base(material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.IsGem() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}