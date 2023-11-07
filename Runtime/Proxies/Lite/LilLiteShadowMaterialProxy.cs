// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteShadowMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Shadow Material Proxy
    /// </summary>
    public class LilLiteShadowMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        public bool UseShadow
        {
            get => _Material.GetSafeBool(PropertyNameID.UseShadow, false);
            set => _Material.SetSafeBool(PropertyNameID.UseShadow, value);
        }

        /// <summary>Shadow Color Texture</summary>
        public Texture2D? ShadowColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.ShadowColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.ShadowColorTex, value);
        }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float ShadowBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBorder, LitePropertyRange.ShadowBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBorder, LitePropertyRange.ShadowBorder, value);
        }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float ShadowBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBlur, LitePropertyRange.ShadowBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBlur, LitePropertyRange.ShadowBlur, value);
        }

        /// <summary>Shadow 2nd Color Texture</summary>
        public Texture2D? Shadow2ndColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Shadow2ndColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.Shadow2ndColorTex, value);
        }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Shadow2ndBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow2ndBorder, LitePropertyRange.Shadow2ndBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow2ndBorder, LitePropertyRange.Shadow2ndBorder, value);
        }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        public float Shadow2ndBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow2ndBlur, LitePropertyRange.Shadow2ndBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow2ndBlur, LitePropertyRange.Shadow2ndBlur, value);
        }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0,0,1)]
        public Color ShadowBorderColor
        {
            get => _Material.GetSafeColor(PropertyNameID.ShadowBorderColor, new Color(1.0f, 0.0f, 0.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.ShadowBorderColor, value);
        }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBorderRange
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBorderRange, LitePropertyRange.ShadowBorderRange.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBorderRange, LitePropertyRange.ShadowBorderRange, value);
        }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowEnvStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowEnvStrength, LitePropertyRange.ShadowEnvStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowEnvStrength, LitePropertyRange.ShadowEnvStrength, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteShadowMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteShadowMaterialProxy(Material material) : base(material)
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