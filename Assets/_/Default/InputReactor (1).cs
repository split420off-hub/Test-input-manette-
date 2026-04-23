using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputReactor : MonoBehaviour
{
    public InputActionReference action;
    public UnityEvent onPressed;
    public UnityEvent onReleased;

    void OnEnable()
    {
        action.action.Enable();
        action.action.performed += HandlePerformed;
        action.action.canceled += HandleCanceled;
    }

    void OnDisable()
    {
        action.action.performed -= HandlePerformed;
        action.action.canceled -= HandleCanceled;
        action.action.Disable();
    }

    void HandlePerformed(InputAction.CallbackContext ctx) => onPressed.Invoke();
    void HandleCanceled(InputAction.CallbackContext ctx) => onReleased.Invoke();
}
