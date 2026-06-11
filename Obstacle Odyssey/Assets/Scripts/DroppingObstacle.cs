using UnityEngine;

public class DroppingObstacle : MonoBehaviour
{
    [SerializeField] private float dropDelay = 3f;
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > dropDelay)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}