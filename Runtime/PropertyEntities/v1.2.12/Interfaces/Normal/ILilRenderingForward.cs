// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRenderingForward
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Forward Interface
    /// </summary>
    public interface ILilRenderingForward
    {
        /// <summary>Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        BlendMode DstBlend { get; set; }

        /// <summary>Src Blend Alpha</summary>
        //[DefaultValue(BlendMode.One)]
        BlendMode SrcBlendAlpha { get; set; }

        /// <summary>Dst Blend Alpha</summary>
        //[DefaultValue(BlendMode.OneMinusSrcAlpha)]
        BlendMode DstBlendAlpha { get; set; }

        /// <summary>Blend Op</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp BlendOp { get; set; }

        /// <summary>Blend Op Alpha</summary>
        //[DefaultValue(BlendOp.Add)]
        BlendOp BlendOpAlpha { get; set; }
    }
}