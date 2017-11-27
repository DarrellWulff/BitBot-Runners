using UnityEngine;
using System.Collections;

public class PlayModeMenu : MonoBehaviour {

	public string characterSelection;
	public string challengeMode;
	public string mainMenuBack;

	public void EndlessGameMode()
	{
		Application.LoadLevel (characterSelection);

	}

	public void ChallengeMode()
	{

		Application.LoadLevel (challengeMode);


	}

	public void Back()
	{
		Application.LoadLevel (mainMenuBack);

	}



}
