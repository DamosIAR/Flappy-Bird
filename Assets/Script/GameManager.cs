using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject replayButton;
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;

    public void Play()
    {
        //replayButton.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

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
        Pause();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        //replayButton.SetActive(true);
        playButton.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Pause();
    }

    /*public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }*/
}
