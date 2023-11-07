// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilSaveMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Save Material Proxy
    /// </summary>
    public class LilSaveMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Base Color</summary>
        public Color BaseColor
        {
            get => _Material.GetSafeColor(PropertyNameID.BaseColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.BaseColor, value);
        }

        /// <summary>Base Map</summary>
        public Texture2D? BaseMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.BaseMap);
            set => _Material.SetSafeTexture(PropertyNameID.BaseMap, value);
        }

        /// <summary>Base Color Map</summary>
        public Texture2D? BaseColorMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.BaseColorMap);
            set => _Material.SetSafeTexture(PropertyNameID.BaseColorMap, value);
        }

        /// <summary>lilToon Version</summary>
        //[DefaultValue(0)]
        public int LilToonVersion
        {
            get => _Material.GetSafeInt(PropertyNameID.LilToonVersion, 0);
            set => _Material.SetSafeInt(PropertyNameID.LilToonVersion, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilSaveMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilSaveMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}