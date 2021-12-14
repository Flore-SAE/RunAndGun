using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Shooter2D shooter;

    private void Awake()
    {
        shooter = GetComponent<Shooter2D>();
    }
    
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0, 4f); 
    }

    private void Shoot()
    {
        shooter.Shoot(Vector2.left);
    }
}
