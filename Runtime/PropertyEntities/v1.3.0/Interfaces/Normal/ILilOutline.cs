// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_3_0
// @Class     : ILilOutline
// ----------------------------------------------------------------------
namespace LilToonShader.v1_3_0
{
    using UnityEngine;

    /// <summary>
    /// lilToon Outline Interface
    /// </summary>
    public interface ILilOutline
    {
        /// <summary>Outline Color</summary>
        //[DefaultValue(0.8,0.85,0.9,1)]
        Color OutlineColor { get; set; }

        /// <summary>Outline Texture</summary>
        Texture2D OutlineTex { get; set; }

        /// <summary>Outline Texture Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 OutlineTex_ScrollRotate { get; set; }

        /// <summary>Outline Texture HSVG</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,1,1,1)]
        Vector4 OutlineTexHSVG { get; set; }

        /// <summary>Outline Lit Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(1.0,0.2,0,0)]
        Color OutlineLitColor { get; set; }

        /// <summary>Outline Lit Apply Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        bool OutlineLitApplyTex { get; set; }

        /// <summary>Outline Lit Scale</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(10)]
        float OutlineLitScale { get; set; }

        /// <summary>Outline Lit Offset</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(-8)]
        float OutlineLitOffset { get; set; }

        /// <summary>Outline Width</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        float OutlineWidth { get; set; }

        /// <summary>Outline Width Mask</summary>
        Texture2D OutlineWidthMask { get; set; }

        /// <summary>Outline Fix Width</summary>
        /// <remarks>v1.3.0 changed int to float</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float OutlineFixWidth { get; set; }

        /// <summary>Outline Vertex R2 Width</summary>
        LilVertexColorMode OutlineVertexR2Width { get; set; }

        /// <summary>Outline Delete Mesh</summary>
        /// <remarks>v1.3.0 added</remarks>
        bool OutlineDeleteMesh { get; set; }

        /// <summary>Outline Vector Texture</summary>
        Texture2D OutlineVectorTex { get; set; }

        /// <summary>Outline Vector UV Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilOutlineVectorUVMode.UV0)]
        LilOutlineVectorUVMode OutlineVectorUVMode { get; set; }

        /// <summary>Outline Vector Scale</summary>
        //[Range(-10, 10)]
        //[DefaultValue(1)]
        float OutlineVectorScale { get; set; }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float OutlineEnableLighting { get; set; }

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0)]
        float OutlineZBias { get; set; }

        /// <summary>Outline Disable in VR</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        bool OutlineDisableInVR { get; set; }
    }
}