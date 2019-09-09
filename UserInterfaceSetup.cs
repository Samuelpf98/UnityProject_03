using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInterfaceSetup : MonoBehaviour
{

    public Text ScoreUI;
    private int Score;
    public GameObject GameOverScreen;
    public GameObject Restartbutton;
    public GameObject QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen.SetActive(false);
        Restartbutton.SetActive(false);
        QuitButton.SetActive(false);
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    public void AddScore()
    {
        Score++;
       
    }
    public void UpdateScore()
    {
        ScoreUI.text = "Score: " + Score;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level01");
    }
}
