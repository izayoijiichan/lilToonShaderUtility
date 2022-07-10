// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFakeShadowMain
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon FakeShadow Main
    /// </summary>
    public class LilFakeShadowMain : ILilFakeShadowMain
    {
        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Color { get; set; }

        /// <summary>Main Texture</summary>
        public Texture2D MainTex { get; set; }

        /// <summary>Fake Shadow Vector</summary>
        /// <remarks>Offset|Vector</remarks>
        //[DefaultValue(0,0,0,0.05)]
        public Vector4 FakeShadowVector { get; set; }
    }
}