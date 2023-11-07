// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRimMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Rim Material Proxy
    /// </summary>
    public class LilRimMaterialProxy : LilMaterialProxyBase
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
        //[DefaultValue(0.66,0.5,0.48,1)]
        public Color RimColor
        {
            get => _Material.GetSafeColor(PropertyNameID.RimColor, new Color(0.66f, 0.5f, 0.48f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.RimColor, value);
        }

        /// <summary>Rim Color Texture</summary>
        public Texture2D? RimColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.RimColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.RimColorTex, value);
        }

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimMainStrength, PropertyRange.RimMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimMainStrength, PropertyRange.RimMainStrength, value);
        }

        /// <summary>Rim Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimNormalStrength, PropertyRange.RimNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimNormalStrength, PropertyRange.RimNormalStrength, value);
        }

        /// <summary>Rim Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimBorder, PropertyRange.RimBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimBorder, PropertyRange.RimBorder, value);
        }

        /// <summary>Rim Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.65f)]
        public float RimBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimBlur, PropertyRange.RimBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimBlur, PropertyRange.RimBlur, value);
        }

        /// <summary>Rim Fresnel Power</summary>
        //[Range(0.01f, 50.0f)]
        //[DefaultValue(3.5f)]
        public float RimFresnelPower
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimFresnelPower, PropertyRange.RimFresnelPower.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimFresnelPower, PropertyRange.RimFresnelPower, value);
        }

        /// <summary>Rim Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimEnableLighting, PropertyRange.RimEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimEnableLighting, PropertyRange.RimEnableLighting, value);
        }

        /// <summary>Rim Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimShadowMask
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimShadowMask, PropertyRange.RimShadowMask.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimShadowMask, PropertyRange.RimShadowMask, value);
        }

        /// <summary>Rim Backface Mask</summary>
        //[DefaultValue(true)]
        public bool RimBackfaceMask
        {
            get => _Material.GetSafeBool(PropertyNameID.RimBackfaceMask, true);
            set => _Material.SetSafeBool(PropertyNameID.RimBackfaceMask, value);
        }

        /// <summary>Rim VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float RimVRParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimVRParallaxStrength, PropertyRange.RimVRParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimVRParallaxStrength, PropertyRange.RimVRParallaxStrength, value);
        }

        /// <summary>Rim Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool RimApplyTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.RimApplyTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.RimApplyTransparency, value);
        }

        /// <summary>Rim Direction Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimDirStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimDirStrength, PropertyRange.RimDirStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimDirStrength, PropertyRange.RimDirStrength, value);
        }

        /// <summary>Rim Direction Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimDirRange
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimDirRange, PropertyRange.RimDirRange.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimDirRange, PropertyRange.RimDirRange, value);
        }

        /// <summary>Rim Indirection Range</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float RimIndirRange
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimIndirRange, PropertyRange.RimIndirRange.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimIndirRange, PropertyRange.RimIndirRange, value);
        }

        /// <summary>Rim Indirection Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color RimIndirColor
        {
            get => _Material.GetSafeColor(PropertyNameID.RimIndirColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.RimIndirColor, value);
        }

        /// <summary>Rim Indirection Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float RimIndirBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimIndirBorder, PropertyRange.RimIndirBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimIndirBorder, PropertyRange.RimIndirBorder, value);
        }

        /// <summary>Rim Indirection Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float RimIndirBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimIndirBlur, PropertyRange.RimIndirBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimIndirBlur, PropertyRange.RimIndirBlur, value);
        }

        /// <summary>Rim Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode RimBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.RimBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.RimBlendMode, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRimMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRimMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}