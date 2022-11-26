using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue;
    public static int tempScoreValue = 50;
    private int nextScene;
    

    void Start()
    {
       scoreValue = PersistentData.Instance.GetScore();
       scoreText = GetComponent<TextMeshProUGUI>();
       nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
       if(scoreValue == tempScoreValue)
       {
           SceneManager.LoadScene(nextScene);
           tempScoreValue += 50;
       }
       if(scoreValue == 300){ //doesnt get called because of the previous function
           QuitGame();
           Application.Quit();
       }
       
    }
     

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}