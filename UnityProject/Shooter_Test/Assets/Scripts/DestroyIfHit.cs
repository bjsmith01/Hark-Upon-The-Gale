using UnityEngine;
using System.Collections;
//This will destroy this object through its Health script if it collides with a 
//certain enemy.

public class DestroyIfHit : MonoBehaviour
{

    public string dangerTag;

    private ShipHealth healthScript;

    // Use this for initialization
    void Start()
    {
        healthScript = GetComponent<ShipHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log(other.name);
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
    /*
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("HI");
        //if (other.gameObject.tag == dangerTag)
          //  healthScript.takeDamage(healthScript.maxHealth);
    }*/

}
