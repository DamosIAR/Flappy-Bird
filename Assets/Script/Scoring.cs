using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text Score;
    private int score = 0;

    private void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        Score.text = "Score = 0" + score;

    }

    private void Update()
    {
        UpdateScore();
    }


}
