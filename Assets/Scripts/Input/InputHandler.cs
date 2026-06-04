using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private InputSystem_Actions _inputActions;

    public event Action OnJumpButtonPressed;

    private Vector2 _moveInputVector;

    public Vector2 MoveInputVector => _moveInputVector;

    private void Awake()
    {
        _inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Player.Move.started += MoveInputStarted;
        _inputActions.Player.Move.canceled += MoveInputCanceled;
        _inputActions.Player.Jump.performed += JumpButtonPressed;
    }

    private void OnDisable()
    {
        _inputActions.Player.Move.started -= MoveInputStarted;
        _inputActions.Player.Move.canceled -= MoveInputCanceled;
        _inputActions.Player.Jump.performed -= JumpButtonPressed; 
        _inputActions.Disable();
    }

    private void MoveInputStarted(InputAction.CallbackContext context)
    {
        _moveInputVector = context.ReadValue<Vector2>();
    }

    private void MoveInputCanceled(InputAction.CallbackContext context)
    {
        _moveInputVector = Vector2.zero;
    }

    private void JumpButtonPressed(InputAction.CallbackContext context)
    {
        OnJumpButtonPressed?.Invoke();
    }
}
