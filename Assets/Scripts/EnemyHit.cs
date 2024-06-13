using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public GameObject target;
    public string tagName = "";
    public float hitDistance = 1f;

    public GameObject explosion;

    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag(tagName);

        foreach (GameObject bullet in bullets)
        {
            float distance = Vector3.Distance(target.transform.position, bullet.transform.position);

            if (distance < hitDistance)
            {
                Debug.Log("Somebody " + target.name + " was hit!");

                gameManager.IncreaseScore(1);

                GameObject explosionCopy = Instantiate(explosion, target.transform.position, target.transform.rotation);
                Destroy(explosionCopy, 3);
                Destroy(bullet);
                Destroy(target);
            }
        }
    }
}