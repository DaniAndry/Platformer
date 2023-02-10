using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody;

    private int RunHash = Animator.StringToHash("Run");
    private int IdleHash = Animator.StringToHash("Idle");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            _animator.SetTrigger(RunHash);
        }
        else
        {
            _animator.SetTrigger(IdleHash);
        }
    }
}
