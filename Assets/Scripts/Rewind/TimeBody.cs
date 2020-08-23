using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeBody : MonoBehaviour
{
    bool isRewinding = false;

    List<PointInTime> pointsInTime;

    public float rewindTime = 5f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        if (GetComponent<Rigidbody>() != null)
        {
            rb = GetComponent<Rigidbody>();
        }
        
        pointsInTime = new List<PointInTime>();
    }

    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Record()
    {
        if (pointsInTime.Count < Mathf.Round(rewindTime / Time.fixedDeltaTime))
        {
            pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
        }
        
    }

    void Rewind()
    {
        if (pointsInTime.Count > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartRewind();
        }
        if(Input.GetKeyUp(KeyCode.Return))
        {
            StopRewind();
        }
    }

    public void StartRewind ()
    {
        if (GetComponent<Rigidbody>() != null)
            rb.isKinematic = true;
        isRewinding = true;
    }
    
    public void StopRewind ()
    {
        if (GetComponent<Rigidbody>() != null)
            rb.isKinematic = false;
        isRewinding = false;
    }
}
