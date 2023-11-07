// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilShadowMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Shadow Material Proxy
    /// </summary>
    public class LilShadowMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Shadow</summary>
        //[DefaultValue(false)]
        public bool UseShadow
        {
            get => _Material.GetSafeBool(PropertyNameID.UseShadow, false);
            set => _Material.SetSafeBool(PropertyNameID.UseShadow, value);
        }

        /// <summary>Shadow Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowStrength, PropertyRange.ShadowStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowStrength, PropertyRange.ShadowStrength, value);
        }

        /// <summary>Shadow Strength Mask</summary>
        public Texture2D? ShadowStrengthMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.ShadowStrengthMask);
            set => _Material.SetSafeTexture(PropertyNameID.ShadowStrengthMask, value);
        }

        /// <summary>Shadow Strength Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowStrengthMaskLOD
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowStrengthMaskLOD, PropertyRange.ShadowStrengthMaskLOD.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowStrengthMaskLOD, PropertyRange.ShadowStrengthMaskLOD, value);
        }

        /// <summary>Shadow Border Mask</summary>
        public Texture2D? ShadowBorderMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.ShadowBorderMask);
            set => _Material.SetSafeTexture(PropertyNameID.ShadowBorderMask, value);
        }

        /// <summary>Shadow Border Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBorderMaskLOD
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBorderMaskLOD, PropertyRange.ShadowBorderMaskLOD.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBorderMaskLOD, PropertyRange.ShadowBorderMaskLOD, value);
        }

        /// <summary>Shadow Blur Mask</summary>
        public Texture2D? ShadowBlurMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.ShadowBlurMask);
            set => _Material.SetSafeTexture(PropertyNameID.ShadowBlurMask, value);
        }

        /// <summary>Shadow Blur Mask Level of Detail (LOD)</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowBlurMaskLOD
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBlurMaskLOD, PropertyRange.ShadowBlurMaskLOD.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBlurMaskLOD, PropertyRange.ShadowBlurMaskLOD, value);
        }

        /// <summary>Shadow Ambient Occlusion Shift</summary>
        /// <remarks>1st Scale|1st Offset|2nd Scale|2nd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        public Vector4 ShadowAOShift
        {
            get => _Material.GetSafeVector4(PropertyNameID.ShadowAOShift, new Vector4(1.0f, 0.0f, 1.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.ShadowAOShift, value);
        }

        /// <summary>Shadow Ambient Occlusion Shift 2</summary>
        /// <remarks>3rd Scale|3rd Offset</remarks>
        //[DefaultValue(1,0,1,0)]
        public Vector4 ShadowAOShift2
        {
            get => _Material.GetSafeVector4(PropertyNameID.ShadowAOShift2, new Vector4(1.0f, 0.0f, 1.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.ShadowAOShift2, value);
        }

        /// <summary>Shadow Post Ambient Occlusion</summary>
        //[DefaultValue(false)]
        public bool ShadowPostAO
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowPostAO, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowPostAO, value);
        }

        /// <summary>Shadow Color Type</summary>
        /// <remarks>v1.3.5 added</remarks>
        //[DefaultValue(LilShadowColorType.Normal)]
        public LilShadowColorType ShadowColorType
        {
            get => _Material.GetSafeEnum<LilShadowColorType>(PropertyNameID.ShadowColorType, LilShadowColorType.Normal);
            set => _Material.SetSafeInt(PropertyNameID.ShadowColorType, (int)value);
        }

        /// <summary>Shadow Color</summary>
        //[DefaultValue(0.82,0.76,0.85,1.0)]
        public Color ShadowColor
        {
            get => _Material.GetSafeColor(PropertyNameID.ShadowColor, new Color(0.82f, 0.76f, 0.85f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.ShadowColor, value);
        }

        /// <summary>Shadow Color Texture</summary>
        public Texture2D? ShadowColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.ShadowColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.ShadowColorTex, value);
        }

        /// <summary>Shadow Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowNormalStrength, PropertyRange.ShadowNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowNormalStrength, PropertyRange.ShadowNormalStrength, value);
        }

        /// <summary>Shadow Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float ShadowBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBorder, PropertyRange.ShadowBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBorder, PropertyRange.ShadowBorder, value);
        }

        /// <summary>Shadow Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float ShadowBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBlur, PropertyRange.ShadowBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBlur, PropertyRange.ShadowBlur, value);
        }

        /// <summary>Receive Shadow</summary>
        //[DefaultValue(false)]
        public bool ShadowReceive
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowReceive, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowReceive, value);
        }

        /// <summary>Shadow 2nd Color</summary>
        //[DefaultValue(0.68,0.66,0.79,1)]
        public Color Shadow2ndColor
        {
            get => _Material.GetSafeColor(PropertyNameID.Shadow2ndColor, new Color(0.68f, 0.66f, 0.79f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.Shadow2ndColor, value);
        }

        /// <summary>Shadow 2nd Color Texture</summary>
        public Texture2D? Shadow2ndColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Shadow2ndColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.Shadow2ndColorTex, value);
        }

        /// <summary>Shadow 2nd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Shadow2ndNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow2ndNormalStrength, PropertyRange.Shadow2ndNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow2ndNormalStrength, PropertyRange.Shadow2ndNormalStrength, value);
        }

        /// <summary>Shadow 2nd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.15f)]
        public float Shadow2ndBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow2ndBorder, PropertyRange.Shadow2ndBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow2ndBorder, PropertyRange.Shadow2ndBorder, value);
        }

        /// <summary>Shadow 2nd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float Shadow2ndBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow2ndBlur, PropertyRange.Shadow2ndBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow2ndBlur, PropertyRange.Shadow2ndBlur, value);
        }

        /// <summary>Receive Shadow 2nd</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool Shadow2ndReceive
        {
            get => _Material.GetSafeBool(PropertyNameID.Shadow2ndReceive, false);
            set => _Material.SetSafeBool(PropertyNameID.Shadow2ndReceive, value);
        }

        /// <summary>Shadow 3rd Color</summary>
        //[DefaultValue(0,0,0,0)]
        public Color Shadow3rdColor
        {
            get => _Material.GetSafeColor(PropertyNameID.Shadow3rdColor, new Color(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Shadow3rdColor, value);
        }

        /// <summary>Shadow 3rd Color Texture</summary>
        public Texture2D? Shadow3rdColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Shadow3rdColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.Shadow3rdColorTex, value);
        }

        /// <summary>Shadow 3rd Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Shadow3rdNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow3rdNormalStrength, PropertyRange.Shadow3rdNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow3rdNormalStrength, PropertyRange.Shadow3rdNormalStrength, value);
        }

        /// <summary>Shadow 3rd Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.25f)]
        public float Shadow3rdBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow3rdBorder, PropertyRange.Shadow3rdBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow3rdBorder, PropertyRange.Shadow3rdBorder, value);
        }

        /// <summary>Shadow 3rd Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float Shadow3rdBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.Shadow3rdBlur, PropertyRange.Shadow3rdBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Shadow3rdBlur, PropertyRange.Shadow3rdBlur, value);
        }

        /// <summary>Receive Shadow 3rd</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool Shadow3rdReceive
        {
            get => _Material.GetSafeBool(PropertyNameID.Shadow3rdReceive, false);
            set => _Material.SetSafeBool(PropertyNameID.Shadow3rdReceive, value);
        }

        /// <summary>Shadow Border Color</summary>
        //[DefaultValue(1,0.1,0,1)]
        public Color ShadowBorderColor
        {
            get => _Material.GetSafeColor(PropertyNameID.ShadowBorderColor, new Color(1.0f, 0.1f, 0.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.ShadowBorderColor, value);
        }

        /// <summary>Shadow Border Range</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.08f)]
        public float ShadowBorderRange
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowBorderRange, PropertyRange.ShadowBorderRange.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowBorderRange, PropertyRange.ShadowBorderRange, value);
        }

        /// <summary>Shadow Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowMainStrength, PropertyRange.ShadowMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowMainStrength, PropertyRange.ShadowMainStrength, value);
        }

        /// <summary>Shadow Environment Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float ShadowEnvStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowEnvStrength, PropertyRange.ShadowEnvStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowEnvStrength, PropertyRange.ShadowEnvStrength, value);
        }

        /// <summary>Shadow Mask Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilShadowMaskType.Strength)]
        public LilShadowMaskType ShadowMaskType
        {
            get => _Material.GetSafeEnum<LilShadowMaskType>(PropertyNameID.ShadowMaskType, LilShadowMaskType.Strength);
            set => _Material.SetSafeInt(PropertyNameID.ShadowMaskType, (int)value);
        }

        /// <summary>Shadow Flat Border</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(-2.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowFlatBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowFlatBorder, PropertyRange.ShadowFlatBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowFlatBorder, PropertyRange.ShadowFlatBorder, value);
        }

        /// <summary>Shadow Flat Blur</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.001f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float ShadowFlatBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowFlatBlur, PropertyRange.ShadowFlatBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowFlatBlur, PropertyRange.ShadowFlatBlur, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilShadowMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilShadowMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}