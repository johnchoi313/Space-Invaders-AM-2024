using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject player;
    public float speed = 1.0f;
    
    //Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Move Up if press W
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0, speed, 0);
        }
        //Move Down if press S
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0, -speed, 0);
        }
        //Move Left if press A
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-speed, 0, 0);
        }
        //Move Right if press D
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(speed, 0, 0);
        }
    }
}