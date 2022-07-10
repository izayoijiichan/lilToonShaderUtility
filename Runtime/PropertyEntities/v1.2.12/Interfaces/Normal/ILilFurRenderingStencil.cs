// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFurRenderingStencil
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Stencil Interface
    /// </summary>
    public interface ILilFurRenderingStencil
    {
        /// <summary>Fur Stencil Reference</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        int FurStencilRef { get; set; }

        /// <summary>Fur Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int FurStencilReadMask { get; set; }

        /// <summary>Fur Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int FurStencilWriteMask { get; set; }

        /// <summary>Fur Stencil Compare Function</summary>
        //[DefaultValue(CompareFunction.Always)]
        CompareFunction FurStencilComp { get; set; }

        /// <summary>Fur Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp FurStencilPass { get; set; }

        /// <summary>Fur StencilFail</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp FurStencilFail { get; set; }

        /// <summary>Fur Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp FurStencilZFail { get; set; }
    }
}