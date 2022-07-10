// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilOutlineRenderingStencil
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Stencil Interface
    /// </summary>
    public interface ILilOutlineRenderingStencil
    {
        /// <summary>Outline Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        int OutlineStencilRef { get; set; }

        /// <summary>Outline Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int OutlineStencilReadMask { get; set; }

        /// <summary>Outline Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int OutlineStencilWriteMask { get; set; }

        /// <summary>Outline Stencil Comp</summary>
        //[DefaultValue(CompareFunction.Always)]
        CompareFunction OutlineStencilComp { get; set; }

        /// <summary>Outline Stencil Pass</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp OutlineStencilPass { get; set; }

        /// <summary>Outline Stencil Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp OutlineStencilFail { get; set; }

        /// <summary>Outline Stencil Z Fail</summary>
        //[DefaultValue(StencilOp.Keep)]
        StencilOp OutlineStencilZFail { get; set; }
    }
}