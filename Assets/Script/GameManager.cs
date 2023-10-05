using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public TMP_Text replayButton;
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;


    private void Start()
    {
        gameOver.SetActive(false);
        playButton.SetActive(false);
    }

    public void Play()
    {
        //replayButton.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        /*Pipes[] pipes = FindObjectOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }*/
    }

    public void Pause()
    {
        Time.timeScale = 0;
        player.enabled = false;
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;
        //Pause();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        //replayButton.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    /*public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }*/
}
