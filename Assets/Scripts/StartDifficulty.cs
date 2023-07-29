using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDifficulty : MonoBehaviour
{
    [SerializeField] GameObject startgame;
    [SerializeField] GameObject difficulty;
    float enemyspeed=0;
    float ballspeed=0;
    bool isselected;
    private void Start()
    {
        Time.timeScale = 0;
    }

    public bool GetisSelected()
    {
        return isselected;

    }
    public float GetEnemyspeed()
    {
        return enemyspeed;
    }
    public float GetBallSpeed()
    {
        return ballspeed;
    }

    public void PlayGame()
    {
        startgame.SetActive(false);
        difficulty.SetActive(true);
        

    }
    public void Easy()
    {
        enemyspeed = 0.07f;
        ballspeed = 6;
        isselected = true;
        Time.timeScale = 1f;
        difficulty.SetActive(false);

    }
    public void Medium()
    {
        enemyspeed = 0.09f;
        ballspeed = 7;
        isselected = true;
        Time.timeScale = 1f;
        difficulty.SetActive(false);

    }
    public void Hard()
    {
        enemyspeed = 0.12f;
        ballspeed = 9;
        isselected = true;
        Time.timeScale = 1f;
        difficulty.SetActive(false);

    }
}
