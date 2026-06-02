using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int scoreCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You've bumped into thing many times: " + scoreCount);
        scoreCount++;
    }
}
