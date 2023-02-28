using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChanged;

    private void Start()
    {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }

    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public void DamageHealth()
    {
        int damage = 10;
        CurrentHealth -= damage;
        _healthChanged.Invoke();
    }

    public void HealHealth()
    {
        int heal = 10;
        CurrentHealth += heal;
        _healthChanged.Invoke();
    }
}
