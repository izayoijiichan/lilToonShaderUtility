// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilGlitterMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Glitter Material Proxy
    /// </summary>
    public class LilGlitterMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Glitter</summary>
        //[DefaultValue(false)]
        public bool UseGlitter
        {
            get => _Material.GetSafeBool(PropertyNameID.UseGlitter, false);
            set => _Material.SetSafeBool(PropertyNameID.UseGlitter, value);
        }

        /// <summary>Glitter UV Mode</summary>
        //[DefaultValue(LilGlitterUVMode.UV0)]
        public LilGlitterUVMode GlitterUVMode
        {
            get => _Material.GetSafeEnum<LilGlitterUVMode>(PropertyNameID.GlitterUVMode, LilGlitterUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.GlitterUVMode, (int)value);
        }

        /// <summary>Glitter Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color GlitterColor
        {
            get => _Material.GetSafeColor(PropertyNameID.GlitterColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.GlitterColor, value);
        }

        /// <summary>Glitter Color Texture</summary>
        public Texture2D? GlitterColorTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.GlitterColorTex);
            set => _Material.SetSafeTexture(PropertyNameID.GlitterColorTex, value);
        }

        /// <summary>Glitter Color Texture UV Mode</summary>
        /// <remarks>v1.3.2 added</remarks>
        public LilGlitterColorTextureUVMode GlitterColorTex_UVMode
        {
            get => _Material.GetSafeEnum<LilGlitterColorTextureUVMode>(PropertyNameID.GlitterColorTex_UVMode, LilGlitterColorTextureUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.GlitterColorTex_UVMode, (int)value);
        }

        /// <summary>Glitter Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterMainStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterMainStrength, PropertyRange.GlitterMainStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterMainStrength, PropertyRange.GlitterMainStrength, value);
        }

        /// <summary>Glitter Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlitterNormalStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterNormalStrength, PropertyRange.GlitterNormalStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterNormalStrength, PropertyRange.GlitterNormalStrength, value);
        }

        /// <summary>Glitter Scale Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterScaleRandomize
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterScaleRandomize, PropertyRange.GlitterScaleRandomize.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterScaleRandomize, PropertyRange.GlitterScaleRandomize, value);
        }

        /// <summary>Glitter Apply Shape</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool GlitterApplyShape
        {
            get => _Material.GetSafeBool(PropertyNameID.GlitterApplyShape, false);
            set => _Material.SetSafeBool(PropertyNameID.GlitterApplyShape, value);
        }

        /// <summary>Glitter Shape Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public Texture2D? GlitterShapeTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.GlitterShapeTex);
            set => _Material.SetSafeTexture(PropertyNameID.GlitterShapeTex, value);
        }

        /// <summary>Glitter Atras</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(1,1,0,0)]
        public Vector4 GlitterAtras
        {
            get => _Material.GetSafeVector4(PropertyNameID.GlitterAtras, new Vector4(1.0f, 1.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.GlitterAtras, value);
        }

        /// <summary>Glitter Angle Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(false)]
        public bool GlitterAngleRandomize
        {
            get => _Material.GetSafeBool(PropertyNameID.GlitterAngleRandomize, false);
            set => _Material.SetSafeBool(PropertyNameID.GlitterAngleRandomize, value);
        }

        /// <summary>Glitter Parameters 1</summary>
        /// <remarks>Tiling|Particle Size|Contrast</remarks>
        //[DefaultValue(256,256,0.16f,50)]
        public Vector4 GlitterParams1
        {
            get => _Material.GetSafeVector4(PropertyNameID.GlitterParams1, new Vector4(256.0f, 256.0f, 0.16f, 50.0f));
            set => _Material.SetSafeVector(PropertyNameID.GlitterParams1, value);
        }

        /// <summary>Glitter Parameters 2</summary>
        /// <remarks>Blink Speed|Angle|Blend Light Direction|Color Randomness</remarks>
        //[DefaultValue(0.25f,0,0,0)]
        public Vector4 GlitterParams2
        {
            get => _Material.GetSafeVector4(PropertyNameID.GlitterParams2, new Vector4(0.25f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.GlitterParams2, value);
        }

        /// <summary>Glitter Post Contrast</summary>
        //[DefaultValue(1.0f)]
        public float GlitterPostContrast
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterPostContrast, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterPostContrast, value);
        }

        /// <summary>Glitter Sensitivity</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0.25f)]
        public float GlitterSensitivity
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterSensitivity, 0.25f);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterSensitivity, value);
        }

        /// <summary>Glitter Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlitterEnableLighting
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterEnableLighting, PropertyRange.GlitterEnableLighting.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterEnableLighting, PropertyRange.GlitterEnableLighting, value);
        }

        /// <summary>Glitter Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterShadowMask
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterShadowMask, PropertyRange.GlitterShadowMask.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterShadowMask, PropertyRange.GlitterShadowMask, value);
        }

        /// <summary>Glitter Backface Mask</summary>
        //[DefaultValue(false)]
        public bool GlitterBackfaceMask
        {
            get => _Material.GetSafeBool(PropertyNameID.GlitterBackfaceMask, true);
            set => _Material.SetSafeBool(PropertyNameID.GlitterBackfaceMask, value);
        }

        /// <summary>Glitter Apply Transparency</summary>
        //[DefaultValue(true)]
        public bool GlitterApplyTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.GlitterApplyTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.GlitterApplyTransparency, value);
        }

        /// <summary>Glitter VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float GlitterVRParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.GlitterVRParallaxStrength, PropertyRange.GlitterVRParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.GlitterVRParallaxStrength, PropertyRange.GlitterVRParallaxStrength, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilGlitterMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilGlitterMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}