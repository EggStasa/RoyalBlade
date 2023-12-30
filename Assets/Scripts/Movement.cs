using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float jumpPower;
    private Rigidbody2D _rigitbody2D;
    private bool _jump;

    private void Awake()
    {
        _rigitbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Work");
            _jump = true;
            Jump();

            if (Input.GetButtonDown("Jump"))
            {

            }
        }
    }

    private void FixedUpdate()
    {
        if (_jump)
        {
            Jump();
            _jump = false;
        }
    }

    public void Jump()
    {
        Debug.Log("Add force movement");
        _rigitbody2D.AddForce(Vector2.up * jumpPower);
    }
}
