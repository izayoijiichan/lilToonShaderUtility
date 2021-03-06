// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : PropertyName
// ----------------------------------------------------------------------
namespace LilToonShader
{
    /// <summary>
    /// Property Name
    /// </summary>
    public class PropertyName
    {
        #region Base

        /// <summary>Invisible</summary>
        public const string Invisible = "_Invisible";

        ///// <summary>As Unlit</summary>
        ///// <remarks>Lighting Advanced</remarks>
        //public const string AsUnlit = "_AsUnlit";

        ///// <summary>Alpha Cutoff</summary>
        ///// <remarks>Rendering</remarks>
        //public const string Cutoff = "_Cutoff";

        ///// <summary>Subpass Alpha Cutoff</summary>
        ///// <remarks>Rendering</remarks>
        //public const string SubpassCutoff = "_SubpassCutoff";

        /// <summary>Flip Backface Normal</summary>
        public const string FlipNormal = "_FlipNormal";

        /// <summary>Shift Backface UV</summary>
        /// <remarks>UV</remarks>
        public const string ShiftBackfaceUV = "_ShiftBackfaceUV";

        /// <summary>Backface Force Shadow</summary>
        public const string BackfaceForceShadow = "_BackfaceForceShadow";

        /// <summary>Backface Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string BackfaceColor = "_BackfaceColor";

        #endregion

        #region Lighting

        /// <summary>Light Min Limit</summary>
        public const string LightMinLimit = "_LightMinLimit";

        /// <summary>Light Max Limit</summary>
        public const string LightMaxLimit = "_LightMaxLimit";

        /// <summary>Monochrome Lighting</summary>
        public const string MonochromeLighting = "_MonochromeLighting";

        #endregion

        #region Lighting Advanced

        /// <summary>As Unlit</summary>
        /// <remarks>Base</remarks>
        public const string AsUnlit = "_AsUnlit";

        /// <summary>Cutoff</summary>
        public const string VertexLightStrength = "_VertexLightStrength";

        /// <summary>Light Direction Override</summary>
        public const string LightDirectionOverride = "_LightDirectionOverride";

        /// <summary>Alpha Boost ForwardAdd</summary>
        public const string AlphaBoostFA = "_AlphaBoostFA";

        /// <summary>Before Exposure Limit</summary>
        public const string BeforeExposureLimit = "_BeforeExposureLimit";

        /// <summary>Directional Light Strength</summary>
        public const string LilDirectionalLightStrength = "_lilDirectionalLightStrength";

        #endregion

        #region Main

        /// <summary>Color</summary>
        public const string Color = "_Color";

        /// <summary>Main Texture</summary>
        public const string MainTex = "_MainTex";

        /// <summary>Main Tex Scroll Rotate</summary>
        public const string MainTex_ScrollRotate = "_MainTex_ScrollRotate";

        /// <summary>Main Tex HSVG</summary>
        public const string MainTexHSVG = "_MainTexHSVG";

        /// <summary>Main Gradation Strength</summary>
        public const string MainGradationStrength = "_MainGradationStrength";

        /// <summary>Main Gradation Texture</summary>
        public const string MainGradationTex = "_MainGradationTex";

        /// <summary>Main Color Adjust Mask</summary>
        public const string MainColorAdjustMask = "_MainColorAdjustMask";

        #endregion

        #region Main 2nd

        /// <summary>Use Main 2nd Texture</summary>
        public const string UseMain2ndTex = "_UseMain2ndTex";

        /// <summary>Main 2nd Color</summary>
        public const string Color2nd = "_Color2nd";

        /// <summary>Main 2nd Texture</summary>
        public const string Main2ndTex = "_Main2ndTex";

        /// <summary>Main 2nd Texture UV Mode</summary>
        public const string Main2ndTex_UVMode = "_Main2ndTex_UVMode";

        /// <summary>Main 2nd Texture Angle</summary>
        public const string Main2ndTexAngle = "_Main2ndTexAngle";

        /// <summary>Main 2nd Texture Decal Animation</summary>
        public const string Main2ndTexDecalAnimation = "_Main2ndTexDecalAnimation";

        /// <summary>Main 2nd Texture Decal Sub Param</summary>
        public const string Main2ndTexDecalSubParam = "_Main2ndTexDecalSubParam";

        /// <summary>Main 2nd Texture Is Decal</summary>
        public const string Main2ndTexIsDecal = "_Main2ndTexIsDecal";

        /// <summary>Main 2nd Texture Is Left Only</summary>
        public const string Main2ndTexIsLeftOnly = "_Main2ndTexIsLeftOnly";

        /// <summary>Main 2nd Texture Is Right Only</summary>
        public const string Main2ndTexIsRightOnly = "_Main2ndTexIsRightOnly";

        /// <summary>Main 2nd Texture Should Copy</summary>
        public const string Main2ndTexShouldCopy = "_Main2ndTexShouldCopy";

        /// <summary>Main 2nd Texture Should Flip Mirror</summary>
        public const string Main2ndTexShouldFlipMirror = "_Main2ndTexShouldFlipMirror";

        /// <summary>Main 2nd Texture Should Flip Copy</summary>
        public const string Main2ndTexShouldFlipCopy = "_Main2ndTexShouldFlipCopy";

        /// <summary>Main 2nd Texture Is MSDF</summary>
        public const string Main2ndTexIsMSDF = "_Main2ndTexIsMSDF";

        /// <summary>Main 2nd Blend Mask</summary>
        public const string Main2ndBlendMask = "_Main2ndBlendMask";

        /// <summary>Main 2nd Texture Blend Mode</summary>
        public const string Main2ndTexBlendMode = "_Main2ndTexBlendMode";

        /// <summary>Main 2nd Enable Lighting</summary>
        public const string Main2ndEnableLighting = "_Main2ndEnableLighting";

        /// <summary>Main 2nd Dissolve Mask</summary>
        public const string Main2ndDissolveMask = "_Main2ndDissolveMask";

        /// <summary>Main 2nd Dissolve Noise Mask</summary>
        public const string Main2ndDissolveNoiseMask = "_Main2ndDissolveNoiseMask";

        /// <summary>Main 2nd Dissolve Noise Mask Scroll Rotate</summary>
        public const string Main2ndDissolveNoiseMask_ScrollRotate = "_Main2ndDissolveNoiseMask_ScrollRotate";

        /// <summary>Main 2nd Dissolve Noise Strength</summary>
        public const string Main2ndDissolveNoiseStrength = "_Main2ndDissolveNoiseStrength";

        /// <summary>Main 2nd Dissolve Color</summary>
        public const string Main2ndDissolveColor = "_Main2ndDissolveColor";

        /// <summary>Main 2nd Dissolve Params</summary>
        public const string Main2ndDissolveParams = "_Main2ndDissolveParams";

        /// <summary>Main 2nd Dissolve Position</summary>
        public const string Main2ndDissolvePos = "_Main2ndDissolvePos";

        /// <summary>Main 2nd Distance Fade</summary>
        public const string Main2ndDistanceFade = "_Main2ndDistanceFade";

        #endregion

        #region Main 3rd

        /// <summary>Use Main 3rd Texture</summary>
        public const string UseMain3rdTex = "_UseMain3rdTex";

        /// <summary>Main 3rd Color</summary>
        public const string Color3rd = "_Color3rd";

        /// <summary>Main 3rd Texture</summary>
        public const string Main3rdTex = "_Main3rdTex";

        /// <summary>Main 3rd Texture UV Mode</summary>
        public const string Main3rdTex_UVMode = "_Main3rdTex_UVMode";

        /// <summary>Main 3rd Texture Angle</summary>
        public const string Main3rdTexAngle = "_Main3rdTexAngle";

