// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Enum      : 
// ----------------------------------------------------------------------
namespace LilToonShader
{
    /// <summary>Main UV Mode</summary>
    /// <remarks>Main Texture</remarks>
    public enum LilMainUVMode
    {
        /// <summary>UV0</summary>
        UV0 = 0,
        /// <summary>UV1</summary>
        UV1 = 1,
        /// <summary>UV2</summary>
        UV2 = 2,
        /// <summary>UV3</summary>
        UV3 = 3,
        /// <summary>MatCap</summary>
        MatCap = 4,
    }

    /// <summary>Glitter UV Mode</summary>
    /// <remarks>Glitter</remarks>
    public enum LilGlitterUVMode
    {
        /// <summary>UV0</summary>
        UV0 = 0,
        /// <summary>UV1</summary>
        UV1 = 1,
    }

    /// <summary>Emission UV Mode</summary>
    /// <remarks>Emission Map</remarks>
    public enum LilEmissionUVMode
    {
        /// <summary>UV0</summary>
        UV0 = 0,
        /// <summary>UV1</summary>
        UV1 = 1,
        /// <summary>UV2</summary>
        UV2 = 2,
        /// <summary>UV3</summary>
        UV3 = 3,
        /// <summary>Rim</summary>
        Rim = 4,
    }

    /// <summary>Audio Link UV Mode</summary>
    /// <remarks>Audio Link</remarks>
    public enum LilAudioLinkUVMode
    {
        /// <summary>None</summary>
        None = 0,
        /// <summary>Rim</summary>
        Rim = 1,
        /// <summary>UV</summary>
        UV = 2,
        /// <summary>Mask</summary>
        Mask = 3,
        /// <summary>Mask (Spectrum)</summary>
        MaskSpectrum = 4,
        /// <summary>Position</summary>
        Position = 5,
    }

    /// <summary>Audio Link Vertex UV Mode</summary>
    /// <remarks>Audio Link</remarks>
    public enum LilAudioLinkVertexUVMode
    {
        /// <summary>None</summary>
        None = 0,
        /// <summary>Position</summary>
        Position = 1,
        /// <summary>UV</summary>
        UV = 2,
        /// <summary>Mask</summary>
        Mask = 3,
    }

    /// <summary>Outline Vector UV Mode</summary>
    /// <remarks>v1.3.0 added</remarks>
    public enum LilOutlineVectorUVMode
    {
        /// <summary>UV0</summary>
        UV0 = 0,
        /// <summary>UV1</summary>
        UV1 = 1,
        /// <summary>UV2</summary>
        UV2 = 2,
        /// <summary>UV3</summary>
        UV3 = 3,
    }
}
