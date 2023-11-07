// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilEncryption
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Encryption
    /// </summary>
    public class LilEncryption : ILilEncryption
    {
        /// <summary>Ignore Encryption</summary>
        //[DefaultValue(false)]
        public bool IgnoreEncryption { get; set; }

        /// <summary>Keys</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Keys { get; set; }
    }
}