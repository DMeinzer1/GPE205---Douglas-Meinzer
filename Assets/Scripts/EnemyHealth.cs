using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth = 50;                          // Setting Enemy Health (this can be chnaged in the inspector)
    public static bool isEnemyDead = false;                 // Showing the enemy is alive

    void OnTriggerEnter(Collider other)                     // When the Shell Hits the Collider
    {
        if (other.tag == "Shell")                           // Make sure to set the tag on the shell to "Shell"
        {
            TakeDamage(10);                                 // This will do 10 damage every time a shell hits the enemy tank
            Destroy(other.gameObject);                      // This destroys the shell after impact
            Debug.Log("Hit");                               // This helps show that a hit was made in the log
        }
    }


    public void TakeDamage(int damage)                      // Function to deal damage and test enemy health to see if it needs to be destroyed
    {
        currentHealth = currentHealth - damage;             // deals the damage to current health of the enemy
        if (currentHealth <= 0 && isEnemyDead == false)     // when the current health reaches 0
        {
            Debug.Log("Destroyed" + currentHealth);         // Logs when the enemy is destroyed
            Destroy(gameObject);                            // Destroys the enemy tank off the game
            isEnemyDead = true;                             // Shows the enemy is dead
        }
    }
}
