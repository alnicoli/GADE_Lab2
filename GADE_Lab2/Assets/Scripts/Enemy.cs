using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(-0,Mathf.Sin(Time.time * 1.5f) * 0.3f, 0));
	}
}
