using UnityEngine;
using System.Collections;
/// <summary>
/// Provides a bounding box for the camera, CameraBound.
/// 
/// The camera must be orthogonal.  It can be resized, but doesn't work quite perfectly
/// with rotation.
/// </summary>

public class CameraBounds : MonoBehaviour
{

    private Bounds cameraBound;        // The Camera's world-coordinate bounds.
    private Camera theCamera;         // The Camera component to be tracked.
    private float oldOrthographicSize; // Used to see if the camera has changed size.

    // Initializes the camera and thisCamera
    void Start()
    {
        theCamera = GetComponent<Camera>();
        cameraBound = new Bounds();
        RecalculateBounds();
    }

    // cameraBound is recalculated only if the size is changed;
    // otherwise, it's just the position.
    public Bounds CameraBound
    {
        get
        {
            if (theCamera.orthographicSize != oldOrthographicSize)
            {
                RecalculateBounds();
                oldOrthographicSize = theCamera.orthographicSize;
            }
            else
            {
                cameraBound.center = transform.position;
            }
            return cameraBound;
        }
    }

    // Fully recalculates cameraBound.
    private void RecalculateBounds()
    {
        Vector3 cameraMin, cameraMax;
        cameraMin = theCamera.ViewportToWorldPoint(Vector3.zero);
        cameraMax = theCamera.ViewportToWorldPoint(Vector3.one);
        cameraBound.SetMinMax(cameraMin, cameraMax);
    }

}
