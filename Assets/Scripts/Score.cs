using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    Ball ball;
    [SerializeField] TextMeshProUGUI playertext;
    [SerializeField] TextMeshProUGUI opponenttext;
    void Start()
    {
        ball = FindObjectOfType<Ball>();     
    }
    // Update is called once per frame
    void Update()
    {
        playertext.text = ball.Getplayerscore().ToString();
        opponenttext.text = ball.GetOpponent().ToString();
      
    }
}
