// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilToonPropertyContainer
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    /// <summary>
    /// lilToon Property Container
    /// </summary>
    public class LilToonPropertyContainer : LilToonPropertyContainerBase
    {
        /// <summary>Normal Property Entity</summary>
        public LilToonNormalPropertyEntity NormalProperty { get; set; }

        /// <summary>Lite Property Entity</summary>
        public LilToonLitePropertyEntity LiteProperty { get; set; }

        /// <summary>Multi Property Entity</summary>
        public LilToonMultiPropertyEntity MultiProperty { get; set; }

        /// <summary>Fake Shadow Property Entity</summary>
        public LilToonFakeShadowPropertyEntity FakeShadowProperty { get; set; }
    }
}