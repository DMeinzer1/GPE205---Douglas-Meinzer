using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 2);             // Destroys bullet after 2 seconds
    }
}
