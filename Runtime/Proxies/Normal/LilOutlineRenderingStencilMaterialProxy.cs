// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilOutlineRenderingStencilMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Stencil Material Proxy
    /// </summary>
    public class LilOutlineRenderingStencilMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Outline Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int OutlineStencilRef
        {
            get => _Material.GetSafeInt(PropertyNameID.OutlineStencilRef, PropertyRange.OutlineStencilRef.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilRef, PropertyRange.OutlineStencilRef, value);
        }

        /// <summary>Outline Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int OutlineStencilReadMask
        {
            get => _Material.GetSafeInt(PropertyNameID.OutlineStencilReadMask, PropertyRange.OutlineStencilReadMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilReadMask, PropertyRange.OutlineStencilReadMask, value);
        }

        /// <summary>Outline Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int OutlineStencilWriteMask
        {
            get => _Material.GetSafeInt(PropertyNameID.OutlineStencilWriteMask, PropertyRange.OutlineStencilWriteMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilWriteMask, PropertyRange.OutlineStencilWriteMask, value);
        }

        /// <summary>Outline Stencil Compare</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction OutlineStencilComp
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.OutlineStencilComp, CompareFunction.Always);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilComp, (int)value);
        }

        /// <summary>Outline Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilPass
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilPass, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilPass, (int)value);
        }

        /// <summary>Outline Stencil Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilFail, (int)value);
        }

        /// <summary>Outline Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilZFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.OutlineStencilZFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.OutlineStencilZFail, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilOutlineRenderingStencilMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilOutlineRenderingStencilMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}