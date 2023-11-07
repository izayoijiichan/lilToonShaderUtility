// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteMainMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Main Material Proxy
    /// </summary>
    public class LilLiteMainMaterialProxy : LilMaterialProxyBase
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

        /// <summary>Main Tex Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 MainTex_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.MainTex_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.MainTex_ScrollRotate, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteMainMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteMainMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsLite() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}