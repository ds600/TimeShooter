using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    

    Vector3 startPosition;
    Vector3 newPosition;
    public float distance = 12;
    public int speedX = 5, speedZ = 5;
    int directionX, directionZ;

    private void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    private void Update()
    {

        newPosition += (transform.right * directionX + transform.forward * directionZ)  * Time.deltaTime;
        transform.position = newPosition;


        if ((transform.position - startPosition).magnitude > distance)
        {
            directionX = -speedX;
            directionZ = -speedZ;
        }

        if ((transform.position - startPosition).magnitude < 1)
        {
            directionX = speedX;
            directionZ = speedZ;
        }
    }

    
}
