using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTravel : MonoBehaviour
{
    public Text infoAnzeige;
    public GameObject player;
    bool needsChange = false;

    private void Update()
    {
        if ( Input.GetMouseButtonDown(1) && needsChange)
        {
            infoAnzeige.text = "";
            needsChange = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            infoAnzeige.text = "leftclick blue objects to let them travel back in Time";
            needsChange = true;
        }
    }
}
