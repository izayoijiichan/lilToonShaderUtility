// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilReflection
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Reflection
    /// </summary>
    public class LilReflection : ILilReflection
    {
        /// <summary>Use Reflection</summary>
        //[DefaultValue(false)]
        public bool UseReflection { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Smoothness { get; set; }

        /// <summary>Smoothness Texture</summary>
        public Texture2D? SmoothnessTex { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D? MetallicGlossMap { get; set; }

        /// <summary>Reflectance</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.04f)]
        public float Reflectance { get; set; }

        /// <summary>Apply Specular</summary>
        //[DefaultValue(true)]
        public bool ApplySpecular { get; set; }

        /// <summary>Apply Specular in Forward Add</summary>
        //[DefaultValue(true)]
        public bool ApplySpecularFA { get; set; }

        /// <summary>Specular Toon</summary>
        //[DefaultValue(true)]
        public bool SpecularToon { get; set; }

        /// <summary>Specular Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SpecularNormalStrength { get; set; }

        /// <summary>Specular Border</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float SpecularBorder { get; set; }

        /// <summary>Specular Blur</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float SpecularBlur { get; set; }

        /// <summary>Apply Reflection</summary>
        //[DefaultValue(false)]
        public bool ApplyReflection { get; set; }

        /// <summary>Reflection Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ReflectionNormalStrength { get; set; }

        /// <summary>Reflection Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color ReflectionColor { get; set; }

        /// <summary>Reflection Color Texture</summary>
        public Texture2D? ReflectionColorTex { get; set; }

        /// <summary>Reflection Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool ReflectionApplyTransparency { get; set; }

        /// <summary>Reflection Cube Texture</summary>
        public Texture2D? ReflectionCubeTex { get; set; }

        /// <summary>Reflection Cube Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color ReflectionCubeColor { get; set; }

        /// <summary>Reflection Cube Override</summary>
        //[DefaultValue(false)]
        public bool ReflectionCubeOverride { get; set; }

        /// <summary>Reflection Cube Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float ReflectionCubeEnableLighting { get; set; }
    }
}