        /// <summary>Main 3rd Texture Decal Animation</summary>
        public const string Main3rdTexDecalAnimation = "_Main3rdTexDecalAnimation";

        /// <summary>Main 3rd Texture Decal Sub Param</summary>
        public const string Main3rdTexDecalSubParam = "_Main3rdTexDecalSubParam";

        /// <summary>Main 3rd Texture Is Decal</summary>
        public const string Main3rdTexIsDecal = "_Main3rdTexIsDecal";

        /// <summary>Main 3rd Texture Is Left Only</summary>
        public const string Main3rdTexIsLeftOnly = "_Main3rdTexIsLeftOnly";

        /// <summary>Main 3rd Texture Is Right Only</summary>
        public const string Main3rdTexIsRightOnly = "_Main3rdTexIsRightOnly";

        /// <summary>Main 3rd Texture Should Copy</summary>
        public const string Main3rdTexShouldCopy = "_Main3rdTexShouldCopy";

        /// <summary>Main 3rd Texture Should Flip Mirror</summary>
        public const string Main3rdTexShouldFlipMirror = "_Main3rdTexShouldFlipMirror";

        /// <summary>Main 3rd Texture Should Flip Copy</summary>
        public const string Main3rdTexShouldFlipCopy = "_Main3rdTexShouldFlipCopy";

        /// <summary>Main 3rd Texture Is MSDF</summary>
        public const string Main3rdTexIsMSDF = "_Main3rdTexIsMSDF";

        /// <summary>Main 3rd Blend Mask</summary>
        public const string Main3rdBlendMask = "_Main3rdBlendMask";

        /// <summary>Main 3rd Texture Blend Mode</summary>
        public const string Main3rdTexBlendMode = "_Main3rdTexBlendMode";

        /// <summary>Main 3rd Enable Lighting</summary>
        public const string Main3rdEnableLighting = "_Main3rdEnableLighting";

        /// <summary>Main 3rd Dissolve Mask</summary>
        public const string Main3rdDissolveMask = "_Main3rdDissolveMask";

        /// <summary>Main 3rd Dissolve Noise Mask</summary>
        public const string Main3rdDissolveNoiseMask = "_Main3rdDissolveNoiseMask";

        /// <summary>Main 3rd Dissolve Noise Mask Scroll Rotate</summary>
        public const string Main3rdDissolveNoiseMask_ScrollRotate = "_Main3rdDissolveNoiseMask_ScrollRotate";

        /// <summary>Main 3rd Dissolve Noise Strength</summary>
        public const string Main3rdDissolveNoiseStrength = "_Main3rdDissolveNoiseStrength";

        /// <summary>Main 3rd Dissolve Color</summary>
        public const string Main3rdDissolveColor = "_Main3rdDissolveColor";

        /// <summary>Main 3rd Dissolve Params</summary>
        public const string Main3rdDissolveParams = "_Main3rdDissolveParams";

        /// <summary>Main 3rd Dissolve Position</summary>
        public const string Main3rdDissolvePos = "_Main3rdDissolvePos";

        /// <summary>Main 3rd Distance Fade</summary>
        public const string Main3rdDistanceFade = "_Main3rdDistanceFade";

        #endregion

        #region Alpha Mask

        /// <summary>Alpha Mask Mode</summary>
        public const string AlphaMaskMode = "_AlphaMaskMode";

        /// <summary>Alpha Mask</summary>
        public const string AlphaMask = "_AlphaMask";

        /// <summary>Alpha Mask Scale</summary>
        public const string AlphaMaskScale = "_AlphaMaskScale";

        /// <summary>Alpha Mask Offset</summary>
        public const string AlphaMaskValue = "_AlphaMaskValue";

        #endregion

        #region Normal Map

        /// <summary>Use Bump Map</summary>
        public const string UseBumpMap = "_UseBumpMap";

        /// <summary>Bump Map</summary>
        public const string BumpMap = "_BumpMap";

        /// <summary>Bump Scale</summary>
        public const string BumpScale = "_BumpScale";

        #endregion

        #region Normal Map 2nd

        /// <summary>UseBump 2nd Map</summary>
        public const string UseBump2ndMap = "_UseBump2ndMap";

        /// <summary>Bump 2nd Map</summary>
        public const string Bump2ndMap = "_Bump2ndMap";

        /// <summary>Bump 2nd Scale</summary>
        public const string Bump2ndScale = "_Bump2ndScale";

        /// <summary>Bump 2nd Scale Mask</summary>
        public const string Bump2ndScaleMask = "_Bump2ndScaleMask";

        #endregion

        #region Anisotropy

        /// <summary>Use Anisotropy</summary>
        public const string UseAnisotropy = "_UseAnisotropy";

        /// <summary>Anisotropy Tangent Map</summary>
        public const string AnisotropyTangentMap = "_AnisotropyTangentMap";

        /// <summary>Anisotropy Scale</summary>
        public const string AnisotropyScale = "_AnisotropyScale";

        /// <summary>Anisotropy Scale Mask</summary>
        public const string AnisotropyScaleMask = "_AnisotropyScaleMask";

        /// <summary>Anisotropy Tangent Width</summary>
        public const string AnisotropyTangentWidth = "_AnisotropyTangentWidth";

        /// <summary>Anisotropy Bitangent Width</summary>
        public const string AnisotropyBitangentWidth = "_AnisotropyBitangentWidth";

        /// <summary>Anisotropy Shift</summary>
        public const string AnisotropyShift = "_AnisotropyShift";

        /// <summary>Anisotropy Shift Noise Scale</summary>
        public const string AnisotropyShiftNoiseScale = "_AnisotropyShiftNoiseScale";

        /// <summary>Anisotropy Specular Strength</summary>
        public const string AnisotropySpecularStrength = "_AnisotropySpecularStrength";

        /// <summary>Anisotropy 2nd Tangent Width</summary>
        public const string Anisotropy2ndTangentWidth = "_Anisotropy2ndTangentWidth";

        /// <summary>Anisotropy 2nd Bitangent Width</summary>
        public const string Anisotropy2ndBitangentWidth = "_Anisotropy2ndBitangentWidth";

        /// <summary>Anisotropy 2nd Shift</summary>
        public const string Anisotropy2ndShift = "_Anisotropy2ndShift";

        /// <summary>Anisotropy 2nd Shift Noise Scale</summary>
        public const string Anisotropy2ndShiftNoiseScale = "_Anisotropy2ndShiftNoiseScale";

        /// <summary>Anisotropy 2nd Specular Strength</summary>
        public const string Anisotropy2ndSpecularStrength = "_Anisotropy2ndSpecularStrength";

        /// <summary>Anisotropy Shift Noise Mask</summary>
        public const string AnisotropyShiftNoiseMask = "_AnisotropyShiftNoiseMask";

        /// <summary>Anisotropy 2 Reflection</summary>
        public const string Anisotropy2Reflection = "_Anisotropy2Reflection";

        /// <summary>Anisotropy 2 Mat Cap</summary>
        public const string Anisotropy2MatCap = "_Anisotropy2MatCap";

        /// <summary>Anisotropy 2 Mat Cap 2nd</summary>
        public const string Anisotropy2MatCap2nd = "_Anisotropy2MatCap2nd";

        #endregion

        #region Backlight

        /// <summary>Use Backlight</summary>
        public const string UseBacklight = "_UseBacklight";

        /// <summary>Backlight Color</summary>
        public const string BacklightColor = "_BacklightColor";

        /// <summary>Backlight Color Tex</summary>
        public const string BacklightColorTex = "_BacklightColorTex";

        /// <summary>Backlight Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string BacklightMainStrength = "_BacklightMainStrength";

        /// <summary>Backlight Normal Strength</summary>
        public const string BacklightNormalStrength = "_BacklightNormalStrength";

