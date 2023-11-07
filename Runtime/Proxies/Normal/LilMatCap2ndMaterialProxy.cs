// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMatCap2ndMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon MatCap 2nd Material Proxy
    /// </summary>
    public class LilMatCap2ndMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Mat Cap 2nd</summary>
        //[DefaultValue(false)]
        public bool UseMatCap2nd
        {
            get => _Material.GetSafeBool(PropertyNameID.UseMatCap2nd, false);
            set => _Material.SetSafeBool(PropertyNameID.UseMatCap2nd, value);
        }

        /// <summary>Mat Cap 2nd Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color MatCap2ndColor
        {
            get => _Material.GetSafeColor(PropertyNameID.MatCap2ndColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.MatCap2ndColor, value);
        }

        /// <summary>Mat Cap 2nd Texture</summary>
        public Texture2D? MatCap2ndTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCap2ndTex);
            set => _Material.SetSafeTexture(PropertyNameID.MatCap2ndTex, value);
        }

        /// <summary>Mat Cap 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCap2ndMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndMainStrength, PropertyRange.MatCap2ndMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndMainStrength, PropertyRange.MatCap2ndMainStrength, value);
        }

        /// <summary>Mat Cap 2nd Blend UV1</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MatCap2ndBlendUV1
        {
            get => _Material.GetSafeVector4(PropertyNameID.MatCap2ndBlendUV1, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.MatCap2ndBlendUV1, value);
        }

        /// <summary>Mat Cap 2nd Z-axis rotation Cancel</summary>
        //[DefaultValue(true)]
        public bool MatCap2ndZRotCancel
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCap2ndZRotCancel, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCap2ndZRotCancel, value);
        }

        /// <summary>Mat Cap 2nd Perspective</summary>
        //[DefaultValue(true)]
        public bool MatCap2ndPerspective
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCap2ndPerspective, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCap2ndPerspective, value);
        }

        /// <summary>Mat Cap 2nd VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCap2ndVRParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndVRParallaxStrength, PropertyRange.MatCap2ndVRParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndVRParallaxStrength, PropertyRange.MatCap2ndVRParallaxStrength, value);
        }

        /// <summary>Mat Cap 2nd Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCap2ndBlend
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndBlend, PropertyRange.MatCap2ndBlend.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndBlend, PropertyRange.MatCap2ndBlend, value);
        }

        /// <summary>Mat Cap 2nd Blend Mask</summary>
        public Texture2D? MatCap2ndBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCap2ndBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.MatCap2ndBlendMask, value);
        }

        /// <summary>Mat Cap 2nd Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCap2ndEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndEnableLighting, PropertyRange.MatCap2ndEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndEnableLighting, PropertyRange.MatCap2ndEnableLighting, value);
        }

        /// <summary>Mat Cap 2nd Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCap2ndShadowMask
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndShadowMask, PropertyRange.MatCap2ndShadowMask.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndShadowMask, PropertyRange.MatCap2ndShadowMask, value);
        }

        /// <summary>Mat Cap 2nd Backface Mask</summary>
        //[DefaultValue(false)]
        public bool MatCap2ndBackfaceMask
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCap2ndBackfaceMask, false);
            set => _Material.SetSafeBool(PropertyNameID.MatCap2ndBackfaceMask, value);
        }

        /// <summary>Mat Cap 2nd Lod</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float MatCap2ndLod
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndLod, PropertyRange.MatCap2ndLod.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndLod, PropertyRange.MatCap2ndLod, value);
        }

        /// <summary>Mat Cap 2nd Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode MatCap2ndBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.MatCap2ndBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.MatCap2ndBlendMode, (int)value);
        }

        /// <summary>Mat Cap 2nd Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool MatCap2ndApplyTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCap2ndApplyTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCap2ndApplyTransparency, value);
        }

        /// <summary>Mat Cap 2nd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCap2ndNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndNormalStrength, PropertyRange.MatCap2ndNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndNormalStrength, PropertyRange.MatCap2ndNormalStrength, value);
        }

        /// <summary>Mat Cap 2nd Custom Normal Map</summary>
        //[DefaultValue(false)]
        public bool MatCap2ndCustomNormal
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCap2ndCustomNormal, false);
            set => _Material.SetSafeBool(PropertyNameID.MatCap2ndCustomNormal, value);
        }

        /// <summary>Mat Cap 2nd Bump Map</summary>
        public Texture2D? MatCap2ndBumpMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCap2ndBumpMap);
            set => _Material.SetSafeTexture(PropertyNameID.MatCap2ndBumpMap, value);
        }

        /// <summary>Mat Cap 2nd Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float MatCap2ndBumpScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCap2ndBumpScale, PropertyRange.MatCap2ndBumpScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCap2ndBumpScale, PropertyRange.MatCap2ndBumpScale, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMatCap2ndMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMatCap2ndMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}