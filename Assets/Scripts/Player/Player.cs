using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Rigidbody2D _rigidbody;

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
        OnValueChanched(_currentHealth, _maxHealth);
    }

    public void HealHealth()
    {
        int heal = 10;
        _currentHealth += heal;
        OnValueChanched(_currentHealth, _maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _currentHealth -= enemy.Damage;
        }

        OnValueChanched(_currentHealth, _maxHealth);
    }

    private void OnValueChanched(int value, int maxValue)
    {
        float delta = 0.5f;

        float targetValue = (float)value / maxValue;

        _slider.DOValue(targetValue, delta);
    }
}
