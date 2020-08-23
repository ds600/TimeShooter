using UnityEngine;

/// <summary>
/// Class to save the Rotation and Position of objects. It is used in for TimeBody Script.
/// </summary>
public class PointInTime 
{
    public Vector3 position;
    public Quaternion rotation;

    public PointInTime (Vector3 _position, Quaternion _rotation)
    {
        position = _position;
        rotation = _rotation;
    }
}
