using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	public string mainMenu;
	public int atStoreScene;
	public int startup;

	public void loadMain()
	{


		UnityEngine.SceneManagement.SceneManager.LoadScene (mainMenu);

	}

	public void backToMenu()
	{
		atStoreScene = 0;
		PlayerPrefs.SetInt ("StoreScene", atStoreScene);


		UnityEngine.SceneManagement.SceneManager.LoadScene (mainMenu);
	}


	// Use this for initialization
	void Start () {

		atStoreScene = PlayerPrefs.GetInt ("StoreScene");
		startup = 0;
		PlayerPrefs.SetInt ("Started", startup);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
