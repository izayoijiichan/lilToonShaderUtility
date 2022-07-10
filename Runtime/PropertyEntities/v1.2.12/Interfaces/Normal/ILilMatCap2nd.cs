// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilMatCap2nd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Mat Cap 2nd Interface
    /// </summary>
    public interface ILilMatCap2nd
    {
        /// <summary>Use Mat Cap 2nd</summary>
        //[DefaultValue(false)]
        bool UseMatCap2nd { get; set; }

        /// <summary>Mat Cap 2nd Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color MatCap2ndColor { get; set; }

        /// <summary>Mat Cap 2nd Texture</summary>
        Texture2D MatCap2ndTex { get; set; }

        /// <summary>Mat Cap 2nd Blend UV1</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 MatCap2ndBlendUV1 { get; set; }

        /// <summary>Mat Cap 2nd Z-axis rotation Cancel</summary>
        //[DefaultValue(true)]
        bool MatCap2ndZRotCancel { get; set; }

        /// <summary>Mat Cap 2nd Perspective</summary>
        //[DefaultValue(true)]
        bool MatCap2ndPerspective { get; set; }

        /// <summary>Mat Ca p2nd VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCap2ndVRParallaxStrength { get; set; }

        /// <summary>Mat Cap 2nd Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCap2ndBlend { get; set; }

        /// <summary>Mat Cap 2nd Blend Mask</summary>
        Texture2D MatCap2ndBlendMask { get; set; }

        /// <summary>Mat Cap 2nd Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCap2ndEnableLighting { get; set; }

        /// <summary>Mat Cap 2nd Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float MatCap2ndShadowMask { get; set; }

        /// <summary>Mat Cap 2nd Backface Mask</summary>
        //[DefaultValue(false)]
        bool MatCap2ndBackfaceMask { get; set; }

        /// <summary>Mat Cap 2nd Lod</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        float MatCap2ndLod { get; set; }

        /// <summary>Mat Cap 2nd Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Add)]
        LilBlendMode MatCap2ndBlendMode { get; set; }

        /// <summary>Mat Cap 2nd Apply Transparency</summary>
        //[DefaultValue(true)]
        bool MatCap2ndApplyTransparency { get; set; }

        /// <summary>Mat Cap 2nd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCap2ndNormalStrength { get; set; }

        /// <summary>Mat Cap 2nd Custom Normal Map</summary>
        //[DefaultValue(false)]
        bool MatCap2ndCustomNormal { get; set; }

        /// <summary>Mat Cap 2nd Bump Map</summary>
        Texture2D MatCap2ndBumpMap { get; set; }

        /// <summary>Mat Cap 2nd Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float MatCap2ndBumpScale { get; set; }
    }
}