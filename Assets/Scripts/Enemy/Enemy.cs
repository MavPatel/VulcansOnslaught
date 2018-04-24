using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private int health;
    private int attackSpeed;
    private int damage;
    private int moveSpeed;

	public Enemy(int health,int attackSpeed,int damage, int moveSpeed)
    {
        this.health = health;
        this.attackSpeed = attackSpeed;
        this.damage = damage;
        this.moveSpeed = moveSpeed;
    }

    public void PrintStats()
    {
        Debug.Log(health);
        Debug.Log(attackSpeed);
        Debug.Log(damage);
        Debug.Log(moveSpeed);
    }
}
