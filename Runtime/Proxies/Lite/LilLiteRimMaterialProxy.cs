// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteRimMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Rim Material Proxy
    /// </summary>
    public class LilLiteRimMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Rim</summary>
        //[DefaultValue(false)]
        public bool UseRim
        {
            get => _Material.GetSafeBool(PropertyNameID.UseRim, false);
            set => _Material.SetSafeBool(PropertyNameID.UseRim, value);
        }

        /// <summary>Rim Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color RimColor
        {
            get => _Material.GetSafeColor(PropertyNameID.RimColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.RimColor, value);
        }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimBorder, LitePropertyRange.RimBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimBorder, LitePropertyRange.RimBorder, value);
        }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float RimBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimBlur, LitePropertyRange.RimBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimBlur, LitePropertyRange.RimBlur, value);
        }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.0f)]
        public float RimFresnelPower
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimFresnelPower, LitePropertyRange.RimFresnelPower.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimFresnelPower, LitePropertyRange.RimFresnelPower, value);
        }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimShadowMask
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadowMask, LitePropertyRange.RimShadowMask.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadowMask, LitePropertyRange.RimShadowMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteRimMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteRimMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsLite() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}