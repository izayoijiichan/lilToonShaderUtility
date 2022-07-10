// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilEmission2ndGradation
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Emission 2nd Gradation Interface
    /// </summary>
    public interface ILilEmission2ndGradation
    {
        /// <summary>E2gci</summary>
        //[DefaultValue(2)]
        int E2gci { get; set; }

        /// <summary>E2gai</summary>
        //[DefaultValue(2)]
        int E2gai { get; set; }

        /// <summary>E2gc0</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc0 { get; set; }

        /// <summary>E2gc1</summary>
        //[DefaultValue(1,1,1,1)]
        Color E2gc1 { get; set; }

        /// <summary>E2gc2</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc2 { get; set; }

        /// <summary>E2gc3</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc3 { get; set; }

        /// <summary>E2gc4</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc4 { get; set; }

        /// <summary>E2gc5</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc5 { get; set; }

        /// <summary>E2gc6</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc6 { get; set; }

        /// <summary>E2gc7</summary>
        //[DefaultValue(1,1,1,0)]
        Color E2gc7 { get; set; }

        /// <summary>E2ga0</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga0 { get; set; }

        /// <summary>E2ga1</summary>
        //[DefaultValue(1,0,0,1)]
        Color E2ga1 { get; set; }

        /// <summary>E2ga2</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga2 { get; set; }

        /// <summary>E2ga3</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga3 { get; set; }

        /// <summary>E2ga4</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga4 { get; set; }

        /// <summary>E2ga5</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga5 { get; set; }

        /// <summary>E2ga6</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga6 { get; set; }

        /// <summary>E2ga7</summary>
        //[DefaultValue(1,0,0,0)]
        Color E2ga7 { get; set; }
    }
}