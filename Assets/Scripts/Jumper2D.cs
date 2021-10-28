using UnityEngine;

public class Jumper2D : MonoBehaviour
{
    public float jumpForce;
    [Range(0,1)]public float groundCheckRadius;
    public LayerMask mask;
    public Transform feet;

    private Rigidbody2D rb2D;
    private bool isGrounded;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (isGrounded)
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void Update()
    {
        var test = Physics2D.OverlapCircle(feet.position, groundCheckRadius, mask);
        Debug.Log(test);
        isGrounded = test != null;
    }
}
