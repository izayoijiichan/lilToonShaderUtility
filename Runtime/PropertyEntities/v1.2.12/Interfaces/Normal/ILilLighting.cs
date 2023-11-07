// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLighting
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Lighting Interface
    /// </summary>
    public interface ILilLighting
    {
        /// <summary>Light Min Limit</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0.05f)]
        float LightMinLimit { get; set; }

        /// <summary>Light Max Limit</summary>
        //[Range(0f, 10f)]
        //[DefaultValue(1f)]
        float LightMaxLimit { get; set; }

        /// <summary>Monochrome Lighting</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        float MonochromeLighting { get; set; }
    }
}