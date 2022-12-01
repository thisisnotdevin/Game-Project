using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
    {

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject); 
        
        MegaEnemy Megaenemy = hitInfo.GetComponent<MegaEnemy>();
        if (Megaenemy != null){
            Megaenemy.TakeDamage(damage);
        }
        Destroy(gameObject); 

        ChasingEnemy chasingEnemy = hitInfo.GetComponent<ChasingEnemy>();
        if (chasingEnemy != null){
            chasingEnemy.TakeDamage(damage);
        }
        Destroy(gameObject); 

        Friendly friend = hitInfo.GetComponent<Friendly>();
        if (friend != null){
            friend.TakeDamage(damage);
        }
        Destroy(gameObject);

    }
    
    
}
