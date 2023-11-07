// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilAlphaMask
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Alpha Mask
    /// </summary>
    public class LilAlphaMask : ILilAlphaMask
    {
        /// <summary>Alpha Mask Mode</summary>
        //[DefaultValue(LilAlphaMaskMode.None)]
        public LilAlphaMaskMode AlphaMaskMode { get; set; }

        /// <summary>Alpha Mask</summary>
        public Texture2D? AlphaMask { get; set; }

        /// <summary>Alpha Mask Scale</summary>
        //[DefaultValue(1.0f)]
        public float AlphaMaskScale { get; set; }

        /// <summary>Alpha Mask Offset</summary>
        //[DefaultValue(0.0f)]
        public float AlphaMaskValue { get; set; }
    }
}