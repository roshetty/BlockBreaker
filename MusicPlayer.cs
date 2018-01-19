using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;   //singleton class used to play music on loop for all levels
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            print("Destroyed duplicate instance (object) OF MUSIC PLAYER");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

}
