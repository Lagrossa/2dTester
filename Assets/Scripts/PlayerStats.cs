using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Damagable
{
    //I SHOULD use getters/setters but...
    public static float speed;
    public static float atkSpd = .5f;
    public static float gold;

    public override void Despawn(GameObject gameObject)
    {
        //Play Death Particles and do death effects
        Destroy(gameObject);
    }

    private void Start()
    {
        //Initialize all stats.
        speed = 1;
        gold = 0;
    }

}
