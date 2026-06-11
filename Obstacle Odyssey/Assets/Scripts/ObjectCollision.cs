using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.purple;

            gameObject.tag = "Obstacle";
        }
    }
}