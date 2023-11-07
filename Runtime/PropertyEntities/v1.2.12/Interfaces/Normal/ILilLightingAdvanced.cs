// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLightingAdvanced
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lighting Advanced Interface
    /// </summary>
    public interface ILilLightingAdvanced
    {
        /// <summary>As Unlit</summary>
        /// <remarks>Base</remarks>
        //[DefaultValue(false)]
        bool AsUnlit { get; set; }

        /// <summary>Vertex Light Strength</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        float VertexLightStrength { get; set; }

        /// <summary>Light Direction Override</summary>
        //[DefaultValue(0.0f, 0.001f, 0.0f, 0.0f)]
        Vector3 LightDirectionOverride { get; set; }

        /// <summary>Alpha Boost Forward Add</summary>
        /// <remarks>Built-in RP</remarks>
        //[Range(1f, 100f)]
        //[DefaultValue(10f)]
        float AlphaBoostFA { get; set; }

        /// <summary>Before Exposure Limit</summary>
        /// <remarks>HDRP</remarks>
        //[DefaultValue(10000f)]
        float BeforeExposureLimit { get; set; }

        /// <summary>Directional Light Strength</summary>
        /// <remarks>HDRP</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(1f)]
        float LilDirectionalLightStrength { get; set; }
    }
}