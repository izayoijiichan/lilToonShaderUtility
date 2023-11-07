// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilReflectionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Reflection Material Proxy
    /// </summary>
    public class LilReflectionMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Reflection</summary>
        //[DefaultValue(false)]
        public bool UseReflection
        {
            get => _Material.GetSafeBool(PropertyNameID.UseReflection, false);
            set => _Material.SetSafeBool(PropertyNameID.UseReflection, value);
        }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Smoothness
        {
            get => _Material.GetSafeFloat(PropertyNameID.Smoothness, PropertyRange.Smoothness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Smoothness, PropertyRange.Smoothness, value);
        }

        /// <summary>Smoothness Texture</summary>
        public Texture2D? SmoothnessTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.SmoothnessTex);
            set => _Material.SetSafeTexture(PropertyNameID.SmoothnessTex, value);
        }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(PropertyNameID.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D? MetallicGlossMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.MetallicGlossMap);
            set => _Material.SetSafeTexture(PropertyNameID.MetallicGlossMap, value);
        }

        /// <summary>Reflectance</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.04f)]
        public float Reflectance
        {
            get => _Material.GetSafeFloat(PropertyNameID.Reflectance, PropertyRange.Reflectance.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Reflectance, PropertyRange.Reflectance, value);
        }

        /// <summary>Geometric Specular Anti-Aliasing (GSAA) Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GSAAStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.GSAAStrength, PropertyRange.GSAAStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GSAAStrength, PropertyRange.GSAAStrength, value);
        }

        /// <summary>Apply Specular</summary>
        //[DefaultValue(true)]
        public bool ApplySpecular
        {
            get => _Material.GetSafeBool(PropertyNameID.ApplySpecular, true);
            set => _Material.SetSafeBool(PropertyNameID.ApplySpecular, value);
        }

        /// <summary>Apply Specular in Forward Add</summary>
        //[DefaultValue(true)]
        public bool ApplySpecularFA
        {
            get => _Material.GetSafeBool(PropertyNameID.ApplySpecularFA, true);
            set => _Material.SetSafeBool(PropertyNameID.ApplySpecularFA, value);
        }

        /// <summary>Specular Toon</summary>
        //[DefaultValue(true)]
        public bool SpecularToon
        {
            get => _Material.GetSafeBool(PropertyNameID.SpecularToon, true);
            set => _Material.SetSafeBool(PropertyNameID.SpecularToon, value);
        }

        /// <summary>Specular Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SpecularNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.SpecularNormalStrength, PropertyRange.SpecularNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.SpecularNormalStrength, PropertyRange.SpecularNormalStrength, value);
        }

        /// <summary>Specular Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float SpecularBorder
        {
            get => _Material.GetSafeFloat(PropertyNameID.SpecularBorder, PropertyRange.SpecularBorder.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.SpecularBorder, PropertyRange.SpecularBorder, value);
        }

        /// <summary>Specular Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float SpecularBlur
        {
            get => _Material.GetSafeFloat(PropertyNameID.SpecularBlur, PropertyRange.SpecularBlur.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.SpecularBlur, PropertyRange.SpecularBlur, value);
        }

        /// <summary>Apply Reflection</summary>
        //[DefaultValue(false)]
        public bool ApplyReflection
        {
            get => _Material.GetSafeBool(PropertyNameID.ApplyReflection, false);
            set => _Material.SetSafeBool(PropertyNameID.ApplyReflection, value);
        }

        /// <summary>Reflection Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ReflectionNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ReflectionNormalStrength, PropertyRange.ReflectionNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ReflectionNormalStrength, PropertyRange.ReflectionNormalStrength, value);
        }

        /// <summary>Reflection Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color ReflectionColor
        {
            get => _Material.GetSafeColor(PropertyNameID.ReflectionColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.ReflectionColor, value);
        }

        /// <summary>Reflection Color Texture</summary>
        public Texture2D? ReflectionColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.ReflectionColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.ReflectionColorTex, value);
        }

        /// <summary>Reflection Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool ReflectionApplyTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.ReflectionApplyTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.ReflectionApplyTransparency, value);
        }

        /// <summary>Reflection Cube Texture</summary>
        public Texture2D? ReflectionCubeTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.ReflectionCubeTex);
            set => _Material.SetSafeTexture(PropertyNameID.ReflectionCubeTex, value);
        }

        /// <summary>Reflection Cube Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color ReflectionCubeColor
        {
            get => _Material.GetSafeColor(PropertyNameID.ReflectionCubeColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.ReflectionCubeColor, value);
        }

        /// <summary>Reflection Cube Override</summary>
        //[DefaultValue(false)]
        public bool ReflectionCubeOverride
        {
            get => _Material.GetSafeBool(PropertyNameID.ReflectionCubeOverride, false);
            set => _Material.SetSafeBool(PropertyNameID.ReflectionCubeOverride, value);
        }

        /// <summary>Reflection Cube Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ReflectionCubeEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.ReflectionCubeEnableLighting, PropertyRange.ReflectionCubeEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ReflectionCubeEnableLighting, PropertyRange.ReflectionCubeEnableLighting, value);
        }

        /// <summary>Reflection Blend Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(LilBlendMode.Add)]
        public LilBlendMode ReflectionBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.ReflectionBlendMode, LilBlendMode.Add);
            set => _Material.SetSafeInt(PropertyNameID.ReflectionBlendMode, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilReflectionMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilReflectionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}