        /// <summary>Backlight Border</summary>
        public const string BacklightBorder = "_BacklightBorder";

        /// <summary>Backlight Blur</summary>
        public const string BacklightBlur = "_BacklightBlur";

        /// <summary>Backlight Directivity</summary>
        public const string BacklightDirectivity = "_BacklightDirectivity";

        /// <summary>Backlight View Strength</summary>
        public const string BacklightViewStrength = "_BacklightViewStrength";

        /// <summary>Backlight Receive Shadow</summary>
        public const string BacklightReceiveShadow = "_BacklightReceiveShadow";

        /// <summary>Backlight Backface Mask</summary>
        public const string BacklightBackfaceMask = "_BacklightBackfaceMask";

        #endregion

        #region Shadow

        /// <summary>Use Shadow</summary>
        public const string UseShadow = "_UseShadow";

        /// <summary>Shadow Strength</summary>
        public const string ShadowStrength = "_ShadowStrength";

        /// <summary>Shadow Strength Mask</summary>
        public const string ShadowStrengthMask = "_ShadowStrengthMask";

        /// <summary>Shadow Strength Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowStrengthMaskLOD = "_ShadowStrengthMaskLOD";

        /// <summary>Shadow Border Mask</summary>
        public const string ShadowBorderMask = "_ShadowBorderMask";

        /// <summary>Shadow Border Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowBorderMaskLOD = "_ShadowBorderMaskLOD";

        /// <summary>Shadow Blur Mask</summary>
        public const string ShadowBlurMask = "_ShadowBlurMask";

        /// <summary>Shadow Blur Mask LOD</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowBlurMaskLOD = "_ShadowBlurMaskLOD";

        /// <summary>Shadow AO Shift</summary>
        public const string ShadowAOShift = "_ShadowAOShift";

        /// <summary>Shadow AO Shift2</summary>
        public const string ShadowAOShift2 = "_ShadowAOShift2";

        /// <summary>Shadow Post AO</summary>
        public const string ShadowPostAO = "_ShadowPostAO";

        /// <summary>Shadow Color</summary>
        public const string ShadowColor = "_ShadowColor";

        /// <summary>Shadow Color Tex</summary>
        public const string ShadowColorTex = "_ShadowColorTex";

        /// <summary>Shadow Normal Strength</summary>
        public const string ShadowNormalStrength = "_ShadowNormalStrength";

        /// <summary>Shadow Border</summary>
        public const string ShadowBorder = "_ShadowBorder";

        /// <summary>Shadow Blur</summary>
        public const string ShadowBlur = "_ShadowBlur";

        /// <summary>Shadow Receive</summary>
        public const string ShadowReceive = "_ShadowReceive";

        /// <summary>Shadow 2nd Color</summary>
        public const string Shadow2ndColor = "_Shadow2ndColor";

        /// <summary>Shadow 2nd Color Tex</summary>
        public const string Shadow2ndColorTex = "_Shadow2ndColorTex";

        /// <summary>Shadow 2nd Normal Strength</summary>
        public const string Shadow2ndNormalStrength = "_Shadow2ndNormalStrength";

        /// <summary>Shadow 2nd Border</summary>
        public const string Shadow2ndBorder = "_Shadow2ndBorder";

        /// <summary>Shadow 2nd Blur</summary>
        public const string Shadow2ndBlur = "_Shadow2ndBlur";

        /// <summary>Receive Shadow 2nd</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string Shadow2ndReceive = "_Shadow2ndReceive";

        /// <summary>Shadow 3rd Color</summary>
        public const string Shadow3rdColor = "_Shadow3rdColor";

        /// <summary>Shadow 3rd ColorTex</summary>
        public const string Shadow3rdColorTex = "_Shadow3rdColorTex";

        /// <summary>Shadow 3rd Normal Strength</summary>
        public const string Shadow3rdNormalStrength = "_Shadow3rdNormalStrength";

        /// <summary>Shadow 3rd Border</summary>
        public const string Shadow3rdBorder = "_Shadow3rdBorder";

        /// <summary>Shadow 3rd Blur</summary>
        public const string Shadow3rdBlur = "_Shadow3rdBlur";

        /// <summary>Receive Shadow 3rd</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string Shadow3rdReceive = "_Shadow3rdReceive";

        /// <summary>Shadow Main Strength</summary>
        public const string ShadowMainStrength = "_ShadowMainStrength";

        /// <summary>Shadow Environment Strength</summary>
        public const string ShadowEnvStrength = "_ShadowEnvStrength";

        /// <summary>Shadow Border Color</summary>
        public const string ShadowBorderColor = "_ShadowBorderColor";

        /// <summary>Shadow Border Range</summary>
        public const string ShadowBorderRange = "_ShadowBorderRange";

        /// <summary>Shadow Mask Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowMaskType = "_ShadowMaskType";

        /// <summary>Shadow Flat Border</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowFlatBorder = "_ShadowFlatBorder";

        /// <summary>Shadow Flat Blur</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ShadowFlatBlur = "_ShadowFlatBlur";

        #endregion

        #region Reflection

        /// <summary>Use Reflection</summary>
        public const string UseReflection = "_UseReflection";

        /// <summary>Smoothness</summary>
        public const string Smoothness = "_Smoothness";

        /// <summary>Smoothness Texture</summary>
        public const string SmoothnessTex = "_SmoothnessTex";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Metallic Gloss Map</summary>
        public const string MetallicGlossMap = "_MetallicGlossMap";

        /// <summary>Reflectance</summary>
        public const string Reflectance = "_Reflectance";

        /// <summary>GSAA Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GSAAStrength = "_GSAAStrength";

        /// <summary>Apply Specular</summary>
        public const string ApplySpecular = "_ApplySpecular";

        /// <summary>Apply Specular in ForwardAdd</summary>
        public const string ApplySpecularFA = "_ApplySpecularFA";

        /// <summary>Specular Toon</summary>
        public const string SpecularToon = "_SpecularToon";

        /// <summary>Specular Normal Strength</summary>
        public const string SpecularNormalStrength = "_SpecularNormalStrength";

        /// <summary>Specular Border</summary>
        public const string SpecularBorder = "_SpecularBorder";

        /// <summary>Specular Blur</summary>
        public const string SpecularBlur = "_SpecularBlur";

        /// <summary>Apply Reflection</summary>
        public const string ApplyReflection = "_ApplyReflection";

        /// <summary>Reflection Normal Strength</summary>
        public const string ReflectionNormalStrength = "_ReflectionNormalStrength";

        /// <summary>Reflection Color</summary>
        public const string ReflectionColor = "_ReflectionColor";

        /// <summary>Reflection Color Texture</summary>
        public const string ReflectionColorTex = "_ReflectionColorTex";

        /// <summary>Reflection Apply Transparency</summary>
        public const string ReflectionApplyTransparency = "_ReflectionApplyTransparency";

        /// <summary>Reflection Cube Tex</summary>
        public const string ReflectionCubeTex = "_ReflectionCubeTex";

        /// <summary>Reflection Cube Color</summary>
        public const string ReflectionCubeColor = "_ReflectionCubeColor";

        /// <summary>Reflection Cube Override</summary>
        public const string ReflectionCubeOverride = "_ReflectionCubeOverride";

        /// <summary>Reflection Cube Enable Lighting</summary>
        public const string ReflectionCubeEnableLighting = "_ReflectionCubeEnableLighting";

        /// <summary>Reflection Blend Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string ReflectionBlendMode = "_ReflectionBlendMode";

        #endregion

        #region MatCap

        /// <summary>Use Mat Cap</summary>
        public const string UseMatCap = "_UseMatCap";

        /// <summary>Mat Cap Color</summary>
        public const string MatCapColor = "_MatCapColor";

