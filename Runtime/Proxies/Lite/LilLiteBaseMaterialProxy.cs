// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteBaseMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Base Material Proxy
    /// </summary>
    public class LilLiteBaseMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Invisible</summary>
        //[DefaultValue(false)]
        public bool Invisible
        {
            get => _Material.GetSafeBool(PropertyNameID.Invisible, false);
            set => _Material.SetSafeBool(PropertyNameID.Invisible, value);
        }

        /// <summary>Flip Backface Normal</summary>
        //[DefaultValue(false)]
        public bool FlipNormal
        {
            get => _Material.GetSafeBool(PropertyNameID.FlipNormal, false);
            set => _Material.SetSafeBool(PropertyNameID.FlipNormal, value);
        }

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        //[DefaultValue(false)]
        public bool ShiftBackfaceUV
        {
            get => _Material.GetSafeBool(PropertyNameID.ShiftBackfaceUV, false);
            set => _Material.SetSafeBool(PropertyNameID.ShiftBackfaceUV, value);
        }

        /// <summary>Backface Force Shadow</summary>
        //[DefaultValue(false)]
        public bool BackfaceForceShadow
        {
            get => _Material.GetSafeBool(PropertyNameID.BackfaceForceShadow, false);
            set => _Material.SetSafeBool(PropertyNameID.BackfaceForceShadow, value);
        }

        /// <summary>Anti-Aliasing Strength</summary>
        /// <remarks>v1.3.7 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0)]
        public float AAStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.AAStrength, PropertyRange.AAStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AAStrength, PropertyRange.AAStrength, value);
        }

        /// <summary>Tri Mask</summary>
        /// <remarks>Mat/Rim/Emission</remarks>
        public Texture2D? TriMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.TriMask);
            set => _Material.SetSafeTexture(PropertyNameID.TriMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteBaseMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteBaseMaterialProxy(Material material) : base(material)
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

            //switch (material.shader.name)
            //{
            //    case ShaderName.Lil_LilToonLite:
            //    case ShaderName.Lil_LilToonLiteOutline:
            //    case ShaderName.Lil_LilToonLiteCutout:
            //    case ShaderName.Lil_LilToonLiteCutoutOutline:
            //    case ShaderName.Lil_LilToonLiteTransparent:
            //    case ShaderName.Lil_LilToonLiteTransparentOutline:
            //    case ShaderName.Lil_LilToonLiteOnePassTransparent:
            //    case ShaderName.Lil_LilToonLiteOnePassTransparentOutline:
            //    case ShaderName.Lil_LilToonLiteTwoPassTransparent:
            //    case ShaderName.Lil_LilToonLiteTwoPassTransparentOutline:
            //    case ShaderName.Lil_LilToonLiteOverlay:
            //    case ShaderName.Lil_LilToonLiteOverlayOnePass:
            //    case ShaderName.Lil_LilToonPassLiteOpaque:
            //    case ShaderName.Lil_LilToonPassLiteCutout:
            //    case ShaderName.Lil_LilToonPassLiteTransparent:
            //        break;
            //    default:
            //        throw new ArgumentException();
            //}
        }

        #endregion
    }
}