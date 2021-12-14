using UnityEngine;

[RequireComponent(typeof(LifeBehaviour))]
public class DamageTaker : MonoBehaviour
{
    public LayerMask damageLayers;

    private LifeBehaviour lifeBehaviour;

    // Start is called before the first frame update
    private void Start()
    {
        lifeBehaviour = GetComponent<LifeBehaviour>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (damageLayers == (damageLayers | 1 << col.gameObject.layer))
            lifeBehaviour.TakeDamage(1);
    }
}