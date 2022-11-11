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
    private int nextScene;
   


    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
       nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
       if(scoreValue == 50)
       {
           SceneManager.LoadScene(nextScene);
       }
    }
}