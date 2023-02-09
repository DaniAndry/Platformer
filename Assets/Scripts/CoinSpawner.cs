using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    Vector2 position;

    private void Start()
    {
        position = transform.position;
        position.x += 20f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Instantiate(_coin, position, Quaternion.identity);
            GameObject.Destroy(gameObject);
        }
    }
}
