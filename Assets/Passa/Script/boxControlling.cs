﻿using UnityEngine;
using System.Collections;

public class boxControlling : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
           gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (Input.GetKey("down"))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
