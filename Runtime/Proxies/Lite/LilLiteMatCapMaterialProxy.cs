// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteMatCapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite MatCap Material Proxy
    /// </summary>
    public class LilLiteMatCapMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        public bool UseMatCap
        {
            get => _Material.GetSafeBool(PropertyNameID.UseMatCap, false);
            set => _Material.SetSafeBool(PropertyNameID.UseMatCap, value);
        }

        /// <summary>Mat Cap Texture</summary>
        public Texture2D? MatCapTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCapTex);
            set => _Material.SetSafeTexture(PropertyNameID.MatCapTex, value);
        }

        /// <summary>Mat Cap Blend UV1</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MatCapBlendUV1
        {
            get => _Material.GetSafeVector4(PropertyNameID.MatCapBlendUV1, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.MatCapBlendUV1, value);
        }

        /// <summary>Mat Cap Z-axis Rotation Cancel</summary>
        //[DefaultValue(true)]
        public bool MatCapZRotCancel
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapZRotCancel, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCapZRotCancel, value);
        }

        /// <summary>Mat Cap Perspective</summary>
        //[DefaultValue(true)]
        public bool MatCapPerspective
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapPerspective, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCapPerspective, value);
        }

        /// <summary>Mat Cap VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapVRParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapVRParallaxStrength, PropertyRange.MatCapVRParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapVRParallaxStrength, PropertyRange.MatCapVRParallaxStrength, value);
        }

        /// <summary>Mat Cap Multiply</summary>
        //[DefaultValue(false)]
        public bool MatCapMul
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapMul, false);
            set => _Material.SetSafeBool(PropertyNameID.MatCapMul, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteMatCapMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteMatCapMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsLite() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}