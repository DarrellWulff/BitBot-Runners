using UnityEngine;
using System.Collections;

public class OptionMenu : MonoBehaviour {

	public string backMainMenu;
	public GameObject howtoPlay;
	public GameObject otherBack;

	public void Back()
	{
		
		UnityEngine.SceneManagement.SceneManager.LoadScene (backMainMenu);

	}

	public void backToOptions()
	{
		howtoPlay.SetActive (false);
		otherBack.SetActive (false);
	}

	public void howToPlayScreen()
	{
		howtoPlay.SetActive (true);
		otherBack.SetActive (true);
	}

}
