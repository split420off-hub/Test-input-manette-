using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class AxisReader2D : MonoBehaviour
{
    public InputActionReference action;
    public UnityEvent<Vector2> onValue;

    void OnEnable()
    {
        action.action.Enable();
    }

    void OnDisable()
    {
        action.action.Disable();
    }

    void Update()
    {
        onValue.Invoke(action.action.ReadValue<Vector2>());
    }
}
