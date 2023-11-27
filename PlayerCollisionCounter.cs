using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerCollisionCounter : MonoBehaviour
{
    public GameObject player;
    public GameObject objectToTrack;
    public Text countText;

    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the objectToTrack
        if (collision.collider.gameObject == objectToTrack)
        {
            collisionCount++;
            UpdateCountText();
        }
    }

    private void UpdateCountText()
    {
        countText.text = "Collision Count: " + collisionCount.ToString();
    }
}