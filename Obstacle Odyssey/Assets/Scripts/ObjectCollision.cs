using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.purple;
    }
}