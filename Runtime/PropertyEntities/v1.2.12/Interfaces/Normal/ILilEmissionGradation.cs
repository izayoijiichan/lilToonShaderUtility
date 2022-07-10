// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilEmissionGradation
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Emission Gradation Interface
    /// </summary>
    public interface ILilEmissionGradation
    {
        /// <summary>Egci</summary>
        //[DefaultValue(2)]
        int Egci { get; set; }

        /// <summary>Egai</summary>
        //[DefaultValue(2)]
        int Egai { get; set; }

        /// <summary>Egc0</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc0 { get; set; }

        /// <summary>Egc1</summary>
        //[DefaultValue(1,1,1,1)]
        Color Egc1 { get; set; }

        /// <summary>Egc2</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc2 { get; set; }

        /// <summary>Egc3</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc3 { get; set; }

        /// <summary>Egc4</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc4 { get; set; }

        /// <summary>Egc5</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc5 { get; set; }

        /// <summary>Egc6</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc6 { get; set; }

        /// <summary>Egc7</summary>
        //[DefaultValue(1,1,1,0)]
        Color Egc7 { get; set; }

        /// <summary>Ega0</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega0 { get; set; }

        /// <summary>Ega1</summary>
        //[DefaultValue(1,0,0,1)]
        Color Ega1 { get; set; }

        /// <summary>Ega2</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega2 { get; set; }

        /// <summary>Ega3</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega3 { get; set; }

        /// <summary>Ega4</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega4 { get; set; }

        /// <summary>Ega5</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega5 { get; set; }

        /// <summary>Ega6</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega6 { get; set; }

        /// <summary>Ega7</summary>
        //[DefaultValue(1,0,0,0)]
        Color Ega7 { get; set; }
    }
}