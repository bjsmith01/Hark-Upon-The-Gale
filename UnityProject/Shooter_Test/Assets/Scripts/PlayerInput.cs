/*
 * Class handles the player's input
 * 
 * Enables simple movement along the 2D plane through keyboard (or gamepad) input.
 * This works using this object's Rigidbody2D so as to work with Unity's collisions
 * system. 
 * 
 */

using UnityEngine;
using System.Collections;


public class PlayerInput : MonoBehaviour
{

    public Vector2 movementSpeed;

    public GameObject shot; // holds instance of bullet
    public Transform shotSpawn;  //spawner for shots

    public float fireRate; //how fast shot is fired
    private float nextFire;  // how long to wait until next shot

    private Rigidbody2D theRigidbody;

    void Awake()
    {
        theRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveDim = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveDim.Scale(movementSpeed);
        //transform.Translate(moveDim * Time.deltaTime);
        theRigidbody.velocity = moveDim;
    }



}
