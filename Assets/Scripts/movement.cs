using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float moveSpeed;
	public float maxSpeed;
	private Vector3 input;

	void Update () {
		input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		if(GetComponent<Rigidbody>().velocity.magnitude < maxSpeed){
			GetComponent<Rigidbody>().AddForce(input * moveSpeed); 
		}
	}
}
