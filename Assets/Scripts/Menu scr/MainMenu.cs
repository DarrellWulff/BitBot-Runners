using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public string playGameMenu;
	public string storeGameMenu;
	public string optionGameMenu;

	public GameObject howToPlay;
	public GameObject backHowToPlay;

	public int atStoreScene;

	void Start()
	{
		atStoreScene = 0;
		PlayerPrefs.SetInt ("StoreScene", atStoreScene);
	}


	public void PlayGame()
	{
		float score = 0;
		PlayerPrefs.SetFloat("CurrentScore", score);

		UnityEngine.SceneManagement.SceneManager.LoadScene (playGameMenu);
	}

	public void StoreMenu()
	{
		atStoreScene = 1;
		PlayerPrefs.SetInt ("StoreScene", atStoreScene);

		UnityEngine.SceneManagement.SceneManager.LoadScene (storeGameMenu);
	}

	public void OptionMenu()
	{

		howToPlay.SetActive (true);
		backHowToPlay.SetActive (true);

	}

	public void QuitGame()
	{
		Application.Quit ();

	}

	public void deleteAll()
	{
		PlayerPrefs.DeleteAll ();
	}







}
