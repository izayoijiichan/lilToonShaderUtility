// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilSave
// ----------------------------------------------------------------------
namespace LilToonShader
{
    using UnityEngine;

    /// <summary>
    /// lilToon Save
    /// </summary>
    public class LilSave : ILilSave
    {
        /// <summary>Base Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color BaseColor { get; set; }

        /// <summary>Base Map</summary>
        public Texture2D BaseMap { get; set; }

        /// <summary>Base Color Map</summary>
        public Texture2D BaseColorMap { get; set; }

        /// <summary>lilToon Version</summary>
        //[DefaultValue(0)]
        public int LilToonVersion { get; set; }
    }
}