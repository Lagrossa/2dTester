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
            DestroyShot();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(0, 3);
        if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "Wall")
        {
            //ignore collisions between shot and player
            Debug.Log(collision.gameObject.tag + " Collision ignored");
            Physics2D.IgnoreCollision(bCollider, collision.collider);
        }
        else
        {
            Debug.Log(collision.gameObject.tag);
            DestroyShot();
        }
    }

    void DestroyShot()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
        Destroy(gameObject, 3f);
    }
}
