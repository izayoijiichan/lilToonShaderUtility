// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilMatCap
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon MatCap
    /// </summary>
    public class LilMatCap : ILilMatCap
    {
        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        public bool UseMatCap { get; set; }

        /// <summary>Mat Cap Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color MatCapColor { get; set; }

        /// <summary>Mat Cap Texture</summary>
        public Texture2D MatCapTex { get; set; }

        /// <summary>Mat Cap Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapMainStrength { get; set; }

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

        /// <summary>Mat Cap Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapBlend { get; set; }

        /// <summary>Mat Cap Blend Mask</summary>
        public Texture2D MatCapBlendMask { get; set; }

        /// <summary>Mat Cap Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapEnableLighting { get; set; }

        /// <summary>Mat Cap Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapShadowMask { get; set; }

        /// <summary>Mat Cap Backface Mask</summary>
        //[DefaultValue(false)]
        public bool MatCapBackfaceMask { get; set; }

        /// <summary>Mat Cap Lod</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapLod { get; set; }

        /// <summary>Mat Cap Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode MatCapBlendMode { get; set; }

        /// <summary>Mat Cap Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool MatCapApplyTransparency { get; set; }

        /// <summary>Mat Cap Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapNormalStrength { get; set; }

        /// <summary>Mat Cap Custom Normal Map</summary>
        //[DefaultValue(false)]
        public bool MatCapCustomNormal { get; set; }

        /// <summary>Mat Cap Bump Map</summary>
        public Texture2D MatCapBumpMap { get; set; }

        /// <summary>Mat Cap Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapBumpScale { get; set; }
    }
}