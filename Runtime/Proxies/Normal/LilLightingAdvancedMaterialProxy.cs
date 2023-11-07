// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLightingAdvancedMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Lighting Advanced Material Proxy
    /// </summary>
    public class LilLightingAdvancedMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>As Unlit</summary>
        /// <remarks>Base</remarks>
        //[DefaultValue(false)]
        public bool AsUnlit
        {
            get => _Material.GetSafeBool(PropertyNameID.AsUnlit, false);
            set => _Material.SetSafeBool(PropertyNameID.AsUnlit, value);
        }

        /// <summary>Vertex Light Strength</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        public float VertexLightStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.VertexLightStrength, PropertyRange.VertexLightStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.VertexLightStrength, PropertyRange.VertexLightStrength, value);
        }

        /// <summary>Light Direction Override</summary>
        //[DefaultValue(0.0f, 0.001f, 0.0f)]
        //[DefaultValue(0.001f, 0.002f, 0.001f)]
        public Vector3 LightDirectionOverride
        {
            get => _Material.GetSafeVector3(PropertyNameID.LightDirectionOverride, new Vector3(0.001f, 0.002f, 0.001f));
            set => _Material.SetSafeVector(PropertyNameID.LightDirectionOverride, value);
        }

        /// <summary>Alpha Boost Forward Add</summary>
        /// <remarks>Built-in RP</remarks>
        //[Range(1f, 100f)]
        //[DefaultValue(10f)]
        public float AlphaBoostFA
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaBoostFA, PropertyRange.AlphaBoostFA.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaBoostFA, PropertyRange.AlphaBoostFA, value);
        }

        /// <summary>Before Exposure Limit</summary>
        /// <remarks>HDRP</remarks>
        //[DefaultValue(10000f)]
        public float BeforeExposureLimit
        {
            get => _Material.GetSafeFloat(PropertyNameID.BeforeExposureLimit, 10000f);
            set => _Material.SetSafeFloat(PropertyNameID.BeforeExposureLimit, value);
        }

        /// <summary>Directional Light Strength</summary>
        /// <remarks>HDRP</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(1f)]
        public float LilDirectionalLightStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.LilDirectionalLightStrength, PropertyRange.LilDirectionalLightStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.LilDirectionalLightStrength, PropertyRange.LilDirectionalLightStrength, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLightingAdvancedMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLightingAdvancedMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}