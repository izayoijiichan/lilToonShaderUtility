// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Enum      : LilUdimDiscardMode
// ----------------------------------------------------------------------
namespace LilToonShader
{
    /// <summary>UDIM (UV Tile) Discard Mode</summary>
    /// <remarks>v1.7.0 added</remarks>
    public enum LilUdimDiscardMode
    {
        /// <summary>Vertex</summary>
        /// <remarks>faster</remarks>
        Vertex = 0,
        /// <summary>Pixel</summary>
        /// <remarks>slower</remarks>
        Pixel = 1,
    }
}
