// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilOutlineRenderingForwardAdd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward Add Interface
    /// </summary>
    public interface ILilOutlineRenderingForwardAdd
    {
        /// <summary>Outline Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode OutlineSrcBlendFA { get; set; }

        /// <summary>Outline Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode OutlineDstBlendFA { get; set; }

        /// <summary>Outline Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        BlendMode OutlineSrcBlendAlphaFA { get; set; }

        /// <summary>Outline Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode OutlineDstBlendAlphaFA { get; set; }

        /// <summary>Outline Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp OutlineBlendOpFA { get; set; }

        /// <summary>Outline Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp OutlineBlendOpAlphaFA { get; set; }
    }
}