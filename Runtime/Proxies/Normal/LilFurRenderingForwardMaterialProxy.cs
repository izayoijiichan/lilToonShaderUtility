// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilAnisotropyMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward Material Proxy
    /// </summary>
    public class LilFurRenderingForwardMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Fur Src Blend</summary>
        //[DefaultValue(BlendMode.SrcAlpha)]
        public BlendMode FurSrcBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlend, BlendMode.SrcAlpha);
            set => _Material.SetSafeInt(PropertyNameID.FurSrcBlend, (int)value);
        }

        /// <summary>Fur Dst Blend</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode FurDstBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlend, BlendMode.SrcAlpha);
            set => _Material.SetSafeInt(PropertyNameID.FurDstBlend, (int)value);
        }

        /// <summary>Fur Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurSrcBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendAlpha, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.FurSrcBlendAlpha, (int)value);
        }

        /// <summary>Fur Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode FurDstBlendAlpha
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendAlpha, BlendMode.OneMinusSrcAlpha);
            set => _Material.SetSafeInt(PropertyNameID.FurDstBlendAlpha, (int)value);
        }

        /// <summary>Fur Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp FurBlendOp
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOp, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.FurBlendOp, (int)value);
        }

        /// <summary>Fur Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp FurBlendOpAlpha
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpAlpha, BlendOp.Add);
            set => _Material.SetSafeInt(PropertyNameID.FurBlendOpAlpha, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFurRenderingForwardMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFurRenderingForwardMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsFur() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}