using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float life = 10f;
    void Start()
    {
       Destroy(gameObject, life);
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        gameObject.transform.Translate(0,speed * dt,0);
    }
}
