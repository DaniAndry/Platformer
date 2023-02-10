using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    private Vector2 _position;

    private void Start()
    {
        _position = transform.position;
        _position.x += 20f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Instantiate(_coin, _position, Quaternion.identity);
            GameObject.Destroy(gameObject);
        }
    }
}
