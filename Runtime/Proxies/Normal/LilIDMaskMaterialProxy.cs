// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilIDMaskMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon ID Mask Material Proxy
    /// </summary>
    public class LilIDMaskMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>ID Mask From</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(LilIDMaskFrom.VertexID)]
        public LilIDMaskFrom IDMaskFrom
        {
            get => _Material.GetSafeEnum<LilIDMaskFrom>(PropertyNameID.IDMaskFrom, LilIDMaskFrom.VertexID);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskFrom, (int)value);
        }

        /// <summary>ID Mask 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask1
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask1, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask1, value);
        }

        /// <summary>ID Mask 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask2
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask2, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask2, value);
        }

        /// <summary>ID Mask 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask3
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask3, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask3, value);
        }

        /// <summary>ID Mask 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask4
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask4, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask4, value);
        }

        /// <summary>ID Mask 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask5
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask5, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask5, value);
        }

        /// <summary>ID Mask 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask6
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask6, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask6, value);
        }

        /// <summary>ID Mask 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask7
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask7, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask7, value);
        }

        /// <summary>ID Mask 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMask8
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMask8, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMask8, value);
        }

        /// <summary>ID Mask is Bitmap</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskIsBitmap
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskIsBitmap, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskIsBitmap, value);
        }

        /// <summary>ID Mask Index 1</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex1
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex1, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex1, value);
        }

        /// <summary>ID Mask Index 2</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex2
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex2, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex2, value);
        }

        /// <summary>ID Mask Index 3</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex3
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex3, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex3, value);
        }

        /// <summary>ID Mask Index 4</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex4
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex4, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex4, value);
        }

        /// <summary>ID Mask Index 5</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex5
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex5, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex5, value);
        }

        /// <summary>ID Mask Index 6</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex6
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex6, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex6, value);
        }

        /// <summary>ID Mask Index 7</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex7
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex7, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex7, value);
        }

        /// <summary>ID Mask Index 8</summary>
        /// <remarks>v1.4.0 added</remarks>
        //[DefaultValue(0)]
        public int IDMaskIndex8
        {
            get => _Material.GetSafeInt(PropertyNameID.IDMaskIndex8, 0);
            set => _Material.SetSafeInt(PropertyNameID.IDMaskIndex8, value);
        }

        /// <summary>ID Mask Controls Dissolve</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskControlsDissolve
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskControlsDissolve, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskControlsDissolve, value);
        }

        /// <summary>ID Mask Prior 1</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior1
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior1, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior1, value);
        }

        /// <summary>ID Mask Prior 2</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior2
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior2, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior2, value);
        }

        /// <summary>ID Mask Prior 3</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior3
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior3, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior3, value);
        }

        /// <summary>ID Mask Prior 4</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior4
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior4, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior4, value);
        }

        /// <summary>ID Mask Prior 5</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior5
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior5, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior5, value);
        }

        /// <summary>ID Mask Prior 6</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior6
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior6, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior6, value);
        }

        /// <summary>ID Mask Prior 7</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior7
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior7, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior7, value);
        }

        /// <summary>ID Mask Prior 8</summary>
        /// <remarks>v1.5.0 added</remarks>
        //[DefaultValue(false)]
        public bool IDMaskPrior8
        {
            get => _Material.GetSafeBool(PropertyNameID.IDMaskPrior8, false);
            set => _Material.SetSafeBool(PropertyNameID.IDMaskPrior8, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilIDMaskMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilIDMaskMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}