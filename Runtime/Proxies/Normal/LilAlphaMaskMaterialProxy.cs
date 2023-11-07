// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilAlphaMaskMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Alpha Mask Material Proxy
    /// </summary>
    public class LilAlphaMaskMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Alpha Mask Mode</summary>
        //[DefaultValue(LilAlphaMaskMode.None)]
        public LilAlphaMaskMode AlphaMaskMode
        {
            get => _Material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.AlphaMaskMode, LilAlphaMaskMode.None);
            set => _Material.SetSafeInt(PropertyNameID.AlphaMaskMode, (int)value);
        }

        /// <summary>Alpha Mask</summary>
        public Texture2D? AlphaMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.AlphaMask);
            set => _Material.SetSafeTexture(PropertyNameID.AlphaMask, value);
        }

        /// <summary>Alpha Mask Scale</summary>
        //[DefaultValue(1.0f)]
        public float AlphaMaskScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaMaskScale, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaMaskScale, value);
        }

        /// <summary>Alpha Mask Offset</summary>
        //[DefaultValue(0.0f)]
        public float AlphaMaskValue
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaMaskValue, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaMaskValue, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilAlphaMaskMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilAlphaMaskMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}