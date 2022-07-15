using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Damagable
{
    public override void Despawn(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.gameObject.tag == "Player")
        {
            PlayerStats playerref = collision.gameObject.GetComponent<PlayerStats>();
            playerref.TakeDamage(health);
        }
    }
}
