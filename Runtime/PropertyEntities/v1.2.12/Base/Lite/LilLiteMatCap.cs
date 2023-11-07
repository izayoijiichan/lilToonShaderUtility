// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLiteMatCap
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite MatCap
    /// </summary>
    public class LilLiteMatCap : ILilLiteMatCap
    {
        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        public bool UseMatCap { get; set; }

        /// <summary>Mat Cap Texture</summary>
        public Texture2D? MatCapTex { get; set; }

        /// <summary>Mat Cap Blend UV1</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MatCapBlendUV1 { get; set; }

        /// <summary>Mat Cap Z-axis Rotation Cancel</summary>
        //[DefaultValue(true)]
        public bool MatCapZRotCancel { get; set; }

        /// <summary>Mat Cap Perspective</summary>
        //[DefaultValue(true)]
        public bool MatCapPerspective { get; set; }

        /// <summary>Mat Cap VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapVRParallaxStrength { get; set; }

        /// <summary>Mat Cap Multiply</summary>
        //[DefaultValue(false)]
        public bool MatCapMul { get; set; }
    }
}