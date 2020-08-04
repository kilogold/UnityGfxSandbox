using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

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
