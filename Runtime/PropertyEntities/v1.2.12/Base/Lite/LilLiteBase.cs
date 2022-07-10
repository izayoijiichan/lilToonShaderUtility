// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLiteBase
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Base
    /// </summary>
    public class LilLiteBase : LilBase, ILilLiteBase
    {
        /// <summary>Tri Mask</summary>
        /// <remarks>Mat/Rim/Emission</remarks>
        public Texture2D TriMask { get; set; }
    }
}