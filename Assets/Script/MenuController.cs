using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject startMenuCanvas;
    public GameObject settingMenuCanvas;
    public GameObject title;

    public void startButton()
    {
        Debug.Log("Start button clicked");
        // Change ScreenName to Screen Name
        SceneManager.LoadScene("ScreenName");
    }

    public void settingButton()
    {
        Debug.Log("Settings button clicked");
        startMenuCanvas.SetActive(false);
        settingMenuCanvas.SetActive(true);
        title.SetActive(false);
    }

    public void quitButton()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }

    public void backToStartMenu()
    {
        Debug.Log("Back arrow clicked");
        settingMenuCanvas.SetActive(false);
        startMenuCanvas.SetActive(true);
        title.SetActive(true);
    }
}
