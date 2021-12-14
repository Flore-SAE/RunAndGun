using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private SpriteFlipper spriteFlipper;
    private Shooter2D shooter;

    private void Awake()
    {
        spriteFlipper = GetComponent<SpriteFlipper>();
        shooter = GetComponent<Shooter2D>();
    }

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if(!ctx.performed)
            return;
        var direction = spriteFlipper.isFacingLeft ? Vector2.left : Vector2.right;
        shooter.Shoot(direction); 
    }
}
