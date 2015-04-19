//This binds an object to the boundaries of a certain camera (on the X and Y axes).
using UnityEngine;
using System.Collections;

public class BindToCamera : MonoBehaviour
{

    private CameraBounds camBinder;

    void Start()
    {
        camBinder = Camera.main.GetComponent<CameraBounds>();
    }

    void Update()
    {
        transform.position = camBinder.CameraBound.ClosestPoint(transform.position);
    }
}
