// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilLiteMain
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Main Interface
    /// </summary>
    public interface ILilLiteMain
    {
        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color Color { get; set; }

        /// <summary>Main Texture</summary>
        Texture2D? MainTex { get; set; }

        /// <summary>Main Tex Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 MainTex_ScrollRotate { get; set; }
    }
}