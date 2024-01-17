// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilUdimDiscardMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon UDIM Discard Material Proxy
    /// </summary>
    public class LilUdimDiscardMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>UDIM Discard Compile</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardCompile
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardCompile, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardCompile, value);
        }

        /// <summary>UDIM Discard UV</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(LilUdimDiscardUVMode.UV0)]
        public LilUdimDiscardUVMode UDIMDiscardUV
        {
            get => _Material.GetSafeEnum<LilUdimDiscardUVMode>(PropertyNameID.UDIMDiscardUV, LilUdimDiscardUVMode.UV0);
            set => _Material.SetSafeInt(PropertyNameID.UDIMDiscardUV, (int)value);
        }

        /// <summary>UDIM Discard Mode</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(LilUdimDiscardMode.Vertex)]
        public LilUdimDiscardMode UDIMDiscardMode
        {
            get => _Material.GetSafeEnum<LilUdimDiscardMode>(PropertyNameID.UDIMDiscardMode, LilUdimDiscardMode.Vertex);
            set => _Material.SetSafeInt(PropertyNameID.UDIMDiscardMode, (int)value);
        }

        /// <summary>UDIM Discard Row 3-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow3_3
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow3_3, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow3_3, value);
        }

        /// <summary>UDIM Discard Row 3-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow3_2
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow3_2, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow3_2, value);
        }

        /// <summary>UDIM Discard Row 3-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow3_1
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow3_1, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow3_1, value);
        }

        /// <summary>UDIM Discard Row 3-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow3_0
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow3_0, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow3_0, value);
        }

        /// <summary>UDIM Discard Row 2-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow2_3
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow2_3, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow2_3, value);
        }

        /// <summary>UDIM Discard Row 2-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow2_2
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow2_2, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow2_2, value);
        }

        /// <summary>UDIM Discard Row 2-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow2_1
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow2_1, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow2_1, value);
        }

        /// <summary>UDIM Discard Row 2-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow2_0
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow2_0, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow2_0, value);
        }

        /// <summary>UDIM Discard Row 1-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow1_3
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow1_3, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow1_3, value);
        }

        /// <summary>UDIM Discard Row 1-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow1_2
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow1_2, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow1_2, value);
        }

        /// <summary>UDIM Discard Row 1-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow1_1
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow1_1, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow1_1, value);
        }

        /// <summary>UDIM Discard Row 1-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow1_0
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow1_0, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow1_0, value);
        }

        /// <summary>UDIM Discard Row 0-3</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow0_3
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow0_3, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow0_3, value);
        }

        /// <summary>UDIM Discard Row 0-2</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow0_2
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow0_2, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow0_2, value);
        }

        /// <summary>UDIM Discard Row 0-1</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow0_1
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow0_1, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow0_1, value);
        }

        /// <summary>UDIM Discard Row 0-0</summary>
        /// <remarks>v1.7.0 added</remarks>
        //[DefaultValue(false)]
        public bool UDIMDiscardRow0_0
        {
            get => _Material.GetSafeBool(PropertyNameID.UDIMDiscardRow0_0, false);
            set => _Material.SetSafeBool(PropertyNameID.UDIMDiscardRow0_0, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilUdimDiscardMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilUdimDiscardMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}