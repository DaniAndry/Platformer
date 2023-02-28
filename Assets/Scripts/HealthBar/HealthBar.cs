using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] private Slider _slider;

    public void OnValueChanched()
    {
        float delta = 0.5f;

        float targetValue = (float)_player.CurrentHealth / _player.MaxHealth;

        _slider.DOValue(targetValue, delta);
    }
}
