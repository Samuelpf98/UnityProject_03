using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getHit()
    {
        
        health--;
        if (health <= 0)
        {
            GameObject.Find("EventSystem").GetComponent<UserInterfaceSetup>().AddScore();
            Die();
            
        }
    }

    public void Die()
    {
        
        Destroy(gameObject);

    }
}
