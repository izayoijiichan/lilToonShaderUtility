// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilDissolveMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Dissolve Material Proxy
    /// </summary>
    public class LilDissolveMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Dissolve Mask</summary>
        public Texture2D? DissolveMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.DissolveMask);
            set => _Material.SetSafeTexture(PropertyNameID.DissolveMask, value);
        }

        /// <summary>Dissolve Noise Mask</summary>
        public Texture2D? DissolveNoiseMask
        {
            get => _Material.GetSafeTexture(PropertyNameID.DissolveNoiseMask);
            set => _Material.SetSafeTexture(PropertyNameID.DissolveNoiseMask, value);
        }

        /// <summary>Dissolve Noise Mask Scroll Rotate</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 DissolveNoiseMask_ScrollRotate
        {
            get => _Material.GetSafeVector4(PropertyNameID.DissolveNoiseMask_ScrollRotate, new Vector4(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(PropertyNameID.DissolveNoiseMask_ScrollRotate, value);
        }

        /// <summary>Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        public float DissolveNoiseStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.DissolveNoiseStrength, 0.1f);
            set => _Material.SetSafeFloat(PropertyNameID.DissolveNoiseStrength, value);
        }

        /// <summary>Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        public Color DissolveColor
        {
            get => _Material.GetSafeColor(PropertyNameID.DissolveColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.DissolveColor, value);
        }

        /// <summary>Dissolve Parameters</summary>
        /// <remarks>Dissolve Mode|Dissolve Shape|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        public Vector4 DissolveParams
        {
            get => _Material.GetSafeVector4(PropertyNameID.DissolveParams, new Vector4(0.0f, 0.0f, 0.5f, 0.1f));
            set => _Material.SetSafeVector(PropertyNameID.DissolveParams, value);
        }

        /// <summary>Dissolve Position</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 DissolvePos
        {
            get => _Material.GetSafeVector4(PropertyNameID.DissolvePos, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.DissolvePos, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilDissolveMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilDissolveMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}