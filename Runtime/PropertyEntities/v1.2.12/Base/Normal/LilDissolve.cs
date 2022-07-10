// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilDissolve
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Dissolve
    /// </summary>
    public class LilDissolve : ILilDissolve
    {
        /// <summary>Dissolve Mask</summary>
        public Texture2D DissolveMask { get; set; }

        /// <summary>Dissolve Noise Mask</summary>
        public Texture2D DissolveNoiseMask { get; set; }

        /// <summary>Dissolve Noise Mask Scroll Rotate</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 DissolveNoiseMask_ScrollRotate { get; set; }

        /// <summary>Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        public float DissolveNoiseStrength { get; set; }

        /// <summary>Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color DissolveColor { get; set; }

        /// <summary>Dissolve Params</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        public Vector4 DissolveParams { get; set; }

        /// <summary>Dissolve Position</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 DissolvePos { get; set; }
    }
}