using System.Collections;
using System.Collections;
using UnityEngine;

public class CoinCollection : MonoBehaviour {

	public AudioSource coin;
	void OnTriggerEnter(Collider col)
	{
		
			ScoreTextScript.coinAmount += 1;
			//add 1 points.
		coin.Play();
			Destroy (gameObject);
	}
}

