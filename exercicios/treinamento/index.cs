using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    float health;
    int speed;
    string enemyName;

EnemyWeapon weapon;
int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

List<int> intList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    void Movement()
    {
        foreach (float intNumbers in intArray)
        {
            
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            int currentNumber = intArray[i];
        }

        for (int i = 0; i < intList.Count; i++)
        {
            int currentNumber = intList[i];
        }

        if (speed >= 0)
        {
            
        }
    }

    void Dead()
    {
        if (health <= 0)
        {
            
        }
    }

    void Attack()
    {
        weapon.damage = 30;
        weapon.fireRate = 0.4f;
        weapon.shoot();
    }
}

public class EnemyWeapon
{
    public float damage;
    puclic float fireRate;

    public void shoot()
    {

    }
}