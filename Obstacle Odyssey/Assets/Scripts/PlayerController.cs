using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Use the arrow keys or WASD to move your character.");
        Debug.Log("Avoid obstacles and reach the goal to win!");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
