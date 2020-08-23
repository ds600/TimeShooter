using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject canonBall;
    Vector3 canonBallStart;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("First Person Player");
        canonBallStart = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z - 3);

        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        // Instantiate the canonball prefab and set its velocity to 50 in the "back" direction
        GameObject prefab = Instantiate(canonBall, canonBallStart, Quaternion.identity);
        prefab.GetComponent<Rigidbody>().velocity = Vector3.back * 50;
        Invoke("SpawnBall", 10);
        StartCoroutine(DestroyGameObject(prefab));

    }

    IEnumerator DestroyGameObject(GameObject prefab)
    {
        // Destroy the transmitted Object after 10 secs., should the player be a child of the Object, then he get removed before the destruction
        yield return new WaitForSeconds(10);
        if ((player.transform.position - prefab.transform.position).magnitude < 5)
        {
            player.transform.parent = null;
        }
        Destroy(prefab);


    }

}
