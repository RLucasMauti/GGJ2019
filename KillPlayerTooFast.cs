using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerTooFast : MonoBehaviour
{
    public Transform spawnpoint;
    public Transform player;
    public Rigidbody2D rb;

    private void Start()
    {
       
    }

    private void Update()
    {
       // Debug.Log(rb.velocity.magnitude);
        if (rb.velocity.magnitude > 35.0f)
            player.position = spawnpoint.position;
    }

    
}
