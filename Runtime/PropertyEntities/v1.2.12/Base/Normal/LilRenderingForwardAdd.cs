// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilRenderingForwardAdd
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward Add
    /// </summary>
    public class LilRenderingForwardAdd : ILilRenderingForwardAdd
    {
        /// <summary>Src Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode SrcBlendFA { get; set; }

        /// <summary>Dst Blend Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode DstBlendFA { get; set; }

        /// <summary>Src Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.Zero)]
        public BlendMode SrcBlendAlphaFA { get; set; }

        /// <summary>Dst Blend Alpha Forward Add</summary>
        //[DefaultValue(BlendMode.One)]
        public BlendMode DstBlendAlphaFA { get; set; }

        /// <summary>Blend Operation Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp BlendOpFA { get; set; }

        /// <summary>Blend Operation Alpha Forward Add</summary>
        //[DefaultValue(BlendOp.Max)]
        public BlendOp BlendOpAlphaFA { get; set; }
    }
}