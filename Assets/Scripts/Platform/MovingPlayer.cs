using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("First Person Player");
    }

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject == player)
        {
            player.transform.parent = null;
        }
    }
}
