using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScene : MonoBehaviour
{
   
    void OnCollisionEnter2D (Collision2D col)
    {

      if(col.gameObject.name == "Player"){
           SceneManager.LoadScene("Scene1");
      }
   
}
}
