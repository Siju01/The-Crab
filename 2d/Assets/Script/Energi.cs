using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energi : MonoBehaviour
{
	public static int hitungEnergi;
	Text hitungEnergiText;
    public GameObject gameOverText, restartButton;

    void Start()
    {
        hitungEnergi = 50;
        hitungEnergiText = GetComponent <Text> ();
        gameOverText.SetActive (false);
        restartButton.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        hitungEnergiText.text = hitungEnergi.ToString ();
        
        if (hitungEnergi <= 0)
        {
            gameOverText.SetActive (true);
            restartButton.SetActive (true);
            gameObject.SetActive (false);
        }
    }
}
