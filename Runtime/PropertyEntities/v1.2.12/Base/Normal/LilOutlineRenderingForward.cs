// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilOutlineRenderingForward
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Forward
    /// </summary>
    public class LilOutlineRenderingForward : ILilOutlineRenderingForward
    {
        /// <summary>Outline Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlend { get; set; }

        /// <summary>Outline Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode OutlineDstBlend { get; set; }

        /// <summary>Outline Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode OutlineSrcBlendAlpha { get; set; }

        /// <summary>Outline Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode OutlineDstBlendAlpha { get; set; }

        /// <summary>Outline Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp OutlineBlendOp { get; set; }

        /// <summary>Outline Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp OutlineBlendOpAlpha { get; set; }
    }
}