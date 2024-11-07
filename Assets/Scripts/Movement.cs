using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    Rigidbody rb;
    SpriteRenderer sr;
    Animator anim;

    public float upForce = 100;
    public float speed = 1500;
    public float runSpeed = 2500;

    public bool isGrounded = false;
    bool isLeftShift;
    float moveHorizontal;
    float moveVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sr = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        isLeftShift = Input.GetKey(KeyCode.LeftShift);
        //Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis ("Vertical");

        if (moveHorizontal > 0)
        {
            sr.flipX = false;
        }
        else if(moveHorizontal < 0)
        {
            sr.flipX = true;
        }

        if (moveHorizontal == 0)
        {
            anim.SetBool("IsRunning", false);
        }
        else
        {
            anim.SetBool("IsRunning", true);
        }


        if (isGrounded)
        {
            anim.SetBool("IsJumping", false);
        }
        else
        {
            anim.SetBool("IsJumping", true);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * upForce);
            isGrounded = false;
        }

    }


    private void FixedUpdate()
     
    {
        
        float currentSpeed = isLeftShift ? runSpeed : speed;

       
        rb.velocity = new Vector3(moveHorizontal * currentSpeed * Time.deltaTime, rb.velocity.y, moveVertical * currentSpeed * Time.deltaTime);
    }




    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    }

