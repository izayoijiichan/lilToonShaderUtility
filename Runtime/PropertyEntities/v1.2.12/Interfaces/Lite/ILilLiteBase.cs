// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Base Interface
    /// </summary>
    public interface ILilLiteBase : ILilBase
    {
        /// <summary>Tri Mask</summary>
        /// <remarks>Mat/Rim/Emission</remarks>
        Texture2D? TriMask { get; set; }
    }
}