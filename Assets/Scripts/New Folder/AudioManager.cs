using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	static bool AudioBegin = false;
	public int startup;


	// Use this for initialization
	void Start () {



		if (!AudioBegin) {
			GetComponent<AudioSource>().Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	
	}
	
	// Update is called once per frame
	void Update () {

		if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Scene 1")
		{
			GetComponent<AudioSource>().Stop();
			AudioBegin = false;
		}
	}
	

	

}
