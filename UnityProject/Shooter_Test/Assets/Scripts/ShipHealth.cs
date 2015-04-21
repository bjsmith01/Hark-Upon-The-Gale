using UnityEngine;
using System.Collections;
/// <summary>
/// Controls a ship's health, destroying it if necessary and setting a max health.
/// It's possible to use Health to set the health directly, but takeDamage() and giveHealth() are usually
/// better alternatives.
/// 
/// If you don't want your ship to die if its health is 0, set immortal to true.
/// </summary>

public class ShipHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public bool immortal = false;
    private int health;

    // Use this for initialization
    void Start()
    {
        health = maxHealth;
    }


    //Set the ship's health (within its boundaries), destroying it if necessary
    private int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = Mathf.Max(0, Mathf.Min(maxHealth, value));
            if (health == 0) onNoHealth();
        }
    }

    // Damage the ship, destroying it if necessary
    public void takeDamage(int amount)
    {
        Health -= amount;
    }

    //Called when the ship runs out of health
    void onNoHealth()
    {
        if (!immortal) Destroy(gameObject);
    }

}
