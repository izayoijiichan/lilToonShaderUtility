// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilOutlineRenderingMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Outline Rendering Material Proxy
    /// </summary>
    public class LilOutlineRenderingMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Outline Cull</summary>
        //[DefaultValue(CullMode.Front)]
        public CullMode OutlineCull
        {
            get => _Material.GetSafeEnum<CullMode>(PropertyNameID.OutlineCull, CullMode.Front);
            set => _Material.SetSafeInt(PropertyNameID.OutlineCull, (int)value);
        }

        /// <summary>Outline Z Clip</summary>
        //[DefaultValue(true)]
        public bool OutlineZClip
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineZClip, true);
            set => _Material.SetSafeBool(PropertyNameID.OutlineZClip, value);
        }

        /// <summary>Outline Z Write</summary>
        //[DefaultValue(true)]
        public bool OutlineZWrite
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineZWrite, true);
            set => _Material.SetSafeBool(PropertyNameID.OutlineZWrite, value);
        }

        /// <summary>Outline Z Test</summary>
        //[DefaultValue(CompareFunction.Less)]
        public CompareFunction OutlineZTest
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.OutlineZTest, CompareFunction.Less);
            set => _Material.SetSafeInt(PropertyNameID.OutlineZTest, (int)value);
        }

        /// <summary>Outline Offset Factor</summary>
        //[DefaultValue(0.0f)]
        public float OutlineOffsetFactor
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineOffsetFactor, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineOffsetFactor, value);
        }

        /// <summary>Outline Offset Units</summary>
        //[DefaultValue(0.0f)]
        public float OutlineOffsetUnits
        {
            get => _Material.GetSafeFloat(PropertyNameID.OutlineOffsetUnits, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.OutlineOffsetUnits, value);
        }

        /// <summary>Outline Color Mask</summary>
        //[DefaultValue(15)]
        public int OutlineColorMask
        {
            get => _Material.GetSafeInt(PropertyNameID.OutlineColorMask, 15);
            set => _Material.SetSafeInt(PropertyNameID.OutlineColorMask, value);
        }

        /// <summary>Outline Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool OutlineAlphaToMask
        {
            get => _Material.GetSafeBool(PropertyNameID.OutlineAlphaToMask, false);
            set => _Material.SetSafeBool(PropertyNameID.OutlineAlphaToMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilOutlineRenderingMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilOutlineRenderingMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsOutline() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}