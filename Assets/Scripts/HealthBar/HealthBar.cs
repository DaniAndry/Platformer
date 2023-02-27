using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] private Slider _slider;

    public void OnValueChanched(int value, int maxValue)
    {
        float delta = 0.5f;

        float targetValue = (float)value / maxValue;

        _slider.DOValue(targetValue, delta);
    }
}
