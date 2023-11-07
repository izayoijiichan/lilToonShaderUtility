// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilOutlineRenderingStencil
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Stencil
    /// </summary>
    public class LilOutlineRenderingStencil : ILilOutlineRenderingStencil
    {
        /// <summary>Outline Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int OutlineStencilRef { get; set; }

        /// <summary>Outline Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int OutlineStencilReadMask { get; set; }

        /// <summary>Outline Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int OutlineStencilWriteMask { get; set; }

        /// <summary>Outline Stencil Compare</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction OutlineStencilComp { get; set; }

        /// <summary>Outline Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilPass { get; set; }

        /// <summary>Outline Stencil Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilFail { get; set; }

        /// <summary>Outline Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        public StencilOp OutlineStencilZFail { get; set; }
    }
}