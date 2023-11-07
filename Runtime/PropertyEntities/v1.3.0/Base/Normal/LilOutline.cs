// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : LilOutline
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Outline
    /// </summary>
    public class LilOutline : ILilOutline
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

        /// <summary>Outline Texture HSVG</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,1,1,1)]
        public Vector4 OutlineTexHSVG { get; set; }

        /// <summary>Outline Lit Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(1.0,0.2,0,0)]
        public Color OutlineLitColor { get; set; }

        /// <summary>Outline Lit Apply Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineLitApplyTex { get; set; }

        /// <summary>Outline Lit Scale</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(10)]
        public float OutlineLitScale { get; set; }

        /// <summary>Outline Lit Offset</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(-8)]
        public float OutlineLitOffset { get; set; }

        /// <summary>Outline Lit Receive Shadow</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineLitShadowReceive { get; set; }

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

        /// <summary>Outline Vector Texture</summary>
        public Texture2D? OutlineVectorTex { get; set; }

        /// <summary>Outline Vector UV Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilOutlineVectorUVMode.UV0)]
        public LilOutlineVectorUVMode OutlineVectorUVMode { get; set; }

        /// <summary>Outline Vector Scale</summary>
        //[Range(-10, 10)]
        //[DefaultValue(1)]
        public float OutlineVectorScale { get; set; }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OutlineEnableLighting { get; set; }

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0)]
        public float OutlineZBias { get; set; }

        /// <summary>Outline Disable in VR</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineDisableInVR { get; set; }
    }
}