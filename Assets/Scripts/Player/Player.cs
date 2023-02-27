using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private HealthBar _healthBar;

    private int _maxHealth = 100;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void DamageHealth()
    {
        int damage = 10;
        _currentHealth -= damage;
        _healthBar.OnValueChanched(_currentHealth, _maxHealth);
    }

    public void HealHealth()
    {
        int heal = 10;
        _currentHealth += heal;
        _healthBar.OnValueChanched(_currentHealth, _maxHealth);
    }
}
