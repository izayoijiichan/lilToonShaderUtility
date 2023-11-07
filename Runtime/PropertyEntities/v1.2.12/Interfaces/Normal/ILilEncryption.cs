// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilEncryption
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Encryption Interface
    /// </summary>
    public interface ILilEncryption
    {
        /// <summary>Ignore Encryption</summary>
        //[DefaultValue(false)]
        bool IgnoreEncryption { get; set; }

        /// <summary>Keys</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 Keys { get; set; }
    }
}