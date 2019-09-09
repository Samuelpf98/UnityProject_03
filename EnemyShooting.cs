using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
  

    public GameObject ProjectilePrefab;
    private Transform target;


    private float timeBtwShots;
    public float StartTimebtwshots;
    

    // Start is called before the first frame update
    void Start()
    {
       
        timeBtwShots = StartTimebtwshots;
        
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

// Update is called once per frame
void Update()
    {
       
            if (timeBtwShots <= 0)
            {
                Shooting();
                timeBtwShots = StartTimebtwshots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    

    public void Shooting()
    {
        Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        
    }
   
}

