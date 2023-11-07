// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRenderingForwardMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward Material Proxy
    /// </summary>
    public class LilRenderingForwardMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlend, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.SrcBlend, (int)value);
        }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlend, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.DstBlend, (int)value);
        }

        /// <summary>Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.SrcBlendAlpha, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.SrcBlendAlpha, (int)value);
        }

        /// <summary>Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode DstBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.DstBlendAlpha, BlendMode.OneMinusSrcAlpha);
            set => _Material.SetSafeInt(PropertyNameID.DstBlendAlpha, (int)value);
        }

        /// <summary>Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOp
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOp, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.BlendOp, (int)value);
        }

        /// <summary>Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOpAlpha
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.BlendOpAlpha, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.BlendOpAlpha, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRenderingForwardMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRenderingForwardMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}