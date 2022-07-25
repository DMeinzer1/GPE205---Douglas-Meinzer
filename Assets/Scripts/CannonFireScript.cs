using UnityEngine;
using System.Collections;

public class CannonFireScript : MonoBehaviour
{
    public float shellSpeed = 5f;       // Defualt speed of the shell (can be modified in the inspector
    public Rigidbody shell;             // Shell object (in the inspector place the shell prefab for this)
    public Transform Spawnpoint;        // Where the shell spawns (make sure to place a blank object and set it at the front of the barrel. you must also place this script on that object and put that object to this place in the inspector)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                                                    // Uses the space bar to fire the shell
        {
            Rigidbody clone;                                                                    // Initializes the shell clone
            clone = Instantiate(shell, transform.position, transform.rotation) as Rigidbody;    // Creates the shell in game
            clone.AddForce(transform.forward * shellSpeed, ForceMode.Impulse);                  // Fires the shell forward
        }
    }
}
