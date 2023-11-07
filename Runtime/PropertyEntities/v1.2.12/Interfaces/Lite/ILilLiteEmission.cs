// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteEmission
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Emission Interface
    /// </summary>
    public interface ILilLiteEmission
    {
        /// <summary>Use Emission</summary>
        //[DefaultValue(false)]
        bool UseEmission { get; set; }

        /// <summary>Emission Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        Texture2D? EmissionMap { get; set; }

        /// <summary>Emission Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 EmissionMap_ScrollRotate { get; set; }

        /// <summary>Emission Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        LilEmissionUVMode EmissionMap_UVMode { get; set; }

        /// <summary>Emission Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        Vector4 EmissionBlink { get; set; }
    }
}