using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject WinPanel;


    void Start()
    {
        WinPanel.SetActive(false);
    }

    public void Win()
    {
        WinPanel.SetActive(true);
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        
    }
}
