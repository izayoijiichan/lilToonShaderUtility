// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMaterialProxyBase
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Material Proxy Base
    /// </summary>
    public abstract class LilMaterialProxyBase
    {
        #region Fields

        /// <summary></summary>
        protected readonly Material _Material;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilToonMaterialProxyBase.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMaterialProxyBase(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion
    }
}