using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcollision : MonoBehaviour
{
    public BoxCollider2D bCollider;
    public Collider shotCollider;
    public float timeSpawned;
    public float durationAlive;
    private void Start()
    {
        timeSpawned = Time.time;
        bCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Time.time - timeSpawned > durationAlive)
        {
            GameObject.Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(0, 3);
        if (collision.gameObject.tag != "Enemy")
        {
            //ignore collisions between shot and player
            Physics2D.IgnoreCollision(bCollider, collision.collider);
        }
        else
        {
            Debug.Log(collision.gameObject.tag);
            GameObject.Destroy(gameObject);
        }
    }
}
