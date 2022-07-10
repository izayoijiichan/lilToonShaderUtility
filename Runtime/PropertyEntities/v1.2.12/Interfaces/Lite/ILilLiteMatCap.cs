// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteMatCap
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Mat Cap Interface
    /// </summary>
    public interface ILilLiteMatCap
    {
        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        bool UseMatCap { get; set; }

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

        /// <summary>Mat Cap Multiply</summary>
        //[DefaultValue(false)]
        bool MatCapMul { get; set; }
    }
}