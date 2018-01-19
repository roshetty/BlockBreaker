using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    public Sprite[] hitSprites;
    public static int brakableCount = 0;
    //public AudioClip crack;

    private bool isBreakable;
    private int maxHits;
    private int timesHit;
    private LevelManager LevelManager;

    // Use this for initialization
    void Start()
    {
        isBreakable = (this.tag == "Breakable");  //if the tag if brick is Breakable it will break else it wont.
        if (isBreakable)
        {
            brakableCount++;
            print(brakableCount);
        }
        timesHit = 0;
        LevelManager = GameObject.FindObjectOfType<LevelManager>();

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        //AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable)
        {
            HandleHits();
        }


    }
    void HandleHits()
    {
        timesHit++;
        maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            brakableCount--;
            Destroy(gameObject);
            LevelManager.BrickDestroyed();

        }
        else
        {
            LoadSprites();
        }
    }

    void SimulateWin()
    {
        LevelManager.LoadNextLevel();
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
}
