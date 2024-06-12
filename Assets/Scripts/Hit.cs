using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject target;
    public string tagName = "";
    public float hitDistance = 1f;

    // Update is called once per frame
    void Update()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag(tagName);

        foreach (GameObject bullet in bullets)
        {
            float distance = Vector3.Distance(target.transform.position, bullet.transform.position);

            if (distance < hitDistance)
            {
                Destroy(bullet);
                Destroy(target);
            }
        }
    }
}