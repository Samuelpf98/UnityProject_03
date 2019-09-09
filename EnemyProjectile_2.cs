using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile_2 : MonoBehaviour
{
    public float movespeed;
    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        Vector2 dir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
       
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
        else if(Wall != null)
        {
            DestroyProjectile();
        }
    }

    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
