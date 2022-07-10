// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilTessellation
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Tessellation Interface
    /// </summary>
    public interface ILilTessellation
    {
        /// <summary>Tessellation Edge</summary>
        //[Range(0, 100)]
        //[DefaultValue(10)]
        float TessEdge { get; set; }

        /// <summary>Tessellation Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float TessStrength { get; set; }

        /// <summary>Tessellation Shrink</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float TessShrink { get; set; }

        /// <summary>Tessellation Factor Max</summary>
        //[Range(1, 8)]
        //[DefaultValue(3)]
        int TessFactorMax { get; set; }
    }
}