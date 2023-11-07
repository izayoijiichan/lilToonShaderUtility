// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilBaseMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Base Material Proxy
    /// </summary>
    public class LilBaseMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        public bool Invisible
        {
            get => _Material.GetSafeBool(PropertyNameID.Invisible, false);
            set => _Material.SetSafeBool(PropertyNameID.Invisible, value);
        }

        /// <summary>Flip Backface Normal</summary>
        //[DefaultValue(false)]
        public bool FlipNormal
        {
            get => _Material.GetSafeBool(PropertyNameID.FlipNormal, false);
            set => _Material.SetSafeBool(PropertyNameID.FlipNormal, value);
        }

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        //[DefaultValue(false)]
        public bool ShiftBackfaceUV
        {
            get => _Material.GetSafeBool(PropertyNameID.ShiftBackfaceUV, false);
            set => _Material.SetSafeBool(PropertyNameID.ShiftBackfaceUV, value);
        }

        /// <summary>Backface Force Shadow</summary>
        //[DefaultValue(false)]
        public bool BackfaceForceShadow
        {
            get => _Material.GetSafeBool(PropertyNameID.BackfaceForceShadow, false);
            set => _Material.SetSafeBool(PropertyNameID.BackfaceForceShadow, value);
        }

        /// <summary>Backface Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0,0,0,0)]
        public Color BackfaceColor
        {
            get => _Material.GetSafeColor(PropertyNameID.BackfaceColor, new Color(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.BackfaceColor, value);
        }

        /// <summary>Anti-Aliasing Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        public float AAStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.AAStrength, PropertyRange.AAStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AAStrength, PropertyRange.AAStrength, value);
        }

        /// <summary>Use Dither</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool UseDither
        {
            get => _Material.GetSafeBool(PropertyNameID.UseDither, false);
            set => _Material.SetSafeBool(PropertyNameID.UseDither, value);
        }

        /// <summary>Dither Texture</summary>
        /// <remarks>v1.4.0 added</remarks>
        public Texture2D? DitherTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.DitherTex);
            set => _Material.SetSafeTexture(PropertyNameID.DitherTex, value);
        }

        /// <summary>Dither Max Value</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(255)]
        public float DitherMaxValue
        {
            get => _Material.GetSafeFloat(PropertyNameID.DitherMaxValue, 255);
            set => _Material.SetSafeFloat(PropertyNameID.DitherMaxValue, value, null, 255, 255);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilBaseMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilBaseMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}