        /// <summary>Mat Cap Texture</summary>
        public const string MatCapTex = "_MatCapTex";

        /// <summary>Mat Cap Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string MatCapMainStrength = "_MatCapMainStrength";

        /// <summary>Mat Cap Blend UV1</summary>
        public const string MatCapBlendUV1 = "_MatCapBlendUV1";

        /// <summary>Mat Cap Z-axis Rotation Cancel</summary>
        public const string MatCapZRotCancel = "_MatCapZRotCancel";

        /// <summary>Mat Cap Perspective</summary>
        public const string MatCapPerspective = "_MatCapPerspective";

        /// <summary>Mat Cap VR Parallax Strength</summary>
        public const string MatCapVRParallaxStrength = "_MatCapVRParallaxStrength";

        /// <summary>Mat Cap Blend</summary>
        public const string MatCapBlend = "_MatCapBlend";

        /// <summary>Mat Cap Blend Mask</summary>
        public const string MatCapBlendMask = "_MatCapBlendMask";

        /// <summary>Mat Cap Enable Lighting</summary>
        public const string MatCapEnableLighting = "_MatCapEnableLighting";

        /// <summary>Mat Cap Shadow Mask</summary>
        public const string MatCapShadowMask = "_MatCapShadowMask";

        /// <summary>Mat Cap Backface Mask</summary>
        public const string MatCapBackfaceMask = "_MatCapBackfaceMask";

        /// <summary>Mat Cap Lod</summary>
        public const string MatCapLod = "_MatCapLod";

        /// <summary>Mat Cap Blend Mode</summary>
        public const string MatCapBlendMode = "_MatCapBlendMode";

        /// <summary>Mat Cap Apply Transparency</summary>
        public const string MatCapApplyTransparency = "_MatCapApplyTransparency";

        /// <summary>Mat Cap Normal Strength</summary>
        public const string MatCapNormalStrength = "_MatCapNormalStrength";

        /// <summary>Mat Cap Custom Normal Map</summary>
        public const string MatCapCustomNormal = "_MatCapCustomNormal";

        /// <summary>Mat Cap Bump Map</summary>
        public const string MatCapBumpMap = "_MatCapBumpMap";

        /// <summary>Mat Cap Bump Scale</summary>
        public const string MatCapBumpScale = "_MatCapBumpScale";

        #endregion

        #region MatCap 2nd

        /// <summary>Use Mat Cap 2nd</summary>
        public const string UseMatCap2nd = "_UseMatCap2nd";

        /// <summary>Mat Cap 2nd Color</summary>
        public const string MatCap2ndColor = "_MatCap2ndColor";

        /// <summary>Mat Cap 2nd Texture</summary>
        public const string MatCap2ndTex = "_MatCap2ndTex";

        /// <summary>Mat Cap 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string MatCap2ndMainStrength = "_MatCap2ndMainStrength";

        /// <summary>Mat Cap 2nd Blend UV1</summary>
        public const string MatCap2ndBlendUV1 = "_MatCap2ndBlendUV1";

        /// <summary>Mat Cap 2nd Z-axis rotation Cancel</summary>
        public const string MatCap2ndZRotCancel = "_MatCap2ndZRotCancel";

        /// <summary>Mat Cap 2nd Perspective</summary>
        public const string MatCap2ndPerspective = "_MatCap2ndPerspective";

        /// <summary>Mat Ca p2nd VR Parallax Strength</summary>
        public const string MatCap2ndVRParallaxStrength = "_MatCap2ndVRParallaxStrength";

        /// <summary>Mat Cap 2nd Blend</summary>
        public const string MatCap2ndBlend = "_MatCap2ndBlend";

        /// <summary>Mat Cap 2nd Blend Mask</summary>
        public const string MatCap2ndBlendMask = "_MatCap2ndBlendMask";

        /// <summary>Mat Cap 2nd Enable Lighting</summary>
        public const string MatCap2ndEnableLighting = "_MatCap2ndEnableLighting";

        /// <summary>Mat Cap 2nd Shadow Mask</summary>
        public const string MatCap2ndShadowMask = "_MatCap2ndShadowMask";

        /// <summary>Mat Cap 2nd Backface Mask</summary>
        public const string MatCap2ndBackfaceMask = "_MatCap2ndBackfaceMask";

        /// <summary>Mat Cap 2nd Lod</summary>
        public const string MatCap2ndLod = "_MatCap2ndLod";

        /// <summary>Mat Cap 2nd Blend Mode</summary>
        public const string MatCap2ndBlendMode = "_MatCap2ndBlendMode";

        /// <summary>Mat Cap 2nd Apply Transparency</summary>
        public const string MatCap2ndApplyTransparency = "_MatCap2ndApplyTransparency";

        /// <summary>Mat Cap 2nd Normal Strength</summary>
        public const string MatCap2ndNormalStrength = "_MatCap2ndNormalStrength";

        /// <summary>Mat Cap 2nd Custom Normal Map</summary>
        public const string MatCap2ndCustomNormal = "_MatCap2ndCustomNormal";

        /// <summary>Mat Cap 2nd Bump Map</summary>
        public const string MatCap2ndBumpMap = "_MatCap2ndBumpMap";

        /// <summary>Mat Cap 2nd Bump Scale</summary>
        public const string MatCap2ndBumpScale = "_MatCap2ndBumpScale";

        #endregion

        #region Rim

        /// <summary>Use Rim</summary>
        public const string UseRim = "_UseRim";

        /// <summary>Rim Color</summary>
        public const string RimColor = "_RimColor";

        /// <summary>Rim Color Tex</summary>
        public const string RimColorTex = "_RimColorTex";

        /// <summary>Rim Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string RimMainStrength = "_RimMainStrength";

        /// <summary>Rim Normal Strength</summary>
        public const string RimNormalStrength = "_RimNormalStrength";

        /// <summary>Rim Border</summary>
        public const string RimBorder = "_RimBorder";

        /// <summary>Rim Blur</summary>
        public const string RimBlur = "_RimBlur";

        /// <summary>Rim Fresnel Power</summary>
        public const string RimFresnelPower = "_RimFresnelPower";

        /// <summary>Rim Enable Lighting</summary>
        public const string RimEnableLighting = "_RimEnableLighting";

        /// <summary>Rim Shadow Mask</summary>
        public const string RimShadowMask = "_RimShadowMask";

        /// <summary>Rim Backface Mask</summary>
        public const string RimBackfaceMask = "_RimBackfaceMask";

        /// <summary>Rim VR Parallax Strength</summary>
        public const string RimVRParallaxStrength = "_RimVRParallaxStrength";

        /// <summary>Rim Apply Transparency</summary>
        public const string RimApplyTransparency = "_RimApplyTransparency";

        /// <summary>Rim Direction Strength</summary>
        public const string RimDirStrength = "_RimDirStrength";

        /// <summary>Rim Direction Range</summary>
        public const string RimDirRange = "_RimDirRange";

        /// <summary>Rim Indirection Range</summary>
        public const string RimIndirRange = "_RimIndirRange";

        /// <summary>Rim Indirection Color</summary>
        public const string RimIndirColor = "_RimIndirColor";

        /// <summary>Rim Indirection Border</summary>
        public const string RimIndirBorder = "_RimIndirBorder";

        /// <summary>Rim Indir Blur</summary>
        public const string RimIndirBlur = "_RimIndirBlur";

        #endregion

        #region Glitter

        /// <summary>Use Glitter</summary>
        public const string UseGlitter = "_UseGlitter";

        /// <summary>Glitter UV Mode</summary>
        public const string GlitterUVMode = "_GlitterUVMode";

        /// <summary>Glitter Color</summary>
        public const string GlitterColor = "_GlitterColor";

        /// <summary>Glitter Color Texture</summary>
        public const string GlitterColorTex = "_GlitterColorTex";

