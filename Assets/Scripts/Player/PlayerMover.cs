using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private bool _isGrounded;

    private void OnEnable()
    {
        _inputHandler.OnJumpButtonPressed += Jump;
    }

    private void Update()
    {
        Move();
    }

    private void OnDisable()
    {
        _inputHandler.OnJumpButtonPressed -= Jump;
    }

    private void Move()
    {
        var movementVector = new Vector3(_inputHandler.MoveInputVector.x, 0f, 0f) * _speed * Time.deltaTime;
        _rigidbody.AddRelativeForce(movementVector, ForceMode.VelocityChange);
    }

    private void Jump()
    {
        if (_isGrounded)
        {
            _rigidbody.AddRelativeForce(transform.up * _jumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }
}
