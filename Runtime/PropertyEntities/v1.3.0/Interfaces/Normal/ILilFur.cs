// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilFur
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Fur Interface
    /// </summary>
    public interface ILilFur
    {
        /// <summary>Fur Noise Mask</summary>
        Texture2D? FurNoiseMask { get; set; }

        /// <summary>Fur Mask</summary>
        Texture2D? FurMask { get; set; }

        /// <summary>Fur Length Mask</summary>
        Texture2D? FurLengthMask { get; set; }

        /// <summary>Fur Vector Texture</summary>
        Texture2D? FurVectorTex { get; set; }

        /// <summary>Fur Vector Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float FurVectorScale { get; set; }

        /// <summary>Fur Vector</summary>
        /// <remarks>Fur Vector|Fur Length</remarks>
        //[DefaultValue(0.0,0.0,1.0,0.02)]
        Vector4 FurVector { get; set; }

        /// <summary>Vertex Color to Fur Vector</summary>
        //[DefaultValue(false)]
        bool VertexColor2FurVector { get; set; }

        /// <summary>Fur Gravity</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        float FurGravity { get; set; }

        /// <summary>Fur Randomize</summary>
        //[DefaultValue(0.0f)]
        float FurRandomize { get; set; }

        /// <summary>Fur Ambient Occlusion</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float FurAO { get; set; }

        /// <summary>Fur Mesh Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilFurMeshType.Shrink)]
        LilFurMeshType FurMeshType { get; set; }

        /// <summary>Fur Layer Number</summary>
        //[Range(1, 6)]
        //[DefaultValue(2)]
        int FurLayerNum { get; set; }

        /// <summary>Fur Root Offset</summary>
        //[Range(-1.0f, 0.0f)]
        //[DefaultValue(0.0f)]
        float FurRootOffset { get; set; }

        /// <summary>Fur Cutout Length</summary>
        //[DefaultValue(0.8f)]
        float FurCutoutLength { get; set; }

        /// <summary>Fur Touch Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float FurTouchStrength { get; set; }
    }
}