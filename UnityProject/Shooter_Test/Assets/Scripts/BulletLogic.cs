/*
 * This class handles bullet logic
 */

using UnityEngine;
using System.Collections;

public class BulletLogic : MonoBehaviour
{

    public float speed;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); // moves the bullet in a straight line
    }

    // Update is called once per frame
    void Update()
    {

    }
}
