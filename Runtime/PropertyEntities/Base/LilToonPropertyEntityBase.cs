// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LilToonPropertyEntityBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    /// <summary>
    /// lilToon Basic Property Entity
    /// </summary>
    public abstract class LilToonPropertyEntityBase : ILilToonPropertyEntityBase
    {
        /// <summary>Save</summary>
        public LilSave? Save { get; set; }
    }
}