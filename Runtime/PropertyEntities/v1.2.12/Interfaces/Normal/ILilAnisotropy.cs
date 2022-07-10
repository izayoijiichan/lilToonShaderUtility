// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilAnisotropy
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Anisotropy Interface
    /// </summary>
    public interface ILilAnisotropy
    {
        /// <summary>Use Anisotropy</summary>
        //[DefaultValue(false)]
        bool UseAnisotropy { get; set; }

        /// <summary>Anisotropy Tangent Map</summary>
        Texture2D AnisotropyTangentMap { get; set; }

        /// <summary>Anisotropy Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float AnisotropyScale { get; set; }

        /// <summary>Anisotropy Scale Mask</summary>
        Texture2D AnisotropyScaleMask { get; set; }

        /// <summary>Anisotropy Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float AnisotropyTangentWidth { get; set; }

        /// <summary>Anisotropy Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float AnisotropyBitangentWidth { get; set; }

        /// <summary>Anisotropy Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        float AnisotropyShift { get; set; }

        /// <summary>Anisotropy Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float AnisotropyShiftNoiseScale { get; set; }

        /// <summary>Anisotropy Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float AnisotropySpecularStrength { get; set; }

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float Anisotropy2ndTangentWidth { get; set; }

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        float Anisotropy2ndBitangentWidth { get; set; }

        /// <summary>Anisotropy 2nd Shift</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        float Anisotropy2ndShift { get; set; }

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float Anisotropy2ndShiftNoiseScale { get; set; }

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        //[Range(0.0f, 10.0f)]
        //[DefaultValue(0.0f)]
        float Anisotropy2ndSpecularStrength { get; set; }

        /// <summary>Anisotropy Shift Noise Mask</summary>
        Texture2D AnisotropyShiftNoiseMask { get; set; }

        /// <summary>Anisotropy 2 Reflection</summary>
        //[DefaultValue(false)]
        bool Anisotropy2Reflection { get; set; }

        /// <summary>Anisotropy 2 Mat Cap</summary>
        //[DefaultValue(false)]
        bool Anisotropy2MatCap { get; set; }

        /// <summary>Anisotropy 2 Mat Cap 2nd</summary>
        //[DefaultValue(false)]
        bool Anisotropy2MatCap2nd { get; set; }
    }
}