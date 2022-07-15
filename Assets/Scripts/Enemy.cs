using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Damagable
{
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
            }
            else if(collision.gameObject.tag == "Shot")
            {
                TakeDamage(collision.gameObject.GetComponent<shotcollision>().damage);
            }
        }
    }
}
