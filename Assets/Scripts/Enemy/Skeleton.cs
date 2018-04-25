using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy {


    private void Awake()
    {
        health = 4;
        attackSpeed = 2;
        damage = 2;
        moveSpeed = 15;
    }
}
