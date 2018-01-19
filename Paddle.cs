using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    private Ball ball;
    // Use this for initialization
    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();

    }

    public bool autoPlay = false;
    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }

    }

    void AutoPlay() //used for testing.
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        Vector3 ballPositon = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPositon.x, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }
    void MoveWithMouse() //moves the paddle using the mouse.
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        float mousePosInBlocks = ((Input.mousePosition.x) / (Screen.width) * 16); //
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }
}
