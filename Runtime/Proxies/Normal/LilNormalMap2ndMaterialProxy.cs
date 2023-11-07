// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEncryptionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Normal Map 2nd Material Proxy
    /// </summary>
    public class LilNormalMap2ndMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Bump 2nd Map</summary>
        //[DefaultValue(false)]
        public bool UseBump2ndMap
        {
            get => _Material.GetSafeBool(PropertyNameID.UseBump2ndMap, false);
            set => _Material.SetSafeBool(PropertyNameID.UseBump2ndMap, value);
        }

        /// <summary>Bump 2nd Map</summary>
        public Texture2D? Bump2ndMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.Bump2ndMap);
            set => _Material.SetSafeTexture(PropertyNameID.Bump2ndMap, value);
        }

        /// <summary>Bump 2nd Map UV Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(LilNormalMapUVMode.UV0)]
        public LilNormalMapUVMode Bump2ndMap_UVMode
        {
            get => _Material.GetSafeEnum<LilNormalMapUVMode>(PropertyNameID.Bump2ndMap_UVMode, LilNormalMapUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.Bump2ndMap_UVMode, (int)value);
        }

        /// <summary>Bump 2nd Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Bump2ndScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.Bump2ndScale, PropertyRange.Bump2ndScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Bump2ndScale, PropertyRange.Bump2ndScale, value);
        }

        /// <summary>Bump 2nd Scale Mask</summary>
        public Texture2D? Bump2ndScaleMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Bump2ndScaleMask);
            set => _Material.SetSafeTexture(PropertyNameID.Bump2ndScaleMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilNormalMap2ndMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilNormalMap2ndMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}