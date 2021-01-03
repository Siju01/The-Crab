using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour
{
    public GameObject[] stars;
    private int scoresCount, energysCount;

    void Start()
    {
        scoresCount = GameObject.FindGameObjectsWithTag("Score").Length;
        energysCount = GameObject.FindGameObjectsWithTag("Energi").Length;
    }

    public void starsAcheived()
    {
        int score = GameObject.FindGameObjectsWithTag("Score").Length;
        int scoresCollected = scoresCount - score;
        int energi = GameObject.FindGameObjectsWithTag("Energi").Length;
        int energysCollected = energysCount - energi;

        float percentage = float.Parse(scoresCollected.ToString()) / float.Parse(scoresCount.ToString()) * 100f;
        float persen = float.Parse(energysCollected.ToString()) / float.Parse(energysCount.ToString()) * 100f;

        if ((percentage >= 33f && percentage < 66) && (persen >= 33f && persen < 66))
        {
            //one star
            stars[0].SetActive(true);
        }

        else if ((percentage >= 66 && persen < 70) && (persen >= 33f && persen < 66))
        {
            //two stars
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }

        else
        {
            //three stars
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }

    }
    
}
