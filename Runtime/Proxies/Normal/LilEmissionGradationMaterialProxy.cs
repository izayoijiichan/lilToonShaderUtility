// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEmissionGradationMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Emission Gradation Material Proxy
    /// </summary>
    public class LilEmissionGradationMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Egci</summary>
        //[DefaultValue(2)]
        public int Egci
        {
            get => _Material.GetSafeInt(PropertyNameID.Egci, 2);
            set => _Material.SetSafeInt(PropertyNameID.Egci, value);
        }

        /// <summary>Egai</summary>
        //[DefaultValue(2)]
        public int Egai
        {
            get => _Material.GetSafeInt(PropertyNameID.Egai, 2);
            set => _Material.SetSafeInt(PropertyNameID.Egai, value);
        }

        /// <summary>Egc0</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc0
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc0, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc0, value);
        }

        /// <summary>Egc1</summary>
        //[DefaultValue(1,1,1,1)]
        public Color Egc1
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc1, new Color(1.8f, 1.0f, 1.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc1, value);
        }

        /// <summary>Egc2</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc2
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc2, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc2, value);
        }

        /// <summary>Egc3</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc3
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc3, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc3, value);
        }

        /// <summary>Egc4</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc4
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc4, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc4, value);
        }

        /// <summary>Egc5</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc5
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc5, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc5, value);
        }

        /// <summary>Egc6</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc6
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc6, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc6, value);
        }

        /// <summary>Egc7</summary>
        //[DefaultValue(1,1,1,0)]
        public Color Egc7
        {
            get => _Material.GetSafeColor(PropertyNameID.Egc7, new Color(1.8f, 1.0f, 1.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Egc7, value);
        }

        /// <summary>Ega0</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega0
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega0, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega0, value);
        }

        /// <summary>Ega1</summary>
        //[DefaultValue(1,0,0,1)]
        public Color Ega1
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega1, new Color(1.8f, 0.0f, 0.0f, 1.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega1, value);
        }

        /// <summary>Ega2</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega2
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega2, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega2, value);
        }

        /// <summary>Ega3</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega3
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega3, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega3, value);
        }

        /// <summary>Ega4</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega4
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega4, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega4, value);
        }

        /// <summary>Ega5</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega5
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega5, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega5, value);
        }

        /// <summary>Ega6</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega6
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega6, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega6, value);
        }

        /// <summary>Ega7</summary>
        //[DefaultValue(1,0,0,0)]
        public Color Ega7
        {
            get => _Material.GetSafeColor(PropertyNameID.Ega7, new Color(1.8f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(PropertyNameID.Ega7, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilEmissionGradationMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilEmissionGradationMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}