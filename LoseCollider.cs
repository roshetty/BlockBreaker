using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager Levelmanage;
   
    
    void Start()
    {
        Levelmanage = GameObject.FindObjectOfType<LevelManager>();
    }
	void OnTriggerEnter2D(Collider2D trigger) // on collision with lose collider at bottom the game ends.
    {
        print("Triggered");
        Levelmanage.LoadLevel("Lose");
    }

}

