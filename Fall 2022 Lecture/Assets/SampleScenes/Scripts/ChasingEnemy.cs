using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingEnemy : MonoBehaviour
{
    public int health = 20;

    public GameObject deathEffect;
    public AudioClip audioPlayer;


    [SerializeField] float moveSpeed =5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       if(target){
           Vector3 direction = -(target.position - transform.position).normalized;
           float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
           rb.rotation = angle;
           moveDirection = direction;
       } 
    }
    private void FixedUpdate(){
        if(target){
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }
    
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0){
            
            Die();
        }
    }
     void Die ()
    {
     PersistentData.Instance.SetScore(ScoreScript.scoreValue += 20);
     Instantiate(deathEffect, transform.position, Quaternion.identity);
     Destroy(gameObject);
     AudioSource.PlayClipAtPoint (audioPlayer, transform.position);
    }
}
