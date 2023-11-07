// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMain2ndMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Main 2nd Material Proxy
    /// </summary>
    public class LilMain2ndMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Main 2nd Texture</summary>
        //[DefaultValue(false)]
        public bool UseMain2ndTex
        {
            get => _Material.GetSafeBool(PropertyNameID.UseMain2ndTex, false);
            set => _Material.SetSafeBool(PropertyNameID.UseMain2ndTex, value);
        }

        /// <summary>Main 2nd Color</summary>
        //[DefaultValue(0,1,1,1)]
        public Color Color2nd
        {
            get => _Material.GetSafeColor(PropertyNameID.Color2nd, new Color(0.0f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.Color2nd, value);
        }

        /// <summary>Main 2nd Texture</summary>
        public Texture2D? Main2ndTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main2ndTex);
            set => _Material.SetSafeTexture(PropertyNameID.Main2ndTex, value);
        }

        /// <summary>Main 2nd Texture Angle</summary>
        //[DefaultValue(0)]
        public float Main2ndTexAngle
        {
            get => _Material.GetSafeFloat(PropertyNameID.Main2ndTexAngle, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.Main2ndTexAngle, value);
        }

        /// <summary>Main 2nd Texture Scroll Rotate</summary>
        /// <remarks>
        /// Angle|UV Animation|Scroll|Rotate
        /// v1.3.7 added
        /// </remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Main2ndTex_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndTex_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.Main2ndTex_ScrollRotate, value);
        }

        /// <summary>Main 2nd Texture UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilMainUVMode Main2ndTex_UVMode
        {
            get => _Material.GetSafeEnum<LilMainUVMode>(PropertyNameID.Main2ndTex_UVMode, LilMainUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.Main2ndTex_UVMode, (int)value);
        }

        /// <summary>Main 2nd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(CullMode.Off)]
        public CullMode Main2ndTex_Cull
        {
            get => _Material.GetSafeEnum<CullMode>(PropertyNameID.Main2ndTex_Cull, CullMode.Off);
            set => _Material.SetSafeInt(PropertyNameID.Main2ndTex_Cull, (int)value);
        }

        /// <summary>Main 2nd Texture Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        //[DefaultValue(1,1,1,30)]
        public Vector4 Main2ndTexDecalAnimation
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndTexDecalAnimation, new Vector4(1.0f, 1.0f, 1.0f, 30.0f));
            set => _Material.SetSafeVector(PropertyNameID.Main2ndTexDecalAnimation, value);
        }

        /// <summary>Main 2nd Texture Decal Sub Parameter</summary>
        /// <remarks>Ratio X|Ratio Y|Fix Border</remarks>
        //[DefaultValue(1,1,0,1)]
        public Vector4 Main2ndTexDecalSubParam
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndTexDecalSubParam, new Vector4(1.0f, 1.0f, 0.0f, 1.0f));
            set => _Material.SetSafeVector(PropertyNameID.Main2ndTexDecalSubParam, value);
        }

        /// <summary>Main 2nd Texture is Decal</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsDecal
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexIsDecal, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexIsDecal, value);
        }

        /// <summary>Main 2nd Texture is Left Only</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsLeftOnly
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexIsLeftOnly, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexIsLeftOnly, value);
        }

        /// <summary>Main 2nd Texture is Right Only</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsRightOnly
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexIsRightOnly, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexIsRightOnly, value);
        }

        /// <summary>Main 2nd Texture Should Copy</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldCopy
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexShouldCopy, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexShouldCopy, value);
        }

        /// <summary>Main 2nd Texture Should Flip Mirror</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldFlipMirror
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexShouldFlipMirror, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexShouldFlipMirror, value);
        }

        /// <summary>Main 2nd Texture Should Flip Copy</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldFlipCopy
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexShouldFlipCopy, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexShouldFlipCopy, value);
        }

        /// <summary>Main 2nd Texture is MSDF</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsMSDF
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndTexIsMSDF, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndTexIsMSDF, value);
        }

        /// <summary>Main 2nd Blend Mask</summary>
        public Texture2D? Main2ndBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main2ndBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main2ndBlendMask, value);
        }

        /// <summary>Main 2nd Texture Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Normal)]
        public LilBlendMode Main2ndTexBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.Main2ndTexBlendMode, LilBlendMode.Normal);
            set => _Material.SetSafeInt(PropertyNameID.Main2ndTexBlendMode, (int)value);
        }

        /// <summary>Main 2nd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilAlphaMaskMode.None)]
        public LilAlphaMaskMode Main2ndTexAlphaMode
        {
            get => _Material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.Main2ndTexAlphaMode, LilAlphaMaskMode.None);
            set => _Material.SetSafeInt(PropertyNameID.Main2ndTexAlphaMode, (int)value);
        }
        //{
        //    get => _Material.GetSafeEnum<LilTransparentMode>(PropertyNameID.Main2ndTexAlphaMode, LilTransparentMode.Normal);
        //    set => _Material.SetSafeInt(PropertyNameID.Main2ndTexAlphaMode, (int) value);
        //}

        /// <summary>Main 2nd Enable Lighting</summary>
        //[DefaultValue(true)]
        public bool Main2ndEnableLighting
        {
            get => _Material.GetSafeBool(PropertyNameID.Main2ndEnableLighting, false);
            set => _Material.SetSafeBool(PropertyNameID.Main2ndEnableLighting, value);
        }

        /// <summary>Main 2nd Dissolve Mask</summary>
        public Texture2D? Main2ndDissolveMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main2ndDissolveMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main2ndDissolveMask, value);
        }

        /// <summary>Main 2nd Dissolve Noise Mask</summary>
        public Texture2D? Main2ndDissolveNoiseMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main2ndDissolveNoiseMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main2ndDissolveNoiseMask, value);
        }

        /// <summary>Main 2nd Dissolve Noise Mask Scroll Rotate</summary>
        public Vector4 Main2ndDissolveNoiseMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndDissolveNoiseMask_ScrollRotate);
            set => _Material.SetSafeVector(PropertyNameID.Main2ndDissolveNoiseMask_ScrollRotate, value);
        }

        /// <summary>Main 2nd Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        public float Main2ndDissolveNoiseStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Main2ndDissolveNoiseStrength, 0.1f);
            set => _Material.SetSafeFloat(PropertyNameID.Main2ndDissolveNoiseStrength, value);
        }

        /// <summary>Main 2nd Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Main2ndDissolveColor
        {
            get => _Material.GetSafeColor(PropertyNameID.Main2ndDissolveColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.Main2ndDissolveColor, value);
        }

        /// <summary>Main 2nd Dissolve Parameters</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        public Vector4 Main2ndDissolveParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndDissolveParams, new Vector4(0.0f, 0.0f, 0.5f, 0.1f));
            set => _Material.SetSafeVector(PropertyNameID.Main2ndDissolveParams, value);
        }

        /// <summary>Main 2nd Dissolve Position</summary>
        public Vector4 Main2ndDissolvePos
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndDissolvePos);
            set => _Material.SetSafeVector(PropertyNameID.Main2ndDissolvePos, value);
        }

        /// <summary>Main 2nd Distance Fade</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        public Vector4 Main2ndDistanceFade
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main2ndDistanceFade);
            set => _Material.SetSafeVector(PropertyNameID.Main2ndDistanceFade, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMain2ndMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMain2ndMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}