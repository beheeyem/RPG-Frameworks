﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public Image hpBarFiller;

    [Header("Stats")]
    public float speed;
    public int damage;
    public int maxHP;
    public float currentHP;

    private void Awake()
    {
        //speed = Random.Range(0f, 7f);
        currentHP = maxHP;
    }

    public virtual void Act()
    {
        print("meep");
    }

    public void Damaged(int _damage)
    {
        currentHP -= _damage;
        hpBarFiller.fillAmount = currentHP / maxHP;

        if (currentHP <= 0)
        {
            print(gameObject.name + " is dead!");
            BattleManager.instance.UnitDied(this);
            Destroy(this.gameObject);
        }
    }

    public void Healed(int _amount)
    {
        currentHP += _amount;

        if (currentHP > maxHP)
            currentHP = maxHP;

        hpBarFiller.fillAmount = currentHP / maxHP;

    }
}


public class UnitEp01 : MonoBehaviour
{
    public float speed;
    public string iDoThis;
    private void Awake()
    {
        speed = Random.Range(0f, 7f);
    }

    public virtual void Act()
    {
        print(name + ": " + iDoThis);
    }
}

public class UnitEp02 : MonoBehaviour
{
    public float speed;
    public int damage;
    public int maxHP;
    public float currentHP;

    private void Awake()
    {
        speed = Random.Range(0f, 7f);
        currentHP = maxHP;
    }

    public virtual void Act()
    {
        print("meep");
    }

    public void Damaged(int _damage)
    {
        currentHP -= _damage;
    }
}

public class UnitEp03 : MonoBehaviour
{
    public float speed;
    public int damage;
    public int maxHP;
    public float currentHP;

    private void Awake()
    {
        speed = Random.Range(0f, 7f);
        currentHP = maxHP;
    }

    public virtual void Act()
    {
        print("meep");
    }

    public void Damaged(int _damage)
    {
        currentHP -= _damage;

        if (currentHP <= 0)
        {
            print("I'm dead!");
            //BattleManager.instance.UnitDied(this);
            Destroy(this.gameObject);
        }
    }
}

//Introduced in episode 2, as a way to differentiate abilities
public enum Targets
{
    MYSELF,
    MY_LEADER,
    MY_SUPPORT,
    ENEMY_LEADER,
    ENEMY_SUPPORT
}
