// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilMatCap
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Mat Cap Interface
    /// </summary>
    public interface ILilMatCap
    {
        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        bool UseMatCap { get; set; }

        /// <summary>Mat Cap Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color MatCapColor { get; set; }

        /// <summary>Mat Cap Texture</summary>
        Texture2D MatCapTex { get; set; }

        /// <summary>Mat Cap Blend UV1</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 MatCapBlendUV1 { get; set; }

        /// <summary>Mat Cap Z-axis Rotation Cancel</summary>
        //[DefaultValue(true)]
        bool MatCapZRotCancel { get; set; }

        /// <summary>Mat Cap Perspective</summary>
        //[DefaultValue(true)]
        bool MatCapPerspective { get; set; }

        /// <summary>Mat Cap VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCapVRParallaxStrength { get; set; }

        /// <summary>Mat Cap Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCapBlend { get; set; }

        /// <summary>Mat Cap Blend Mask</summary>
        Texture2D MatCapBlendMask { get; set; }

        /// <summary>Mat Cap Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCapEnableLighting { get; set; }

        /// <summary>Mat Cap Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float MatCapShadowMask { get; set; }

        /// <summary>Mat Cap Backface Mask</summary>
        //[DefaultValue(false)]
        bool MatCapBackfaceMask { get; set; }

        /// <summary>Mat Cap Lod</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        float MatCapLod { get; set; }

        /// <summary>Mat Cap Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Add)]
        LilBlendMode MatCapBlendMode { get; set; }

        /// <summary>Mat Cap Apply Transparency</summary>
        //[DefaultValue(true)]
        bool MatCapApplyTransparency { get; set; }

        /// <summary>Mat Cap Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float MatCapNormalStrength { get; set; }

        /// <summary>Mat Cap Custom Normal Map</summary>
        //[DefaultValue(false)]
        bool MatCapCustomNormal { get; set; }

        /// <summary>Mat Cap Bump Map</summary>
        Texture2D MatCapBumpMap { get; set; }

        /// <summary>Mat Cap Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float MatCapBumpScale { get; set; }
    }
}