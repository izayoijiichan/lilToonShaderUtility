// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMultiMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Multi Material Proxy
    /// </summary>
    public class LilMultiMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Outline</summary>
        //[DefaultValue(false)]
        public bool UseOutline
        {
            get => _Material.GetSafeBool(PropertyNameID.UseOutline, false);
            set => _Material.SetSafeBool(PropertyNameID.UseOutline, value);
        }

        /// <summary>Transparent Mode</summary>
        //[DefaultValue(LilRenderingMode.Opaque)]
        public LilRenderingMode TransparentMode
        {
            get => _Material.GetSafeEnum<LilRenderingMode>(PropertyNameID.TransparentMode, LilRenderingMode.Opaque);
            set => _Material.SetSafeInt(PropertyNameID.TransparentMode, (int)value);
        }

        /// <summary>Use Parallax Occlusion Mapping (POM)</summary>
        /// <remarks>v1.3.0 to Parallax</remarks>
        //[DefaultValue(false)]
        public bool UsePOM
        {
            get => _Material.GetSafeBool(PropertyNameID.UsePOM, false);
            set => _Material.SetSafeBool(PropertyNameID.UsePOM, value);
        }

        /// <summary>Use Clipping Canceller</summary>
        //[DefaultValue(false)]
        public bool UseClippingCanceller
        {
            get => _Material.GetSafeBool(PropertyNameID.UseClippingCanceller, false);
            set => _Material.SetSafeBool(PropertyNameID.UseClippingCanceller, value);
        }

        /// <summary>As Overlay</summary>
        //[DefaultValue(false)]
        public bool AsOverlay
        {
            get => _Material.GetSafeBool(PropertyNameID.AsOverlay, false);
            set => _Material.SetSafeBool(PropertyNameID.AsOverlay, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMultiMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMultiMaterialProxy(Material material) : base(material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.IsMulti() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}