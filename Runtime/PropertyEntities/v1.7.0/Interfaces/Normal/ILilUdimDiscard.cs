// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_7_0
// @Class     : ILilUdimDiscard
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_7_0
{
    /// <summary>
    /// lilToon UDIM Discard Interface
    /// </summary>
    public interface ILilUdimDiscard
    {
        /// <summary>UDIM Discard Compile</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardCompile { get; set; }

        /// <summary>UDIM Discard UV</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(LilUdimDiscardUVMode.UV0)]
        LilUdimDiscardUVMode UDIMDiscardUV { get; set; }

        /// <summary>UDIM Discard Mode</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(LilUdimDiscardMode.Vertex)]
        LilUdimDiscardMode UDIMDiscardMode { get; set; }

        /// <summary>UDIM Discard Row 3-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow3_3 { get; set; }

        /// <summary>UDIM Discard Row 3-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow3_2 { get; set; }

        /// <summary>UDIM Discard Row 3-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow3_1 { get; set; }

        /// <summary>UDIM Discard Row 3-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow3_0 { get; set; }

        /// <summary>UDIM Discard Row 2-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow2_3 { get; set; }

        /// <summary>UDIM Discard Row 2-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow2_2 { get; set; }

        /// <summary>UDIM Discard Row 2-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow2_1 { get; set; }

        /// <summary>UDIM Discard Row 2-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow2_0 { get; set; }

        /// <summary>UDIM Discard Row 1-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow1_3 { get; set; }

        /// <summary>UDIM Discard Row 1-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow1_2 { get; set; }

        /// <summary>UDIM Discard Row 1-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow1_1 { get; set; }

        /// <summary>UDIM Discard Row 1-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow1_0 { get; set; }

        /// <summary>UDIM Discard Row 0-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow0_3 { get; set; }

        /// <summary>UDIM Discard Row 0-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow0_2 { get; set; }

        /// <summary>UDIM Discard Row 0-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow0_1 { get; set; }

        /// <summary>UDIM Discard Row 0-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        bool UDIMDiscardRow0_0 { get; set; }
    }
}