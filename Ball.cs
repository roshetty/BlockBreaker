using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Paddle paddle;
    private bool hasStarted = false;
    private Rigidbody2D rb;
    //private AudioSource Audio;
    private Vector3 paddleToBallvector;
    // Use this for initialization
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallvector = this.transform.position - paddle.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallvector;


            if (Input.GetMouseButtonDown(0))  //on pressing the left mouse button the ball begins to bounce initially
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                hasStarted = true;
            }
        }
    }


    void OnCollisonEnter2D(Collision2D collision)
    {

        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f)); // assignes random vector values to tweak 2D vector
        if (hasStarted)
        {

            //Audio = GetComponent<AudioSource>();
            //Audio.Play();
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = rb.velocity + tweak;   //tweaks the velocity of ball on collision

        }

    }
}
