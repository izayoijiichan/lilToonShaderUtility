// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFur
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Fur
    /// </summary>
    public class LilFur : ILilFur
    {
        /// <summary>Fur Noise Mask</summary>
        public Texture2D? FurNoiseMask { get; set; }

        /// <summary>Fur Mask</summary>
        public Texture2D? FurMask { get; set; }

        /// <summary>Fur Length Mask</summary>
        public Texture2D? FurLengthMask { get; set; }

        /// <summary>Fur Vector Texture</summary>
        public Texture2D? FurVectorTex { get; set; }

        /// <summary>Fur Vector Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float FurVectorScale { get; set; }

        /// <summary>Fur Vector</summary>
        /// <remarks>Fur Vector|Fur Length</remarks>
        //[DefaultValue(0.0,0.0,1.0,0.2)]
        public Vector4 FurVector { get; set; }

        /// <summary>Vertex Color to Fur Vector</summary>
        //[DefaultValue(false)]
        public bool VertexColor2FurVector { get; set; }

        /// <summary>Fur Gravity</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        public float FurGravity { get; set; }

        /// <summary>Fur Randomize</summary>
        //[DefaultValue(0.0f)]
        public float FurRandomize { get; set; }

        /// <summary>Fur Ambient Occlusion</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float FurAO { get; set; }

        /// <summary>Fur Layer Number</summary>
        //[Range(1, 6)]
        //[DefaultValue(2)]
        public int FurLayerNum { get; set; }

        /// <summary>Fur Root Offset</summary>
        //[Range(-1.0f, 0.0f)]
        //[DefaultValue(0.0f)]
        public float FurRootOffset { get; set; }

        /// <summary>Fur Cutout Length</summary>
        //[DefaultValue(0.8f)]
        public float FurCutoutLength { get; set; }

        /// <summary>Fur Touch Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float FurTouchStrength { get; set; }
    }
}