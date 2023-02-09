using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _groundCheck;

    private float _speed = 5;
    private float _jumpPower = 8;
    private float _horizontal;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_horizontal * _speed, _rigidbody.velocity.y);
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space)&& IsGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpPower);
        }
    }

    private bool IsGrounded()
    {
        float radiusCheck = 0.01f;
        return Physics2D.OverlapCircle(_groundCheck.position, radiusCheck);
    }
}
