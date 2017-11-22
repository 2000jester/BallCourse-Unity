using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
	public GameObject player;  
	public Vector3 resetPoint;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		resetPoint = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.y < -25){
			player.transform.position = resetPoint;
			rb.velocity = Vector3.zero;
		}
		if(player.transform.position.y < -2){
			rb.AddForce(0,(transform.position.y * 7),0);
		}
	}
}
