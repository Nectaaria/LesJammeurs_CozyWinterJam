using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 250;

    public Rigidbody2D rb;
    private Vector2 movementDirection;

    // Update is called once per frame
    void update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * moveSpeed;
    }
}   