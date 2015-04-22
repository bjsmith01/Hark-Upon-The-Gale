using UnityEngine;
using System.Collections;

public class BindToCamera : MonoBehaviour
{

    public CameraBounds cameraBounds;

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraBounds.CameraBound.ClosestPoint(transform.position);
    }
}
