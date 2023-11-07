// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilNormalMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Normal Map Material Proxy
    /// </summary>
    public class LilNormalMapMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Bump Map</summary>
        //[DefaultValue(false)]
        public bool UseBumpMap
        {
            get => _Material.GetSafeBool(PropertyNameID.UseBumpMap, false);
            set => _Material.SetSafeBool(PropertyNameID.UseBumpMap, value);
        }

        /// <summary>Bump Map</summary>
        public Texture2D? BumpMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.BumpMap);
            set => _Material.SetSafeTexture(PropertyNameID.BumpMap, value);
        }

        /// <summary>Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float BumpScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.BumpScale, PropertyRange.BumpScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BumpScale, PropertyRange.BumpScale, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilNormalMapMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilNormalMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}