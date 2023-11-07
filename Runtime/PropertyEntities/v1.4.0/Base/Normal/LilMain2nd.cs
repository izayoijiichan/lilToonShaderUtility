// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : LilMain2nd
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_4_0
{
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Main 2nd
    /// </summary>
    public class LilMain2nd : ILilMain2nd
    {
        /// <summary>Use Main 2nd Texture</summary>
        //[DefaultValue(false)]
        public bool UseMain2ndTex { get; set; }

        /// <summary>Main 2nd Color</summary>
        //[DefaultValue(0,1,1,1)]
        public Color Color2nd { get; set; }

        /// <summary>Main 2nd Texture</summary>
        public Texture2D? Main2ndTex { get; set; }

        /// <summary>Main 2nd Texture Angle</summary>
        //[DefaultValue(0)]
        public float Main2ndTexAngle { get; set; }

        /// <summary>Main 2nd Texture Scroll Rotate</summary>
        /// <remarks>
        /// Angle|UV Animation|Scroll|Rotate
        /// v1.3.7 added
        /// </remarks>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Main2ndTex_ScrollRotate { get; set; }

        /// <summary>Main 2nd Texture UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        public LilMainUVMode Main2ndTex_UVMode { get; set; }

        /// <summary>Main 2nd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(CullMode.Off)]
        public CullMode Main2ndTex_Cull { get; set; }

        /// <summary>Main 2nd Texture Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        //[DefaultValue(1,1,1,30)]
        public Vector4 Main2ndTexDecalAnimation { get; set; }

        /// <summary>Main 2nd Texture Decal Sub Parameter</summary>
        /// <remarks>Ratio X|Ratio Y|Fix Border</remarks>
        //[DefaultValue(1,1,0,1)]
        public Vector4 Main2ndTexDecalSubParam { get; set; }

        /// <summary>Main 2nd Texture is Decal</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsDecal { get; set; }

        /// <summary>Main 2nd Texture is Left Only</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsLeftOnly { get; set; }

        /// <summary>Main 2nd Texture is Right Only</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsRightOnly { get; set; }

        /// <summary>Main 2nd Texture Should Copy</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldCopy { get; set; }

        /// <summary>Main 2nd Texture Should Flip Mirror</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldFlipMirror { get; set; }

        /// <summary>Main 2nd Texture Should Flip Copy</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexShouldFlipCopy { get; set; }

        /// <summary>Main 2nd Texture is MSDF</summary>
        //[DefaultValue(false)]
        public bool Main2ndTexIsMSDF { get; set; }

        /// <summary>Main 2nd Blend Mask</summary>
        public Texture2D? Main2ndBlendMask { get; set; }

        /// <summary>Main 2nd Texture Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Normal)]
        public LilBlendMode Main2ndTexBlendMode { get; set; }

        /// <summary>Main 2nd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilAlphaMaskMode.None)]
        public LilAlphaMaskMode Main2ndTexAlphaMode { get; set; }
        //public LilTransparentMode Main2ndTexAlphaMode { get; set; }

        /// <summary>Main 2nd Enable Lighting</summary>
        //[DefaultValue(true)]
        public bool Main2ndEnableLighting { get; set; }

        /// <summary>Main 2nd Dissolve Mask</summary>
        public Texture2D? Main2ndDissolveMask { get; set; }

        /// <summary>Main 2nd Dissolve Noise Mask</summary>
        public Texture2D? Main2ndDissolveNoiseMask { get; set; }

        /// <summary>Main 2nd Dissolve Noise Mask Scroll Rotate</summary>
        public Vector4 Main2ndDissolveNoiseMask_ScrollRotate { get; set; }

        /// <summary>Main 2nd Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        public float Main2ndDissolveNoiseStrength { get; set; }

        /// <summary>Main 2nd Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Main2ndDissolveColor { get; set; }

        /// <summary>Main 2nd Dissolve Parameters</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        public Vector4 Main2ndDissolveParams { get; set; }

        /// <summary>Main 2nd Dissolve Position</summary>
        public Vector4 Main2ndDissolvePos { get; set; }

        /// <summary>Main 2nd Distance Fade</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        public Vector4 Main2ndDistanceFade { get; set; }
    }
}