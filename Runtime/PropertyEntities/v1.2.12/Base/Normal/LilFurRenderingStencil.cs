// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFurRenderingStencil
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Stencil
    /// </summary>
    public class LilFurRenderingStencil : ILilFurRenderingStencil
    {
        /// <summary>Fur Stencil Reference</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int FurStencilRef { get; set; }

        /// <summary>Fur Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int FurStencilReadMask { get; set; }

        /// <summary>Fur Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int FurStencilWriteMask { get; set; }

        /// <summary>Fur Stencil Compare Function</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction FurStencilComp { get; set; }

        /// <summary>Fur Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilPass { get; set; }

        /// <summary>Fur StencilFail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilFail { get; set; }

        /// <summary>Fur Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp FurStencilZFail { get; set; }
    }
}