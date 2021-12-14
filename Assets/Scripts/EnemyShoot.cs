using System;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;

    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0, 0.4f); 
    }

    private void Shoot()
    {
        var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletMove = instantiatedBullet.GetComponent<ConstantMove2D>();
        bulletMove.direction = Vector2.left;
    }
}