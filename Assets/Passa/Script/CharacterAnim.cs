using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator anim;
    int Jump = Animator.StringToHash("Jump");
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid.AddForce(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }


        if (Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger(Jump);
         }

    }

    void FixedUpdate()
    {
        
    }
}
