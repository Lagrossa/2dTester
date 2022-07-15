using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcollision : MonoBehaviour
{
    public BoxCollider2D bCollider;
    public Collider shotCollider;
    public float timeSpawned;
    public float durationAlive;
    public GameObject burn;
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
        if (collision.gameObject.tag != "Damagable" && collision.gameObject.tag != "Wall")
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
        GameObject burning = Instantiate<GameObject>(burn, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(burning, 1f);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
