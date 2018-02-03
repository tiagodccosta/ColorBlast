using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AdManager.Instance.ShowBannerDown();
    }

    public void PlayLevelEasy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        AdManager.Instance.ShowBannerDown();
    }

    public void RateApp()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.TiagoDCCosta.ColorBlast");
        AdManager.Instance.ShowBannerDown();
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        AdManager.Instance.ShowBannerDown();
    }

    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        AdManager.Instance.ShowBannerDown();
    }
}
