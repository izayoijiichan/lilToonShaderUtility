// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilDistanceFade
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Distance Fade Interface
    /// </summary>
    public interface ILilDistanceFade
    {
        /// <summary>Distance Fade</summary>
        /// <remarks>Start|End|Strength|Fix backface</remarks>
        //[DefaultValue(0.1,0.01,0,0)]
        Vector4 DistanceFade { get; set; }

        /// <summary>Distance Fade Color</summary>
        //[DefaultValue(0,0,0,1)]
        Color DistanceFadeColor { get; set; }
    }
}