using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    /// <summary>
    /// This class Control the checkpoints colliders and 
    /// interection with the player in the scene.
    /// this contains the animation of the checkpoint and the sound.
    /// </summary>
    /// 
    private AudioSource audioSrc;
    public GameObject shinningPRefab;
    private PlayerCheckpoint playerCheckpoint;
    public AudioClip CheckPointSound;
    IEnumerator waitSecs()
    {
        GameObject tempPrefab = Instantiate(shinningPRefab) as GameObject;
        tempPrefab.transform.position = transform.position;
        yield return new WaitForSeconds(20f* Time.deltaTime);
        Destroy(tempPrefab);
        Destroy(this.gameObject);
    }//lifeTime of the animation and flag.
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        playerCheckpoint = GameObject.FindGameObjectWithTag("playerCheck").GetComponent<PlayerCheckpoint>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSrc.PlayOneShot(CheckPointSound);
            playerCheckpoint.lastCheckPosition = transform.position;
            StartCoroutine(waitSecs());
        }
    }
}
