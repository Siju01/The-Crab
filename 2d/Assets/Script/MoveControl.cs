using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    private Rigidbody2D rb;
    
	private bool moveLeft, moveRight;
    
	private float moveSpeed, jumpForce, bulletSpeed;

    public Transform barrel;
    public Rigidbody2D bullet;
	
	// Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       moveSpeed = 5f;
       jumpForce = 715f;
       bulletSpeed = 500f;
       moveLeft = false;
       moveRight = false;
    }

    //i am pressing the left button
    public void MoveLeft()
    {
    	moveLeft = true;
	}
    
    //same thing with the right button
    public void MoveRight()
    {
    	moveRight = true;
    }
    
    public void Jump()
    {
    	if (rb.velocity.y == 0)
    	{
    		rb.AddForce(Vector2.up * jumpForce);
    	}
    }

    public void Fire()
    {
        var firedBullet = Instantiate (bullet, barrel.position, barrel.rotation);
        firedBullet.AddForce (barrel.up * bulletSpeed);
    }
    
    public void StopMoving()
    {
    	moveLeft = false;
    	moveRight = false;
    	rb.velocity = Vector2.zero;
    }
    
	// Update is called once per frame
    private void Update()
    {
        //keyboard
		float horiz = Input.GetAxisRaw("Horizontal");
   		rb.velocity = new Vector2(moveSpeed * horiz, rb.velocity.y);
		
		if (moveLeft)
        {
        	rb.velocity = new Vector2(-moveSpeed, 0f);
        }
        
        if (moveRight)
        {
        	rb.velocity = new Vector2(moveSpeed, 0f);
        }
    }
    
}
