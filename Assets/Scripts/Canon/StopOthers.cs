using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopOthers : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("CanonShot") )
        {
            Rigidbody rbCollision = collision.gameObject.GetComponent<Rigidbody>();
            rbCollision.velocity = new Vector3( 0, rbCollision.velocity.y, 0);
        }
    }
}
