// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFakeShadowBaseMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Fake Shadow Base Material Proxy
    /// </summary>
    public class LilFakeShadowBaseMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        public bool Invisible
        {
            get => _Material.GetSafeBool(PropertyNameID.Invisible, false);
            set => _Material.SetSafeBool(PropertyNameID.Invisible, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFakeShadowBaseMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFakeShadowBaseMaterialProxy(Material material) : base(material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name != ShaderName.Lil_LilToonFakeShadow)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}