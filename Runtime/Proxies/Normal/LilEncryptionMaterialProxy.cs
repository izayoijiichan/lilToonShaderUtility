// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Proxies
// @Class     : LilEncryptionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace LilToonShader.Proxies
{
    using LilToonShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// lilToon Encryption Material Proxy
    /// </summary>
    public class LilEncryptionMaterialProxy : LilMaterialProxyBase
    {
        #region Properties

        /// <summary>Ignore Encryption</summary>
        //[DefaultValue(false)]
        public bool IgnoreEncryption
        {
            get => _Material.GetSafeBool(PropertyNameID.IgnoreEncryption, false);
            set => _Material.SetSafeBool(PropertyNameID.IgnoreEncryption, value);
        }

        /// <summary>Keys</summary>
        //[DefaultValue(0,0,0,0)]
        public Vector4 Keys
        {
            get => _Material.GetSafeVector4(PropertyNameID.Keys, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.Keys, value);
        }

        /// <summary>Bit Key 0</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey0
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey0, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey0, value);
        }

        /// <summary>Bit Key 1</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey1
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey1, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey1, value);
        }

        /// <summary>Bit Key 2</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey2
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey2, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey2, value);
        }

        /// <summary>Bit Key 3</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey3
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey3, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey3, value);
        }

        /// <summary>Bit Key 4</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey4
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey4, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey4, value);
        }

        /// <summary>Bit Key 5</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey5
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey5, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey5, value);
        }

        /// <summary>Bit Key 6</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey6
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey6, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey6, value);
        }

        /// <summary>Bit Key 7</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey7
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey7, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey7, value);
        }

        /// <summary>Bit Key 8</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey8
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey8, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey8, value);
        }

        /// <summary>Bit Key 9</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey9
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey9, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey9, value);
        }

        /// <summary>Bit Key 10</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey10
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey10, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey10, value);
        }

        /// <summary>Bit Key 11</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey11
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey11, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey11, value);
        }

        /// <summary>Bit Key 12</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey12
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey12, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey12, value);
        }

        /// <summary>Bit Key 13</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey13
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey13, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey13, value);
        }

        /// <summary>Bit Key 14</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey14
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey14, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey14, value);
        }

        /// <summary>Bit Key 15</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey15
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey15, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey15, value);
        }

        /// <summary>Bit Key 16</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey16
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey16, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey16, value);
        }

        /// <summary>Bit Key 17</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey17
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey17, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey17, value);
        }

        /// <summary>Bit Key 18</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey18
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey18, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey18, value);
        }

        /// <summary>Bit Key 19</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey19
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey19, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey19, value);
        }

        /// <summary>Bit Key 20</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey20
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey20, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey20, value);
        }

        /// <summary>Bit Key 21</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey21
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey21, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey21, value);
        }

        /// <summary>Bit Key 22</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey22
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey22, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey22, value);
        }

        /// <summary>Bit Key 23</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey23
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey23, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey23, value);
        }

        /// <summary>Bit Key 24</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey24
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey24, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey24, value);
        }

        /// <summary>Bit Key 25</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey25
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey25, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey25, value);
        }

        /// <summary>Bit Key 26</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey26
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey26, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey26, value);
        }

        /// <summary>Bit Key 27</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey27
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey27, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey27, value);
        }

        /// <summary>Bit Key 28</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey28
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey28, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey28, value);
        }

        /// <summary>Bit Key 29</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey29
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey29, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey29, value);
        }

        /// <summary>Bit Key 30</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey30
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey30, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey30, value);
        }

        /// <summary>Bit Key 31</summary>
        /// <remarks>v1.3.7 added</remarks>
        public float BitKey31
        {
            get => _Material.GetSafeFloat(PropertyNameID.BitKey31, 0);
            set => _Material.SetSafeFloat(PropertyNameID.BitKey31, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of LilEncryptionMaterialProxy.
        /// </summary>
        /// <param name="material">The lilToon material.</param>
        public LilEncryptionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion
    }
}