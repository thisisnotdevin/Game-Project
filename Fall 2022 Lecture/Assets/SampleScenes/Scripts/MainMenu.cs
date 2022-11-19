using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    // private int nextSceneToLoad;
    
    // private void Start()
    // {
    //     nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    // }
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void GameInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void MenuGoBack()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void GameSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void QuitGame() {
        Application.Quit();
    }
}