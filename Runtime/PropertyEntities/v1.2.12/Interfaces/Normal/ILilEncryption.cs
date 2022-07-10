// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilEncryption
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Encryption Interface
    /// </summary>
    public interface ILilEncryption
    {
        /// <summary>IgnoreEncryption</summary>
        //[DefaultValue(false)]
        bool IgnoreEncryption { get; set; }

        /// <summary>Keys</summary>
        //[DefaultValue(0,0,0,0)]
        Vector4 Keys { get; set; }
    }
}