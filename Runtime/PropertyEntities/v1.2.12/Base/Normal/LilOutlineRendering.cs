// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilOutlineRendering
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering
    /// </summary>
    public class LilOutlineRendering : ILilOutlineRendering
    {
        /// <summary>Outline Cull</summary>
        //[DefaultValue(CullMode.Front)]
        public CullMode OutlineCull { get; set; }

        /// <summary>Outline Z Clip</summary>
        //[DefaultValue(true)]
        public bool OutlineZClip { get; set; }

        /// <summary>Outline Z Write</summary>
        //[DefaultValue(true)]
        public bool OutlineZWrite { get; set; }

        /// <summary>Outline Z Test</summary>
        //[DefaultValue(CompareFunction.Less)]
        public CompareFunction OutlineZTest { get; set; }

        /// <summary>Outline Offset Factor</summary>
        //[DefaultValue(0.0f)]
        public float OutlineOffsetFactor { get; set; }

        /// <summary>Outline Offset Units</summary>
        //[DefaultValue(0.0f)]
        public float OutlineOffsetUnits { get; set; }

        /// <summary>Outline Color Mask</summary>
        //[DefaultValue(15)]
        public int OutlineColorMask { get; set; }

        /// <summary>Outline Alpha To Mask</summary>
        //[DefaultValue(false)]
        public bool OutlineAlphaToMask { get; set; }
    }
}