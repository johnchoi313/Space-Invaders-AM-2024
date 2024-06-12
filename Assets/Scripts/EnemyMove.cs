using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject enemy;
    
    public float xAmplitude = 1f;
    public float xPeriod = 1f;
    float xStart = 0f;

    public float yAmplitude = 1f;
    public float yPeriod = 1f;
    float yStart = 0f;

    // Start is called before the first frame update
    void Start()
    {
        xStart = enemy.transform.position.x;
        yStart = enemy.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = xAmplitude * Mathf.Sin(xPeriod * Time.time) + xStart;
        float yPos = yAmplitude * Mathf.Sin(yPeriod * Time.time) + yStart;

        enemy.transform.position = new Vector3(xPos, yPos, 0);
    }
}
