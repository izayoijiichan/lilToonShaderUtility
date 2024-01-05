// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRimShadeMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Rim Shade Material Proxy
    /// </summary>
    public class LilRimShadeMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Rim Shade</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(false)]
        public bool UseRimShade
        {
            get => _Material.GetSafeBool(PropertyNameID.UseRimShade, false);
            set => _Material.SetSafeBool(PropertyNameID.UseRimShade, value);
        }

        /// <summary>Rim Shade Color</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[DefaultValue(0.5,0.5,0.5,1.0)]
        public Color RimShadeColor
        {
            get => _Material.GetSafeColor(PropertyNameID.RimShadeColor, new Color(0.5f, 0.5f, 0.5f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.RimShadeColor, value);
        }

        /// <summary>Rim Shade Mask</summary>
        /// <remarks>v1.6.0 added</remarks>
        public Texture2D? RimShadeMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.RimShadeMask);
            set => _Material.SetSafeTexture(PropertyNameID.RimShadeMask, value);
        }

        /// <summary>Rim Shade Normal Strength</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadeNormalStrength, PropertyRange.RimShadeNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadeNormalStrength, PropertyRange.RimShadeNormalStrength, value);
        }

        /// <summary>Rim Shade Border</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimShadeBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadeBorder, PropertyRange.RimShadeBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadeBorder, PropertyRange.RimShadeBorder, value);
        }

        /// <summary>Rim Shade Blur</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadeBlur, PropertyRange.RimShadeBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadeBlur, PropertyRange.RimShadeBlur, value);
        }

        /// <summary>Rim Shade Fresnel Power</summary>
        /// <remarks>v1.6.0 added</remarks>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(1.0f)]
        public float RimShadeFresnelPower
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadeFresnelPower, PropertyRange.RimShadeFresnelPower.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadeFresnelPower, PropertyRange.RimShadeFresnelPower, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRimShadeMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRimShadeMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}