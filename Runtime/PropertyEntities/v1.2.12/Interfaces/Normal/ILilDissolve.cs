// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilDissolve
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Dissolve Interface
    /// </summary>
    public interface ILilDissolve
    {
        /// <summary>Dissolve Mask</summary>
        Texture2D DissolveMask { get; set; }

        /// <summary>Dissolve Noise Mask</summary>
        Texture2D DissolveNoiseMask { get; set; }

        /// <summary>Dissolve Noise Mask Scroll Rotate</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 DissolveNoiseMask_ScrollRotate { get; set; }

        /// <summary>Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        float DissolveNoiseStrength { get; set; }

        /// <summary>Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color DissolveColor { get; set; }

        /// <summary>Dissolve Params</summary>
        /// <remarks>Dissolve Mode|None|Alpha|UV|Position|Dissolve Shape|Point|Line|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        Vector4 DissolveParams { get; set; }

        /// <summary>Dissolve Position</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 DissolvePos { get; set; }
    }
}