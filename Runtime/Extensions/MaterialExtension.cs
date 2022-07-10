// ----------------------------------------------------------------------
// @Namespace : LilToonShader.Extensions
// @Class     : MaterialExtension
// ----------------------------------------------------------------------
namespace LilToonShader.Extensions
{
    using System;
    using UnityEngine;

    public static class MaterialExtension
    {
        #region Methods (Get)

        /// <summary>
        /// Gets bool value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static bool GetSafeBool(this Material material, string propertyName)
        {
            if (material.HasInt(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Gets color value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static Color GetSafeColor(this Material material, string propertyName)
        {
            if (material.HasColor(propertyName))
            {
                return material.GetColor(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Color.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static TEnum GetSafeEnum<TEnum>(this Material material, string propertyName, TEnum? defaultValue = null) where TEnum : struct
        {
            int propertyValue = material.GetSafeInt(propertyName);

            if (Enum.TryParse(propertyValue.ToString(), out TEnum result))
            {
                return result;
            }
            else if (defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets float value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static float GetSafeFloat(this Material material, string propertyName)
        {
            if (material.HasFloat(propertyName))
            {
                return material.GetFloat(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not float.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static int GetSafeInt(this Material material, string propertyName)
        {
            //return material.GetSafeInteger(propertyName);

            if (material.HasInt(propertyName))
            {
                return material.GetInt(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static int GetSafeInteger(this Material material, string propertyName)
        {
            if (material.HasInteger(propertyName))
            {
                return material.GetInteger(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not integer.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets the Texture.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static Texture2D GetSafeTexture(this Material material, string propertyName)
        {
            if (material.HasTexture(propertyName))
            {
                return (Texture2D)material.GetTexture(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Texture.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets Vector3 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static Vector3 GetSafeVector3(this Material material, string propertyName)
        {
            return material.GetSafeVector4(propertyName);
        }

        /// <summary>
        /// Gets Vector4 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static Vector4 GetSafeVector4(this Material material, string propertyName)
        {
            if (material.HasVector(propertyName))
            {
                return material.GetVector(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Vector.");

                return default;
            }
            else
            {
                Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        #endregion

        #region Methods (Set)

        /// <summary>
        /// Sets bool value to property.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeBool(this Material material, string propertyName, bool value)
        {
            if (material.HasInt(propertyName))
            {
                material.SetInt(propertyName, (value == true) ? 1 : 0);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="defaultValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, int value, int? minValue = null, int? maxValue = null, int defaultValue = default)
        {
            //return material.SetSafeInteger(propertyName, value, minValue, maxValue, defaultValue);

            if (material.HasInt(propertyName))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue)
                {
                    setValue = defaultValue;
                }
                else if (maxValue.HasValue && value > maxValue)
                {
                    setValue = defaultValue;
                }

                material.SetInt(propertyName, setValue);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="defaultValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, int value, int? minValue = null, int? maxValue = null, int defaultValue = default)
        {
            if (material.HasInteger(propertyName))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue)
                {
                    setValue = defaultValue;
                }
                else if (maxValue.HasValue && value > maxValue)
                {
                    setValue = defaultValue;
                }

                material.SetInteger(propertyName, setValue);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not integer.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="defaultValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, string propertyName, float value, float? minValue = null, float? maxValue = null, float defaultValue = default)
        {
            if (material.HasFloat(propertyName))
            {
                float setValue = value;

                if (minValue.HasValue && value < minValue)
                {
                    setValue = defaultValue;
                }
                else if (maxValue.HasValue && value > maxValue)
                {
                    setValue = defaultValue;
                }

                material.SetFloat(propertyName, setValue);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not float.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets color value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="color"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeColor(this Material material, string propertyName, Color color)
        {
            if (material.HasColor(propertyName))
            {
                material.SetColor(propertyName, color);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Color.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="texture"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTexture(this Material material, string propertyName, Texture2D texture)
        {
            if (material.HasTexture(propertyName))
            {
                material.SetTexture(propertyName, texture);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Texture.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Vector value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="vector"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeVector(this Material material, string propertyName, Vector4 vector)
        {
            if (material.HasVector(propertyName))
            {
                material.SetVector(propertyName, vector);

                return true;
            }
            else if (material.HasProperty(propertyName))
            {
                Debug.LogError($"{material.name} {propertyName} property type is not Vector.");

                return default;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="keyword">A material keyword.</param>
        /// <param name="enable"></param>
        public static void SetKeyword(this Material material, string keyword, bool enable)
        {
            if (enable)
            {
                material.EnableKeyword(keyword);
            }
            else
            {
                material.DisableKeyword(keyword);
            }
        }

        #endregion
    }
}