        /// <summary>Glitter Main Strength</summary>
        public const string GlitterMainStrength = "_GlitterMainStrength";

        /// <summary>Glitter Normal Strength</summary>
        public const string GlitterNormalStrength = "_GlitterNormalStrength";

        /// <summary>Glitter Scale Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterScaleRandomize = "_GlitterScaleRandomize";

        /// <summary>Glitter Apply Shape</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterApplyShape = "_GlitterApplyShape";

        /// <summary>Glitter Shape Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterShapeTex = "_GlitterShapeTex";

        /// <summary>Glitter Atras</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterAtras = "_GlitterAtras";

        /// <summary>Glitter Angle Randomize</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterAngleRandomize = "_GlitterAngleRandomize";

        /// <summary>Glitter Params1</summary>
        public const string GlitterParams1 = "_GlitterParams1";

        /// <summary>Glitter Params2</summary>
        public const string GlitterParams2 = "_GlitterParams2";

        /// <summary>Glitter Post Contrast</summary>
        public const string GlitterPostContrast = "_GlitterPostContrast";

        /// <summary>Glitter Sensitivity</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string GlitterSensitivity = "_GlitterSensitivity";

        /// <summary>Glitter Enable Lighting</summary>
        public const string GlitterEnableLighting = "_GlitterEnableLighting";

        /// <summary>Glitter Shadow Mask</summary>
        public const string GlitterShadowMask = "_GlitterShadowMask";

        /// <summary>Glitter Backface Mask</summary>
        public const string GlitterBackfaceMask = "_GlitterBackfaceMask";

        /// <summary>Glitter Apply Transparency</summary>
        public const string GlitterApplyTransparency = "_GlitterApplyTransparency";

        /// <summary>Glitter VR Parallax Strength</summary>
        public const string GlitterVRParallaxStrength = "_GlitterVRParallaxStrength";

        #endregion

        #region Emission

        /// <summary>Use Emission</summary>
        public const string UseEmission = "_UseEmission";

        /// <summary>Emission Color</summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Emission Map</summary>
        public const string EmissionMap = "_EmissionMap";

        /// <summary>Emission Map Scroll Rotate</summary>
        public const string EmissionMap_ScrollRotate = "_EmissionMap_ScrollRotate";

        /// <summary>Emission Map UV Mode</summary>
        public const string EmissionMap_UVMode = "_EmissionMap_UVMode";

        /// <summary>Emission Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string EmissionMainStrength = "_EmissionMainStrength";

        /// <summary>Emission Blend</summary>
        public const string EmissionBlend = "_EmissionBlend";

        /// <summary>Emission Blend Mask</summary>
        public const string EmissionBlendMask = "_EmissionBlendMask";

        /// <summary>Emission Blend Mask Scroll Rotate</summary>
        public const string EmissionBlendMask_ScrollRotate = "_EmissionBlendMask_ScrollRotate";

        /// <summary>Emission Blink</summary>
        public const string EmissionBlink = "_EmissionBlink";

        /// <summary>Emission Use Gradation</summary>
        public const string EmissionUseGrad = "_EmissionUseGrad";

        /// <summary>Emission Gradation Texture</summary>
        public const string EmissionGradTex = "_EmissionGradTex";

        /// <summary>Emission Gradation Speed</summary>
        public const string EmissionGradSpeed = "_EmissionGradSpeed";

        /// <summary>Emission Parallax Depth</summary>
        public const string EmissionParallaxDepth = "_EmissionParallaxDepth";

        /// <summary>Emission Fluorescence</summary>
        public const string EmissionFluorescence = "_EmissionFluorescence";

        #endregion

        #region Emission Gradation

        /// <summary>Egci</summary>
        public const string Egci = "_egci";

        /// <summary>Egai</summary>
        public const string Egai = "_egai";

        /// <summary>Egc0</summary>
        public const string Egc0 = "_egc0";

        /// <summary>Egc1</summary>
        public const string Egc1 = "_egc1";

        /// <summary>Egc2</summary>
        public const string Egc2 = "_egc2";

        /// <summary>Egc3</summary>
        public const string Egc3 = "_egc3";

        /// <summary>Egc4</summary>
        public const string Egc4 = "_egc4";

        /// <summary>Egc5</summary>
        public const string Egc5 = "_egc5";

        /// <summary>Egc6</summary>
        public const string Egc6 = "_egc6";

        /// <summary>Egc7</summary>
        public const string Egc7 = "_egc7";

        /// <summary>Ega0</summary>
        public const string Ega0 = "_ega0";

        /// <summary>Ega1</summary>
        public const string Ega1 = "_ega1";

        /// <summary>Ega2</summary>
        public const string Ega2 = "_ega2";

        /// <summary>Ega3</summary>
        public const string Ega3 = "_ega3";

        /// <summary>Ega4</summary>
        public const string Ega4 = "_ega4";

        /// <summary>Ega5</summary>
        public const string Ega5 = "_ega5";

        /// <summary>Ega6</summary>
        public const string Ega6 = "_ega6";

        /// <summary>Ega7</summary>
        public const string Ega7 = "_ega7";

        #endregion

        #region Emission 2nd

        /// <summary>Use Emission 2nd</summary>
        public const string UseEmission2nd = "_UseEmission2nd";

        /// <summary>Emission 2nd Color</summary>
        public const string Emission2ndColor = "_Emission2ndColor";

        /// <summary>Emission 2nd Map</summary>
        public const string Emission2ndMap = "_Emission2ndMap";

        /// <summary>Emission 2nd Map Scroll Rotate</summary>
        public const string Emission2ndMap_ScrollRotate = "_Emission2ndMap_ScrollRotate";

        /// <summary>Emission 2nd Map UV Mode</summary>
        public const string Emission2ndMap_UVMode = "_Emission2ndMap_UVMode";

        /// <summary>Emission 2nd Main Strength</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string Emission2ndMainStrength = "_Emission2ndMainStrength";

        /// <summary>Emission 2nd Blend</summary>
        public const string Emission2ndBlend = "_Emission2ndBlend";

        /// <summary>Emission 2nd Blend Mask</summary>
        public const string Emission2ndBlendMask = "_Emission2ndBlendMask";

        /// <summary>Emission 2nd BlendMask Scroll Rotate</summary>
        public const string Emission2ndBlendMask_ScrollRotate = "_Emission2ndBlendMask_ScrollRotate";

        /// <summary>Emission 2nd Blink</summary>
        public const string Emission2ndBlink = "_Emission2ndBlink";

        /// <summary>Emission 2nd Use Gradation</summary>
        public const string Emission2ndUseGrad = "_Emission2ndUseGrad";

        /// <summary>Emission 2nd Gradation Texture</summary>
        public const string Emission2ndGradTex = "_Emission2ndGradTex";

        /// <summary>Emission 2nd Gradation Speed</summary>
        public const string Emission2ndGradSpeed = "_Emission2ndGradSpeed";

        /// <summary>Emission 2nd Parallax Depth</summary>
        public const string Emission2ndParallaxDepth = "_Emission2ndParallaxDepth";

        /// <summary>Emission 2nd Fluorescence</summary>
        public const string Emission2ndFluorescence = "_Emission2ndFluorescence";

        #endregion

        #region Emission 2nd Gradation

        /// <summary>E2gci</summary>
        public const string E2gci = "_e2gci";

        /// <summary>E2gai</summary>
        public const string E2gai = "_e2gai";

        /// <summary>E2gc0</summary>
        public const string E2gc0 = "_e2gc0";

        /// <summary>E2gc1</summary>
        public const string E2gc1 = "_e2gc1";

        /// <summary>E2gc2</summary>
        public const string E2gc2 = "_e2gc2";

