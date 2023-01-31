using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private GameObject[] _portals;
    private Coroutine _coroutine;


    void Start()
    {
        _portals = GameObject.FindGameObjectsWithTag("Respawn");
        _coroutine = StartCoroutine(Spawn());
    }


    private IEnumerator Spawn()
    {
        Vector3 _tempSpawnPoint;
        GameObject _spawnPoint;
        System.Random random = new System.Random();
        var WaitForSeconds = new WaitForSeconds(2f);

        while (true)
        {
            _spawnPoint = _portals[random.Next(_portals.Length)];
            _tempSpawnPoint = _spawnPoint.transform.position;
            Instantiate(Enemy, _tempSpawnPoint, Quaternion.identity);
            yield return WaitForSeconds;
        }
    }
}
