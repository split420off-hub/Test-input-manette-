using UnityEngine;

public class PlayerAimer : MonoBehaviour
{
    public float deadzone = 0.1f;

    public void Aim(Vector2 input)
    {
        if (input.sqrMagnitude < deadzone * deadzone) return;
        float angle = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
