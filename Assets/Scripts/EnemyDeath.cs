using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "building")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //score++
        }
     }
}
