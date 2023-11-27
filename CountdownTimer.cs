using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float countdownDuration = 5f;  // Duration of the countdown in seconds
    public string nextSceneName;          // Name of the scene to load after countdown

    private float countdownTimer;         // Current countdown time

    private void Start()
    {
        countdownTimer = countdownDuration;
    }

    private void Update()
    {
        countdownTimer -= Time.deltaTime;

        if (countdownTimer <= 0f)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}