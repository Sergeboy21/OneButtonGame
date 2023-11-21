using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;

    public TextMeshProUGUI HealthTxt;

    void Update()
    {
        if (health <= 0)
            SceneManager.LoadScene("GameOver");

         HealthTxt.text = health.ToString() + " / 3";

    }
}
