using UnityEngine;
using System.Collections;
/// <summary>
/// CameraBounds.cs - Contains CameraBound, which is a read-only Bounds property for the camera.
/// </summary>
public class CameraBounds : MonoBehaviour
{

    private Camera theCamera;
    private Bounds cameraBound;
    private float oldOrthographicSize;

    // Use this for initialization
    void Start()
    {
        theCamera = GetComponent<Camera>();
        cameraBound = new Bounds();
        oldOrthographicSize = 0f;
        recalculate();
    }

    //Recalculate the bounds if the size changed
    public Bounds CameraBound
    {
        get
        {
            if (oldOrthographicSize != theCamera.orthographicSize)
                recalculate();
            else
                cameraBound.center = transform.position;
            return cameraBound;
        }
    }

    //Recalculate Bounds fully
    private void recalculate()
    {
        Vector2 cameraMin, cameraMax;
        cameraMin = theCamera.ViewportToWorldPoint(Vector2.zero);
        cameraMax = theCamera.ViewportToWorldPoint(Vector2.one);
        cameraBound.SetMinMax(cameraMin, cameraMax);
    }

}
