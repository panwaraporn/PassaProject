﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;
    int Jump = Animator.StringToHash("Jump");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }*/
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(Jump);
        }
    }
}
