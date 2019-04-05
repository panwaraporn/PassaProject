using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 20f;
    public float jumpSpeed = 9f;
    public float maxSpeed = 40f;
    public float jumpPower = 70f;
    public bool grounded;
    public bool grabbed;
    public float jumpRate = 1f;
    private float nextPress = 0.0f;
    private Rigidbody2D rigidbody2d;
    private Physics2D physics2d;
    private Animator anim;
  /*  public GameLogic control; */

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", true);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-7, 7, 7);
        }
        else
        {
            transform.localScale = new Vector3(7, 7, 7);
        }
        if (Input.GetButtonDown("Jump") && Time.time > nextPress)
        {
            nextPress = Time.time + jumpRate;
            rigidbody2d.AddForce((Vector2.up * jumpPower) * jumpSpeed);
        }
    }


    void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");
            rigidbody2d.AddForce((Vector2.right * speed) * h);
            if (rigidbody2d.velocity.x > maxSpeed)
            {
                rigidbody2d.velocity = new Vector2(maxSpeed, rigidbody2d.velocity.y);
            }
            if (rigidbody2d.velocity.x < -maxSpeed)
            {
                rigidbody2d.velocity = new Vector2(-maxSpeed, rigidbody2d.velocity.y);
            }
        }

}
