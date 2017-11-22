using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {
	public float moveSpeed;
	private bool dir;
	// Use this for initialization
	void Start () {
		dir = transform.position.z < 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(dir == true && transform.position.z > 15){
			dir = false;
		}
		if(dir == false && transform.position.z < -15){
			dir = true;
		}
		if(dir == true){
			Vector3 pos = transform.position;
			pos.z = pos.z + moveSpeed;
			transform.position = pos;
		} 
		if(dir == false){
			Vector3 pos = transform.position;
			pos.z = pos.z - moveSpeed;
			transform.position = pos;
		}
	}
}
