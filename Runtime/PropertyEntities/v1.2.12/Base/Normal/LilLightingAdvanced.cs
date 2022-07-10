// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLightingAdvanced
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lighting Advanced
    /// </summary>
    public class LilLightingAdvanced : ILilLightingAdvanced
    {
        /// <summary>As Unlit</summary>
        /// <remarks>Base</remarks>
        //[DefaultValue(false)]
        public bool AsUnlit { get; set; }

        /// <summary>Vertex Light Strength</summary>
        //[Range(0f, 1f)]
        //[DefaultValue(0f)]
        public float VertexLightStrength { get; set; }

        /// <summary>Light Direction Override</summary>
        //[DefaultValue(0.0f, 0.001f, 0.0f, 0.0f)]
        public Vector3 LightDirectionOverride { get; set; }

        /// <summary>Alpha Boost ForwardAdd</summary>
        /// <remarks>Built-in RP</remarks>
        //[Range(1f, 100f)]
        //[DefaultValue(10f)]
        public float AlphaBoostFA { get; set; }

        /// <summary>Before Exposure Limit</summary>
        /// <remarks>HDRP</remarks>
        //[DefaultValue(10000f)]
        public float BeforeExposureLimit { get; set; }

        /// <summary>Directional Light Strength</summary>
        /// <remarks>HDRP</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(1f)]
        public float LilDirectionalLightStrength { get; set; }
    }
}