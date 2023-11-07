// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilRendering
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering
    /// </summary>
    public class LilRendering : ILilRendering
    {
        /// <summary>Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(-0.001f, 1.001f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        /// <summary>Subpass Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(0.5f)]
        public float SubpassCutoff { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull { get; set; }

        /// <summary>Z Clip</summary>
        //[DefaultValue(true)]
        public bool ZClip { get; set; }

        /// <summary>Z Write</summary>
        //[DefaultValue(true)]
        public bool ZWrite { get; set; }

        /// <summary>Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        public CompareFunction ZTest { get; set; }

        /// <summary>Offset Factor</summary>
        //[DefaultValue(0)]
        public float OffsetFactor { get; set; }

        /// <summary>Offset Units</summary>
        //[DefaultValue(0)]
        public float OffsetUnits { get; set; }

        /// <summary>Color Mask</summary>
        //[DefaultValue(15)]
        public int ColorMask { get; set; }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask { get; set; }

        /// <summary>Shadow Caster Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0.0f)]
        public float LilShadowCasterBias { get; set; }
    }
}