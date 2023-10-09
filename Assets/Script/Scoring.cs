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

    public void AddScore()
    {
        source.PlayOneShot(clip);
        Currentscore++;
        ScoreText.text = Currentscore.ToString();
    }

}
