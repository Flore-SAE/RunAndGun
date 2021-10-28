using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter2D : MonoBehaviour
{
    private SpriteFlipper spriteFlipper;

    public GameObject bullet;

    private void Awake()
    {
        spriteFlipper = GetComponent<SpriteFlipper>();
    }

    public void Shoot(InputAction.CallbackContext ctx)
    {
        if(!ctx.performed)
            return;
        var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletMove = instantiatedBullet.GetComponent<ConstantMove2D>();
        if (spriteFlipper.isFacingLeft)
            bulletMove.direction = Vector2.left;
        else
            bulletMove.direction = Vector2.right;
    }
}
