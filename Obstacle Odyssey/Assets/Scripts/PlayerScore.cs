using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int scoreCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Obstacle")
        {
            Debug.Log("You've bumped into thing many times: " + scoreCount);
            scoreCount++;
        }

        Debug.Log("You've already got the tag");
    }
}
