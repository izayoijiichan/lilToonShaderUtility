// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilDistanceFadeMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Distance Fade Material Proxy
    /// </summary>
    public class LilDistanceFadeMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Distance Fade Settings</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        //[DefaultValue(0.1,0.01,0,0)]
        public Vector4 DistanceFade
        {
            get => _Material.GetSafeVector4(PropertyNameID.DistanceFade, new Vector4(0.1f, 0.01f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.DistanceFade, value);
        }

        /// <summary>Distance Fade Color</summary>
        //[DefaultValue(0,0,0,1)]
        public Color DistanceFadeColor
        {
            get => _Material.GetSafeColor(PropertyNameID.DistanceFadeColor, Color.black);
            set => _Material.SetSafeColor(PropertyNameID.DistanceFadeColor, value);
        }

        /// <summary>Distance Fade Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public LilDistanceFadeMode DistanceFadeMode
        {
            get => _Material.GetSafeEnum<LilDistanceFadeMode>(PropertyNameID.DistanceFadeMode, LilDistanceFadeMode.Vertex);
            set => _Material.SetSafeInt(PropertyNameID.DistanceFadeMode, (int)value);
        }

        /// <summary>Distance Fade Rim Color</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0,0,0,0)]
        public Color DistanceFadeRimColor
        {
            get => _Material.GetSafeColor(PropertyNameID.DistanceFadeRimColor, new Color(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.DistanceFadeRimColor, value);
        }

        /// <summary>Distance Fade Rim Fresnel Power</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[Range(0.01,50.0)]
        //[DefaultValue(5.0)]
        public float DistanceFadeRimFresnelPower
        {
            get => _Material.GetSafeFloat(PropertyNameID.DistanceFadeRimFresnelPower, PropertyRange.DistanceFadeRimFresnelPower.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.DistanceFadeRimFresnelPower, PropertyRange.DistanceFadeRimFresnelPower, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilDistanceFadeMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilDistanceFadeMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}