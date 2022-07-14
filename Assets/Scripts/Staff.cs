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

    public void Fire(Vector3 mouseDirection, Vector3 offset)
    {
        mousePost = mouseDirection;

        GameObject thisShot = Instantiate<GameObject>(shot, spawnPoint.position, spawnPoint.rotation);
        thisShot.GetComponent<Rigidbody2D>().AddForce(spawnPoint.up * forceMultiplier, ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(spawnPoint.position, mousePost.normalized * forceMultiplier);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(spawnPoint.position, mousePost);
    }
}
