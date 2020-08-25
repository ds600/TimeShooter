using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject canonBall;
    Vector3 canonBallStart;

    GameObject player;
    public GameObject target;
    GameObject prefab;

    float speed = 60;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("First Person Player");
        
        if (target.transform.position.z < transform.position.z)
        {
            canonBallStart = new Vector3(transform.position.x, transform.position.y, transform.position.z - 3);
        } 
        else
        {
            canonBallStart = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
        }
        

        SpawnBall();
    }

    private void Update()
    {
        if (prefab == null)
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        // Instantiate the canonball prefab and set its velocity to speed in direction of the target, ignore height difference
        prefab = Instantiate(canonBall, canonBallStart, Quaternion.identity);
        Rigidbody rbPrefab = prefab.GetComponent<Rigidbody>();
        rbPrefab.velocity = (target.transform.position - transform.position).normalized * speed;
        rbPrefab.velocity = new Vector3(rbPrefab.velocity.x, 0, rbPrefab.velocity.z);

    }

}
