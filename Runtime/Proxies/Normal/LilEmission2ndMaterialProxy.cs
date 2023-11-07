// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEmission2ndMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Emission 2nd Material Proxy
    /// </summary>
    public class LilEmission2ndMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Emission 2nd</summary>
        //[DefaultValue(false)]
        public bool UseEmission2nd
        {
            get => _Material.GetSafeBool(PropertyNameID.UseEmission2nd, false);
            set => _Material.SetSafeBool(PropertyNameID.UseEmission2nd, value);
        }

        /// <summary>Emission 2nd Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Emission2ndColor
        {
            get => _Material.GetSafeColor(PropertyNameID.Emission2ndColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.Emission2ndColor, value);
        }

        /// <summary>Emission 2nd Map</summary>
        public Texture2D? Emission2ndMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.Emission2ndMap);
            set => _Material.SetSafeTexture(PropertyNameID.Emission2ndMap, value);
        }

        /// <summary>Emission 2nd Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Emission2ndMap_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Emission2ndMap_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.Emission2ndMap_ScrollRotate, value);
        }

        /// <summary>Emission 2nd Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilEmissionUVMode Emission2ndMap_UVMode
        {
            get => _Material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.Emission2ndMap_UVMode, LilEmissionUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.Emission2ndMap_UVMode, (int)value);
        }

        /// <summary>Emission 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Emission2ndMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Emission2ndMainStrength, PropertyRange.Emission2ndMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Emission2ndMainStrength, PropertyRange.Emission2ndMainStrength, value);
        }

        /// <summary>Emission 2nd Blend</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Emission2ndBlend
        {
            get => _Material.GetSafeFloat(PropertyNameID.Emission2ndBlend, PropertyRange.Emission2ndBlend.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Emission2ndBlend, PropertyRange.Emission2ndBlend, value);
        }

        /// <summary>Emission 2nd Blend Mask</summary>
        public Texture2D? Emission2ndBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Emission2ndBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.Emission2ndBlendMask, value);
        }

        /// <summary>Emission 2nd BlendMask Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Emission2ndBlendMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Emission2ndBlendMask_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.Emission2ndBlendMask_ScrollRotate, value);
        }

        /// <summary>Emission 2nd Blend Mode</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode Emission2ndBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.Emission2ndBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.Emission2ndBlendMode, (int)value);
        }

        /// <summary>Emission 2nd Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        public Vector4 Emission2ndBlink
        {
            get => _Material.GetSafeVector4(PropertyNameID.Emission2ndBlink,  new Vector4(0.0f, 0.0f, 3.141593f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.Emission2ndBlink, value);
        }

        /// <summary>Emission 2nd Use Gradation</summary>
        //[DefaultValue(false)]
        public bool Emission2ndUseGrad
        {
            get => _Material.GetSafeBool(PropertyNameID.Emission2ndUseGrad, false);
            set => _Material.SetSafeBool(PropertyNameID.Emission2ndUseGrad, value);
        }

        /// <summary>Emission 2nd Gradation Texture</summary>
        public Texture2D? Emission2ndGradTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Emission2ndGradTex);
            set => _Material.SetSafeTexture(PropertyNameID.Emission2ndGradTex, value);
        }

        /// <summary>Emission 2nd Gradation Speed</summary>
        //[DefaultValue(1.0f)]
        public float Emission2ndGradSpeed
        {
            get => _Material.GetSafeFloat(PropertyNameID.Emission2ndGradSpeed, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.Emission2ndGradSpeed, value);
        }

        /// <summary>Emission 2nd Parallax Depth</summary>
        //[DefaultValue(0.0f)]
        public float Emission2ndParallaxDepth
        {
            get => _Material.GetSafeFloat(PropertyNameID.Emission2ndParallaxDepth, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.Emission2ndParallaxDepth, value);
        }

        /// <summary>Emission 2nd Fluorescence</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Emission2ndFluorescence
        {
            get => _Material.GetSafeFloat(PropertyNameID.Emission2ndFluorescence, PropertyRange.Emission2ndFluorescence.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Emission2ndFluorescence, PropertyRange.Emission2ndFluorescence, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilEmission2ndMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilEmission2ndMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}