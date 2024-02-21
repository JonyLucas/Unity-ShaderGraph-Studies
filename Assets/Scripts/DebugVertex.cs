using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DebugVertex : MonoBehaviour
{
    
    Mesh mesh;
    Vector3[] vertices;

    private void OnDrawGizmos()
    {
        if(vertices == null)
        {
            mesh = GetComponent<MeshFilter>().sharedMesh;
            vertices = mesh.vertices;
        }

        foreach (var vertex in vertices)
        {
            var vertPosition = $"local: {vertex} \n world: {transform.TransformPoint(vertex)}";
            UnityEditor.Handles.Label(transform.TransformPoint(vertex), vertPosition);
        }
    }
}
