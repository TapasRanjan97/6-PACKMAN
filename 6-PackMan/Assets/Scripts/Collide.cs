using System.Collections;
using System.Collections;
using UnityEngine;

public class Collide : MonoBehaviour {

	void OnCollisionEnter(Collision cold)
	{

		ReduceHealth.collHealth -= 1;
		//add 1 points.
	}
}

