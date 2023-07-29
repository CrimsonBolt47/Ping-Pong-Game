using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{ 
    [SerializeField] private float speed;
     public Rigidbody2D rb;
    bool begin=false;

    [SerializeField] int playerscore=0;
    [SerializeField] int opponentscore=0;
    Opponent op;

    [SerializeField] GameObject wincanvas;
    [SerializeField] GameObject losecanvas;

    bool didplayerscore;

    StartDifficulty sd;
    bool done;




    private void Start()
    {
        op = FindObjectOfType<Opponent>();
        sd = FindObjectOfType<StartDifficulty>();
    }


    public bool Getbegin()
    {
        return begin;
    }
    public int Getplayerscore()
    {
        return playerscore;

    }
    public int GetOpponent()
    {
        return opponentscore;
    }
    

    void Launch()
    {
        transform.position = Vector2.zero;
        rb.velocity = Vector2.zero;
        if (Input.anyKeyDown)
        {
            begin = true;
            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;
            rb.velocity = new Vector2(x * speed, y * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="WinPlayer")
        {
            playerscore++;
            begin = false;
            op.IncSpeed();
        }
        else if(collision.tag=="WinOpponent")
        {
            opponentscore++;
            begin = false;
          
        }
    }

    void WinLoseCheck()
    {
        if(playerscore==5)
        {
            wincanvas.SetActive(true);

        }
        else if(opponentscore==5)
        {
            losecanvas.SetActive(true);

        }
    }




    void Update()
    {
        if (begin == false&&done==true)
        {
            Launch();
        }
        WinLoseCheck();
        if(sd.GetisSelected()==true&&done==false)
        {
            speed = sd.GetBallSpeed();
            done = true;
        }

       

    }
}
