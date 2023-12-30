using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TakeDamage : MonoBehaviour {

    [SerializeField] public int _hp;

    public void TakeDamages(int damage) {
        _hp -= damage;
        if (_hp <= 0) {
            Death();
        }

    }

    protected abstract void Death();
    
}
