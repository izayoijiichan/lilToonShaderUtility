// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilAnisotropyMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Anisotropy Material Proxy
    /// </summary>
    public class LilAnisotropyMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Anisotropy</summary>
        //[DefaultValue(false)]
        public bool UseAnisotropy
        {
            get => _Material.GetSafeBool(PropertyNameID.UseAnisotropy, false);
            set => _Material.SetSafeBool(PropertyNameID.UseAnisotropy, value);
        }

        /// <summary>Anisotropy Tangent Map</summary>
        public Texture2D? AnisotropyTangentMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.AnisotropyTangentMap);
            set => _Material.SetSafeTexture(PropertyNameID.AnisotropyTangentMap, value);
        }

        /// <summary>Anisotropy Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropyScale, PropertyRange.AnisotropyScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropyScale, PropertyRange.AnisotropyScale, value);
        }

        /// <summary>Anisotropy Scale Mask</summary>
        public Texture2D? AnisotropyScaleMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.AnisotropyScaleMask);
            set => _Material.SetSafeTexture(PropertyNameID.AnisotropyScaleMask, value);
        }

        /// <summary>Anisotropy Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyTangentWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropyTangentWidth, PropertyRange.AnisotropyTangentWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropyTangentWidth, PropertyRange.AnisotropyTangentWidth, value);
        }

        /// <summary>Anisotropy Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyBitangentWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropyBitangentWidth, PropertyRange.AnisotropyBitangentWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropyBitangentWidth, PropertyRange.AnisotropyBitangentWidth, value);
        }

        /// <summary>Anisotropy Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float AnisotropyShift
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropyShift, PropertyRange.AnisotropyShift.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropyShift, PropertyRange.AnisotropyShift, value);
        }

        /// <summary>Anisotropy Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float AnisotropyShiftNoiseScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropyShiftNoiseScale, PropertyRange.AnisotropyShiftNoiseScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropyShiftNoiseScale, PropertyRange.AnisotropyShiftNoiseScale, value);
        }

        /// <summary>Anisotropy Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropySpecularStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.AnisotropySpecularStrength, PropertyRange.AnisotropySpecularStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AnisotropySpecularStrength, PropertyRange.AnisotropySpecularStrength, value);
        }

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Anisotropy2ndTangentWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.Anisotropy2ndTangentWidth, PropertyRange.Anisotropy2ndTangentWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Anisotropy2ndTangentWidth, PropertyRange.Anisotropy2ndTangentWidth, value);
        }

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Anisotropy2ndBitangentWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.Anisotropy2ndBitangentWidth, PropertyRange.Anisotropy2ndBitangentWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Anisotropy2ndBitangentWidth, PropertyRange.Anisotropy2ndBitangentWidth, value);
        }

        /// <summary>Anisotropy 2nd Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndShift
        {
            get => _Material.GetSafeFloat(PropertyNameID.Anisotropy2ndShift, PropertyRange.Anisotropy2ndShift.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Anisotropy2ndShift, PropertyRange.Anisotropy2ndShift, value);
        }

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndShiftNoiseScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.Anisotropy2ndShiftNoiseScale, PropertyRange.Anisotropy2ndShiftNoiseScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Anisotropy2ndShiftNoiseScale, PropertyRange.Anisotropy2ndShiftNoiseScale, value);
        }

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndSpecularStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Anisotropy2ndSpecularStrength, PropertyRange.Anisotropy2ndSpecularStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Anisotropy2ndSpecularStrength, PropertyRange.Anisotropy2ndSpecularStrength, value);
        }

        /// <summary>Anisotropy Shift Noise Mask</summary>
        public Texture2D? AnisotropyShiftNoiseMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.AnisotropyShiftNoiseMask);
            set => _Material.SetSafeTexture(PropertyNameID.AnisotropyShiftNoiseMask, value);
        }

        /// <summary>Anisotropy 2 Reflection</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2Reflection
        {
            get => _Material.GetSafeBool(PropertyNameID.Anisotropy2Reflection, false);
            set => _Material.SetSafeBool(PropertyNameID.Anisotropy2Reflection, value);
        }

        /// <summary>Anisotropy 2 Mat Cap</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2MatCap
        {
            get => _Material.GetSafeBool(PropertyNameID.Anisotropy2MatCap, false);
            set => _Material.SetSafeBool(PropertyNameID.Anisotropy2MatCap, value);
        }

        /// <summary>Anisotropy 2 Mat Cap 2nd</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2MatCap2nd
        {
            get => _Material.GetSafeBool(PropertyNameID.Anisotropy2MatCap2nd, false);
            set => _Material.SetSafeBool(PropertyNameID.Anisotropy2MatCap2nd, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilAnisotropyMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilAnisotropyMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}