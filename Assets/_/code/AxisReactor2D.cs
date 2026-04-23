using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class AxisReactor2D : MonoBehaviour
{
    public InputActionReference action;
    public UnityEvent<Vector2> onChanged;

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

    void HandlePerformed(InputAction.CallbackContext ctx) => onChanged.Invoke(ctx.ReadValue<Vector2>());
    void HandleCanceled(InputAction.CallbackContext ctx) => onChanged.Invoke(Vector2.zero);
}
