using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    public void Move(Vector2 input)
    {
        Vector3 delta = new Vector3(input.x, 0f, input.y) * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }
}
