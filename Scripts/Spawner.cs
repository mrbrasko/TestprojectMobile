using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector2 range;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _bonus;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(_enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }
    private IEnumerator SpawnBonus()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(_bonus, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnBonus());
    }
}
