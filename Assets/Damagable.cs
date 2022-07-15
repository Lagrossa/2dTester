using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damagable : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;

    private int health;

    private void Start()
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
}
