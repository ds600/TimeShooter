using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    float gravity = -29.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;
    bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        Jump();
    }

    void Jump()
    {
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -8f;
        }
        

        velocity.y = Mathf.Sqrt(jumpHeight * -8f * gravity);
        controller.Move(velocity * Time.deltaTime);
        
        Invoke("DownToEarth", 1);
        Invoke("Jump", 3);
    }

    void DownToEarth()
    {
        velocity.y = gravity;
        controller.Move(velocity * Time.deltaTime);
    }
}
