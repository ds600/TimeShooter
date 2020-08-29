using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyText : MonoBehaviour
{
    public Text infoAnzeige;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            infoAnzeige.text = "Rightclick blue objects to destroy them";
        }
    }
}
