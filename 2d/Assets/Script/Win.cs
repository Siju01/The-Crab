using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Win : MonoBehaviour
{
	//public GameObject GameManager;
	//public Text scoreText, energyText;
	//public static GameManager instance;

	/*void Start()
    {
        rightCollider.SetActive(false);
		levelDialog.SetActive (false);
    }*/

	/*IEnumerator Finish (GameObject win)
	{
		yield return new WaitForSeconds(1f);
		win.SetActive(false);

		GetComponent<Energi>();
		GetComponent<Score>();

		if (win.gameObject.tag == "Player")
		{
			UIHandler.instance.ShowLevelDialog("Level Cleared", "Score", "Energi");
		}
	}*/

	private void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			UIHandler.instance.ShowLevelDialog("Level Cleared", "Energi", "Score");
			//GameManager.instance.Win();
		}
	}

	/*void Update ()
	{
		OnTriggerEnter2D (Collision 2D col);
	}*/

}

/*if (col.gameObject.tag.Equals ("Player"))
		{
			UIHandler.ShowLevelDialog("Level Cleared", scoreText.text, energyText.text);
			//gameObject.SetActive (false);
		}*/