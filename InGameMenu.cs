using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Restart;
    public GameObject Quit;
    int pressed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Pause.SetActive(false);
        Restart.SetActive(false);
        Quit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //fix this
        if (pressed == 0 && Input.GetKey(KeyCode.Escape))
        {

                pressed = 1;
                Pause.SetActive(true);
                Restart.SetActive(true);
                Quit.SetActive(true);
            
        }
        else if (pressed == 1&& Input.GetKey(KeyCode.Escape))
        {
           
                pressed = 0;
                Pause.SetActive(false);
                Restart.SetActive(false);
                Quit.SetActive(false);
          
        }
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level01");
    }
    public void QuitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
