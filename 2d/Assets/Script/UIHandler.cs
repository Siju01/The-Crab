using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler instance;
    public GameObject LevelDialog;
    public Text LevelStatus;
    public Text scoreText, energyText;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void ShowLevelDialog(string status, string scores, string energys)
    {
        GetComponent<StarsHandler>().starsAcheived();
        LevelDialog.SetActive(true);
        LevelStatus.text = status;
        scoreText.text = scores;
        energyText.text = energys;
    }
}
