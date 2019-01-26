using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour {

    [SerializeField] private Transform _startingPos;
    [SerializeField] private Transform _endingPos;

    [SerializeField] private int spawnAmount = 10;

    [SerializeField] private GameObject objectToGenerate;

    [SerializeField] private GameObject _objectRoot;

    private float alongThePath;

    void Awake()
    {
        alongThePath = 1f / spawnAmount;
        for (int i = 0; i < spawnAmount; i++)
        {

            Vector3 spawnPosition = _startingPos.position + (_endingPos.position - _startingPos.position) * (alongThePath * i);

            GameObject spawnedObject = Instantiate(objectToGenerate, _objectRoot.transform);
            spawnedObject.transform.position = spawnPosition;
        }
    }

    // Use this for initialization
    void Start () {

	}
}
