using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {


	[SerializeField] private string loadLevel1;
	public void Playgame()
	{
		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
		SceneManager.LoadScene (loadLevel1);
	}
}