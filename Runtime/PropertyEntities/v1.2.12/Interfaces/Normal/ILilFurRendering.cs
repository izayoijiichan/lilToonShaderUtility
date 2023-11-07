// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFurRendering
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Interface
    /// </summary>
    public interface ILilFurRendering
    {
        /// <summary>Fur Cull</summary>
        //[DefaultValue(CullMode.Off)]
        CullMode FurCull { get; set; }

        /// <summary>Fur Z Clip</summary>
        //[DefaultValue(true)]
        bool FurZClip { get; set; }

        /// <summary>Fur Z Write</summary>
        //[DefaultValue(false)]
        bool FurZWrite { get; set; }

        /// <summary>Fur Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        CompareFunction FurZTest { get; set; }

        /// <summary>Fur Offset Factor</summary>
        //[DefaultValue(0.0f)]
        float FurOffsetFactor { get; set; }

        /// <summary>Fur Offset Units</summary>
        //[DefaultValue(0.0f)]
        float FurOffsetUnits { get; set; }

        /// <summary>Fur Color Mask</summary>
        //[DefaultValue(15)]
        int FurColorMask { get; set; }

        /// <summary>Fur Alpha to Mask</summary>
        //[DefaultValue(false)]
        bool FurAlphaToMask { get; set; }
    }
}