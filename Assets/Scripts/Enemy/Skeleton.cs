using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy {

	public Skeleton(int health, int attackSpeed, int damage, int moveSpeed) : base(health,attackSpeed,damage,moveSpeed)
    {
        base.PrintStats();
    }
}
