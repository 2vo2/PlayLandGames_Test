using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private InputSystem_Actions _inputActions;

    private event Action OnJumpButtonPressed;

    private Vector2 _inputVector;

    public Vector2 InputVector => _inputVector;

    private void Awake()
    {
        _inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Player.Move.performed += context => {_inputVector = context.ReadValue<Vector2>(); print(_inputVector);};
        _inputActions.Player.Jump.performed += context => OnJumpButtonPressed?.Invoke();
    }

    private void OnDisable()
    {
        _inputActions.Player.Move.performed -= context => print(context.ReadValue<Vector2>());
        _inputActions.Player.Jump.performed -= context => OnJumpButtonPressed?.Invoke(); 
        _inputActions.Disable();
    }
}
