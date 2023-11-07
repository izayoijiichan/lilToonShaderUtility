// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilRenderingMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// lilToon Rendering Material Proxy
    /// </summary>
    public class LilRenderingMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(-0.001f, 1.001f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(PropertyNameID.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Subpass Alpha Cutoff</summary>
        /// <remarks>Base</remarks>
        //[Range(0f, 1f)]
        //[DefaultValue(0.5f)]
        public float SubpassCutoff
        {
            get => _Material.GetSafeFloat(PropertyNameID.SubpassCutoff, PropertyRange.SubpassCutoff.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.SubpassCutoff, PropertyRange.SubpassCutoff, value);
        }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull
        {
            get => _Material.GetSafeEnum<CullMode>(PropertyNameID.Cull, CullMode.Back);
            set => _Material.SetSafeInt(PropertyNameID.Cull, (int)value);
        }

        /// <summary>Z Clip</summary>
        //[DefaultValue(true)]
        public bool ZClip
        {
            get => _Material.GetSafeBool(PropertyNameID.ZClip, true);
            set => _Material.SetSafeBool(PropertyNameID.ZClip, value);
        }

        /// <summary>Z Write</summary>
        //[DefaultValue(true)]
        public bool ZWrite
        {
            get => _Material.GetSafeBool(PropertyNameID.ZWrite, true);
            set => _Material.SetSafeBool(PropertyNameID.ZWrite, value);
        }

        /// <summary>Z Test</summary>
        //[DefaultValue(CompareFunction.LessEqual)]
        public CompareFunction ZTest
        {
            get => _Material.GetSafeEnum<CompareFunction>(PropertyNameID.ZTest, CompareFunction.LessEqual);
            set => _Material.SetSafeInt(PropertyNameID.ZTest, (int)value);
        }

        /// <summary>Offset Factor</summary>
        //[DefaultValue(0)]
        public float OffsetFactor
        {
            get => _Material.GetSafeFloat(PropertyNameID.OffsetFactor, 0);
            set => _Material.SetSafeFloat(PropertyNameID.OffsetFactor, value);
        }

        /// <summary>Offset Units</summary>
        //[DefaultValue(0)]
        public float OffsetUnits
        {
            get => _Material.GetSafeFloat(PropertyNameID.OffsetUnits, 0);
            set => _Material.SetSafeFloat(PropertyNameID.OffsetUnits, value);
        }

        /// <summary>Color Mask</summary>
        //[DefaultValue(15)]
        public int ColorMask
        {
            get => _Material.GetSafeInt(PropertyNameID.ColorMask, 15);
            set => _Material.SetSafeInt(PropertyNameID.ColorMask, value);
        }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask
        {
            get => _Material.GetSafeBool(PropertyNameID.AlphaToMask, false);
            set => _Material.SetSafeBool(PropertyNameID.AlphaToMask, value);
        }

        /// <summary>Shadow Caster Bias</summary>
        /// <remarks>v1.3.0 added</remarks>
        //[DefaultValue(0.0f)]
        public float LilShadowCasterBias
        {
            get => _Material.GetSafeFloat(PropertyNameID.LilShadowCasterBias, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.LilShadowCasterBias, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilRenderingMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilRenderingMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}