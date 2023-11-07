// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFurMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Fur Material Proxy
    /// </summary>
    public class LilFurMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Fur Noise Mask</summary>
        public Texture2D? FurNoiseMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.FurNoiseMask);
            set => _Material.SetSafeTexture(PropertyNameID.FurNoiseMask, value);
        }

        /// <summary>Fur Mask</summary>
        public Texture2D? FurMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.FurMask);
            set => _Material.SetSafeTexture(PropertyNameID.FurMask, value);
        }

        /// <summary>Fur Length Mask</summary>
        public Texture2D? FurLengthMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.FurLengthMask);
            set => _Material.SetSafeTexture(PropertyNameID.FurLengthMask, value);
        }

        /// <summary>Fur Vector Texture</summary>
        public Texture2D? FurVectorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.FurVectorTex);
            set => _Material.SetSafeTexture(PropertyNameID.FurVectorTex, value);
        }

        /// <summary>Fur Vector Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float FurVectorScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurVectorScale, PropertyRange.FurVectorScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.FurVectorScale, PropertyRange.FurVectorScale, value);
        }

        /// <summary>Fur Vector</summary>
        /// <remarks>Fur Vector|Fur Length</remarks>
        //[DefaultValue(0.0,0.0,1.0,0.02)]
        public Vector4 FurVector
        {
            get => _Material.GetSafeVector4(PropertyNameID.FurVector, new Vector4(0.0f, 0.0f, 1.0f, 0.02f));
            set => _Material.SetSafeVector(PropertyNameID.FurVector, value);
        }

        /// <summary>Vertex Color to Fur Vector</summary>
        //[DefaultValue(false)]
        public bool VertexColor2FurVector
        {
            get => _Material.GetSafeBool(PropertyNameID.VertexColor2FurVector, false);
            set => _Material.SetSafeBool(PropertyNameID.VertexColor2FurVector, value);
        }

        /// <summary>Fur Gravity</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        public float FurGravity
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurGravity, PropertyRange.FurGravity.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.FurGravity, PropertyRange.FurGravity, value);
        }

        /// <summary>Fur Randomize</summary>
        //[DefaultValue(0.0f)]
        public float FurRandomize
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurRandomize, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.FurRandomize, value);
        }

        /// <summary>Fur Ambient Occlusion</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float FurAO
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurAO, PropertyRange.FurAO.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.FurAO, PropertyRange.FurAO, value);
        }

        /// <summary>Fur Mesh Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilFurMeshType.Shrink)]
        public LilFurMeshType FurMeshType
        {
            get => _Material.GetSafeEnum<LilFurMeshType>(PropertyNameID.FurMeshType, LilFurMeshType.Shrink);
            set => _Material.SetSafeInt(PropertyNameID.FurMeshType, (int)value);
        }

        /// <summary>Fur Layer Number</summary>
        //[Range(1, 6)]
        //[DefaultValue(2)]
        public int FurLayerNum
        {
            get => _Material.GetSafeInt(PropertyNameID.FurLayerNum, PropertyRange.FurLayerNum.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.FurLayerNum, PropertyRange.FurLayerNum, value);
        }

        /// <summary>Fur Root Offset</summary>
        //[Range(-1.0f, 0.0f)]
        //[DefaultValue(0.0f)]
        public float FurRootOffset
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurRootOffset, PropertyRange.FurRootOffset.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.FurRootOffset, PropertyRange.FurRootOffset, value);
        }

        /// <summary>Fur Cutout Length</summary>
        //[DefaultValue(0.8f)]
        public float FurCutoutLength
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurCutoutLength, 0.8f);
            set => _Material.SetSafeFloat(PropertyNameID.FurCutoutLength, value);
        }

        /// <summary>Fur Touch Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float FurTouchStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurTouchStrength, PropertyRange.FurTouchStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.FurTouchStrength, PropertyRange.FurTouchStrength, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFurMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        /// <remarks>RenderingMode is Fur or Gem</remarks>
        public LilFurMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsFur() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}