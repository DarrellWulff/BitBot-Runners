using UnityEngine;
using System.Collections;

public class LetsGoButton : MonoBehaviour {

	public string levelScene = "Level Select";
	public string playMenu;


	public void playButton()
	{
		
		UnityEngine.SceneManagement.SceneManager.LoadScene (levelScene);
	}

	public void backButton()
	{
		
		UnityEngine.SceneManagement.SceneManager.LoadScene (playMenu);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
