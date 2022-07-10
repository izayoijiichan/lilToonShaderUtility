// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRenderingStencil
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Stencil Interface
    /// </summary>
    public interface ILilRenderingStencil
    {
        /// <summary>Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        int StencilRef { get; set; }

        /// <summary>Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int StencilReadMask { get; set; }

        /// <summary>Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        int StencilWriteMask { get; set; }

        /// <summary>Stencil Comp</summary>
        //[DefaultValue(CompareFunction.Always)]
        CompareFunction StencilComp { get; set; }

        /// <summary>Stencil Pass</summary>
        //[DefaultValue(BlendOp.Add)]
        StencilOp StencilPass { get; set; }

        /// <summary>Stencil Fail</summary>
        //[DefaultValue(BlendOp.Add)]
        StencilOp StencilFail { get; set; }

        /// <summary>Stencil Z Fail</summary>
        //[DefaultValue(BlendOp.Add)]
        StencilOp StencilZFail { get; set; }
    }
}