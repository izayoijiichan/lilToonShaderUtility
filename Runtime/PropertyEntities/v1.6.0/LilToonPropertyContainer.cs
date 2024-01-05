// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_6_0
// @Class     : LilToonPropertyContainer
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_6_0
{
    /// <summary>
    /// lilToon Property Container
    /// </summary>
    public class LilToonPropertyContainer : LilToonPropertyContainerBase
    {
        /// <summary>Normal Property Entity</summary>
        public LilToonNormalPropertyEntity? NormalProperty { get; set; }

        /// <summary>Lite Property Entity</summary>
        public LilToonLitePropertyEntity? LiteProperty { get; set; }

        /// <summary>Fake Shadow Property Entity</summary>
        public LilToonFakeShadowPropertyEntity? FakeShadowProperty { get; set; }
    }
}