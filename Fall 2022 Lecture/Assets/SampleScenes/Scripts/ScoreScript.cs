using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue;
    public static int LivesValue;
    public static int tempScoreValue = 50;
    private int nextScene;
    

    void Start()
    {
       scoreValue = PersistentData.Instance.GetScore();
       LivesValue = PersistentData.Instance.GetLives();
       scoreText = GetComponent<TextMeshProUGUI>();
       nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue + "\n Lives: " + LivesValue;
       if(scoreValue >= tempScoreValue)
       {
           SceneManager.LoadScene(nextScene);
           tempScoreValue += 50;
       }
       
    }
     

    
}