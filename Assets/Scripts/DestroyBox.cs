using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] Vector2 Coodrinate;
    [SerializeField] int spin;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Coodrinate);
        rb.AddTorque(spin);


    }
}
    
