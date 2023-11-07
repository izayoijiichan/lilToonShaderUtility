// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Structure : FloatRange
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader
{
    /// <summary>
    /// 
    /// </summary>
    public struct FloatRange
    {
        /// <summary></summary>
        public float minValue;

        /// <summary></summary>
        public float maxValue;

        /// <summary>
        /// Create a new instance of FloatRange.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public FloatRange(float minValue, float maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}