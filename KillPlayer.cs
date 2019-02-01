using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public Transform spawnpoint;
    public Transform player;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.name == "Player")
        {
            player.position = spawnpoint.position;
        }
    }
}
