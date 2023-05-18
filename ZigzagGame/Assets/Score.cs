using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text sc;
    public BallMovementController ball;
     void Start()
    {
        
    }

     void Update()
    {
        
           sc.text = ball.puan.ToString();
        
    }
}
