// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEmissionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Emission Material Proxy
    /// </summary>
    public class LilEmissionMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Emission</summary>
        //[DefaultValue(false)]
        public bool UseEmission
        {
            get => _Material.GetSafeBool(PropertyNameID.UseEmission, false);
            set => _Material.SetSafeBool(PropertyNameID.UseEmission, value);
        }

        /// <summary>Emission Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(PropertyNameID.EmissionColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.EmissionColor, value);
        }

        /// <summary>Emission Map</summary>
        public Texture2D? EmissionMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionMap);
            set => _Material.SetSafeTexture(PropertyNameID.EmissionMap, value);
        }

        /// <summary>Emission Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 EmissionMap_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.EmissionMap_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.EmissionMap_ScrollRotate, value);
        }

        /// <summary>Emission Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilEmissionUVMode EmissionMap_UVMode
        {
            get => _Material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.EmissionMap_UVMode, LilEmissionUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMap_UVMode, (int)value);
        }

        /// <summary>Emission Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float EmissionMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionMainStrength, PropertyRange.EmissionMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionMainStrength, PropertyRange.EmissionMainStrength, value);
        }

        /// <summary>Emission Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float EmissionBlend
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionBlend, PropertyRange.EmissionBlend.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionBlend, PropertyRange.EmissionBlend, value);
        }

        /// <summary>Emission Blend Mask</summary>
        public Texture2D? EmissionBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.EmissionBlendMask, value);
        }

        /// <summary>Emission Blend Mask Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 EmissionBlendMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.EmissionBlendMask_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.EmissionBlendMask_ScrollRotate, value);
        }

        /// <summary>Emission Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode EmissionBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.EmissionBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.EmissionBlendMode, (int)value);
        }

        /// <summary>Emission Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        public Vector4 EmissionBlink
        {
            get => _Material.GetSafeVector4(PropertyNameID.EmissionBlink, new Vector4(0.0f, 0.0f, 3.141593f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.EmissionBlink, value);
        }

        /// <summary>Emission Use Gradation</summary>
        //[DefaultValue(false)]
        public bool EmissionUseGrad
        {
            get => _Material.GetSafeBool(PropertyNameID.EmissionUseGrad, false);
            set => _Material.SetSafeBool(PropertyNameID.EmissionUseGrad, value);
        }

        /// <summary>Emission Gradation Texture</summary>
        public Texture2D? EmissionGradTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionGradTex);
            set => _Material.SetSafeTexture(PropertyNameID.EmissionGradTex, value);
        }

        /// <summary>Emission Gradation Speed</summary>
        //[DefaultValue(1.0f)]
        public float EmissionGradSpeed
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionGradSpeed, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionGradSpeed, value);
        }

        /// <summary>Emission Parallax Depth</summary>
        //[DefaultValue(0.0f)]
        public float EmissionParallaxDepth
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionParallaxDepth, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionParallaxDepth, value);
        }

        /// <summary>Emission Fluorescence</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float EmissionFluorescence
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionFluorescence, PropertyRange.EmissionFluorescence.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionFluorescence, PropertyRange.EmissionFluorescence, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilEmissionMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilEmissionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}