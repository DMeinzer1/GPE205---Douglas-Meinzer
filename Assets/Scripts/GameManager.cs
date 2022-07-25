using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public int playerHealth = 100;
    public int kills = 0;



    // Use this for initialization
    void Start ()
    {

    }

    private void Awake()
    {
        // Ensures only one game manager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("There is already an instance of GameManager in the scene.");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
