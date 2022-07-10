// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilRenderingForward
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward
    /// </summary>
    public class LilRenderingForward : ILilRenderingForward
    {
        /// <summary>Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode DstBlend { get; set; }

        /// <summary>Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlendAlpha { get; set; }

        /// <summary>Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode DstBlendAlpha { get; set; }

        /// <summary>Blend Op</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOp { get; set; }

        /// <summary>Blend Op Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOpAlpha { get; set; }
    }
}