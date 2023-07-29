using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    public float speed;
    public GameObject ball;
    Vector2 opponent;
    Vector3 ballPosition;
    Vector3 paddlePosition;
    Vector2 originalpos;

    Ball ballstatus;

    StartDifficulty sd;
    bool done;


   
    void Start()
    {
        ballstatus = ball.GetComponent<Ball>();
        originalpos = this.transform.position;
        Debug.Log(ballstatus.Getbegin());
        sd = FindObjectOfType<StartDifficulty>();
       
    }
    void EnemyAi()
    {
        ballPosition = ball.transform.position;
        paddlePosition = this.transform.position;
        if (paddlePosition.y > ballPosition.y)
        {
            paddlePosition.y -= speed;
        }
        else if (paddlePosition.y < ballPosition.y)
        {
            paddlePosition.y += speed;
        }

        transform.position = paddlePosition;

    }
    public void IncSpeed()
    {
        speed = speed + 0.02f;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (ballstatus.Getbegin() == false)
        {
            transform.position = originalpos;
        }
        else
        {
            EnemyAi();
        }
        if (sd.GetisSelected() == true && done == false)
        {
            speed = sd.GetEnemyspeed();
            done = true;
        }




    }
}
