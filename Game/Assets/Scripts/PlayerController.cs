using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float vSpeed = 0f;
    public float speed = 12f;
    public float gravity = 9.807f;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        if (controller.isGrounded)
        {
            vSpeed = 0f;
            if (Input.GetKeyDown("space"))
            {
                vSpeed = 3;
            }
        }
        vSpeed -= gravity * Time.deltaTime;
        move.y = vSpeed;
        var vel = move * speed;
        controller.Move(vel * Time.deltaTime);
    }
}
