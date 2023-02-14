using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;

    private Vector2 _triggerPosition;
    private float _spawnPossition = 20f;

    private void Start()
    {
        _triggerPosition = transform.position;
        _triggerPosition.x += _spawnPossition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Instantiate(_coin, _triggerPosition, Quaternion.identity);
            GameObject.Destroy(gameObject);
        }
    }
}
