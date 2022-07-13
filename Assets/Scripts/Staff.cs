using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    public GameObject shot;
    public float forceMultiplier;
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
        GameObject thisShot = Instantiate<GameObject>(shot);
        thisShot.GetComponent<Rigidbody2D>().AddForce(mouseDirection * forceMultiplier);
    }
}
