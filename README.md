# Unity GFX Sandbox

## Parallax Mapping
![Demo](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Parallax.gif?raw=true)

This technique is implemented using a well-known approach for creating the illusion of depth on a flat surface. 
The shadergraph is quite simple:
![ShaderGraph](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Img2.png?raw=true)

The magic is actually contained in a custom shader function node, which references [ParallaxShaderFunc.hlsl](https://github.com/kilogold/UnityGfxSandbox/blob/master/Assets/ParallaxShaderFunc.hlsl).
 I took the concept from an OpenGL tutorial [here](https://learnopengl.com/Advanced-Lighting/Parallax-Mapping).

## Fresnel Effect
![Demo](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Fresnel.gif?raw=true)

Although Shadergraph already comes with a Fresnel node, I decided to implement my own.
For this experiment, I decided to explore without reading up on any information or Unity docs. 
My only tools were in my imagination (and engine, of course). 
The challenge here was to see if I could replicate an effect by simply remembering games I've played in the past.

## Matrix Manipulations
As I contemplated on resuming development of my [VR Engine](https://dev.azure.com/bonillakelvin/VR%20Engine), I needed to ensure my matrix manipulations & linear algebra skills are still sharp. I needed to visually test my understanding of coordinate system transformations, without writing a ton of Vulkan boilerplate code. I decided to just do a silly sanity test in Unity.
