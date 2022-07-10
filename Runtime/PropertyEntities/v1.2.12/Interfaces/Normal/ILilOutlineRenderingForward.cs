// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilOutlineRenderingForward
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward Interface
    /// </summary>
    public interface ILilOutlineRenderingForward
    {
        /// <summary>Outline SrcBlend</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode OutlineSrcBlend { get; set; }

        /// <summary>Outline Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        BlendMode OutlineDstBlend { get; set; }

        /// <summary>Outline Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode OutlineSrcBlendAlpha { get; set; }

        /// <summary>Outline Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        BlendMode OutlineDstBlendAlpha { get; set; }

        /// <summary>Outline Blend Op</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp OutlineBlendOp { get; set; }

        /// <summary>Outline Blend Op Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp OutlineBlendOpAlpha { get; set; }
    }
}