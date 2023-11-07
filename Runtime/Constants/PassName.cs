// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : PassName
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    /// <summary>
    /// Pass Name
    /// </summary>
    public class PassName
    {
        /// <summary>Shadow Caster</summary>
        public const string ShadowCaster = "ShadowCaster";

        /// <summary>Depth Only</summary>
        public const string DepthOnly = "DepthOnly";

        /// <summary>Depth Normals</summary>
        public const string DepthNormals = "DepthNormals";

        /// <summary>Depth Forward Only</summary>
        public const string DepthForwardOnly = "DepthForwardOnly";

        /// <summary>Motion Vectors</summary>
        public const string MotionVectors = "MotionVectors";

        /// <summary>SRP Default Unlit</summary>
        public const string SrpDefaultUnlit = "SRPDEFAULTUNLIT";
    }
}