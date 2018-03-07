using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Bullet : MonoBehaviour {	
	float destroyTime = 2.0f;

	void FixedUpdate () {
		GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(0.5f,0,0));
	}

	private void OnTriggerEnter(Collider other) {
		Type type = other.gameObject.GetComponent<Type>();
		
		if (type != null && type.isDestroyable) {
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}

	private void Update() {
		Destroy(gameObject, destroyTime);
	}
}
