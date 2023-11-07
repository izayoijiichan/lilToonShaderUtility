// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilLiteOutline
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Outline
    /// </summary>
    public class LilLiteOutline : ILilLiteOutline
    {
        /// <summary>Outline Color</summary>
        //[DefaultValue(0.8,0.85,0.9,1)]
        public Color OutlineColor { get; set; }

        /// <summary>Outline Texture</summary>
        public Texture2D? OutlineTex { get; set; }

        /// <summary>Outline Texture Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 OutlineTex_ScrollRotate { get; set; }

        /// <summary>Outline Width</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        public float OutlineWidth { get; set; }

        /// <summary>Outline Width Mask</summary>
        public Texture2D? OutlineWidthMask { get; set; }

        /// <summary>Outline Fix Width</summary>
        /// <remarks>v1.3.0 changed int to float</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float OutlineFixWidth { get; set; }

        /// <summary>Outline Vertex R2 Width</summary>
        public LilVertexColorMode OutlineVertexR2Width { get; set; }

        /// <summary>Outline Delete Mesh</summary>
        /// <remarks>v1.3.0 added</remarks>
        public bool OutlineDeleteMesh { get; set; }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OutlineEnableLighting { get; set; }

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0)]
        public float OutlineZBias { get; set; }
    }
}