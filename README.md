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
Although Shadergraph already comes with a [Fresnel node]([https://docs.unity3d.com/Packages/com.unity.shadergraph@6.9/manual/Fresnel-Effect-Node.html](https://docs.unity3d.com/Packages/com.unity.shadergraph@6.9/manual/Fresnel-Effect-Node.html)), I decided to blindly implement my own.
For this experiment, I chose to explore without reading any information or Unity docs on the subject. 
My only tools were in my imagination (and engine, of course). 
The challenge here was to see if I could replicate an effect by simply remembering games I've played in the past.

## Matrix Manipulations
![Demo](https://github.com/kilogold/UnityGfxSandbox/blob/master/ReadMe/Matrix.gif?raw=true)

As I contemplated on resuming development of my [VR Engine](https://dev.azure.com/bonillakelvin/VR%20Engine), I wanted to first play with matrix manipulations & linear algebra. I needed to visually review my understanding of coordinate system transformations, without writing a ton of Vulkan boilerplate code. I decided to just do a silly sanity test in Unity.

There is no special logic here. All we do is transform the same point into each matrix representing an alternate collinear coordinate space. 
```cs
public class Mather : MonoBehaviour
{
    public Matrix4x4 origin;
    public Matrix4x4 alternate;
    public Matrix4x4 faceLeft;
    public Matrix4x4 faceLeftChildUp;
    public Vector4 offset;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(origin * offset, Vector3.one);

        Gizmos.color = Color.red;
        Gizmos.DrawCube(origin * alternate * offset, Vector3.one);

        Gizmos.color = Color.green;
        Gizmos.DrawCube(origin * faceLeft * offset, Vector3.one);

        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(faceLeftChildUp * faceLeft * offset, Vector3.one * 0.5f);

        Gizmos.color = Color.magenta;
        var transformation1 = faceLeft * offset;
        var transformation2 = faceLeftChildUp * transformation1;
        Gizmos.DrawCube(transformation1 + transformation2 , Vector3.one * 0.5f);
    }
}
```

This is a neat approach we could use to animate a complex composition of sliding doors, windows, or even fractals. All you need is a series of matrices and a single vector that can be lerped throughout the animation. 