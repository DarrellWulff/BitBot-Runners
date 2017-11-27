using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string mainMenuLevel;

	public GameObject PauseMenuGame;

	public GameObject DeathMenuGame;



	public void PauseGame()
	{


			Time.timeScale = 0f;
			PauseMenuGame.SetActive (true);



	
	}

	public void ResumeGame()
	{
		Time.timeScale = 1f;
		PauseMenuGame.SetActive (false);

	}




	public void RestartGame()
	{
		Time.timeScale = 1f;
		FindObjectOfType<GameManager>().Reset ();
		PauseMenuGame.SetActive (false);
	}
	
	public void QuitToMain()
	{

		Time.timeScale = 1f;


		UnityEngine.SceneManagement.SceneManager.LoadScene (mainMenuLevel);

	}
}
