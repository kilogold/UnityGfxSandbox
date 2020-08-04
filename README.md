# Unity GFX Sandbox

## Parallax Mapping

![Demo](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Parallax.gif?raw=true)
The technique is implemented using a well-known technique for creating the illusion of depth on a flat surface.

The shadergraph is quite simple:
![ShaderGraph](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Img2.png?raw=true)

The magic is actually contained in a custom shader function node, which references [filename link].
 I took the concept from an OpenGL tutorial [here](https://learnopengl.com/Advanced-Lighting/Parallax-Mapping).

## Fresnel Effect
For this experiment, I decided to explore without looking up any information. 
The challenge here was to see if I could replicate an effect by simply looking at it. 

## Matrix Manipulations
As I contemplated on resuming development of my [VR Engine], I needed to ensure my matrix manipulations & linear algebra skills are still sharp. I needed to visually test my understanding of coordinate system transformations, without writing a ton of Vulkan boilerplate code. I decided to just do a silly sanity test in Unity.