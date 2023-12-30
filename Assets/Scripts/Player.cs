using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : TakeDamage
{

    protected override void Death() => Destroy(gameObject);
}

