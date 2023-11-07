// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLightingMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Lighting Material Proxy
    /// </summary>
    public class LilLightingMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Light Min Limit</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0.05f)]
        public float LightMinLimit
        {
            get => _Material.GetSafeFloat(PropertyNameID.LightMinLimit, PropertyRange.LightMinLimit.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.LightMinLimit, PropertyRange.LightMinLimit, value);
        }

        /// <summary>Light Max Limit</summary>
        //[Range(0f, 10f)]
        //[DefaultValue(1f)]
        public float LightMaxLimit
        {
            get => _Material.GetSafeFloat(PropertyNameID.LightMaxLimit, PropertyRange.LightMaxLimit.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.LightMaxLimit, PropertyRange.LightMaxLimit, value);
        }

        /// <summary>Monochrome Lighting</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        public float MonochromeLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.MonochromeLighting, PropertyRange.MonochromeLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MonochromeLighting, PropertyRange.MonochromeLighting, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLightingMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLightingMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}