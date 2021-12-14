using UnityEngine;

public class LifeBehaviour : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    
    public int currentHealth;

    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = startingHealth;
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth += modifier;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if(currentHealth == 0)
            Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        ModifyHealth(damage * -1);
    }

    public void Heal(int healAmount)
    {
        ModifyHealth(healAmount);
    }
}
