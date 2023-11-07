// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : ILilSave
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    using UnityEngine;

    /// <summary>
    /// lilToon Save Interface
    /// </summary>
    public interface ILilSave
    {
        /// <summary>Base Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color BaseColor { get; set; }

        /// <summary>Base Map</summary>
        Texture2D? BaseMap { get; set; }

        /// <summary>Base Color Map</summary>
        Texture2D? BaseColorMap { get; set; }

        /// <summary>lilToon Version</summary>
        //[DefaultValue(0)]
        int LilToonVersion { get; set; }
    }
}