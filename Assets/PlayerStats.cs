using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //I SHOULD use getters/setters but...

    public static float health;
    public static float speed;
    public static float maxHealth;
    public static float atkSpd;
    public static float gold;

    private void Start()
    {
        //Initialize all stats.
        maxHealth = 10;
        speed = 1;
        health = maxHealth;
        atkSpd = .5f;
        gold = 0;
    }

}
