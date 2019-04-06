using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed = 5f;
    public Animator animator;
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(h, 0,v);
        rigid.AddForce(movement*speed);

        if (v == 0 && h == 0) {
            animator.SetBool("isRunning", false);
        }else
        {
            animator.SetBool("isRunning", true);
        }
      
    }

}
