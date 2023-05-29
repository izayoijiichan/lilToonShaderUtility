// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_4_0
// @Class     : ILilMain2nd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_4_0
{
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Main 2nd Interface
    /// </summary>
    public interface ILilMain2nd
    {
        /// <summary>Use Main 2nd Texture</summary>
        //[DefaultValue(false)]
        bool UseMain2ndTex { get; set; }

        /// <summary>Main 2nd Color</summary>
        //[DefaultValue(0,1,1,1)]
        Color Color2nd { get; set; }

        /// <summary>Main 2nd Texture</summary>
        Texture2D Main2ndTex { get; set; }

        /// <summary>Main 2nd Texture Angle</summary>
        //[DefaultValue(0)]
        float Main2ndTexAngle { get; set; }

        /// <summary>Main 2nd Texture Scroll Rotate</summary>
        /// <remarks>
        /// Angle|UV Animation|Scroll|Rotate
        /// v1.3.7 added
        /// </remarks>
        //[DefaultValue(0,0,0,0)]
        Vector4 Main2ndTex_ScrollRotate { get; set; }

        /// <summary>Main 2nd Texture UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        LilMainUVMode Main2ndTex_UVMode { get; set; }

        /// <summary>Main 2nd Texture Cull Mode</summary>
        /// <remarks>v1.3.1 added</remarks>
        //[DefaultValue(CullMode.Off)]
        CullMode Main2ndTex_Cull { get; set; }

        /// <summary>Main 2nd Texture Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        //[DefaultValue(1,1,1,30)]
        Vector4 Main2ndTexDecalAnimation { get; set; }

        /// <summary>Main 2nd Texture Decal Sub Param</summary>
        /// <remarks>Ratio X|Ratio Y|Fix Border</remarks>
        //[DefaultValue(1,1,0,1)]
        Vector4 Main2ndTexDecalSubParam { get; set; }

        /// <summary>Main 2nd Texture Is Decal</summary>
        //[DefaultValue(false)]
        bool Main2ndTexIsDecal { get; set; }

        /// <summary>Main 2nd Texture Is Left Only</summary>
        //[DefaultValue(false)]
        bool Main2ndTexIsLeftOnly { get; set; }

        /// <summary>Main 2nd Texture Is Right Only</summary>
        //[DefaultValue(false)]
        bool Main2ndTexIsRightOnly { get; set; }

        /// <summary>Main 2nd Texture Should Copy</summary>
        //[DefaultValue(false)]
        bool Main2ndTexShouldCopy { get; set; }

        /// <summary>Main 2nd Texture Should Flip Mirror</summary>
        //[DefaultValue(false)]
        bool Main2ndTexShouldFlipMirror { get; set; }

        /// <summary>Main 2nd Texture Should Flip Copy</summary>
        //[DefaultValue(false)]
        bool Main2ndTexShouldFlipCopy { get; set; }

        /// <summary>Main 2nd Texture Is MSDF</summary>
        //[DefaultValue(false)]
        bool Main2ndTexIsMSDF { get; set; }

        /// <summary>Main 2nd Blend Mask</summary>
        Texture2D Main2ndBlendMask { get; set; }

        /// <summary>Main 2nd Texture Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Normal)]
        LilBlendMode Main2ndTexBlendMode { get; set; }

        /// <summary>Main 2nd Texture Alpha Mask Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilAlphaMaskMode.None)]
        LilAlphaMaskMode Main2ndTexAlphaMode { get; set; }
        //LilTransparentMode Main2ndTexAlphaMode { get; set; }

        /// <summary>Main 2nd Enable Lighting</summary>
        //[DefaultValue(true)]
        bool Main2ndEnableLighting { get; set; }

        /// <summary>Main 2nd Dissolve Mask</summary>
        Texture2D Main2ndDissolveMask { get; set; }

        /// <summary>Main 2nd Dissolve Noise Mask</summary>
        Texture2D Main2ndDissolveNoiseMask { get; set; }

        /// <summary>Main 2nd Dissolve Noise Mask Scroll Rotate</summary>
        Vector4 Main2ndDissolveNoiseMask_ScrollRotate { get; set; }

        /// <summary>Main 2nd Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        float Main2ndDissolveNoiseStrength { get; set; }

        /// <summary>Main 2nd Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color Main2ndDissolveColor { get; set; }

        /// <summary>Main 2nd Dissolve Params</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        Vector4 Main2ndDissolveParams { get; set; }

        /// <summary>Main 2nd Dissolve Position</summary>
        Vector4 Main2ndDissolvePos { get; set; }

        /// <summary>Main 2nd Distance Fade</summary>
        /// <remarks>Start Distance|End Distance|Strength|Backface Force Shadow</remarks>
        Vector4 Main2ndDistanceFade { get; set; }
    }
}