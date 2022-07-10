// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFurRenderingForwardAdd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward Add Interface
    /// </summary>
    public interface ILilFurRenderingForwardAdd
    {
        /// <summary>Fur Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode FurSrcBlendFA { get; set; }

        /// <summary>Fur Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode FurDstBlendFA { get; set; }

        /// <summary>Fur Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        BlendMode FurSrcBlendAlphaFA { get; set; }

        /// <summary>Fur Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode FurDstBlendAlphaFA { get; set; }

        /// <summary>Fur Blend Op Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp FurBlendOpFA { get; set; }

        /// <summary>Fur Blend Op Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp FurBlendOpAlphaFA { get; set; }
    }
}