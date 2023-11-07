// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEmission2ndGradationMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Emission2ndGradation Material Proxy
    /// </summary>
    public class LilEmission2ndGradationMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>E2gci</summary>
        //[DefaultValue(2)]
        public int E2gci
        {
            get => _Material.GetSafeInt(PropertyNameID.E2gci, 2);
            set => _Material.SetSafeInt(PropertyNameID.E2gci, value);
        }

        /// <summary>E2gai</summary>
        //[DefaultValue(2)]
        public int E2gai
        {
            get => _Material.GetSafeInt(PropertyNameID.E2gai, 2);
            set => _Material.SetSafeInt(PropertyNameID.E2gai, value);
        }

        /// <summary>E2gc0</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc0
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc0, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc0, value);
        }

        /// <summary>E2gc1</summary>
        //[DefaultValue(1,1,1,1)]
        public Color E2gc1
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc1, new Color(1.8f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc1, value);
        }

        /// <summary>E2gc2</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc2
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc2, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc2, value);
        }

        /// <summary>E2gc3</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc3
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc3, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc3, value);
        }

        /// <summary>E2gc4</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc4
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc4, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc4, value);
        }

        /// <summary>E2gc5</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc5
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc5, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc5, value);
        }

        /// <summary>E2gc6</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc6
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc6, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc6, value);
        }

        /// <summary>E2gc7</summary>
        //[DefaultValue(1,1,1,0)]
        public Color E2gc7
        {
            get => _Material.GetSafeColor(PropertyNameID.E2gc7, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2gc7, value);
        }

        /// <summary>E2ga0</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga0
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga0, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga0, value);
        }

        /// <summary>E2ga1</summary>
        //[DefaultValue(1,0,0,1)]
        public Color E2ga1
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga1, new Color(1.8f, 0.0f, 0.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga1, value);
        }

        /// <summary>E2ga2</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga2
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga2, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga2, value);
        }

        /// <summary>E2ga3</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga3
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga3, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga3, value);
        }

        /// <summary>E2ga4</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga4
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga4, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga4, value);
        }

        /// <summary>E2ga5</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga5
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga5, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga5, value);
        }

        /// <summary>E2ga6</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga6
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga6, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga6, value);
        }

        /// <summary>E2ga7</summary>
        //[DefaultValue(1,0,0,0)]
        public Color E2ga7
        {
            get => _Material.GetSafeColor(PropertyNameID.E2ga7, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.E2ga7, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilEmission2ndGradationMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilEmission2ndGradationMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}