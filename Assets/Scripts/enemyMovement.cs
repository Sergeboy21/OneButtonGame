using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        GetComponent<Rigidbody>().AddForce(0,0,-Speed);
    }
}
