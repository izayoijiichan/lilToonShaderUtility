// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFurRenderingForward
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward
    /// </summary>
    public class LilFurRenderingForward : ILilFurRenderingForward
    {
        /// <summary>Fur Src Blend</summary>
        //[DefaultValue(BlendMode.SrcAlpha)]
        public BlendMode FurSrcBlend { get; set; }

        /// <summary>Fur Dst Blend</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode FurDstBlend { get; set; }

        /// <summary>Fur Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurSrcBlendAlpha { get; set; }

        /// <summary>Fur Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        public BlendMode FurDstBlendAlpha { get; set; }

        /// <summary>Fur Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp FurBlendOp { get; set; }

        /// <summary>Fur Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp FurBlendOpAlpha { get; set; }
    }
}