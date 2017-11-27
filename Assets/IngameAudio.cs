using UnityEngine;
using System.Collections;

public class IngameAudio : MonoBehaviour {



	// Use this for initialization
	void Start () {

		waitForFadeCo ();
		GetComponent<AudioSource>().Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator waitForFadeCo()
	{

		yield return new WaitForSeconds (3f);
	}
}
