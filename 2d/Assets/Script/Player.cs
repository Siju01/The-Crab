using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Inventory inventory;

	public GameObject gameOverText, restartButton;

	void Start () {
		gameOverText.SetActive(false);
		restartButton.SetActive (false);
	}

	private void Awake(){
		/*Instance = this;
		playerBase = gameObject.GetComponent<Player_Base>();
		SetStateNormal();*/

		inventory = new Inventory();
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Enemy"))
		{
			gameOverText.SetActive (true);
			restartButton.SetActive (true);
			gameObject.SetActive (false);
		}

		if (col.gameObject.tag.Equals ("Mati"))
		{
			gameOverText.SetActive (true);
			restartButton.SetActive (true);
			gameObject.SetActive (false);
		}
	}

}