        /// <summary>E2gc3</summary>
        public const string E2gc3 = "_e2gc3";

        /// <summary>E2gc4</summary>
        public const string E2gc4 = "_e2gc4";

        /// <summary>E2gc5</summary>
        public const string E2gc5 = "_e2gc5";

        /// <summary>E2gc6</summary>
        public const string E2gc6 = "_e2gc6";

        /// <summary>E2gc7</summary>
        public const string E2gc7 = "_e2gc7";

        /// <summary>E2ga0</summary>
        public const string E2ga0 = "_e2ga0";

        /// <summary>E2ga1</summary>
        public const string E2ga1 = "_e2ga1";

        /// <summary>E2ga2</summary>
        public const string E2ga2 = "_e2ga2";

        /// <summary>E2ga3</summary>
        public const string E2ga3 = "_e2ga3";

        /// <summary>E2ga4</summary>
        public const string E2ga4 = "_e2ga4";

        /// <summary>E2ga5</summary>
        public const string E2ga5 = "_e2ga5";

        /// <summary>E2ga6</summary>
        public const string E2ga6 = "_e2ga6";

        /// <summary>E2ga7</summary>
        public const string E2ga7 = "_e2ga7";

        #endregion

        #region Parallax

        /// <summary>Use Parallax</summary>
        public const string UseParallax = "_UseParallax";

        /// <summary>Use POM</summary>
        /// <remarks>v1.3.0 from Multi</remarks>
        public const string UsePOM = "_UsePOM";

        /// <summary>Parallax Map</summary>
        public const string ParallaxMap = "_ParallaxMap";

        /// <summary>Parallax Scale</summary>
        public const string Parallax = "_Parallax";

        /// <summary>Parallax Offset</summary>
        public const string ParallaxOffset = "_ParallaxOffset";

        #endregion

        #region Distance Fade

        /// <summary>Distance Fade</summary>
        public const string DistanceFade = "_DistanceFade";

        /// <summary>Distance Fade Color</summary>
        public const string DistanceFadeColor = "_DistanceFadeColor";

        #endregion

        #region Audio Link

        /// <summary>Use Audio Link</summary>
        public const string UseAudioLink = "_UseAudioLink";

        /// <summary>Audio Link Default Value</summary>
        public const string AudioLinkDefaultValue = "_AudioLinkDefaultValue";

        /// <summary>Audio Link UV Mode</summary>
        public const string AudioLinkUVMode = "_AudioLinkUVMode";

        /// <summary>Audio Link UV Params</summary>
        public const string AudioLinkUVParams = "_AudioLinkUVParams";

        /// <summary>Audio Link Start Position</summary>
        public const string AudioLinkStart = "_AudioLinkStart";

        /// <summary>Audio Link Mask</summary>
        public const string AudioLinkMask = "_AudioLinkMask";

        /// <summary>Audio Link 2 Main 2nd</summary>
        public const string AudioLink2Main2nd = "_AudioLink2Main2nd";

        /// <summary>Audio Link 2 Main 3rd</summary>
        public const string AudioLink2Main3rd = "_AudioLink2Main3rd";

        /// <summary>Audio Link 2 Emission</summary>
        public const string AudioLink2Emission = "_AudioLink2Emission";

        /// <summary>Audio Link 2 Emission Gradation</summary>
        public const string AudioLink2EmissionGrad = "_AudioLink2EmissionGrad";

        /// <summary>Audio Link 2 Emission 2nd</summary>
        public const string AudioLink2Emission2nd = "_AudioLink2Emission2nd";

        /// <summary>Audio Link 2 Emission 2nd Gradation</summary>
        public const string AudioLink2Emission2ndGrad = "_AudioLink2Emission2ndGrad";

        /// <summary>Audio Link 2 Vertex</summary>
        public const string AudioLink2Vertex = "_AudioLink2Vertex";

        /// <summary>Audio Link Vertex UV Mode</summary>
        public const string AudioLinkVertexUVMode = "_AudioLinkVertexUVMode";

        /// <summary>Audio Link Vertex UV Params</summary>
        public const string AudioLinkVertexUVParams = "_AudioLinkVertexUVParams";

        /// <summary>Audio Link Vertex Start Position</summary>
        public const string AudioLinkVertexStart = "_AudioLinkVertexStart";

        /// <summary>Audio Link Vertex Strength</summary>
        public const string AudioLinkVertexStrength = "_AudioLinkVertexStrength";

        /// <summary>Audio Link As Local</summary>
        public const string AudioLinkAsLocal = "_AudioLinkAsLocal";

        /// <summary>Audio Link Local Map</summary>
        public const string AudioLinkLocalMap = "_AudioLinkLocalMap";

        /// <summary>Audio Link Local Map Params</summary>
        public const string AudioLinkLocalMapParams = "_AudioLinkLocalMapParams";

        #endregion

        #region Dissolve

        /// <summary>Dissolve Mask</summary>
        public const string DissolveMask = "_DissolveMask";

        /// <summary>Dissolve Noise Mask</summary>
        public const string DissolveNoiseMask = "_DissolveNoiseMask";

        /// <summary>Dissolve Noise Mask Scroll Rotate</summary>
        public const string DissolveNoiseMask_ScrollRotate = "_DissolveNoiseMask_ScrollRotate";

        /// <summary>Dissolve Noise Strength</summary>
        public const string DissolveNoiseStrength = "_DissolveNoiseStrength";

        /// <summary>Dissolve Color</summary>
        public const string DissolveColor = "_DissolveColor";

        /// <summary>Dissolve Params</summary>
        public const string DissolveParams = "_DissolveParams";

        /// <summary>Dissolve Position</summary>
        public const string DissolvePos = "_DissolvePos";

        #endregion

        #region Encryption

        /// <summary>IgnoreEncryption</summary>
        public const string IgnoreEncryption = "_IgnoreEncryption";

        /// <summary>Keys</summary>
        public const string Keys = "_Keys";

        #endregion

        #region Refraction

        /// <summary>Refraction Strength</summary>
        public const string RefractionStrength = "_RefractionStrength";

        /// <summary>Refraction Fresnel Power</summary>
        public const string RefractionFresnelPower = "_RefractionFresnelPower";

        /// <summary>Refraction Color From Main</summary>
        public const string RefractionColorFromMain = "_RefractionColorFromMain";

        /// <summary>Refraction Color</summary>
        public const string RefractionColor = "_RefractionColor";

        #endregion

        #region Fur

        /// <summary>Fur Noise Mask</summary>
        public const string FurNoiseMask = "_FurNoiseMask";

        /// <summary>Fur Mask</summary>
        public const string FurMask = "_FurMask";

        /// <summary>Fur Length Mask</summary>
        public const string FurLengthMask = "_FurLengthMask";

        /// <summary>Fur Vector Texture</summary>
        public const string FurVectorTex = "_FurVectorTex";

        /// <summary>Fur Vector Scale</summary>
        public const string FurVectorScale = "_FurVectorScale";

        /// <summary>Fur Vector</summary>
        public const string FurVector = "_FurVector";

        /// <summary>Vertex Color to Fur Vector</summary>
        public const string VertexColor2FurVector = "_VertexColor2FurVector";

        /// <summary>Fur Gravity</summary>
        public const string FurGravity = "_FurGravity";

        /// <summary>Fur Randomize</summary>
        public const string FurRandomize = "_FurRandomize";

        /// <summary>Fur AO</summary>
        public const string FurAO = "_FurAO";

        /// <summary>Fur Mesh Type</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string FurMeshType = "_FurMeshType";

        /// <summary>Fur Layer Num</summary>
        public const string FurLayerNum = "_FurLayerNum";

        /// <summary>Fur Root Offset</summary>
        public const string FurRootOffset = "_FurRootOffset";

