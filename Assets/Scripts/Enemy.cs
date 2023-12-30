using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : TakeDamage
{
    [SerializeField] GameObject destroyObject;
    private int _maxHp = 3;
    private int _minHp = 1;

    private void Start() {
        _hp = Random.Range(_minHp, _maxHp + 1);
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("StandartWeapon")) {
            TakeDamages(collision.GetComponent<StandartWeapon>().damageWeapon);
            if (_hp <= 0) {
                Death();
            }
        }
    }

    protected override void Death()
    {
        GameObject destruct = Instantiate(destroyObject);
        destruct.transform.position = gameObject.transform.position;
        Destroy(destruct, 1.5f);
        Destroy(gameObject);
    }
}

