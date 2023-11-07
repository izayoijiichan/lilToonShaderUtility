// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRefractionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Refraction Material Proxy
    /// </summary>
    public class LilRefractionMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Refraction Strength</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float RefractionStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RefractionStrength, PropertyRange.RefractionStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RefractionStrength, PropertyRange.RefractionStrength, value);
        }

        /// <summary>Refraction Fresnel Power</summary>
        //[Range(0.01f, 10.0f)]
        //[DefaultValue(0.5f)]
        public float RefractionFresnelPower
        {
            get => _Material.GetSafeFloat(PropertyNameID.RefractionFresnelPower, PropertyRange.RefractionFresnelPower.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RefractionFresnelPower, PropertyRange.RefractionFresnelPower, value);
        }

        /// <summary>Refraction Color from Main</summary>
        //[DefaultValue(false)]
        public bool RefractionColorFromMain
        {
            get => _Material.GetSafeBool(PropertyNameID.RefractionColorFromMain, false);
            set => _Material.SetSafeBool(PropertyNameID.RefractionColorFromMain, value);
        }

        /// <summary>Refraction Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color RefractionColor
        {
            get => _Material.GetSafeColor(PropertyNameID.RefractionColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.RefractionColor, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRefractionMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        /// <remarks>RenderingMode is Refraction or Gem</remarks>
        public LilRefractionMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsRefraction() == false &&
                material.shader.IsGem() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}