using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacing : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
	{
    	if (col.gameObject.tag.Equals ("Player"))
		{
    		print("cacing diambil");
    		Destroy (gameObject);
    		Energi.hitungEnergi += 10;
	    }
	}
}
 /////
