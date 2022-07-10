// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilDistanceFade
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Distance Fade
    /// </summary>
    public class LilDistanceFade : ILilDistanceFade
    {
        /// <summary>Distance Fade</summary>
        /// <remarks>Start|End|Strength|Fix backface</remarks>
        //[DefaultValue(0.1,0.01,0,0)]
        public Vector4 DistanceFade { get; set; }

        /// <summary>Distance Fade Color</summary>
        //[DefaultValue(0,0,0,1)]
        public Color DistanceFadeColor { get; set; }
    }
}