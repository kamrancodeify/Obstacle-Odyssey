using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField] float spinSpeedX = 0f;
    [SerializeField] float spinSpeedY = 0f;
    [SerializeField] float spinSpeedZ = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(spinSpeedX, spinSpeedY, spinSpeedZ);
    }
}
