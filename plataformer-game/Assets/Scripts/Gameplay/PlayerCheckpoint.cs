using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    /// <summary>
    /// This class Control the checkpoints in the scene.
    /// This allows to save the last position of the player.
    /// </summary>
    private static PlayerCheckpoint instance;
    public Vector2 lastCheckPosition;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
