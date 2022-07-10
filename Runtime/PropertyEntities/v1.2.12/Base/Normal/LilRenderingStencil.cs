// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilRenderingStencil
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Stencil
    /// </summary>
    public class LilRenderingStencil : ILilRenderingStencil
    {
        /// <summary>Stencil Ref</summary>
        //[Range(0, 255)]
        //[DefaultValue(0)]
        public int StencilRef { get; set; }

        /// <summary>Stencil Read Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int StencilReadMask { get; set; }

        /// <summary>Stencil Write Mask</summary>
        //[Range(0, 255)]
        //[DefaultValue(255)]
        public int StencilWriteMask { get; set; }

        /// <summary>Stencil Comp</summary>
        //[DefaultValue(CompareFunction.Always)]
        public CompareFunction StencilComp { get; set; }

        /// <summary>Stencil Pass</summary>
        //[DefaultValue(BlendOp.Add)]
        public StencilOp StencilPass { get; set; }

        /// <summary>Stencil Fail</summary>
        //[DefaultValue(BlendOp.Add)]
        public StencilOp StencilFail { get; set; }

        /// <summary>Stencil Z Fail</summary>
        //[DefaultValue(BlendOp.Add)]
        public StencilOp StencilZFail { get; set; }
    }
}