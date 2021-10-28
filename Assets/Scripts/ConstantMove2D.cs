using UnityEngine;

public class ConstantMove2D : MonoBehaviour
{
    public Vector2 direction;
    public float speed;

    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb2D.velocity = direction.normalized * speed;
    }
}
