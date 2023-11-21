using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEverySec : MonoBehaviour
{
    public GameObject bullets;
    public Transform shootPoint;
    public float bulletSpeed = 0f;

    private float shooterInterval = 1f;
    private float elapsedTime = 0f; 

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= shooterInterval)
        {
            shoot();
            elapsedTime = 0f;
            Destroy(bullets,1f);
        }
    }

    void shoot()
    {
        var tempBullet  = Instantiate( bullets, shootPoint.position, shootPoint.rotation);
        tempBullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward * bulletSpeed, ForceMode.Impulse);
    }
}
