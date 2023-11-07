// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFurRenderingForward
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Forward Interface
    /// </summary>
    public interface ILilFurRenderingForward
    {
        /// <summary>Fur Src Blend</summary>
        //[DefaultValue(BlendMode.SrcAlpha)]
        BlendMode FurSrcBlend { get; set; }

        /// <summary>Fur Dst Blend</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        BlendMode FurDstBlend { get; set; }

        /// <summary>Fur Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode FurSrcBlendAlpha { get; set; }

        /// <summary>Fur Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        BlendMode FurDstBlendAlpha { get; set; }

        /// <summary>Fur Blend Operation</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp FurBlendOp { get; set; }

        /// <summary>Fur Blend Operation Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp FurBlendOpAlpha { get; set; }
    }
}