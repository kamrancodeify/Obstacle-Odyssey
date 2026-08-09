using UnityEngine;

public class DroppingObstacle : MonoBehaviour
{
    [SerializeField] private float dropDelay = 3f;
    MeshRenderer meshRenderer;
    Rigidbody droppingRB;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        droppingRB = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        droppingRB.useGravity = false;
    }

    void Update()
    {
        if (Time.time > dropDelay)
        {
            meshRenderer.enabled = true;
            droppingRB.useGravity = true;
        }
    }
}