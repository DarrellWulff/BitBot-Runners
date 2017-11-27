using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {


	public string mainMenuLevel;
	public GameObject DeathMenuGame;

	public GameObject PauseGameMenu;
	public bool isMenuActive;



	public bool ActiveTest(bool isMenuAcitve)
	{
		if (DeathMenuGame == true) {


			return true;


		} else {


			return false;
		}

	}


	public void RestartGame()
	{
		FindObjectOfType<GameManager>().Reset ();
		PlayerPrefs.SetFloat("CurrentScore", 0f);
	}

	public void QuitToMain()
	{
		
		UnityEngine.SceneManagement.SceneManager.LoadScene (mainMenuLevel);
	}



}
