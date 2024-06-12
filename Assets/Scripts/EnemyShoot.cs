using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bullet;

    public float shootMinTime = 1;
    public float shootMaxTime = 3;

    public float shootTimer = 0;

    void Start()
    {
        shootTimer = Random.Range(shootMinTime,shootMaxTime);   
    }

    // Update is called once per frame
    void Update()
    {
        if (shootTimer <= 0)
        {
            Instantiate(bullet, enemy.transform.position, enemy.transform.rotation);
            shootTimer = Random.Range(shootMinTime, shootMaxTime);
        } 
        else
        {
            shootTimer -= Time.deltaTime;
        }
    }
}
