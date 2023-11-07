// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilAudioLinkMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon AudioLink Material Proxy
    /// </summary>
    public class LilAudioLinkMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Use Audio Link</summary>
        //[DefaultValue(false)]
        public bool UseAudioLink
        {
            get => _Material.GetSafeBool(PropertyNameID.UseAudioLink, false);
            set => _Material.SetSafeBool(PropertyNameID.UseAudioLink, value);
        }

        /// <summary>Audio Link Default Value</summary>
        /// <remarks>Strength|Blink Strength|Blink Speed|Blink Threshold</remarks>
        //[DefaultValue(0.0,0.0,2.0,0.75)]
        public Vector4 AudioLinkDefaultValue
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkDefaultValue, new Vector4(0.0f, 0.0f, 2.0f, 0.75f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkDefaultValue, value);
        }

        /// <summary>Audio Link UV Mode</summary>
        //[DefaultValue(LilAudioLinkUVMode.Rim)]
        public LilAudioLinkUVMode AudioLinkUVMode
        {
            get => _Material.GetSafeEnum<LilAudioLinkUVMode>(PropertyNameID.AudioLinkUVMode, LilAudioLinkUVMode.Rim);
            set => _Material.SetSafeInt(PropertyNameID.AudioLinkUVMode, (int)value);
        }

        /// <summary>Audio Link UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        public Vector4 AudioLinkUVParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkUVParams, new Vector4(0.25f, 0.0f, 0.0f, 0.125f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkUVParams, value);
        }

        /// <summary>Audio Link Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        public Vector4 AudioLinkStart
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkStart, new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkStart, value);
        }

        /// <summary>Audio Link Mask</summary>
        public Texture2D? AudioLinkMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.AudioLinkMask);
            set => _Material.SetSafeTexture(PropertyNameID.AudioLinkMask, value);
        }

        /// <summary>Audio Link Mask Scroll Rotate</summary>
        /// <remarks>
        /// Angle|UV Animation|Scroll|Rotate
        /// v1.4.0 added
        /// </remarks>
        public Vector4 AudioLinkMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkMask_ScrollRotate, new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkMask_ScrollRotate, value);
        }

        /// <summary>Audio Link Mask UV Mode</summary>
        /// <remarks>v1.4.0 added</remarks>
        public LilAudioLinkMaskUVMode AudioLinkMask_UVMode
        {
            get => _Material.GetSafeEnum<LilAudioLinkMaskUVMode>(PropertyNameID.AudioLinkMask_UVMode, LilAudioLinkMaskUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.AudioLinkMask_UVMode, (int)value);
        }

        #region Apply to

        /// <summary>Audio Link to Main 2nd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Main2nd
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Main2nd, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Main2nd, value);
        }

        /// <summary>Audio Link to Main 3rd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Main3rd
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Main3rd, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Main3rd, value);
        }

        /// <summary>Audio Link to Emission</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Emission, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Emission, value);
        }

        /// <summary>Audio Link to Emission Gradation</summary>
        //[DefaultValue(false)]
        public bool AudioLink2EmissionGrad
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2EmissionGrad, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2EmissionGrad, value);
        }

        /// <summary>Audio Link to Emission 2nd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission2nd
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Emission2nd, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Emission2nd, value);
        }

        /// <summary>Audio Link to Emission 2nd Gradation</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission2ndGrad
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Emission2ndGrad, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Emission2ndGrad, value);
        }

        /// <summary>Audio Link to Vertex</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Vertex
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLink2Vertex, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLink2Vertex, value);
        }

        #endregion

        #region Vertex

        /// <summary>Audio Link Vertex UV Mode</summary>
        //[DefaultValue(LilAudioLinkVertexUVMode.Position)]
        public LilAudioLinkVertexUVMode AudioLinkVertexUVMode
        {
            get => _Material.GetSafeEnum<LilAudioLinkVertexUVMode>(PropertyNameID.AudioLinkVertexUVMode, LilAudioLinkVertexUVMode.Position);
            set => _Material.SetSafeInt(PropertyNameID.AudioLinkVertexUVMode, (int)value);
        }

        /// <summary>Audio Link Vertex UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        public Vector4 AudioLinkVertexUVParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkVertexUVParams, new Vector4(0.25f, 0.0f, 0.0f, 0.125f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkVertexUVParams, value);
        }

        /// <summary>Audio Link Vertex Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        public Vector4 AudioLinkVertexStart
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkVertexStart, new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkVertexStart, value);
        }

        /// <summary>Audio Link Vertex Strength</summary>
        /// <remarks>Moving Vector|Normal Strength</remarks>
        //[DefaultValue(0.0,0.0,0.0,1.0)]
        public Vector4 AudioLinkVertexStrength
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkVertexStrength, new Vector4(0.0f, 0.0f, 0.0f, 1.0f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkVertexStrength, value);
        }

        #endregion

        #region As Local

        /// <summary>Audio Link as Local</summary>
        //[DefaultValue(false)]
        public bool AudioLinkAsLocal
        {
            get => _Material.GetSafeBool(PropertyNameID.AudioLinkAsLocal, false);
            set => _Material.SetSafeBool(PropertyNameID.AudioLinkAsLocal, value);
        }

        /// <summary>Audio Link Local Map</summary>
        public Texture2D? AudioLinkLocalMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.AudioLinkLocalMap);
            set => _Material.SetSafeTexture(PropertyNameID.AudioLinkLocalMap, value);
        }

        /// <summary>Audio Link Local Map Parameters</summary>
        /// <remarks>BPM|Notes|Offset</remarks>
        //[DefaultValue(120,1,0,0)]
        public Vector4 AudioLinkLocalMapParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.AudioLinkLocalMapParams, new Vector4(120.0f, 1.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.AudioLinkLocalMapParams, value);
        }

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilAudioLinkMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilAudioLinkMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}