using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRespawn : MonoBehaviour
{
    DeathRespawn deathRespawn;
    public GameObject player;
    public Vector3 newRespawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        deathRespawn = player.GetComponent<DeathRespawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            deathRespawn.startPoint = newRespawnPoint;
        }
    }
}
