using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int enemydamage;
    public int playerHeal;
    public int lowDamage;
    public int mediumDamage;
    public int highDamage;

    public int maxHP;
    public int currentHP;

    public int minValueEnemy;
    public int maxValueEnemy;

    public void Update()
    {
        enemydamage = Random.Range(minValueEnemy, maxValueEnemy);
        playerHeal = Random.Range(10, 12);
    }

    public bool TakeDamage(int dam)
    {
        currentHP -= dam;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
}
