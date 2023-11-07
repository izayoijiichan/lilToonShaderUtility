// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : ILilToonPropertyEntityBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    /// <summary>
    /// lilToon Basic Property Entity Interface
    /// </summary>
    public interface ILilToonPropertyEntityBase
    {
        /// <summary>Save</summary>
        LilSave? Save { get; set; }
    }
}