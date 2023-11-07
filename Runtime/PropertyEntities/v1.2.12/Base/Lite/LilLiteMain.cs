// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilLiteMain
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Main
    /// </summary>
    public class LilLiteMain : ILilLiteMain
    {
        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Color { get; set; }

        /// <summary>Main Texture</summary>
        public Texture2D? MainTex { get; set; }

        /// <summary>Main Tex Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MainTex_ScrollRotate { get; set; }
    }
}