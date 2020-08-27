using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRespawn : MonoBehaviour
{
    Vector3 startPoint;
    CharacterController ccPlayer;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        ccPlayer = GetComponent<CharacterController>();
    }


    private void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.CompareTag("Death"))
        {
            ccPlayer.enabled = false;
            transform.position = startPoint;
            ccPlayer.enabled = true;

        }
    }
}
