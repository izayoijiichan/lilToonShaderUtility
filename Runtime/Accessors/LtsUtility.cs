// ----------------------------------------------------------------------
// @Namespace : LilToonShader
// @Class     : LtsUtility
// ----------------------------------------------------------------------
#if !LILTOON_1_2_12_OR_OLDER && !LILTOON_1_3_0_OR_NEWER && !LILTOON_1_4_0_OR_NEWER && !LILTOON_1_5_0_OR_NEWER
#define LILTOON_1_5_0_OR_NEWER
#endif
#nullable enable
namespace LilToonShader
{
    using UnityEngine;
    using UnityEngine.Rendering;
    using LilToonShader.Extensions;

#if LILTOON_1_5_0_OR_NEWER
    using LilToonShader.v1_5_0;
#elif LILTOON_1_4_0_OR_NEWER
    using LilToonShader.v1_4_0;
#elif LILTOON_1_3_0_OR_NEWER
    using LilToonShader.v1_3_0;
#elif LILTOON_1_2_12_OR_OLDER
    using LilToonShader.v1_2_12;
#endif

    /// <summary>
    /// lilToon Shader Utility
    /// </summary>
    public class LtsUtility
    {
        #region Fields

#pragma warning disable IDE0090
        /// <summary>A lilToon material getter.</summary>
        protected readonly LilToonMaterialGetter _MaterialGetter = new LilToonMaterialGetter();

        /// <summary>A lilToon material setter.</summary>
        protected readonly LilToonMaterialSetter _MaterialSetter = new LilToonMaterialSetter();
#pragma warning restore IDE0090

        #endregion

        #region Properties

        /// <summary>A lilToon material getter.</summary>
        public LilToonMaterialGetter MaterialGetter => _MaterialGetter;

        /// <summary>A lilToon material setter.</summary>
        public LilToonMaterialSetter MaterialSetter => _MaterialSetter;

        #endregion

        #region Methods

        /// <summary>
        /// Get the lilToon version from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns>The lilToon version.</returns>
        public virtual int GetLilToonVersion(Material material)
        {
            return material.GetLilToonVersion();
        }

        /// <summary>
        /// Get the property values from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns>A lilToon property container.</returns>
        public virtual LilToonPropertyContainer GetPropertyValuesFromMaterial(Material material)
        {
            return _MaterialGetter.GetLilToonPropertyContainer(material);
        }

        /// <summary>
        /// Set the property values to the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyContainer">A lilToon property container.</param>
        public virtual void SetPropertyValuesToMaterial(Material material, LilToonPropertyContainer propertyContainer)
        {
            _MaterialSetter.SetLilToonPropertyValues(material, propertyContainer);
        }

        /// <summary>
        /// Check and get the render pipeline of current Unity project.
        /// </summary>
        /// <returns>
        /// Render Pipeline
        ///  BRP : null
        ///  LWRP : LightweightPipeline.LightweightRenderPipelineAsset
        ///  URP : Universal.UniversalRenderPipelineAsset
        ///  HDRP : HighDefinition.HDRenderPipelineAsset
        /// </returns>
        /// <remarks>
        /// lilInspector.CheckRP()
        /// </remarks>
        public virtual LilRenderPipeline CheckRenderPipeline()
        {
            RenderPipelineAsset? renderPipelineAsset = GraphicsSettings.renderPipelineAsset;

            if (renderPipelineAsset == null)
            {
                return LilRenderPipeline.BRP;
            }
            else
            {
                string renderPipelineAssetName = renderPipelineAsset.name;

                if (string.IsNullOrEmpty(renderPipelineAssetName))
                {
                    return LilRenderPipeline.BRP;
                }
                else if (renderPipelineAssetName.Contains("Lightweight"))
                {
                    return LilRenderPipeline.LWRP;
                }
                else if (
                    renderPipelineAssetName.StartsWith("UniversalRP-") ||
                    renderPipelineAssetName.StartsWith("Universal"))
                {
                    return LilRenderPipeline.URP;
                }
                else if (
                    renderPipelineAssetName.StartsWith("HDRP") ||
                    renderPipelineAssetName.StartsWith("HDRenderPipeline"))
                {
                    return LilRenderPipeline.HDRP;
                }
                else
                {
                    return LilRenderPipeline.BRP;
                }
            }
        }

        #endregion
    }
}