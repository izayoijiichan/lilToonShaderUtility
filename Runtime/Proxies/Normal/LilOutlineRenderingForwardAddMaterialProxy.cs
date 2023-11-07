// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilOutlineRenderingForwardAddMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward Add Material Proxy
    /// </summary>
    public class LilOutlineRenderingForwardAddMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Outline Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.OutlineSrcBlendFA, (int)value);
        }

        /// <summary>Outline Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineDstBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.OutlineDstBlendFA, (int)value);
        }

        /// <summary>Outline Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode OutlineSrcBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendAlphaFA, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.OutlineSrcBlendAlphaFA, (int)value);
        }

        /// <summary>Outline Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineDstBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendAlphaFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.OutlineDstBlendAlphaFA, (int)value);
        }

        /// <summary>Outline Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp OutlineBlendOpFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.OutlineBlendOpFA, (int)value);
        }

        /// <summary>Outline Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp OutlineBlendOpAlphaFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpAlphaFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.OutlineBlendOpAlphaFA, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilOutlineRenderingForwardAddMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilOutlineRenderingForwardAddMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}