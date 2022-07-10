// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilRendering
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Interface
    /// </summary>
    public interface ILilRendering
    {
        /// <summary>Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(-0.001f, 1.001f)]
        //[DefaultValue(0.5f)]
        float Cutoff { get; set; }

        /// <summary>Subpass Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(0.5f)]
        float SubpassCutoff { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        CullMode Cull { get; set; }

        /// <summary>Z Clip</summary>
        //[DefaultValue(true)]
        bool ZClip { get; set; }

        /// <summary>Z Write</summary>
        //[DefaultValue(true)]
        bool ZWrite { get; set; }

        /// <summary>Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        CompareFunction ZTest { get; set; }

        /// <summary>Offset Factor</summary>
        //[DefaultValue(0)]
        float OffsetFactor { get; set; }

        /// <summary>Offset Units</summary>
        //[DefaultValue(0)]
        float OffsetUnits { get; set; }

        /// <summary>Color Mask</summary>
        //[DefaultValue(15)]
        int ColorMask { get; set; }

        /// <summary>Alpha To Mask</summary>
        //[DefaultValue(false)]
        bool AlphaToMask { get; set; }
    }
}