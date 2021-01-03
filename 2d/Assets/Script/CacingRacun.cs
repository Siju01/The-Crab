using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacingRacun : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
	{
    	if (col.gameObject.tag.Equals ("Player")){
    		print("cacing racun diambil");
    		Destroy (gameObject);
    		Energi.hitungEnergi -= 100;
	    }
	}
}
