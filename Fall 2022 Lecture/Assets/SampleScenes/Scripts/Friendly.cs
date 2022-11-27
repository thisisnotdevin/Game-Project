using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Friendly : MonoBehaviour
{
    
    public int health = 50;

    public GameObject deathEffect;
    public AudioClip audioPlayer;
    
    // Start is called before the first frame update

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0){
            
            Die();
        }
    }

    // Update is called once per frame
    void Die ()
    {
     //ScoreScript.scoreValue -= 10;
     PersistentData.Instance.SetScore(ScoreScript.scoreValue -= 10);
     
     Instantiate(deathEffect, transform.position, Quaternion.identity);
     Destroy(gameObject);
     AudioSource.PlayClipAtPoint (audioPlayer, transform.position);
    }
}
