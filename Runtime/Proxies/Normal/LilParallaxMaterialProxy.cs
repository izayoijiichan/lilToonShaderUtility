// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilParallaxMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Parallax Material Proxy
    /// </summary>
    public class LilParallaxMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Parallax</summary>
        //[DefaultValue(false)]
        public bool UseParallax
        {
            get => _Material.GetSafeBool(PropertyNameID.UseParallax, false);
            set => _Material.SetSafeBool(PropertyNameID.UseParallax, value);
        }

        /// <summary>Use Parallax Occlusion Mapping (POM)</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool UsePOM
        {
            get => _Material.GetSafeBool(PropertyNameID.UsePOM, false);
            set => _Material.SetSafeBool(PropertyNameID.UsePOM, value);
        }

        /// <summary>Parallax Map</summary>
        public Texture2D? ParallaxMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.ParallaxMap);
            set => _Material.SetSafeTexture(PropertyNameID.ParallaxMap, value);
        }

        /// <summary>Parallax Scale</summary>
        //[DefaultValue(0.02f)]
        public float Parallax
        {
            get => _Material.GetSafeFloat(PropertyNameID.Parallax, 0.02f);
            set => _Material.SetSafeFloat(PropertyNameID.Parallax, value);
        }

        /// <summary>Parallax Offset</summary>
        //[DefaultValue(0.5f)]
        public float ParallaxOffset
        {
            get => _Material.GetSafeFloat(PropertyNameID.ParallaxOffset, 0.5f);
            set => _Material.SetSafeFloat(PropertyNameID.ParallaxOffset, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilParallaxMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilParallaxMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}