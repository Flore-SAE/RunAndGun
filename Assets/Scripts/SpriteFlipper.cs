using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteFlipper : MonoBehaviour
{
    [HideInInspector] public bool isFacingLeft;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnStickMoved(InputAction.CallbackContext ctx)
    {
        if(!ctx.performed)
            return;
        var value = ctx.ReadValue<float>();
        isFacingLeft = value < 0;
        var xScale = isFacingLeft ? -1 : 1;
        var newScale = new Vector3(xScale, 1, 1);
        transform.localScale = newScale;
    }
}
