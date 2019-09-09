using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileInfo : MonoBehaviour
{

    public float speed;
    
    private Transform player;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x==target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthBar player1 = collision.GetComponent<HealthBar>();
        WallObstacle Wall = collision.GetComponent<WallObstacle>();
        if (player1 != null)
        {
            player1.getHit();
            DestroyProjectile();
        }
        else if (Wall != null)
        {
            DestroyProjectile();
        }
    }

    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
