using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRandom : MonoBehaviour
{

    [SerializeField]
    private GameObject _object1;

    [SerializeField]
    private GameObject _object2;

    [SerializeField]
    private Transform _parent;

    [SerializeField]
    private Vector2 _spawnPeriodRange;

    [SerializeField]
    private Vector2 _spawnDelayRange;

    [SerializeField]
    private bool _autoStart = true;

    private int dice;

    private void Start()
    {
        if (_autoStart)
            StartSpawn();
    }

    private void Update()
    {
        dice = Random.Range(1, 100);
    }

    public void StartSpawn()
    {
        StartCoroutine(Spawn());
    }

    public void StopSpawn()
    {
        StopAllCoroutines();
    }


    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(_spawnDelayRange.x, _spawnDelayRange.y));

        while (true)
        {
            if (dice < 50)
            {
                Instantiate(_object1, transform.position, transform.rotation, _parent);
                yield return new WaitForSeconds(Random.Range(_spawnPeriodRange.x, _spawnPeriodRange.y));
            }
            else
            {
                Instantiate(_object2, transform.position, transform.rotation, _parent);
                yield return new WaitForSeconds(Random.Range(_spawnPeriodRange.x, _spawnPeriodRange.y));
            }
        }
    }
}
