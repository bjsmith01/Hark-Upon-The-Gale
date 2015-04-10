using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour
{

    public Vector2 force;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(force * Time.deltaTime);
    }
}
