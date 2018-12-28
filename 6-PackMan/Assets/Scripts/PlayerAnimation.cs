using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	static Animator anim;
	public float speed = 30.0f;
	public float rotationSpeed = 50.0f;
	public float gravity = 1.0f;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;

		if (translation != 0) {

			anim.SetBool ("IsRunning", true);
		} else {
			anim.SetBool ("IsRunning", false);
		}
	}
}

