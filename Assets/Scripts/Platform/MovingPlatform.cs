﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    

    Vector3 startPosition;
    Vector3 newPosition;

    int direction = 1;

    private void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    private void Update()
    {
        newPosition += transform.right * direction * Time.deltaTime;

        transform.position = newPosition;

        if ((transform.position - startPosition).magnitude > 12)
        {
            direction = -1;
        }

        if ((transform.position - startPosition).magnitude < 1)
        {
            direction = 1;
        }
    }

    
}