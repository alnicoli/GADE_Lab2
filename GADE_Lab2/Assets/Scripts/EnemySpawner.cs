using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public GameObject _enemyPrefab;
	public Transform _playerTransform;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", 1.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(_playerTransform.position.x + 100, transform.position.y, transform.position.z);
	}

	void SpawnEnemy() {
		Instantiate(_enemyPrefab, transform.position, transform.rotation);
	}
}
