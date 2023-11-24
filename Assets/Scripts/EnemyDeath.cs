using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;


    private void Start()
    {
       score = 0;
    }
    private void Update()
    {
        scoreText.text = score.ToString();

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);

        if (collision.gameObject.tag == "building")
        {
            score++;
        }
        else if (collision.gameObject.tag == "Tonk")
        {
            score += 2;
        }
     }
}
