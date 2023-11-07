// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFurRenderingStencilMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon FurRenderingStencil Material Proxy
    /// </summary>
    public class LilFurRenderingStencilMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Fur Stencil Reference</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int FurStencilRef
        {
            get => _Material.GetSafeInt(PropertyNameID.FurStencilRef, PropertyRange.FurStencilRef.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilRef, PropertyRange.FurStencilRef, value);
        }

        /// <summary>Fur Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int FurStencilReadMask
        {
            get => _Material.GetSafeInt(PropertyNameID.FurStencilReadMask, PropertyRange.FurStencilReadMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilReadMask, PropertyRange.FurStencilReadMask, value);
        }

        /// <summary>Fur Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int FurStencilWriteMask
        {
            get => _Material.GetSafeInt(PropertyNameID.FurStencilWriteMask, PropertyRange.FurStencilWriteMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilWriteMask, PropertyRange.FurStencilWriteMask, value);
        }

        /// <summary>Fur Stencil Compare Function</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction FurStencilComp
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.FurStencilComp, CompareFunction.Always);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilComp, (int)value);
        }

        /// <summary>Fur Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilPass
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilPass, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilPass, (int)value);
        }

        /// <summary>Fur Stencil Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilFail, (int)value);
        }

        /// <summary>Fur Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilZFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.FurStencilZFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.FurStencilZFail, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFurRenderingStencilMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFurRenderingStencilMaterialProxy(Material material) : base(material)
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