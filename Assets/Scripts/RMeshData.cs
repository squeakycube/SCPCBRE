using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class RMeshData : MonoBehaviour
{
    public MeshData visibleData;
    public Mesh invisibleMesh;
    public RMTriggerBox[] triggerBoxes;
    public Mesh collisionMesh;
    public GameObject[] entities;

    public void RefreshData()
    {
        transform.localScale = Vector3.one * RMeshLoader.Scale;
        GetComponent<MeshFilter>().sharedMesh = visibleData.mesh;
        GetComponent<MeshRenderer>().sharedMaterials = visibleData.materials;
        GetComponent<MeshCollider>().sharedMesh = collisionMesh;
    }
}