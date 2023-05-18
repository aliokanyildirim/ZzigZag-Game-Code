using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisText;
    [SerializeField] TMP_Text highScoreDisText;
    public BallMovementController bmc;

    private void Start()
    {
        ScoreDisplay();
    }
    private void ScoreDisplay()
    {
        scoreDisText.text = "Your Score :" + bmc.puan;
    }
}
