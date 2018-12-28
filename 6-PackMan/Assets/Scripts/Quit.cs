using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	public void Quitgame()
	{
		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
		Application.Quit();
	}
}

