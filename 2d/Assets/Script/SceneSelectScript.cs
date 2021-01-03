using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene(){
        switch (this.gameObject.name) {
            case "PlayButton" :
                SceneManager.LoadScene ("Level1");
                break;
        }

        switch (this.gameObject.name)
        {
            case "CreditsButton":
                SceneManager.LoadScene("Credits");
                break;
        }

        switch (this.gameObject.name)
        {
            case "BackC":
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }
}
