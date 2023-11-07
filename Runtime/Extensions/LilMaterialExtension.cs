// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Extensions
// @Class     : LilMaterialExtension
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Extensions
{
    using UnityEngine;

    public static class LilMaterialExtension
    {
        #region Methods

        /// <summary>
        /// Get the lilToon version from the material.
        /// </summary>
        /// <param name="material">>A lilToon material.</param>
        /// <returns>The lilToon version.</returns>
        public static int GetLilToonVersion(this Material material)
        {
            return material.GetSafeInt(LilToonShader.PropertyName.LilToonVersion);
        }

        #endregion
    }
}