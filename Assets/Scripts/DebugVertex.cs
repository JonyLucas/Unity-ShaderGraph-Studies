using UnityEditor;
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

        var firstCamera = SceneView.GetAllSceneCameras()[0];

        foreach (var vertex in vertices)
        {
            var worldPos = transform.TransformPoint(vertex);
            var viewPosition = firstCamera.WorldToViewportPoint(worldPos);
            var vertPosition = $"local: {vertex} \n world: {worldPos} \n view: {viewPosition}";
            Handles.Label(worldPos, vertPosition);
        }
    }
}
