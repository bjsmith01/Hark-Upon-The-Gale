//This binds an object's position to the boundaries of a Collider2D object.
//For example, if we put a Collider2D on the Main Camera object and set its bounds to coincide with the camera, then an object with this script cannot go off-screen.
using UnityEngine;
using System.Collections;

public class BindToCollider2D : MonoBehaviour
{

    private Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 pixelPosition = mainCamera.WorldToScreenPoint(transform.position);
        pixelPosition = Vector3.Min((Vector3)mainCamera.pixelRect.max, pixelPosition);
        pixelPosition = Vector3.Max((Vector3)mainCamera.pixelRect.min, pixelPosition);
        transform.position = mainCamera.ScreenToWorldPoint(pixelPosition);
    }

}
