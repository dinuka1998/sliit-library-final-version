using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLIITplayer : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGround;
    Vector3 velocity;

    void Start()
    {
        
    }

    
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
