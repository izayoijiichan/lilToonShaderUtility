// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilReflection
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Reflection Interface
    /// </summary>
    public interface ILilReflection
    {
        /// <summary>Use Reflection</summary>
        //[DefaultValue(false)]
        bool UseReflection { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float Smoothness { get; set; }

        /// <summary>Smoothness Texture</summary>
        Texture2D SmoothnessTex { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float Metallic { get; set; }

        /// <summary>Metallic Gloss Map</summary>
        Texture2D MetallicGlossMap { get; set; }

        /// <summary>Reflectance</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.04f)]
        float Reflectance { get; set; }

        /// <summary>Apply Specular</summary>
        //[DefaultValue(true)]
        bool ApplySpecular { get; set; }

        /// <summary>Apply Specular in Forward Add</summary>
        //[DefaultValue(true)]
        bool ApplySpecularFA { get; set; }

        /// <summary>Specular Toon</summary>
        //[DefaultValue(true)]
        bool SpecularToon { get; set; }

        /// <summary>Specular Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float SpecularNormalStrength { get; set; }

        /// <summary>Specular Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        float SpecularBorder { get; set; }

        /// <summary>Specular Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float SpecularBlur { get; set; }

        /// <summary>Apply Reflection</summary>
        //[DefaultValue(false)]
        bool ApplyReflection { get; set; }

        /// <summary>Reflection Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float ReflectionNormalStrength { get; set; }

        /// <summary>Reflection Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color ReflectionColor { get; set; }

        /// <summary>Reflection Color Texture</summary>
        Texture2D ReflectionColorTex { get; set; }

        /// <summary>Reflection Apply Transparency</summary>
        //[DefaultValue(true)]
        bool ReflectionApplyTransparency { get; set; }

        /// <summary>Reflection Cube Texture</summary>
        Texture2D ReflectionCubeTex { get; set; }

        /// <summary>Reflection Cube Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color ReflectionCubeColor { get; set; }

        /// <summary>Reflection Cube Override</summary>
        //[DefaultValue(false)]
        bool ReflectionCubeOverride { get; set; }

        /// <summary>Reflection Cube Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float ReflectionCubeEnableLighting { get; set; }
    }
}