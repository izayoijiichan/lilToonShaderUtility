// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilAnisotropy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Anisotropy
    /// </summary>
    public class LilAnisotropy : ILilAnisotropy
    {
        /// <summary>Use Anisotropy</summary>
        //[DefaultValue(false)]
        public bool UseAnisotropy { get; set; }

        /// <summary>Anisotropy Tangent Map</summary>
        public Texture2D? AnisotropyTangentMap { get; set; }

        /// <summary>Anisotropy Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyScale { get; set; }

        /// <summary>Anisotropy Scale Mask</summary>
        public Texture2D? AnisotropyScaleMask { get; set; }

        /// <summary>Anisotropy Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyTangentWidth { get; set; }

        /// <summary>Anisotropy Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropyBitangentWidth { get; set; }

        /// <summary>Anisotropy Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float AnisotropyShift { get; set; }

        /// <summary>Anisotropy Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float AnisotropyShiftNoiseScale { get; set; }

        /// <summary>Anisotropy Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float AnisotropySpecularStrength { get; set; }

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Anisotropy2ndTangentWidth { get; set; }

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Anisotropy2ndBitangentWidth { get; set; }

        /// <summary>Anisotropy 2nd Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndShift { get; set; }

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndShiftNoiseScale { get; set; }

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy2ndSpecularStrength { get; set; }

        /// <summary>Anisotropy Shift Noise Mask</summary>
        public Texture2D? AnisotropyShiftNoiseMask { get; set; }

        /// <summary>Anisotropy 2 Reflection</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2Reflection { get; set; }

        /// <summary>Anisotropy 2 Mat Cap</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2MatCap { get; set; }

        /// <summary>Anisotropy 2 Mat Cap 2nd</summary>
        //[DefaultValue(false)]
        public bool Anisotropy2MatCap2nd { get; set; }
    }
}