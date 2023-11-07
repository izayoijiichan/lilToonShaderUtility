// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilFurRenderingMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Fur Rendering Material Proxy
    /// </summary>
    public class LilFurRenderingMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Fur Cull</summary>
        //[DefaultValue(CullMode.Off)]
        public CullMode FurCull
        {
            get => _Material.GetSafeEnum<CullMode>(PropertyNameID.FurCull, CullMode.Back);
            set => _Material.SetSafeInt(PropertyNameID.FurCull, (int)value);
        }

        /// <summary>Fur Z Clip</summary>
        //[DefaultValue(true)]
        public bool FurZClip
        {
            get => _Material.GetSafeBool(PropertyNameID.FurZClip, true);
            set => _Material.SetSafeBool(PropertyNameID.FurZClip, value);
        }

        /// <summary>Fur Z Write</summary>
        //[DefaultValue(false)]
        public bool FurZWrite
        {
            get => _Material.GetSafeBool(PropertyNameID.FurZWrite, false);
            set => _Material.SetSafeBool(PropertyNameID.FurZWrite, value);
        }

        /// <summary>Fur Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        public CompareFunction FurZTest
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.FurZTest, CompareFunction.LessEqual);
            set => _Material.SetSafeInt(PropertyNameID.FurZTest, (int)value);
        }

        /// <summary>Fur Offset Factor</summary>
        //[DefaultValue(0.0f)]
        public float FurOffsetFactor
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurOffsetFactor, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.FurOffsetFactor, value);
        }

        /// <summary>Fur Offset Units</summary>
        //[DefaultValue(0.0f)]
        public float FurOffsetUnits
        {
            get => _Material.GetSafeFloat(PropertyNameID.FurOffsetUnits, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.FurOffsetUnits, value);
        }

        /// <summary>Fur Color Mask</summary>
        //[DefaultValue(15)]
        public int FurColorMask
        {
            get => _Material.GetSafeInt(PropertyNameID.FurColorMask, 15);
            set => _Material.SetSafeInt(PropertyNameID.FurColorMask, value);
        }

        /// <summary>Fur Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool FurAlphaToMask
        {
            get => _Material.GetSafeBool(PropertyNameID.FurAlphaToMask, false);
            set => _Material.SetSafeBool(PropertyNameID.FurAlphaToMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilFurRenderingMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilFurRenderingMaterialProxy(Material material) : base(material)
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

            if (material.shader.IsFur() == false)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}