// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilOutlineRenderingForwardAdd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward Add
    /// </summary>
    public class LilOutlineRenderingForwardAdd : ILilOutlineRenderingForwardAdd
    {
        /// <summary>Outline Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlendFA { get; set; }

        /// <summary>Outline Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineDstBlendFA { get; set; }

        /// <summary>Outline Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode OutlineSrcBlendAlphaFA { get; set; }

        /// <summary>Outline Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineDstBlendAlphaFA { get; set; }

        /// <summary>Outline Blend Op Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp OutlineBlendOpFA { get; set; }

        /// <summary>Outline Blend Op Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp OutlineBlendOpAlphaFA { get; set; }
    }
}