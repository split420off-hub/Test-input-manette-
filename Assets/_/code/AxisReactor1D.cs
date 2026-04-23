using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class AxisReactor1D : MonoBehaviour
{
    public InputActionReference action;
    public UnityEvent<float> onChanged;

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

    void HandlePerformed(InputAction.CallbackContext ctx) => onChanged.Invoke(ctx.ReadValue<float>());
    void HandleCanceled(InputAction.CallbackContext ctx) => onChanged.Invoke(0f);
}
