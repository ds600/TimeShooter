using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMovement : MonoBehaviour
{
    float zRotation;
    // Start is called before the first frame update
    void Start()
    {
        zRotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(45, 45, zRotation);
        zRotation += 1;
    }
}
