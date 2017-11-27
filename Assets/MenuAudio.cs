using UnityEngine;
using System.Collections;

public class MenuAudio : MonoBehaviour {

	static bool AudioBegin = false;
	public int startup;
	
	
	// Use this for initialization
	void Start () {
		/*
		startup = 1;
		PlayerPrefs.SetInt ("Started", startup);
		
		if (!AudioBegin && startup == 0) {
			GetComponent<AudioSource>().Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} */
		
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if(Application.loadedLevelName == "Scene 1")
		{
			GetComponent<AudioSource>().Stop();
			AudioBegin = false;
		}*/
	}
	
	
	
	
}


