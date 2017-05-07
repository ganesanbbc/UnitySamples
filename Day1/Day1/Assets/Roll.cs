using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {

	public float movementSpeed = 1000;

	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {

		this.myRigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Vector3.left);

		//if (Vector3.left <= 10) {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);


		
		//}

//		float rotation = Input.GetAxis ("Horizontal");
//		rotation *= Time.deltaTime * movementSpeed;
//
//		this.myRigidbody.AddRelativeTorque(Vector3.back * rotation);

	}
}
