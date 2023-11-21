using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] spawns;
    public GameObject enemy;

    //spawntimer shit
    float timer;
    public int spawnInterval;

    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);

        if (timer >= spawnInterval) //(Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        timer = 0;

        int randomIndeSpawn = Random.Range(0, spawns.Length);

        var tempEnemy = Instantiate(enemy, spawns[randomIndeSpawn].transform.position, Quaternion.identity);

        Destroy(tempEnemy, 5);
    }
}
