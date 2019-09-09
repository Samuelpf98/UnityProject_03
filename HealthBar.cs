using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public int health;
    public int NoOfHearts;

    public Image[] hearts;
    public Sprite fullheart;
    public Sprite EmptyHeart;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        healthActivity();
        

        
    }
    public void healthActivity()
    {
        if (health > NoOfHearts)
        {
            health = NoOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullheart;

            }
            else
            {
                hearts[i].sprite = EmptyHeart;
            }
            if (i < NoOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void getHit()
    {

        health--;
        if (health <= 0)
        {
            healthActivity();
            Die();
        }
    }

    public void Die()
    {
        GameObject.Find("EventSystem").GetComponent<UserInterfaceSetup>().GameOverScreen.SetActive(true);
        GameObject.Find("EventSystem").GetComponent<UserInterfaceSetup>().Restartbutton.SetActive(true);
        GameObject.Find("EventSystem").GetComponent<UserInterfaceSetup>().QuitButton.SetActive(true);
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject Enemy in Enemies)
        {
            Destroy(Enemy.GetComponent<EnemyMovement>());
            Destroy(Enemy.GetComponent<EnemyShooting>());

        }

       
        
        Destroy(gameObject);
        
    }


}
