// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFakeShadowMainMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Fake Shadow Main Material Proxy
    /// </summary>
    public class LilFakeShadowMainMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Color
        {
            get => _Material.GetSafeColor(PropertyNameID.Color, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.Color, value);
        }

        /// <summary>Main Texture</summary>
        public Texture2D? MainTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.MainTex);
            set => _Material.SetSafeTexture(PropertyNameID.MainTex, value);
        }

        /// <summary>Fake Shadow Vector</summary>
        /// <remarks>Offset|Vector</remarks>
        //[DefaultValue(0,0,0,0.05)]
        public Vector4 FakeShadowVector
        {
            get => _Material.GetSafeVector4(PropertyNameID.FakeShadowVector, new Vector4(0, 0, 0, 0.05f));
            set => _Material.SetSafeVector(PropertyNameID.FakeShadowVector, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFakeShadowMainMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFakeShadowMainMaterialProxy(Material material) : base(material)
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