using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Platformer.Mechanics {
    public class TrampolineController : KinematicObject
    {
        bool onTop;
        Animator anim;
        Rigidbody2D bouncer;
        

        private void Start()
        {
            anim = gameObject.GetComponent<Animator>();
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            if (onTop)
            {

               
            }


        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            onTop = true;
            anim.SetBool("isStepped", true);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            onTop = false;
            anim.SetBool("isStepped", false);

        }


        public void Jump()
        {
           


        }


    }
}