// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilMain3rdMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Main 3rd Material Proxy
    /// </summary>
    public class LilMain3rdMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Main 3rd Texture</summary>
        //[DefaultValue(false)]
        public bool UseMain3rdTex
        {
            get => _Material.GetSafeBool(PropertyNameID.UseMain3rdTex, false);
            set => _Material.SetSafeBool(PropertyNameID.UseMain3rdTex, value);
        }

        /// <summary>Main 3rd Color</summary>
        //[DefaultValue(0,1,1,1)]
        public Color Color3rd
        {
            get => _Material.GetSafeColor(PropertyNameID.Color3rd, new Color(0.0f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.Color3rd, value);
        }

        /// <summary>Main 3rd Texture</summary>
        public Texture2D? Main3rdTex
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main3rdTex);
            set => _Material.SetSafeTexture(PropertyNameID.Main3rdTex, value);
        }

        /// <summary>Main 3rd Texture Angle</summary>
        //[DefaultValue(0)]
        public float Main3rdTexAngle
        {
            get => _Material.GetSafeFloat(PropertyNameID.Main3rdTexAngle, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.Main3rdTexAngle, value);
        }

        /// <summary>Main 3rd Texture Scroll Rotate</summary>
        /// <remarks>
        /// Angle|UV Animation|Scroll|Rotate
        /// v1.3.7 added
        /// </remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Main3rdTex_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdTex_ScrollRotate, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.Main3rdTex_ScrollRotate, value);
        }

        /// <summary>Main 3rd Texture UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilMainUVMode Main3rdTex_UVMode
        {
            get => _Material.GetSafeEnum<LilMainUVMode>(PropertyNameID.Main3rdTex_UVMode, LilMainUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.Main3rdTex_UVMode, (int)value);
        }

        /// <summary>Main 3rd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(CullMode.Off)]
        public CullMode Main3rdTex_Cull
        {
            get => _Material.GetSafeEnum<CullMode>(PropertyNameID.Main3rdTex_Cull, CullMode.Off);
            set => _Material.SetSafeInt(PropertyNameID.Main3rdTex_Cull, (int)value);
        }

        /// <summary>Main 3rd Texture Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        //[DefaultValue(1,1,1,30)]
        public Vector4 Main3rdTexDecalAnimation
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdTexDecalAnimation, new Vector4(1.0f, 1.0f, 1.0f, 30.0f));
            set => _Material.SetSafeVector(PropertyNameID.Main3rdTexDecalAnimation, value);
        }

        /// <summary>Main 3rd Texture Decal Sub Parameter</summary>
        /// <remarks>Ratio X|Ratio Y|Fix Border</remarks>
        //[DefaultValue(1,1,0,1)]
        public Vector4 Main3rdTexDecalSubParam
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdTexDecalSubParam, new Vector4(1.0f, 1.0f, 0.0f, 1.0f));
            set => _Material.SetSafeVector(PropertyNameID.Main3rdTexDecalSubParam, value);
        }

        /// <summary>Main 3rd Texture is Decal</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexIsDecal
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexIsDecal, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexIsDecal, value);
        }

        /// <summary>Main 3rd Texture is Left Only</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexIsLeftOnly
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexIsLeftOnly, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexIsLeftOnly, value);
        }

        /// <summary>Main 3rd Texture is Right Only</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexIsRightOnly
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexIsRightOnly, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexIsRightOnly, value);
        }

        /// <summary>Main 3rd Texture Should Copy</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexShouldCopy
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexShouldCopy, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexShouldCopy, value);
        }

        /// <summary>Main 3rd Texture Should Flip Mirror</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexShouldFlipMirror
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexShouldFlipMirror, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexShouldFlipMirror, value);
        }

        /// <summary>Main 3rd Texture Should Flip Copy</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexShouldFlipCopy
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexShouldFlipCopy, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexShouldFlipCopy, value);
        }

        /// <summary>Main 3rd Texture is MSDF</summary>
        //[DefaultValue(false)]
        public bool Main3rdTexIsMSDF
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdTexIsMSDF, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdTexIsMSDF, value);
        }

        /// <summary>Main 3rd Blend Mask</summary>
        public Texture2D? Main3rdBlendMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main3rdBlendMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main3rdBlendMask, value);
        }

        /// <summary>Main 3rd Texture Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Normal)]
        public LilBlendMode Main3rdTexBlendMode
        {
            get => _Material.GetSafeEnum<LilBlendMode>(PropertyNameID.Main3rdTexBlendMode, LilBlendMode.Normal);
            set => _Material.SetSafeInt(PropertyNameID.Main3rdTexBlendMode, (int)value);
        }

        /// <summary>Main 3rd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilAlphaMaskMode.None)]
        public LilAlphaMaskMode Main3rdTexAlphaMode
        {
            get => _Material.GetSafeEnum<LilAlphaMaskMode>(PropertyNameID.Main3rdTexAlphaMode, LilAlphaMaskMode.None);
            set => _Material.SetSafeInt(PropertyNameID.Main3rdTexAlphaMode, (int)value);
        }
        //{
        //    get => _Material.GetSafeEnum<LilTransparentMode>(PropertyNameID.Main3rdTexAlphaMode, LilTransparentMode.Normal);
        //    set => _Material.SetSafeInt(PropertyNameID.Main3rdTexAlphaMode, (int) value);
        //}

        /// <summary>Main 3rd Enable Lighting</summary>
        //[DefaultValue(true)]
        public bool Main3rdEnableLighting
        {
            get => _Material.GetSafeBool(PropertyNameID.Main3rdEnableLighting, false);
            set => _Material.SetSafeBool(PropertyNameID.Main3rdEnableLighting, value);
        }

        /// <summary>Main 3rd Dissolve Mask</summary>
        public Texture2D? Main3rdDissolveMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main3rdDissolveMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main3rdDissolveMask, value);
        }

        /// <summary>Main 3rd Dissolve Noise Mask</summary>
        public Texture2D? Main3rdDissolveNoiseMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.Main3rdDissolveNoiseMask);
            set => _Material.SetSafeTexture(PropertyNameID.Main3rdDissolveNoiseMask, value);
        }

        /// <summary>Main 3rd Dissolve Noise Mask Scroll Rotate</summary>
        public Vector4 Main3rdDissolveNoiseMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdDissolveNoiseMask_ScrollRotate);
            set => _Material.SetSafeVector(PropertyNameID.Main3rdDissolveNoiseMask_ScrollRotate, value);
        }

        /// <summary>Main 3rd Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        public float Main3rdDissolveNoiseStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.Main3rdDissolveNoiseStrength, 0.1f);
            set => _Material.SetSafeFloat(PropertyNameID.Main3rdDissolveNoiseStrength, value);
        }

        /// <summary>Main 3rd Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Main3rdDissolveColor
        {
            get => _Material.GetSafeColor(PropertyNameID.Main3rdDissolveColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.Main3rdDissolveColor, value);
        }

        /// <summary>Main 3rd Dissolve Parameters</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        public Vector4 Main3rdDissolveParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdDissolveParams, new Vector4(0.0f, 0.0f, 0.5f, 0.1f));
            set => _Material.SetSafeVector(PropertyNameID.Main3rdDissolveParams, value);
        }

        /// <summary>Main 3rd Dissolve Position</summary>
        public Vector4 Main3rdDissolvePos
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdDissolvePos);
            set => _Material.SetSafeVector(PropertyNameID.Main3rdDissolvePos, value);
        }

        /// <summary>Main 3rd Distance Fade</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        public Vector4 Main3rdDistanceFade
        {
            get => _Material.GetSafeVector4(PropertyNameID.Main3rdDistanceFade);
            set => _Material.SetSafeVector(PropertyNameID.Main3rdDistanceFade, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilMain3rdMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilMain3rdMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}