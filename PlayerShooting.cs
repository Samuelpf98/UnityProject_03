using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform ShootPosition;
    public Transform ShootPosition2;
    public Transform ShootPosition3;
    public Transform ShootPosition4;

    public int CurrentShootPosition = 0;

    public GameObject ProjectilePrefab;
    private Vector3 target;
    public float offset;

    private float timeBtwShots;
    public float StartTimebtwshots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = target - transform.position;
        float rotationz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationz+offset);
        */

        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {

                CurrentShootPosition = 1;
                ShootUp();
                timeBtwShots = StartTimebtwshots;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                CurrentShootPosition = 2;
                ShootDown();
                timeBtwShots = StartTimebtwshots;   
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                CurrentShootPosition = 3;
                ShootLeft();
                timeBtwShots = StartTimebtwshots;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                CurrentShootPosition = 4;
                ShootRight();
                timeBtwShots = StartTimebtwshots;
            }


        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    
        //crosshairs.transform.position = new Vector2(target.x, target.y);

       
    }

    public void ShootUp()
    {
        
        Instantiate(ProjectilePrefab, ShootPosition.position, transform.rotation);
    }
    public void ShootDown()
    {
        Instantiate(ProjectilePrefab, ShootPosition2.position,transform.rotation);
    }
    public void ShootLeft()
    {
        Instantiate(ProjectilePrefab, ShootPosition3.position,transform.rotation);
    }
    public void ShootRight()
    {
        Instantiate(ProjectilePrefab, ShootPosition4.position,transform.rotation);
    }

    public int getCurrentShootPosition()
    {
        return CurrentShootPosition;
    }
}
