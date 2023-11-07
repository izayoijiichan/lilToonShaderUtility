// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRenderingForwardAddMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward Add Material Proxy
    /// </summary>
    public class LilRenderingForwardAddMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.SrcBlendFA, (int)value);
        }

        /// <summary>Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode DstBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.DstBlendFA, (int)value);
        }

        /// <summary>Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode SrcBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendAlphaFA, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.SrcBlendAlphaFA, (int)value);
        }

        /// <summary>Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode DstBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendAlphaFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.DstBlendAlphaFA, (int)value);
        }

        /// <summary>Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp BlendOpFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.BlendOpFA, (int)value);
        }

        /// <summary>Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp BlendOpAlphaFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpAlphaFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.BlendOpAlphaFA, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRenderingForwardAddMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRenderingForwardAddMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}