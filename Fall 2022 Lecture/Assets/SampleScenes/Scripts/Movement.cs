using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] Rigidbody2D rigid;
	[SerializeField] float movement;
	[SerializeField] int speed = 15;
	[SerializeField] bool isFacingRight = true;
	[SerializeField] bool jumpPressed = false;
	[SerializeField] float jumpForce = 500.0f;
	// [SerializeField] bool isGrounded = true;
	private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator>();
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>(); //animation
    }

    // Update is called once per frame
    //good for user input
    void Update()
    {
		AnimationControl(); //animation
		movement = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
			jumpPressed = true;
		
    }

    //called potentially multiple times per frame
    //use for physics/movement
    void FixedUpdate()
	{
		rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
		if ((movement < 0 && isFacingRight) || (movement > 0 && !isFacingRight))
			Flip();
		if (jumpPressed)
			Jump();
	}

    void Flip()
	{
		transform.Rotate(0, 180, 0);
		isFacingRight = !isFacingRight; 
	}

    void Jump()
	{
		rigid.velocity = new Vector2(rigid.velocity.x, 0);
		rigid.AddForce(new Vector2(0, jumpForce));
		jumpPressed = false;
		//  isGrounded = false;
	}
	private void AnimationControl()
	{
		if(rigid.velocity.y == 0 && rigid.velocity.x ==0)
		{
			anim.Play("IdleAnim");
		}
		if(rigid.velocity.y != 0 || rigid.velocity.x !=0 )
		{
			anim.Play("RunAnim");
		}
		
	}
    // void OnCollisionEnter2D (Collision2D collision)
	// {
	// 	if (collision.gameObject.tag == "Ground")
	// 		isGrounded = true;
	// }
}
