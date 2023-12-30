using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartWeapon : MonoBehaviour {

    [Header("Setting weapon")]
    public Transform attackPosition;
    public LayerMask enemy;
    public float attackRange;

    [Header("Setting for scripts")]
    public int damageWeapon = 1;
   


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPosition.position, attackRange);
    }   
    
}



