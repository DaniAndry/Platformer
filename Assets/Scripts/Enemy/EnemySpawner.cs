using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private List<Portal> _portals;

    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int enemyCount = 1;
        Vector3 tempSpawnPoint;
        Portal spawnPoint;
        var WaitForSeconds = new WaitForSeconds(2f);

        for (int i = 0; i < enemyCount; i++)
        {
            spawnPoint = _portals[UnityEngine.Random.Range(0, _portals.Count)];
            tempSpawnPoint = spawnPoint.transform.position;
            Enemy enemy = Instantiate(_enemy, tempSpawnPoint, Quaternion.identity);
            yield return WaitForSeconds;
        }
    }
}

