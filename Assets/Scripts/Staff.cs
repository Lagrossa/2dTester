using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    public GameObject shot;
    public float forceMultiplier;
    public Transform spawnPoint;



    //TESTING

    public Vector3 mousePost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(Vector2 mouseDirection)
    {
        mousePost = mouseDirection;

        GameObject thisShot = Instantiate<GameObject>(shot);
        thisShot.transform.position = spawnPoint.position;
        thisShot.GetComponent<Rigidbody2D>().AddForce(mouseDirection.normalized * forceMultiplier);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(spawnPoint.position, mousePost.normalized * forceMultiplier);
    }
}
