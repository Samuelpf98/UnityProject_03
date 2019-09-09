using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // control fuctionality of buttons in the main menu screen

    public Button PlayButton;
    public Button Quit;

    public void OnPlayButton()
    {
        SceneManager.LoadScene("Level01");
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

