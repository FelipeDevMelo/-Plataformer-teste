using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    /// <summary>
    /// This class Control the checkpoints colliders and 
    /// interection with the player in the scene.
    /// </summary>
    /// 
    private PlayerCheckpoint playerCheckpoint;

    private void Start()
    {
        playerCheckpoint = GameObject.FindGameObjectWithTag("playerCheck").GetComponent<PlayerCheckpoint>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCheckpoint.lastCheckPosition = transform.position;
        }
    }
}
