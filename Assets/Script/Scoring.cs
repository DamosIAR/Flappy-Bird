using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int Currentscore = 0;
    public AudioClip clip;
    public AudioSource source;
    private void Start()
    {
        //score = 0;
    }

    public void AddScore()
    {
        source.PlayOneShot(clip);
        Currentscore++;
        ScoreText.text = Currentscore.ToString();
    }

    /*public void UpdateScore()
    {
        Score.text = "Score = 0" + score;

    }

    private void Update()
    {
        UpdateScore();
    }*/


}
