// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilOutlineRenderingForwardMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward Material Proxy
    /// </summary>
    public class LilOutlineRenderingForwardMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Outline Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlend, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.OutlineSrcBlend, (int)value);
        }

        /// <summary>Outline Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode OutlineDstBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlend, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.OutlineDstBlend, (int)value);
        }

        /// <summary>Outline Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineSrcBlendAlpha, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.OutlineSrcBlendAlpha, (int)value);
        }

        /// <summary>Outline Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode OutlineDstBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.OutlineDstBlendAlpha, BlendMode.OneMinusSrcAlpha);
            set => _Material.SetSafeInt(PropertyNameID.OutlineDstBlendAlpha, (int)value);
        }

        /// <summary>Outline Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp OutlineBlendOp
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOp, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.OutlineBlendOp, (int)value);
        }

        /// <summary>Outline Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp OutlineBlendOpAlpha
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.OutlineBlendOpAlpha, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.OutlineBlendOpAlpha, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilOutlineRenderingForwardMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilOutlineRenderingForwardMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}