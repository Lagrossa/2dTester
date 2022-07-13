using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       rigidbody.MovePosition(new Vector2(transform.position.x,transform.position.y)+movement.normalized * Time.fixedDeltaTime * speed);
    }
}
