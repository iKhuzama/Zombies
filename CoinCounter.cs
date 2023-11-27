using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coinCount = 0;
    public string nextSceneName; // Name of the scene to load after collecting 7 coins

    
/* private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            UpdateCoinText();
            // Destroy the collected coin
            // Destroy(other.gameObject);

            if (coinCount >= 7)
            {
                MoveToNextScene();
            }
        }
    } */

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }

    private void MoveToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }


    public void IncrementCoinCount()
    {
        coinCount++;
        UpdateCoinText();

        if (coinCount >= 7)
        {
            MoveToNextScene();
        }
    }
}