// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilAlphaMask
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Alpha Mask Interface
    /// </summary>
    public interface ILilAlphaMask
    {
        /// <summary>Alpha Mask Mode</summary>
        LilAlphaMaskMode AlphaMaskMode { get; set; }

        /// <summary>Alpha Mask</summary>
        Texture2D? AlphaMask { get; set; }

        /// <summary>Alpha Mask Scale</summary>
        //[DefaultValue(1.0f)]
        float AlphaMaskScale { get; set; }

        /// <summary>Alpha Mask Offset</summary>
        //[DefaultValue(0.0f)]
        float AlphaMaskValue { get; set; }
    }
}