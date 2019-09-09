using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementX = 0f;
        float movementY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            movementY = +1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementX = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementY = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementX = +1f;
        }
        Vector3 moveDirection = new Vector3(movementX, movementY, 0);

        rb.MovePosition(new Vector2((transform.position.x + moveDirection.x * speed * Time.deltaTime),
            (transform.position.y + moveDirection.y * speed * Time.deltaTime)));
    }

  
}
