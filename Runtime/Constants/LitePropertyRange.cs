// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LitePropertyRange
// ----------------------------------------------------------------------
#nullable enable
#pragma warning disable IDE0090
namespace LilToonShader
{
    /// <summary>
    /// Lite Property Range
    /// </summary>
    public class LitePropertyRange
    {
        #region Shadow (Lite)

        /// <summary>Shadow Border</summary>
        public static FloatRangeDefault ShadowBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Shadow Blur</summary>
        public static FloatRangeDefault ShadowBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Shadow 2nd Border</summary>
        public static FloatRangeDefault Shadow2ndBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Shadow 2nd Blur</summary>
        public static FloatRangeDefault Shadow2ndBlur = new FloatRangeDefault(0.0f, 1.0f, 0.3f);

        /// <summary>Shadow Border Range</summary>
        public static FloatRangeDefault ShadowBorderRange = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Shadow Environment Strength</summary>
        public static FloatRangeDefault ShadowEnvStrength = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Rim (Lite)

        /// <summary>Rim Border</summary>
        public static FloatRangeDefault RimBorder = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Rim Blur</summary>
        public static FloatRangeDefault RimBlur = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Rim Fresnel Power</summary>
        public static FloatRangeDefault RimFresnelPower = new FloatRangeDefault(0.01f, 50.0f, 3.0f);

        /// <summary>Rim Shadow Mask</summary>
        public static FloatRangeDefault RimShadowMask = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion
    }
}
#pragma warning restore IDE0090