using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Damagable
{
    public GameObject player;
    public Rigidbody2D rigidb;
    public float speed = .5f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * speed);
    }
    private void Awake()
    {
        player = GameObject.Find("Player");
        rigidb = gameObject.GetComponent<Rigidbody2D>();
    }

    void moveToPlayer()
    { 
        Vector3.MoveTowards(transform.position, player.transform.position * Time.deltaTime * speed, 5f);
    }

    public override void Despawn(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                PlayerStats playerref = collision.gameObject.GetComponent<PlayerStats>();
                playerref.TakeDamage(health);
                Debug.Log("Dealt Damage to player ${health}");
            }
            else if(collision.gameObject.tag == "Shot")
            {
                TakeDamage(collision.gameObject.GetComponent<shotcollision>().damage);
                Debug.Log($"{collision.gameObject.GetComponent<shotcollision>().damage} taken by enemy");
            }
        }
    }
}
