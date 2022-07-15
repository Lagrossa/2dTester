using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damagable : MonoBehaviour
{
    [SerializeField]
    protected int maxHealth;
    protected int health;

    //Health bar reference

    private void Awake()
    {
        health = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Despawn(gameObject);
        }
    }

    public abstract void Despawn(GameObject gameObject);

    //health bar update-r
}
