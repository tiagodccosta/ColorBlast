using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    bool paused;
    public GameObject pauseScreen;

    public void Start()
    {
        paused = false;
        pauseScreen.SetActive(false);
    }

    public void PauseGame()
    {
        paused = !paused;

        if (!paused)
        {
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
        }
        else if (paused)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
    }

    public void KeepPlaying()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        AdManager.Instance.ShowBannerDown();
    }

    public void MainMenuLevelEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        AdManager.Instance.ShowBannerDown();
    }
}
