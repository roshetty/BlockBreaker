using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Level Load Requested for" + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest(string name)
    {
        Debug.Log("Level Quit Requested for" + name);  //closes the application.
        Application.Quit();
    }

    public void ReturnLevel(string name)
    {
        Debug.Log("Level Return Requested for" + name);
        Application.LoadLevel(name);
    }
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);   //after winning loads the next level in order 
    }

    public void BrickDestroyed()
    {
        if (brick.brakableCount <= 0)   // if brick  count is less than equal to zero load next level.
        {
            LoadNextLevel();
        }

    }
}
