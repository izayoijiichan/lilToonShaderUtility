// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFurRenderingForwardAdd
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward Add
    /// </summary>
    public class LilFurRenderingForwardAdd : ILilFurRenderingForwardAdd
    {
        /// <summary>Fur Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurSrcBlendFA { get; set; }

        /// <summary>Fur Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurDstBlendFA { get; set; }

        /// <summary>Fur Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode FurSrcBlendAlphaFA { get; set; }

        /// <summary>Fur Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode FurDstBlendAlphaFA { get; set; }

        /// <summary>Fur Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp FurBlendOpFA { get; set; }

        /// <summary>Fur Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp FurBlendOpAlphaFA { get; set; }
    }
}