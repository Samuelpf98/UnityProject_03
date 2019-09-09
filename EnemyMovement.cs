using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float StoppingDistance;
    

    //make the enemy prefab follow the player gameobject

    // Start is called before the first frame update
    void Start()
    {
        
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    void Update()
    {
       
            if (Vector2.Distance(transform.position, target.position) > StoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
   

}
