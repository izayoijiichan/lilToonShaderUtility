// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilFakeShadowBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon FakeShadow Base Interface
    /// </summary>
    public interface ILilFakeShadowBase
    {
        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        bool Invisible { get; set; }
    }
}