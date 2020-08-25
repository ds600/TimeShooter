
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public LayerMask layerMask;
    public float range = 100f;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            ShootDelete();
        }
    }

    void Shoot()
    {
        // Shoot Ray that only hits things on the TimeTravel Layer
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, layerMask))
        {
            // See if it actually has a TimeBody script, if it does initiate the rewind method
            TimeBody timebody = hit.transform.GetComponent<TimeBody>();
            if (timebody != null)
            {
                timebody.StartRewind();
            }
            Debug.Log(hit.transform.name);
        }
    }

    void ShootDelete()
    {
        // Shoot Ray that only hits things on the TimeTravel Layer
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, layerMask))
        {
            if (hit.transform.gameObject.tag == "CanonShot")
            {
                if ((transform.position -hit.transform.position).magnitude < 5)
                {
                    transform.parent = null;
                }

                Destroy(hit.transform.gameObject);
            }
        }
    }
}
