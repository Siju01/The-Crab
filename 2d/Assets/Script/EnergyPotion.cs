using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPotion : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
	{
    	if (col.gameObject.tag.Equals ("Player"))
		{
    		print("Energy potion diambil");
    		Destroy (gameObject);
    		Energi.hitungEnergi += 100;
	    }
	}
}

