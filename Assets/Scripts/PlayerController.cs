using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 90;                           // Default turn speed of the tank (can be modified in the inspector)
    public float speed = 5.0f;                             // Default speed of the tank (can be modified in the inspector)

	void Update ()
    {
        var movementAmount = speed * Time.deltaTime;       // Allows the tank to move
        var turnAmount = turnSpeed * Time.deltaTime;       // Allows the tank to turn

        if (Input.GetKey("w"))                             // Movement control key set
        {
            transform.Translate(0, 0, movementAmount);     // Allows movement forward
        }
        if (Input.GetKey("s"))                             // Movement control key set
        {
            transform.Translate(0, 0, -movementAmount);    // Allows movement backwards
        }
        if (Input.GetKey("a"))                             // Movement control key set
        {
            transform.Rotate(0, -turnAmount, 0);           // Allows left turn
        }
        if (Input.GetKey("d"))                             // Movement control key set
        {
            transform.Rotate(0, turnAmount, 0);            // Allows right turn
        }
    }
}
