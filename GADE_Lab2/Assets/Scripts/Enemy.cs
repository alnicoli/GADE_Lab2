using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(0, Mathf.Sin(Time.time * 10.0f) * 10.0f, 0));
	}
}
