//This binds an object to the boundaries of a certain camera (on the X and Y axes).
using UnityEngine;
using System.Collections;

public class BindToCamera : MonoBehaviour
{

    public CameraBounds camBounds;

    void Update()
    {
        transform.position = camBounds.CameraBound.ClosestPoint(transform.position);
    }
}