        /// <summary>Fur Cutout Length</summary>
        public const string FurCutoutLength = "_FurCutoutLength";

        /// <summary>Fur Touch Strength</summary>
        public const string FurTouchStrength = "_FurTouchStrength";

        #endregion

        #region Fur Rendering

        /// <summary>Fur Cull</summary>
        public const string FurCull = "_FurCull";

        /// <summary>Fur Z Clip</summary>
        public const string FurZClip = "_FurZClip";

        /// <summary>Fur Z Write</summary>
        public const string FurZWrite = "_FurZWrite";

        /// <summary>Fur Z Test</summary>
        public const string FurZTest = "_FurZTest";

        /// <summary>Fur Offset Factor</summary>
        public const string FurOffsetFactor = "_FurOffsetFactor";

        /// <summary>Fur Offset Units</summary>
        public const string FurOffsetUnits = "_FurOffsetUnits";

        /// <summary>Fur Color Mask</summary>
        public const string FurColorMask = "_FurColorMask";

        /// <summary>Fur Alpha To Mask</summary>
        public const string FurAlphaToMask = "_FurAlphaToMask";

        #endregion

        #region Fur Rendering Forward

        /// <summary>Fur Src Blend</summary>
        public const string FurSrcBlend = "_FurSrcBlend";

        /// <summary>Fur Dst Blend</summary>
        public const string FurDstBlend = "_FurDstBlend";

        /// <summary>Fur Src Blend Alpha</summary>
        public const string FurSrcBlendAlpha = "_FurSrcBlendAlpha";

        /// <summary>Fur Dst Blend Alpha</summary>
        public const string FurDstBlendAlpha = "_FurDstBlendAlpha";

        /// <summary>Fur Blend Op</summary>
        public const string FurBlendOp = "_FurBlendOp";

        /// <summary>Fur Blend Op Alpha</summary>
        public const string FurBlendOpAlpha = "_FurBlendOpAlpha";

        #endregion

        #region Fur Rendering Forward Add

        /// <summary>Fur Src Blend ForwardAdd</summary>
        public const string FurSrcBlendFA = "_FurSrcBlendFA";

        /// <summary>Fur Dst Blend ForwardAdd</summary>
        public const string FurDstBlendFA = "_FurDstBlendFA";

        /// <summary>Fur Src Blend Alpha ForwardAdd</summary>
        public const string FurSrcBlendAlphaFA = "_FurSrcBlendAlphaFA";

        /// <summary>Fur Dst Blend Alpha ForwardAdd</summary>
        public const string FurDstBlendAlphaFA = "_FurDstBlendAlphaFA";

        /// <summary>Fur Blend Op ForwardAdd</summary>
        public const string FurBlendOpFA = "_FurBlendOpFA";

        /// <summary>Fur Blend Op Alpha ForwardAdd</summary>
        public const string FurBlendOpAlphaFA = "_FurBlendOpAlphaFA";

        #endregion

        #region Fur Rendering Stencil

        /// <summary>Fur Stencil Reference</summary>
        public const string FurStencilRef = "_FurStencilRef";

        /// <summary>Fur Stencil Read Mask</summary>
        public const string FurStencilReadMask = "_FurStencilReadMask";

        /// <summary>Fur Stencil Write Mask</summary>
        public const string FurStencilWriteMask = "_FurStencilWriteMask";

        /// <summary>Fur Stencil Compare Function</summary>
        public const string FurStencilComp = "_FurStencilComp";

        /// <summary>Fur Stencil Pass</summary>
        public const string FurStencilPass = "_FurStencilPass";

        /// <summary>Fur StencilFail</summary>
        public const string FurStencilFail = "_FurStencilFail";

        /// <summary>Fur Stencil Z Fail</summary>
        public const string FurStencilZFail = "_FurStencilZFail";

        #endregion

        #region Gem

        /// <summary>Gem Chromatic Aberration</summary>
        public const string GemChromaticAberration = "_GemChromaticAberration";

        /// <summary>Gem Environment Contrast</summary>
        public const string GemEnvContrast = "_GemEnvContrast";

        /// <summary>Gem Environment Color</summary>
        public const string GemEnvColor = "_GemEnvColor";

        /// <summary>Gem Particle Loop</summary>
        public const string GemParticleLoop = "_GemParticleLoop";

        /// <summary>Gem Particle Color</summary>
        public const string GemParticleColor = "_GemParticleColor";

        /// <summary>Gem VR Parallax Strength</summary>
        public const string GemVRParallaxStrength = "_GemVRParallaxStrength";

        #endregion

        #region Tessellation

        /// <summary>Tessellation Edge</summary>
        public const string TessEdge = "_TessEdge";

        /// <summary>Tessellation Strength</summary>
        public const string TessStrength = "_TessStrength";

        /// <summary>Tessellation Shrink</summary>
        public const string TessShrink = "_TessShrink";

        /// <summary>Tessellation Factor Max</summary>
        public const string TessFactorMax = "_TessFactorMax";

        #endregion

        #region Outline

        /// <summary>Outline Color</summary>
        public const string OutlineColor = "_OutlineColor";

        /// <summary>Outline Texture</summary>
        public const string OutlineTex = "_OutlineTex";

        /// <summary>Outline Texture Scroll Rotate</summary>
        public const string OutlineTex_ScrollRotate = "_OutlineTex_ScrollRotate";

        /// <summary>Outline Texture HSVG</summary>
        public const string OutlineTexHSVG = "_OutlineTexHSVG";

        /// <summary>Outline Lit Color</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineLitColor = "_OutlineLitColor";

        /// <summary>Outline Lit Apply Texture</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineLitApplyTex = "_OutlineLitApplyTex";

        /// <summary>Outline Lit Scale</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineLitScale = "_OutlineLitScale";

        /// <summary>Outline Lit Offset</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineLitOffset = "_OutlineLitOffset";

        /// <summary>Outline Width</summary>
        public const string OutlineWidth = "_OutlineWidth";

        /// <summary>Outline Width Mask</summary>
        public const string OutlineWidthMask = "_OutlineWidthMask";

        /// <summary>Outline Fix Width</summary>
        public const string OutlineFixWidth = "_OutlineFixWidth";

        /// <summary>Outline Vertex R2 Width</summary>
        public const string OutlineVertexR2Width = "_OutlineVertexR2Width";

        /// <summary>Outline Delete Mesh</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineDeleteMesh = "_OutlineDeleteMesh";

        /// <summary>Outline Vector Texture</summary>
        public const string OutlineVectorTex = "_OutlineVectorTex";

        /// <summary>Outline Vector UV Mode</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineVectorUVMode = "_OutlineVectorUVMode";

        /// <summary>Outline Vector Scale</summary>
        public const string OutlineVectorScale = "_OutlineVectorScale";

        /// <summary>Outline Enable Lighting</summary>
        public const string OutlineEnableLighting = "_OutlineEnableLighting";

        /// <summary>Outline Z Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineZBias = "_OutlineZBias";

        /// <summary>Outline Disable in VR</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string OutlineDisableInVR = "_OutlineDisableInVR";

        #endregion

        #region Outline Rendering

        /// <summary>Outline Cull</summary>
        public const string OutlineCull = "_OutlineCull";

        /// <summary>Outline Z Clip</summary>
        public const string OutlineZClip = "_OutlineZClip";

        /// <summary>Outline Z Write</summary>
        public const string OutlineZWrite = "_OutlineZWrite";

        /// <summary>Outline Z Test</summary>
        public const string OutlineZTest = "_OutlineZTest";

        /// <summary>Outline Offset Factor</summary>
        public const string OutlineOffsetFactor = "_OutlineOffsetFactor";

