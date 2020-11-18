using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Platformer.Mechanics
{
    /// <summary>
    /// This is the class used to implement the trampoline animation but 
    /// the trampoline effect is in the "PlayerController class".
    /// 
    /// </summary>
    public class TrampolineController : MonoBehaviour
    {
        Animator trampolineAnimetor;
        AudioSource audioSrc;
        public AudioClip jumpElastic;
        private void Start()
        {
            audioSrc = GetComponent<AudioSource>();
            trampolineAnimetor = gameObject.GetComponent<Animator>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            trampolineAnimetor.SetBool("isStepped", true);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {      
            trampolineAnimetor.SetBool("isStepped", false);    
        }

        public void JumpTrampoline()
        {
            audioSrc.PlayOneShot(jumpElastic);
            PlayerController.canJumpTrampoline = true;
        }
    }
}