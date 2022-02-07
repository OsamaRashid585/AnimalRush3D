using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{

    public GameObject[] AnimalsPrefab;
    private float _randomPos;
    private int _randomPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
    }

    void Spawn()
    {
        _randomPos = Random.Range(-20, 20);
        _randomPrefab = Random.Range(0, AnimalsPrefab.Length);

        Instantiate(AnimalsPrefab[_randomPrefab], transform.position = new Vector3(_randomPos, transform.position.y, transform.position.z), AnimalsPrefab[_randomPrefab].transform.rotation);
    } 
}
