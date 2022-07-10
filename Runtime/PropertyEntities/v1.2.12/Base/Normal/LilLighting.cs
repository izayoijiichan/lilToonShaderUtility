// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLighting
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Lighting
    /// </summary>
    public class LilLighting : ILilLighting
    {
        /// <summary>Light Min Limit</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0.05f)]
        public float LightMinLimit { get; set; }

        /// <summary>Light Max Limit</summary>
        //[Range(0f, 10f)]
        //[DefaultValue(1f)]
        public float LightMaxLimit { get; set; }

        /// <summary>Monochrome Lighting</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        public float MonochromeLighting { get; set; }
    }
}