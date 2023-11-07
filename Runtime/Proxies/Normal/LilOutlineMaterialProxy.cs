// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilOutlineMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Outline Material Proxy
    /// </summary>
    public class LilOutlineMaterialProxy : LilMaterialProxyBase
    {
        #region Properties
        
        /// <summary>Outline Color</summary>
        //[DefaultValue(0.8,0.85,0.9,1)]
        public Color OutlineColor
        {
            get => _Material.GetSafeColor(PropertyNameID.OutlineColor, new Color(0.8f, 0.85f, 0.9f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.OutlineColor, value);
        }

        /// <summary>Outline Texture</summary>
        public Texture2D? OutlineTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.OutlineTex);
            set => _Material.SetSafeTexture(PropertyNameID.OutlineTex, value);
        }

        /// <summary>Outline Texture Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 OutlineTex_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.OutlineTex_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.OutlineTex_ScrollRotate, value);
        }

        /// <summary>Outline Texture HSVG</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,1,1,1)]
        public Vector4 OutlineTexHSVG
        {
            get => _Material.GetSafeVector4(PropertyNameID.OutlineTexHSVG, new Vector4(0.0f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeVector(PropertyNameID.OutlineTexHSVG, value);
        }

        /// <summary>Outline Lit Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(1.0,0.2,0,0)]
        public Color OutlineLitColor
        {
            get => _Material.GetSafeColor(PropertyNameID.OutlineLitColor, new Color(1.0f, 0.2f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.OutlineLitColor, value);
        }

        /// <summary>Outline Lit Apply Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineLitApplyTex
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineLitApplyTex, false);
            set => _Material.SetSafeBool(PropertyNameID.OutlineLitApplyTex, value);
        }

        /// <summary>Outline Lit Scale</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(10)]
        public float OutlineLitScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineLitScale, 10.0f);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineLitScale, value);
        }

        /// <summary>Outline Lit Offset</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(-8)]
        public float OutlineLitOffset
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineLitOffset, -8.0f);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineLitOffset, value);
        }

        /// <summary>Outline Lit Receive Shadow</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineLitShadowReceive
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineLitShadowReceive, false);
            set => _Material.SetSafeBool(PropertyNameID.OutlineLitShadowReceive, value);
        }

        /// <summary>Outline Width</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.05f)]
        public float OutlineWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineWidth, PropertyRange.OutlineWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineWidth, PropertyRange.OutlineWidth, value);
        }

        /// <summary>Outline Width Mask</summary>
        public Texture2D? OutlineWidthMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.OutlineWidthMask);
            set => _Material.SetSafeTexture(PropertyNameID.OutlineWidthMask, value);
        }

        /// <summary>Outline Fix Width</summary>
        /// <remarks>v1.3.0 changed int to float</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float OutlineFixWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineFixWidth, PropertyRange.OutlineFixWidth.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineFixWidth, PropertyRange.OutlineFixWidth, value);
        }

        /// <summary>Outline Vertex R2 Width</summary>
        public LilVertexColorMode OutlineVertexR2Width
        {
            get => _Material.GetSafeEnum<LilVertexColorMode>(PropertyNameID.OutlineVertexR2Width, LilVertexColorMode.None);
            set => _Material.SetSafeInt(PropertyNameID.OutlineVertexR2Width, (int)value);
        }

        /// <summary>Outline Delete Mesh</summary>
        /// <remarks>v1.3.0 added</remarks>
        public bool OutlineDeleteMesh
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineDeleteMesh, false);
            set => _Material.SetSafeBool(PropertyNameID.OutlineDeleteMesh, value);
        }

        /// <summary>Outline Vector Texture</summary>
        public Texture2D? OutlineVectorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.OutlineVectorTex);
            set => _Material.SetSafeTexture(PropertyNameID.OutlineVectorTex, value);
        }

        /// <summary>Outline Vector UV Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilOutlineVectorUVMode.UV0)]
        public LilOutlineVectorUVMode OutlineVectorUVMode
        {
            get => _Material.GetSafeEnum<LilOutlineVectorUVMode>(PropertyNameID.OutlineVectorUVMode, LilOutlineVectorUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.OutlineVectorUVMode, (int)value);
        }

        /// <summary>Outline Vector Scale</summary>
        //[Range(-10, 10)]
        //[DefaultValue(1)]
        public float OutlineVectorScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineVectorScale, PropertyRange.OutlineVectorScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineVectorScale, PropertyRange.OutlineVectorScale, value);
        }

        /// <summary>Outline Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OutlineEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineEnableLighting, PropertyRange.OutlineEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineEnableLighting, PropertyRange.OutlineEnableLighting, value);
        }

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0)]
        public float OutlineZBias
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineZBias, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineZBias, value);
        }

        /// <summary>Outline Disable in VR</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool OutlineDisableInVR
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineDisableInVR, false);
            set => _Material.SetSafeBool(PropertyNameID.OutlineDisableInVR, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilOutlineMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilOutlineMaterialProxy(Material material) : base(material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.IsOutline() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}