using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour
{
    public Vector2 force;

    private Rigidbody2D theRigidbody;

    void Start()
    {
        theRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRigidbody.velocity = force;
    }
}
