// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMainMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Main Material Proxy
    /// </summary>
    public class LilMainMaterialProxy : LilMaterialProxyBase
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

        /// <summary>Main Tex HSVG</summary>
        /// <remarks>Hue|Saturation|Value|Gamma</remarks>
        //[DefaultValue(0,1,1,1)]
        public Vector4 MainTexHSVG
        {
            get => _Material.GetSafeVector4(PropertyNameID.MainTexHSVG, new Vector4(0.0f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeVector(PropertyNameID.MainTexHSVG, value);
        }

        /// <summary>Main Gradation Strength</summary>
        //[Range(0, 1)]
        //[DefaultValue(0)]
        public float MainGradationStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.MainGradationStrength, PropertyRange.MainGradationStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.MainGradationStrength, PropertyRange.MainGradationStrength, value);
        }

        /// <summary>Main Gradation Texture</summary>
        public Texture2D? MainGradationTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.MainGradationTex);
            set => _Material.SetSafeTexture(PropertyNameID.MainGradationTex, value);
        }

        /// <summary>Main Color Adjust Mask</summary>
        public Texture2D? MainColorAdjustMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.MainColorAdjustMask);
            set => _Material.SetSafeTexture(PropertyNameID.MainColorAdjustMask, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMainMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMainMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}