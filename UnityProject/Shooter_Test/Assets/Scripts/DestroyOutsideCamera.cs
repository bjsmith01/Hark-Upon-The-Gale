using UnityEngine;
using System.Collections;

public class DestroyOutsideCamera : MonoBehaviour
{

    private CameraBounds camBinder;
    private Collider2D   theCollider;

    void Start()
    {
        camBinder = Camera.main.GetComponent<CameraBounds>();
        theCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!camBinder.CameraBound.Intersects(theCollider.bounds))
            Destroy(gameObject);
    }
}
