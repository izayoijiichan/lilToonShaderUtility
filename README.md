# lilToon Shader Utility

This package is a utility script to get/set lilToon shader property values.

___

## lilToon Version

|version name|version value|
|:---|:---:|
|1.2.12|25|
|1.3.0|26|
|1.3.1|27|

## Shaders

|shader name|shader type|rendering type|rendering mode|
|:---|:---|:---|:---|
|lilToon|Normal|||
|Hidden/lilToonOutline|Normal||Opaque|
|Hidden/lilToonCutout|Normal||Cutout|
|Hidden/lilToonCutoutOutline|Normal||Cutout|
|Hidden/lilToonTransparent|Normal||Transparent|
|Hidden/lilToonTransparentOutline|Normal||Transparent|
|Hidden/lilToonOnePassTransparent|Normal||Transparent|
|Hidden/lilToonOnePassTransparentOutline|Normal||Transparent|
|Hidden/lilToonTwoPassTransparent|Normal||Transparent|
|Hidden/lilToonTwoPassTransparentOutline|Normal||Transparent|
|Hidden/lilToonRefraction|Normal|||
|Hidden/lilToonRefractionBlur|Normal|||
|Hidden/lilToonFur|Normal|Fur|Opaque|
|Hidden/lilToonFurCutout|Normal|Fur|Cutout|
|Hidden/lilToonFurTwoPass|Normal|Fur|Transparent|
|Hidden/lilToonGem|Normal|Gem||
|Hidden/lilToonTessellation|Normal||Opaque|
|Hidden/lilToonTessellationOutline|Normal||Opaque|
|Hidden/lilToonTessellationCutout|Normal||Cutout|
|Hidden/lilToonTessellationCutoutOutline|Normal||Cutout|
|Hidden/lilToonTessellationTransparent|Normal||Transparent|
|Hidden/lilToonTessellationTransparentOutline|Normal||Transparent|
|Hidden/lilToonTessellationOnePassTransparent|Normal||Transparent|
|Hidden/lilToonTessellationOnePassTransparentOutline|Normal||Transparent|
|Hidden/lilToonTessellationTwoPassTransparent|Normal||Transparent|
|Hidden/lilToonTessellationTwoPassTransparentOutline|Normal||Transparent|
|Hidden/lilToonLite|Lite||Opaque|
|Hidden/lilToonLiteOutline|Lite||Opaque|
|Hidden/lilToonLiteCutout|Lite||Cutout|
|Hidden/lilToonLiteCutoutOutline|Lite||Cutout|
|Hidden/lilToonLiteTransparent|Lite||Transparent|
|Hidden/lilToonLiteTransparentOutline|Lite||Transparent|
|Hidden/lilToonLiteOnePassTransparent|Lite||Transparent|
|Hidden/lilToonLiteOnePassTransparentOutline|Lite||Transparent|
|Hidden/lilToonLiteTwoPassTransparent|Lite||Transparent|
|Hidden/lilToonLiteTwoPassTransparentOutline|Lite||Transparent|
|_lil/lilToonMulti|Multi|||
|Hidden/lilToonMultiOutline|Multi|||
|Hidden/lilToonMultiRefraction|Multi|Refraction||
|Hidden/lilToonMultiFur|Multi|Fur||
|Hidden/lilToonMultiGem|Multi|Gem||
|_lil/[Optional] lilToonFakeShadow|FakeShadow|||
|_lil/[Optional] lilToonOutlineOnly|Normal||Opaque|
|_lil/[Optional] lilToonOutlineOnlyCutout|Normal||Cutout|
|_lil/[Optional] lilToonOutlineOnlyTransparent|Normal||Transparent|
|_lil/[Optional] lilToonOverlay|Normal||Transparent||
|_lil/[Optional] lilToonOverlayOnePass|Normal||Transparent|
|_lil/[Optional] lilToonFurOnly|Normal|Fur|Opaque|
|_lil/[Optional] lilToonFurOnlyCutout|Normal|Fur|Cutout|
|_lil/[Optional] lilToonFurOnlyTwoPass|Normal|Fur|Transparent|
|_lil/[Optional] lilToonLiteOverlay|Lite||Transparent|
|_lil/[Optional] lilToonLiteOverlayOnePass|Lite||Transparent|

## Package name

com.izayoi.liltoon.shader.utility

## Assembly name

LilToonShader.Utility

## Assembly file

LilToonShader.Utility.dll

## Namespace

LilToonShader

## Unity

|unity version|
|:---|
|Unity 2019.4|
|Unity 2020.3|
|Unity 2021.3|
|Unity 2022.1|

|render pipeline|description|
|:---|:---|
|BRP|Built-in render pipeline|
|URP|Universal render pipeline|
|HDRP|High Definition render pipeline|

## Install

### Package Manager

{UnityProject}/Packages/manifest.json

```json
{
  "dependencies": {
    "com.izayoi.liltoon.shader.utility": "https://github.com/izayoijiichan/lilToonShaderUtility.git#v1.0.0",
    "jp.lilxyzw.liltoon": "https://github.com/lilxyzw/lilToon.git?path=Assets/lilToon#1.3.1",
    // --- other packages ---
  }
}

```

### Scripting Define Symbol

Used to specify a specific version.

`Projcet Settings` > `Player` > `Other Settings` > `Script Compilation` > `Scripting Define Symbols`

|Scripting Define Symbols|description|
|:---|:---|
|LILTOON_1_3_0_OR_NEWER|Define when using lilToon version 1.3.0 or higher.|
|LILTOON_1_2_12_OR_OLDER|Define when using lilToon version 1.2.12 or lower.|
|(not define)|latest (recommended)|

## Usage

```csharp
using LilToonShader;
using UnityEngine;

public void Method()
{
    var ltsUtility = new LtsUtility();

    // Get all property values.
    LilToonPropertyContainer property = ltsUtility.GetPropertyValuesFromMaterial(material);

    if (property.PropertyEntityType == LilPropertyEntityType.Normal)
    {
        property.NormalPropertyEntity.Emission.EmissionColor = Color.white;
    }
    else if (property.PropertyEntityType == LilPropertyEntityType.Lite)
    {
        property.LitePropertyEntity.Emission.EmissionColor = Color.white;
    }

    // Set all property values.
    ltsUtility.SetPropertyValuesToMaterial(material, property);
}

public void BlockMethod()
{
    var ltsUtility = new LtsUtility();

    // Get property block values.
    LilEmission emission = ltsUtility.MaterialGetter.GetLilEmissionPropertyValues(material);

    emission.EmissionColor = Color.white;

    // Set property block values.
    ltsUtility.MaterialSetter.SetLilEmissionPropertyValues(material, emission);
}

public void OneMethod()
{
    // Get property value.
    var emissionColor = material.GetColor(PropertyName.EmissionColor);

    emissionColor = Color.white;

    // Set property value.
    material.SetColor(PropertyName.EmissionColor, emissionColor);
}

```

## Link

[lilToon](https://lilxyzw.github.io/lilToon)

___
Last updated: 11 July, 2022  
Editor: Izayoi Jiichan

*Copyright (C) 2022 Izayoi Jiichan. All Rights Reserved.*
