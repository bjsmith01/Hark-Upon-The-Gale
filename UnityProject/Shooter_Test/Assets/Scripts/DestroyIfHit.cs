using UnityEngine;
using System.Collections;
//This will destroy this object through its Health script if it collides with a 
//certain enemy.

public class DestroyIfHit : MonoBehaviour
{

    public string dangerTag;

    //private ShipHealth healthScript;

    // Use this for initialization
    void Start()
    {
        //healthScript = GetComponent<ShipHealth>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == dangerTag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
