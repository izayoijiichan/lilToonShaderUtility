// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFurRenderingForwardAddMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward Add Material Proxy
    /// </summary>
    public class LilFurRenderingForwardAddMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Fur Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurSrcBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.FurSrcBlendFA, (int)value);
        }

        /// <summary>Fur Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurDstBlendFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.FurDstBlendFA, (int)value);
        }

        /// <summary>Fur Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode FurSrcBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurSrcBlendAlphaFA, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.FurSrcBlendAlphaFA, (int)value);
        }

        /// <summary>Fur Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurDstBlendAlphaFA
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.FurDstBlendAlphaFA, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.FurDstBlendAlphaFA, (int)value);
        }

        /// <summary>Fur Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp FurBlendOpFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.FurBlendOpFA, (int)value);
        }

        /// <summary>Fur Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp FurBlendOpAlphaFA
        {
            get => _Material.GetSafeEnum<BlendOp>(PropertyNameID.FurBlendOpAlphaFA, BlendOp.Max);
            set => _Material.SetSafeInt(PropertyNameID.FurBlendOpAlphaFA, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFurRenderingForwardAddMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFurRenderingForwardAddMaterialProxy(Material material) : base(material)
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