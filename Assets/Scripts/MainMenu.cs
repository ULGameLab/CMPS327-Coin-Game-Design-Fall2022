using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI countText; // Assign this in inspector

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (countText) 
        { 
            countText.text = "Coins Collected = " + CountCoins.numCoinsCollected; 
        }
    }

    public void QuitGameButton()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("CoinGame");  
    }

    public void RestartGame()
    {
        CountCoins.numCoinsCollected = 0;
        SceneManager.LoadScene("CoinGame");
    }
}
