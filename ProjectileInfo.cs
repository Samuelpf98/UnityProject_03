using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileInfo : MonoBehaviour
{
    public float speed;
  
    public float lifetime;
    public float distance;

    private bool shootingUp;
    private bool shootingDown;
    private bool shootingLeft;
    private bool shootingRight;

    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifetime);
        int currentshootingPod = GameObject.Find("Player").GetComponent<PlayerShooting>().getCurrentShootPosition();
        if (currentshootingPod == 1)
        {
            shootingUp = true;          
        }
        else if (currentshootingPod == 2)
        {
            shootingDown = true;
        }
        else if (currentshootingPod == 3)
        {
            shootingLeft = true;
        }
        else if (currentshootingPod == 4)
        {
            shootingRight = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (shootingUp == true)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (shootingDown == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (shootingLeft == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if (shootingRight == true)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

    }

    //destroy Projectile GameObject
    private void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        Enemy enemy = collision.GetComponent<Enemy>();
        WallObstacle Wall = collision.GetComponent<WallObstacle>();
        if (enemy != null)
        {
            enemy.getHit();
            DestroyProjectile();
        }
        else if (Wall != null)
        {
            DestroyProjectile();
        }
    }
}
