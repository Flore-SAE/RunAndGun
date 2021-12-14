using UnityEngine;

public class Shooter2D : MonoBehaviour
{
    public GameObject bullet;

    public void Shoot(Vector2 bulletDirection)
    {
        var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletMove = instantiatedBullet.GetComponent<ConstantMove2D>();
        bulletMove.direction = bulletDirection;
    }
}