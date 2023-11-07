// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Extensions
// @Class     : LilShaderExtension
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Extensions
{
    using UnityEngine;

    public static class LilShaderExtension
    {
        #region Fields

        /// <summary></summary>
        private static readonly bool isMultiVariants = false;

        #endregion

        #region Methods

        /// <summary>
        /// Get the lilToon property entity type from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>The lilToon property entity type.</returns>
        public static LilPropertyEntityType GetLilPropertyEntityType(this Shader shader)
        {
            if (shader.IsMulti())
            {
                return LilPropertyEntityType.Multi;
            }
            else if (shader.IsLite())
            {
                return LilPropertyEntityType.Lite;
            }
            else if (shader.IsFakeShadow())
            {
                return LilPropertyEntityType.FakeShadow;
            }

            return LilPropertyEntityType.Normal;
        }

        /// <summary>
        /// Get the lilToon rendering mode from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>The lilToon rendering mode.</returns>
        public static LilRenderingMode GetRenderingMode(this Shader shader)
        {
            if (shader.IsGem())
            {
                return LilRenderingMode.Gem;
            }

            if (shader.IsFur())
            {
                if (shader.IsTwoPass())
                {
                    return LilRenderingMode.FurTwoPass;
                }

                if (shader.IsCutout())
                {
                    return LilRenderingMode.FurCutout;
                }

                return LilRenderingMode.Fur;
            }

            if (shader.name.Contains("RefractionBlur"))
            {
                return LilRenderingMode.RefractionBlur;
            }

            if (shader.name.Contains("Refraction"))
            {
                return LilRenderingMode.Refraction;
            }

            if (shader.IsTransparent())
            {
                return LilRenderingMode.Transparent;
            }

            if (shader.IsCutout())
            {
                return LilRenderingMode.Cutout;
            }

            return LilRenderingMode.Opaque;
        }

        /// <summary>
        /// Get the lilToon transparent mode from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>The lilToon transparent mode.</returns>
        public static LilTransparentMode GetTransparentMode(this Shader shader)
        {
            if (shader.IsTwoPass())
            {
                return LilTransparentMode.TwoPass;
            }

            if (shader.IsOnePass())
            {
                return LilTransparentMode.OnePass;
            }

            return LilTransparentMode.Normal;
        }

        /// <summary>
        /// Check if it is blur from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if blur, false otherwise.</returns>
        public static bool IsBlur(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Blur");
        }

        /// <summary>
        /// Check if it is custom shader from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if custom shader, false otherwise.</returns>
        public static bool IsCustomShader(this Shader shader)
        {
            return shader.name.Contains("Optional");
        }

        /// <summary>
        /// Check if it is cutout from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if cutout, false otherwise.</returns>
        public static bool IsCutout(this Shader shader)
        {
            return shader.name.Contains("Cutout");
        }

        /// <summary>
        /// Check if it is fake shadow from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if fake shadow, false otherwise.</returns>
        public static bool IsFakeShadow(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("FakeShadow");
        }

        /// <summary>
        /// Check if it is fur from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if fur, false otherwise.</returns>
        public static bool IsFur(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Fur");
        }

        /// <summary>
        /// Check if it is gem from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if gem, false otherwise.</returns>
        public static bool IsGem(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Gem");
        }

        /// <summary>
        /// Check if it is lite from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if lite, false otherwise.</returns>
        public static bool IsLite(this Shader shader)
        {
            return shader.name.Contains("Lite");
        }

        /// <summary>
        /// Check if it is one pass from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if one pass, false otherwise.</returns>
        public static bool IsOnePass(this Shader shader)
        {
            return shader.name.Contains("OnePass");
        }

        /// <summary>
        /// Check if it is outline from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if outline, false otherwise.</returns>
        public static bool IsOutline(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Outline");
        }

        /// <summary>
        /// Check if it is overlay from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if overlay, false otherwise.</returns>
        public static bool IsOverlay(this Shader shader)
        {
            return shader.name.Contains("Overlay");
        }

        /// <summary>
        /// Check if it is refraction from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if refraction, false otherwise.</returns>
        public static bool IsRefraction(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Refraction");
        }

        /// <summary>
        /// Check if it is multi from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if multi, false otherwise.</returns>
        public static bool IsMulti(this Shader shader)
        {
            return shader.name.Contains("Multi");
        }

        /// <summary>
        /// Check if it is custom shader from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if custom shader, false otherwise.</returns>
        public static bool IsShowRenderMode(this Shader shader)
        {
            return !shader.IsCustomShader();
        }

        /// <summary>
        /// Check if it is tessellation from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if tessellation, false otherwise.</returns>
        public static bool IsTessellation(this Shader shader)
        {
            if (isMultiVariants)
            {
                return false;
            }

            return shader.name.Contains("Tessellation");
        }

        /// <summary>
        /// Check if it is transparent from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if transparent, false otherwise.</returns>
        public static bool IsTransparent(this Shader shader)
        {
            return
                shader.name.Contains("Transparent") ||
                shader.name.Contains("Overlay");
        }

        /// <summary>
        /// Check if it is two pass from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if two pass, false otherwise.</returns>
        public static bool IsTwoPass(this Shader shader)
        {
            return shader.name.Contains("TwoPass");
        }

        #endregion
    }
}
