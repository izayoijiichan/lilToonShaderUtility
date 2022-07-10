// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilFurRendering
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering
    /// </summary>
    public class LilFurRendering : ILilFurRendering
    {
        /// <summary>Fur Cull</summary>
        //[DefaultValue(CullMode.Off)]
        public CullMode FurCull { get; set; }

        /// <summary>Fur Z Clip</summary>
        //[DefaultValue(true)]
        public bool FurZClip { get; set; }

        /// <summary>Fur Z Write</summary>
        //[DefaultValue(false)]
        public bool FurZWrite { get; set; }

        /// <summary>Fur Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        public CompareFunction FurZTest { get; set; }

        /// <summary>Fur Offset Factor</summary>
        //[DefaultValue(0.0f)]
        public float FurOffsetFactor { get; set; }

        /// <summary>Fur Offset Units</summary>
        //[DefaultValue(0.0f)]
        public float FurOffsetUnits { get; set; }

        /// <summary>Fur Color Mask</summary>
        //[DefaultValue(15)]
        public int FurColorMask { get; set; }

        /// <summary>Fur Alpha To Mask</summary>
        //[DefaultValue(false)]
        public bool FurAlphaToMask { get; set; }
    }
}