# Double-Sided Alpha Texture Shader

This folder contains the Double-Sided Alpha Texture Shader for Unity, which allows for rendering both the front and back faces of geometry. This is particularly useful for creating materials where transparency and details need to be visible from all directions, such as in the case of leaves, banners, or fabrics.

## Features

- **Physically-based rendering**: Integrates seamlessly with Unity's standard lighting.
- **Double-sided rendering**: Both sides of the geometry are rendered, avoiding the need for duplicate geometry.
- **Separate alpha texture control**: Allows precise control over transparency using a dedicated alpha texture.
- **Support for standard maps**: Includes albedo, metallic, smoothness, and normal maps.

## Installation

1. Clone or download this repository.
2. Navigate to the `DoubleSided` folder.
3. Copy the `.shader` file into your Unity project's `Assets` directory.

## Usage

To use the double-sided shader:
1. Create a new material in Unity.
2. In the Material Inspector, change the Shader to `Custom/AlphaTextureShaderDoubleSided`.
3. Assign the textures to the respective slots:
   - **_MainTex**: Albedo (color texture).
   - **_MetallicGlossMap**: Metallic properties.
   - **_AlphaTex**: Alpha texture for transparency control.
   - **_Glossiness**: Surface smoothness.
   - **_BumpMap**: Normal map.
4. Apply this material to any mesh that requires double-sided rendering.
