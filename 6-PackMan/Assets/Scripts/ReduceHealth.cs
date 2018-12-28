using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReduceHealth : MonoBehaviour {

	Text text;
	public static int collHealth=10;
	[SerializeField] private string Loadlevel;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = collHealth.ToString ();

		if (collHealth == 0) {
			SceneManager.LoadScene (Loadlevel);
		}

	}
		
}
