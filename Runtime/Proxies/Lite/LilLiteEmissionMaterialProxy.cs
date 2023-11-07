// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilLiteEmissionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using System;
    using UnityEngine;

    /// <summary>
    /// lilToon Lite Emission Material Proxy
    /// </summary>
    public class LilLiteEmissionMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Emission</summary>
        //[DefaultValue(false)]
        public bool UseEmission
        {
            get => _Material.GetSafeBool(PropertyNameID.UseEmission, false);
            set => _Material.SetSafeBool(PropertyNameID.UseEmission, value);
        }

        /// <summary>Emission Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(PropertyNameID.EmissionColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.EmissionColor, value);
        }

        /// <summary>Emission Map</summary>
        public Texture2D? EmissionMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionMap);
            set => _Material.SetSafeTexture(PropertyNameID.EmissionMap, value);
        }

        /// <summary>Emission Map Scroll Rotate</summary>
        /// <remarks>Angle|UV Animation|Scroll|Rotate</remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 EmissionMap_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.EmissionMap_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.EmissionMap_ScrollRotate, value);
        }

        /// <summary>Emission Map UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilEmissionUVMode EmissionMap_UVMode
        {
            get => _Material.GetSafeEnum<LilEmissionUVMode>(PropertyNameID.EmissionMap_UVMode, LilEmissionUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMap_UVMode, (int)value);
        }

        /// <summary>Emission Blink</summary>
        /// <remarks>Blink Strength|Blink Type|Blink Speed|Blink Offset</remarks>
        //[DefaultValue(0,0,3.141593,0)]
        public Vector4 EmissionBlink
        {
            get => _Material.GetSafeVector4(PropertyNameID.EmissionBlink, new Vector4(0.0f, 0.0f, 3.141593f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.EmissionBlink, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilLiteEmissionMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilLiteEmissionMaterialProxy(Material material) : base(material)
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