using UnityEngine;
using System.Collections;

public class DestroyOffscreen : MonoBehaviour {

    public CameraBounds cameraBounds;

    private Collider2D theCollider;

    void Start()
    {
        theCollider = GetComponent<Collider2D>();
    }

	// Update is called once per frame
	void Update () {
        if (!cameraBounds.CameraBound.Intersects(theCollider.bounds))
            Destroy(gameObject);
	}
}
