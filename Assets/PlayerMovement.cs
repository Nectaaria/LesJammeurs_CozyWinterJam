using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed=250;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizonMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        MovePlayer(horizonMovement);
    }

    void MovePlayer(float _horizonMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizonMovement, rb.linearVelocity.y);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, .05f);
    }
}
