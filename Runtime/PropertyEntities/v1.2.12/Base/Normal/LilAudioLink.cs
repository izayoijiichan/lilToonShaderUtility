// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilAudioLink
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon AudioLink
    /// </summary>
    public class LilAudioLink : ILilAudioLink
    {
        /// <summary>Use Audio Link</summary>
        //[DefaultValue(false)]
        public bool UseAudioLink { get; set; }

        /// <summary>Audio Link Default Value</summary>
        /// <remarks>Strength|Blink Strength|Blink Speed|Blink Threshold</remarks>
        //[DefaultValue(0.0,0.0,2.0,0.75)]
        public Vector4 AudioLinkDefaultValue { get; set; }

        /// <summary>Audio Link UV Mode</summary>
        //[DefaultValue(LilAudioLinkUVMode.Rim)]
        public LilAudioLinkUVMode AudioLinkUVMode { get; set; }

        /// <summary>Audio Link UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        public Vector4 AudioLinkUVParams { get; set; }

        /// <summary>Audio Link Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        public Vector4 AudioLinkStart { get; set; }

        /// <summary>Audio Link Mask</summary>
        public Texture2D? AudioLinkMask { get; set; }

        #region Apply to

        /// <summary>Audio Link to Main 2nd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Main2nd { get; set; }

        /// <summary>Audio Link to Main 3rd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Main3rd { get; set; }

        /// <summary>Audio Link to Emission</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission { get; set; }

        /// <summary>Audio Link to Emission Gradation</summary>
        //[DefaultValue(false)]
        public bool AudioLink2EmissionGrad { get; set; }

        /// <summary>Audio Link to Emission 2nd</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission2nd { get; set; }

        /// <summary>Audio Link to Emission 2nd Gradation</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Emission2ndGrad { get; set; }

        /// <summary>Audio Link to Vertex</summary>
        //[DefaultValue(false)]
        public bool AudioLink2Vertex { get; set; }

        #endregion

        #region Vertex

        /// <summary>Audio Link Vertex UV Mode</summary>
        //[DefaultValue(LilAudioLinkVertexUVMode.Position)]
        public LilAudioLinkVertexUVMode AudioLinkVertexUVMode { get; set; }

        /// <summary>Audio Link Vertex UV Parameters</summary>
        /// <remarks>Scale|Offset|Angle|Band</remarks>
        //[DefaultValue(0.25,0,0,0.125)]
        public Vector4 AudioLinkVertexUVParams { get; set; }

        /// <summary>Audio Link Vertex Start Position</summary>
        //[DefaultValue(0.0,0.0,0.0,0.0)]
        public Vector4 AudioLinkVertexStart { get; set; }

        /// <summary>Audio Link Vertex Strength</summary>
        /// <remarks>Moving Vector|Normal Strength</remarks>
        //[DefaultValue(0.0,0.0,0.0,1.0)]
        public Vector4 AudioLinkVertexStrength { get; set; }

        #endregion

        #region As Local

        /// <summary>Audio Link as Local</summary>
        //[DefaultValue(false)]
        public bool AudioLinkAsLocal { get; set; }

        /// <summary>Audio Link Local Map</summary>
        public Texture2D? AudioLinkLocalMap { get; set; }

        /// <summary>Audio Link Local Map Parameters</summary>
        /// <remarks>BPM|Notes|Offset</remarks>
        //[DefaultValue(120,1,0,0)]
        public Vector4 AudioLinkLocalMapParams { get; set; }

        #endregion
    }
}