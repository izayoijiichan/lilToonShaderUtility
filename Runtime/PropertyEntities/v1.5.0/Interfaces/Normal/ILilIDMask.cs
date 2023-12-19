// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_5_0
// @Class     : ILilIDMask
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_5_0
{
    /// <summary>
    /// lilToon ID Mask Interface
    /// </summary>
    public interface ILilIDMask
    {
        /// <summary>ID Mask From</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilIDMaskFrom.VertexID)]
        LilIDMaskFrom IDMaskFrom { get; set; }

        /// <summary>ID Mask 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask1 { get; set; }

        /// <summary>ID Mask 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask2 { get; set; }

        /// <summary>ID Mask 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask3 { get; set; }

        /// <summary>ID Mask 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask4 { get; set; }

        /// <summary>ID Mask 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask5 { get; set; }

        /// <summary>ID Mask 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask6 { get; set; }

        /// <summary>ID Mask 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask7 { get; set; }

        /// <summary>ID Mask 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMask8 { get; set; }

        /// <summary>ID Mask is Bitmap</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskIsBitmap { get; set; }

        /// <summary>ID Mask Index 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex1 { get; set; }

        /// <summary>ID Mask Index 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex2 { get; set; }

        /// <summary>ID Mask Index 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex3 { get; set; }

        /// <summary>ID Mask Index 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex4 { get; set; }

        /// <summary>ID Mask Index 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex5 { get; set; }

        /// <summary>ID Mask Index 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex6 { get; set; }

        /// <summary>ID Mask Index 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex7 { get; set; }

        /// <summary>ID Mask Index 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        int IDMaskIndex8 { get; set; }

        /// <summary>ID Mask Controls Dissolve</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskControlsDissolve { get; set; }

        /// <summary>ID Mask Prior 1</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior1 { get; set; }

        /// <summary>ID Mask Prior 2</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior2 { get; set; }

        /// <summary>ID Mask Prior 3</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior3 { get; set; }

        /// <summary>ID Mask Prior 4</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior4 { get; set; }

        /// <summary>ID Mask Prior 5</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior5 { get; set; }

        /// <summary>ID Mask Prior 6</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior6 { get; set; }

        /// <summary>ID Mask Prior 7</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior7 { get; set; }

        /// <summary>ID Mask Prior 8</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        bool IDMaskPrior8 { get; set; }
    }
}