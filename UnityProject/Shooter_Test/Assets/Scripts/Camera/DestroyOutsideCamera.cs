using UnityEngine;
using System.Collections;
/// <summary>
/// Destroys an object as soon as it leaves the camera.
/// This script requires a Collider2D in order to work.
/// </summary>
public class DestroyOutsideCamera : MonoBehaviour
{

    public CameraBounds camBounds;

    private Collider2D theCollider;

    void Start()
    {
        theCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!camBounds.CameraBound.Contains(transform.position))
            Destroy(gameObject);
    }
}
