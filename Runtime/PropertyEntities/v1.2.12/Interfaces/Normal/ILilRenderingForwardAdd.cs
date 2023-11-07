// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRenderingForwardAdd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward Add Interface
    /// </summary>
    public interface ILilRenderingForwardAdd
    {
        /// <summary>Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode SrcBlendFA { get; set; }

        /// <summary>Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode DstBlendFA { get; set; }

        /// <summary>Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        BlendMode SrcBlendAlphaFA { get; set; }

        /// <summary>Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode DstBlendAlphaFA { get; set; }

        /// <summary>Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp BlendOpFA { get; set; }

        /// <summary>Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        BlendOp BlendOpAlphaFA { get; set; }
    }
}