        /// <summary>Outline Offset Units</summary>
        public const string OutlineOffsetUnits = "_OutlineOffsetUnits";

        /// <summary>Outline Color Mask</summary>
        public const string OutlineColorMask = "_OutlineColorMask";

        /// <summary>Outline Alpha To Mask</summary>
        public const string OutlineAlphaToMask = "_OutlineAlphaToMask";

        #endregion

        #region Outline Rendering Forward

        /// <summary>Outline SrcBlend</summary>
        public const string OutlineSrcBlend = "_OutlineSrcBlend";

        /// <summary>Outline Dst Blend</summary>
        public const string OutlineDstBlend = "_OutlineDstBlend";

        /// <summary>Outline Src Blend Alpha</summary>
        public const string OutlineSrcBlendAlpha = "_OutlineSrcBlendAlpha";

        /// <summary>Outline Dst Blend Alpha</summary>
        public const string OutlineDstBlendAlpha = "_OutlineDstBlendAlpha";

        /// <summary>Outline Blend Op</summary>
        public const string OutlineBlendOp = "_OutlineBlendOp";

        /// <summary>Outline Blend Op Alpha</summary>
        public const string OutlineBlendOpAlpha = "_OutlineBlendOpAlpha";

        #endregion

        #region Outline Rendering Forward Add

        /// <summary>Outline Src Blend FA</summary>
        public const string OutlineSrcBlendFA = "_OutlineSrcBlendFA";

        /// <summary>Outline Dst Blend FA</summary>
        public const string OutlineDstBlendFA = "_OutlineDstBlendFA";

        /// <summary>Outline Src Blend Alpha FA</summary>
        public const string OutlineSrcBlendAlphaFA = "_OutlineSrcBlendAlphaFA";

        /// <summary>Outline Dst Blend Alpha FA</summary>
        public const string OutlineDstBlendAlphaFA = "_OutlineDstBlendAlphaFA";

        /// <summary>Outline Blend Op FA</summary>
        public const string OutlineBlendOpFA = "_OutlineBlendOpFA";

        /// <summary>Outline Blend Op Alpha FA</summary>
        public const string OutlineBlendOpAlphaFA = "_OutlineBlendOpAlphaFA";

        #endregion

        #region Outline Rendering Stencil

        /// <summary>Outline Stencil Ref</summary>
        public const string OutlineStencilRef = "_OutlineStencilRef";

        /// <summary>Outline Stencil Read Mask</summary>
        public const string OutlineStencilReadMask = "_OutlineStencilReadMask";

        /// <summary>Outline Stencil Write Mask</summary>
        public const string OutlineStencilWriteMask = "_OutlineStencilWriteMask";

        /// <summary>Outline Stencil Comp</summary>
        public const string OutlineStencilComp = "_OutlineStencilComp";

        /// <summary>Outline Stencil Pass</summary>
        public const string OutlineStencilPass = "_OutlineStencilPass";

        /// <summary>Outline Stencil Fail</summary>
        public const string OutlineStencilFail = "_OutlineStencilFail";

        /// <summary>Outline Stencil Z Fail</summary>
        public const string OutlineStencilZFail = "_OutlineStencilZFail";

        #endregion

        #region Multi

        /// <summary>Use Outline</summary>
        public const string UseOutline = "_UseOutline";

        /// <summary>Transparent Mode</summary>
        public const string TransparentMode = "_TransparentMode";

        ///// <summary>Use POM</summary>
        ///// <remarks>v1.3.0 to Parallax</remarks>
        //public const string UsePOM = "_UsePOM";

        /// <summary>Use Clipping Canceller</summary>
        public const string UseClippingCanceller = "_UseClippingCanceller";

        /// <summary>As Overlay</summary>
        public const string AsOverlay = "_AsOverlay";

        #endregion

        #region Lite

        /// <summary>Tri Mask</summary>
        public const string TriMask = "_TriMask";

        /// <summary>Mat Cap Mul</summary>
        public const string MatCapMul = "_MatCapMul";

        #endregion

        #region Fake Shadow

        /// <summary>Fake Shadow Vector</summary>
        public const string FakeShadowVector = "_FakeShadowVector";

        #endregion

        #region Rendering

        /// <summary>Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        public const string Cutoff = "_Cutoff";

        /// <summary>Subpass Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        public const string SubpassCutoff = "_SubpassCutoff";

        /// <summary>Cull Mode</summary>
        public const string Cull = "_Cull";

        /// <summary>Z Clip</summary>
        public const string ZClip = "_ZClip";

        /// <summary>Z Write</summary>
        public const string ZWrite = "_ZWrite";

        /// <summary>Z Test</summary>
        public const string ZTest = "_ZTest";

        /// <summary>Offset Factor</summary>
        public const string OffsetFactor = "_OffsetFactor";

        /// <summary>Offset Units</summary>
        public const string OffsetUnits = "_OffsetUnits";

        /// <summary>Color Mask</summary>
        public const string ColorMask = "_ColorMask";

        /// <summary>Alpha To Mask</summary>
        public const string AlphaToMask = "_AlphaToMask";

        /// <summary>Shadow Caster Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        public const string LilShadowCasterBias = "_lilShadowCasterBias";

        #endregion

        #region Rendering Forward

        /// <summary>Src Blend</summary>
        public const string SrcBlend = "_SrcBlend";

        /// <summary>Dst Blend</summary>
        public const string DstBlend = "_DstBlend";

        /// <summary>Src Blend Alpha</summary>
        public const string SrcBlendAlpha = "_SrcBlendAlpha";

        /// <summary>Dst Blend Alpha</summary>
        public const string DstBlendAlpha = "_DstBlendAlpha";

        /// <summary>Blend Op</summary>
        public const string BlendOp = "_BlendOp";

        /// <summary>Blend Op Alpha</summary>
        public const string BlendOpAlpha = "_BlendOpAlpha";

        #endregion

        #region Rendering Forward Add

        /// <summary>Src Blend FA</summary>
        public const string SrcBlendFA = "_SrcBlendFA";

        /// <summary>Dst Blend FA</summary>
        public const string DstBlendFA = "_DstBlendFA";

        /// <summary>Src Blend Alpha FA</summary>
        public const string SrcBlendAlphaFA = "_SrcBlendAlphaFA";

        /// <summary>Dst Blend Alpha FA</summary>
        public const string DstBlendAlphaFA = "_DstBlendAlphaFA";

        /// <summary>Blend Op FA</summary>
        public const string BlendOpFA = "_BlendOpFA";

        /// <summary>Blend Op Alpha FA</summary>
        public const string BlendOpAlphaFA = "_BlendOpAlphaFA";

        #endregion

        #region Rendering Stencil

        /// <summary>Stencil Ref</summary>
        public const string StencilRef = "_StencilRef";

        /// <summary>Stencil Read Mask</summary>
        public const string StencilReadMask = "_StencilReadMask";

        /// <summary>Stencil Write Mask</summary>
        public const string StencilWriteMask = "_StencilWriteMask";

        /// <summary>Stencil Comp</summary>
        public const string StencilComp = "_StencilComp";

        /// <summary>Stencil Pass</summary>
        public const string StencilPass = "_StencilPass";

        /// <summary>Stencil Fail</summary>
        public const string StencilFail = "_StencilFail";

        /// <summary>Stencil Z Fail</summary>
        public const string StencilZFail = "_StencilZFail";

        #endregion

        #region Save

        /// <summary>Base Map</summary>
        public const string BaseMap = "_BaseMap";

        /// <summary>Base Color</summary>
        public const string BaseColor = "_BaseColor";

        /// <summary>Base Color Map</summary>
        public const string BaseColorMap = "_BaseColorMap";

        /// <summary>LilToon Version</summary>
        public const string LilToonVersion = "_lilToonVersion";

        #endregion
    }
}