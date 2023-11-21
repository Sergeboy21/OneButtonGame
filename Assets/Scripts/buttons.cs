using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    //main menu button om het spel te starten
    public void StartBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //main menu button om de applicatie te sluiten
    public void Quit()
    {
        Application.Quit();
    }

    //end screen button om terug te gaan naar het main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
