using UnityEngine;
using System.Collections;

public class DestroyOutsideCamera : MonoBehaviour
{

    public CameraBounds camBounds;

    private Collider2D   theCollider;

    void Start()
    {
        theCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!camBounds.CameraBound.Intersects(theCollider.bounds))
            Destroy(gameObject);
    }
}
