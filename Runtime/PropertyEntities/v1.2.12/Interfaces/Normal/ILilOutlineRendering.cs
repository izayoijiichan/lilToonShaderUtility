// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilOutlineRendering
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Interface
    /// </summary>
    public interface ILilOutlineRendering
    {
        /// <summary>Outline Cull</summary>
        //[DefaultValue(CullMode.Front)]
        CullMode OutlineCull { get; set; }

        /// <summary>Outline Z Clip</summary>
        //[DefaultValue(true)]
        bool OutlineZClip { get; set; }

        /// <summary>Outline Z Write</summary>
        //[DefaultValue(true)]
        bool OutlineZWrite { get; set; }

        /// <summary>Outline Z Test</summary>
        //[DefaultValue(CompareFunction.Less)]
        CompareFunction OutlineZTest { get; set; }

        /// <summary>Outline Offset Factor</summary>
        //[DefaultValue(0.0f)]
        float OutlineOffsetFactor { get; set; }

        /// <summary>Outline Offset Units</summary>
        //[DefaultValue(0.0f)]
        float OutlineOffsetUnits { get; set; }

        /// <summary>Outline Color Mask</summary>
        //[DefaultValue(15)]
        int OutlineColorMask { get; set; }

        /// <summary>Outline Alpha To Mask</summary>
        //[DefaultValue(false)]
        bool OutlineAlphaToMask { get; set; }
    }
}