// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFakeShadowMain
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon FakeShadow Main Interface
    /// </summary>
    public interface ILilFakeShadowMain
    {
        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color Color { get; set; }

        /// <summary>Main Texture</summary>
        Texture2D? MainTex { get; set; }

        /// <summary>Fake Shadow Vector</summary>
        /// <remarks>Offset|Vector</remarks>
        //[DefaultValue(0,0,0,0.05)]
        Vector4 FakeShadowVector { get; set; }
    }
}