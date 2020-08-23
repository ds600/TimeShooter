using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public CharacterController controller;

    public float speed = 12;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Vector3 move;
    bool isGrounded;

    public float jumpHeight = 3f;

    public bool isOnMovingPlatform = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

        isGrounded = Physics.CheckSphere( groundCheck.position, groundDistance, groundMask );

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        move = transform.right * x + transform.forward * z;

        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }

        velocity.y += gravity * Time.deltaTime;

        if (isOnMovingPlatform == false)
        {
            controller.Move(move * speed * Time.deltaTime);

            controller.Move(velocity * Time.deltaTime);
        }

    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "MovingPlat" && move == Vector3.zero && !Input.GetButton("Jump"))
        {
            isOnMovingPlatform = true;
        } 
        else
        {
            isOnMovingPlatform = false;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "MovingPlat")
        {
            isOnMovingPlatform = false;
        }
    }
}
