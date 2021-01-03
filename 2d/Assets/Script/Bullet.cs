using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float destroyTime = 2f;

    void OnCollisionEnter2D (Collision2D col)
	{
    	if (col.gameObject.tag == "Enemy")
		{
    		print("Enemy hancur");
    		Destroy (gameObject);
            Destroy(col.gameObject);
    		//Energi.hitungEnergi += 10;
	    }
	}
    
    // Start is called before the first frame update
    /*void Start()
    {
        Destroy (gameObject, destroyTime);
        //rb = GetComponent<Rigidbody2D> ();
    }*/



    /*public float velX = 5f;
    float velY = 0f;
    Rigidbody2D rb;*/

    // Update is called once per frame
    /*void Update()
    {
        rb.velocity = new Vector2 (velX, velY);
    }*/
}
