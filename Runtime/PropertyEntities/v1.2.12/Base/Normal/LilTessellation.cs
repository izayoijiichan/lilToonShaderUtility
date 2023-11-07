// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilTessellation
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Tessellation
    /// </summary>
    public class LilTessellation : ILilTessellation
    {
        /// <summary>Tessellation Edge</summary>
        //[Range(0, 100)]
        //[DefaultValue(10)]
        public float TessEdge { get; set; }

        /// <summary>Tessellation Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float TessStrength { get; set; }

        /// <summary>Tessellation Shrink</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float TessShrink { get; set; }

        /// <summary>Tessellation Factor Max</summary>
        //[Range(1, 8)]
        //[DefaultValue(3)]
        public int TessFactorMax { get; set; }
    }
}