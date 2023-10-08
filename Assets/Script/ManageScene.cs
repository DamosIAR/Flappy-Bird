using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    void Start()
    {

    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
