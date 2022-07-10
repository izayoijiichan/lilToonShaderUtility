// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilOutline
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
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
        public Texture2D OutlineTex { get; set; }

        /// <summary>Outline Texture Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 OutlineTex_ScrollRotate { get; set; }

        /// <summary>Outline Texture HSVG</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,1,1,1)]
        public Vector4 OutlineTexHSVG { get; set; }

        /// <summary>Outline Width</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        public float OutlineWidth { get; set; }

        /// <summary>Outline Width Mask</summary>
        public Texture2D OutlineWidthMask { get; set; }

        /// <summary>Outline Fix Width</summary>
        //[DefaultValue(1)]
        public int OutlineFixWidth { get; set; }

        /// <summary>Outline Vertex R2 Width</summary>
        public LilVertexColorMode OutlineVertexR2Width { get; set; }

        /// <summary>Outline Vector Texture</summary>
        public Texture2D OutlineVectorTex { get; set; }

        /// <summary>Outline Vector Scale</summary>
        //[Range(-10, 10)]
        //[DefaultValue(1)]
        public float OutlineVectorScale { get; set; }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OutlineEnableLighting { get; set; }
    }
}