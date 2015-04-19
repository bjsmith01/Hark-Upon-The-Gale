using UnityEngine;
using System.Collections;
/// <summary>
/// Camera Bounds
/// This script's main attraction is CameraBound, a property that basically provides
/// a bounding box for the camera.  The box has a depth of 1.
/// 
/// Currently, the box updates with the camera's position, but it's a bit expensive to
/// recalculate the bounds when it scales.  Keep that in mind.
/// </summary>
public class CameraBounds : MonoBehaviour
{

    private Bounds cameraBound;        // The Camera's world-coordinate bounds.
    private Camera thisCamera;         // The Camera component to be tracked.
    private float oldOrthographicSize; // Used to see if the camera has changed size.

    // Use this for initialization
    void Start()
    {
        thisCamera = GetComponent<Camera>();
        cameraBound = new Bounds();
        RecalculateBounds();
    }

    // This uses lazy evaluation to keep costs down.
    // Intensive re-calculation is only performed when necessary.
    public Bounds CameraBound
    {
        get
        {
            if (thisCamera.orthographicSize != oldOrthographicSize)
            {
                RecalculateBounds();
                oldOrthographicSize = thisCamera.orthographicSize;
            }
            else
            {
                cameraBound.center = transform.position;
            }
            return cameraBound;
        }
    }

    // This completely recalculates the bounds of the camera.
    // Ideally, it's only called when the size is changed.
    private void RecalculateBounds()
    {
        Vector3 cameraMin, cameraMax;
        cameraMin = thisCamera.ViewportToWorldPoint(Vector3.zero);
        cameraMax = thisCamera.ViewportToWorldPoint(Vector3.one);
        cameraBound.SetMinMax(cameraMin, cameraMax);
    }

}
