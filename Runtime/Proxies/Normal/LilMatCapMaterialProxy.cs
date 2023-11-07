// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMatCapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon MatCap Material Proxy
    /// </summary>
    public class LilMatCapMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Mat Cap</summary>
        //[DefaultValue(false)]
        public bool UseMatCap
        {
            get => _Material.GetSafeBool(PropertyNameID.UseMatCap, false);
            set => _Material.SetSafeBool(PropertyNameID.UseMatCap, value);
        }

        /// <summary>Mat Cap Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color MatCapColor
        {
            get => _Material.GetSafeColor(PropertyNameID.MatCapColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.MatCapColor, value);
        }

        /// <summary>Mat Cap Texture</summary>
        public Texture2D? MatCapTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCapTex);
            set => _Material.SetSafeTexture(PropertyNameID.MatCapTex, value);
        }

        /// <summary>Mat Cap Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapMainStrength, PropertyRange.MatCapMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapMainStrength, PropertyRange.MatCapMainStrength, value);
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

        /// <summary>Mat Cap Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapBlend
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapBlend, PropertyRange.MatCapBlend.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapBlend, PropertyRange.MatCapBlend, value);
        }

        /// <summary>Mat Cap Blend Mask</summary>
        public Texture2D? MatCapBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCapBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.MatCapBlendMask, value);
        }

        /// <summary>Mat Cap Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapEnableLighting, PropertyRange.MatCapEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapEnableLighting, PropertyRange.MatCapEnableLighting, value);
        }

        /// <summary>Mat Cap Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapShadowMask
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapShadowMask, PropertyRange.MatCapShadowMask.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapShadowMask, PropertyRange.MatCapShadowMask, value);
        }

        /// <summary>Mat Cap Backface Mask</summary>
        //[DefaultValue(false)]
        public bool MatCapBackfaceMask
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapBackfaceMask, false);
            set => _Material.SetSafeBool(PropertyNameID.MatCapBackfaceMask, value);
        }

        /// <summary>Mat Cap Lod</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float MatCapLod
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapLod, PropertyRange.MatCapLod.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapLod, PropertyRange.MatCapLod, value);
        }

        /// <summary>Mat Cap Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode MatCapBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.MatCapBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.MatCapBlendMode, (int)value);
        }

        /// <summary>Mat Cap Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool MatCapApplyTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapApplyTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.MatCapApplyTransparency, value);
        }

        /// <summary>Mat Cap Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapNormalStrength, PropertyRange.MatCapNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapNormalStrength, PropertyRange.MatCapNormalStrength, value);
        }

        /// <summary>Mat Cap Custom Normal Map</summary>
        //[DefaultValue(false)]
        public bool MatCapCustomNormal
        {
            get => _Material.GetSafeBool(PropertyNameID.MatCapCustomNormal, false);
            set => _Material.SetSafeBool(PropertyNameID.MatCapCustomNormal, value);
        }

        /// <summary>Mat Cap Bump Map</summary>
        public Texture2D? MatCapBumpMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.MatCapBumpMap);
            set => _Material.SetSafeTexture(PropertyNameID.MatCapBumpMap, value);
        }

        /// <summary>Mat Cap Bump Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float MatCapBumpScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.MatCapBumpScale, PropertyRange.MatCapBumpScale.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MatCapBumpScale, PropertyRange.MatCapBumpScale, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMatCapMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMatCapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}