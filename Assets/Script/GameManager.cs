using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject menuButton;


    private void Start()
    {
        gameOver.SetActive(false);
        playButton.SetActive(false);
        menuButton.SetActive(false);
    }

    public void Play()
    {
        playButton.SetActive(false);
        gameOver.SetActive(false);
        menuButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void unPause()
    {
        Time.timeScale = 1f;
        player.enabled = true;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        player.enabled = false;
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    public void Menu()
    {
        unPause();
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        menuButton.SetActive(true);
        Pause();
        
    }
}
