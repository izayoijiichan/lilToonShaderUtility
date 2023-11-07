// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilTessellationMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Tessellation Material Proxy
    /// </summary>
    public class LilTessellationMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Tessellation Edge</summary>
        //[Range(0, 100)]
        //[DefaultValue(10)]
        public float TessEdge
        {
            get => _Material.GetSafeFloat(PropertyNameID.TessEdge, PropertyRange.TessEdge.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TessEdge, PropertyRange.TessEdge, value);
        }

        /// <summary>Tessellation Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float TessStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.TessStrength, PropertyRange.TessStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TessStrength, PropertyRange.TessStrength, value);
        }

        /// <summary>Tessellation Shrink</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float TessShrink
        {
            get => _Material.GetSafeFloat(PropertyNameID.TessShrink, PropertyRange.TessShrink.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TessShrink, PropertyRange.TessShrink, value);
        }

        /// <summary>Tessellation Factor Max</summary>
        //[Range(1, 8)]
        //[DefaultValue(3)]
        public int TessFactorMax
        {
            get => _Material.GetSafeInt(PropertyNameID.TessFactorMax, PropertyRange.TessFactorMax.defaultValue);
            set => _Material.SetSafeInt(PropertyNameID.TessFactorMax, PropertyRange.TessFactorMax, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilTessellationMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        /// <remarks>RenderingMode is Tessellation or Tessellation</remarks>
        public LilTessellationMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsTessellation() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}