using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 30.0f;
	public float rotationSpeed = 50.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed*Time.deltaTime;
		float rotation = Input.GetAxis ("Horizontal") *rotationSpeed*Time.deltaTime;
		//translation *= Time.deltaTime;
		//rotation*= Time.deltaTime;
		transform.Translate ( 0,0,translation);
		transform.Rotate (0, rotation, 0);

	}
}