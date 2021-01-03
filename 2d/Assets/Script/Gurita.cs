using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gurita : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
    	if (col.gameObject.tag.Equals ("Bullet"))
		{
    		Score.scoreValue += 100;
            print("Enemy mati, score bertambah 100");
    		Destroy (col.gameObject);
            Destroy (gameObject);
	    }
	}

}
