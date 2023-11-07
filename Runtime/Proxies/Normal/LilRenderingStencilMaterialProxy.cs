// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRenderingStencilMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Stencil Material Proxy
    /// </summary>
    public class LilRenderingStencilMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int StencilRef
        {
            get => _Material.GetSafeInt(PropertyNameID.StencilRef, PropertyRange.StencilRef.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.StencilRef, PropertyRange.StencilRef, value);
        }

        /// <summary>Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int StencilReadMask
        {
            get => _Material.GetSafeInt(PropertyNameID.StencilReadMask, PropertyRange.StencilReadMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.StencilReadMask, PropertyRange.StencilReadMask, value);
        }

        /// <summary>Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int StencilWriteMask
        {
            get => _Material.GetSafeInt(PropertyNameID.StencilWriteMask, PropertyRange.StencilWriteMask.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.StencilWriteMask, PropertyRange.StencilWriteMask, value);
        }

        /// <summary>Stencil Compare</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction StencilComp
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.StencilComp, CompareFunction.Always);
            set => _Material.SetSafeInt(PropertyNameID.StencilComp, (int)value);
        }

        /// <summary>Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp StencilPass
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.StencilPass, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.StencilPass, (int)value);
        }

        /// <summary>Stencil Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp StencilFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.StencilFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.StencilFail, (int)value);
        }

        /// <summary>Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp StencilZFail
        {
            get => _Material.GetSafeEnum<StencilOp>(PropertyNameID.StencilZFail, StencilOp.Keep);
            set => _Material.SetSafeInt(PropertyNameID.StencilZFail, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRenderingStencilMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRenderingStencilMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}