// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilBacklightMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Backlight Material Proxy
    /// </summary>
    public class LilBacklightMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Backlight</summary>
        //[DefaultValue(false)]
        public bool UseBacklight
        {
            get => _Material.GetSafeBool(PropertyNameID.UseBacklight, false);
            set => _Material.SetSafeBool(PropertyNameID.UseBacklight, value);
        }

        /// <summary>Backlight Color</summary>
        //[DefaultValue(0.85,0.8,0.7,1.0)]
        public Color BacklightColor
        {
            get => _Material.GetSafeColor(PropertyNameID.BacklightColor, new Color(0.85f, 0.8f, 0.7f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.BacklightColor, value);
        }

        /// <summary>Backlight Color Texture</summary>
        public Texture2D? BacklightColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.BacklightColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.BacklightColorTex, value);
        }

        /// <summary>Backlight Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float BacklightMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightMainStrength, PropertyRange.BacklightMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightMainStrength, PropertyRange.BacklightMainStrength, value);
        }

        /// <summary>Backlight Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BacklightNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightNormalStrength, PropertyRange.BacklightNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightNormalStrength, PropertyRange.BacklightNormalStrength, value);
        }

        /// <summary>Backlight Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.35f)]
        public float BacklightBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightBorder, PropertyRange.BacklightBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightBorder, PropertyRange.BacklightBorder, value);
        }

        /// <summary>Backlight Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        public float BacklightBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightBlur, PropertyRange.BacklightBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightBlur, PropertyRange.BacklightBlur, value);
        }

        /// <summary>Backlight Directivity</summary>
        //[DefaultValue(5.0f)]
        public float BacklightDirectivity
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightDirectivity, 5.0f);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightDirectivity, value);
        }

        /// <summary>Backlight View Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BacklightViewStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.BacklightViewStrength, PropertyRange.BacklightViewStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BacklightViewStrength, PropertyRange.BacklightViewStrength, value);
        }

        /// <summary>Backlight Receive Shadow</summary>
        //[DefaultValue(true)]
        public bool BacklightReceiveShadow
        {
            get => _Material.GetSafeBool(PropertyNameID.BacklightReceiveShadow, true);
            set => _Material.SetSafeBool(PropertyNameID.BacklightReceiveShadow, value);
        }

        /// <summary>Backlight Backface Mask</summary>
        //[DefaultValue(true)]
        public bool BacklightBackfaceMask
        {
            get => _Material.GetSafeBool(PropertyNameID.BacklightBackfaceMask, true);
            set => _Material.SetSafeBool(PropertyNameID.BacklightBackfaceMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilBacklightMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilBacklightMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}