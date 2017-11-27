using UnityEngine;
using System.Collections;

public class LevelSelector : MonoBehaviour {

	public GameObject[] levelButtonPool;
	public int levelIndexNumber;

	public string[] LevelNames = new string[9];
	public string backToCharacter = "Character Select";
	
	public int[] levelsUnlocked = new int[9];

	public void playVerdantValley(){
		
		levelIndexNumber = 0;
		PlayerPrefs.SetInt ("LevelIndex", levelIndexNumber);
		
	}

	public void playCragCanyon(){
		
		levelIndexNumber = 1;
		PlayerPrefs.SetInt ("LevelIndex", levelIndexNumber);
		
	}

	public void playSkyCity(){
		
		levelIndexNumber = 2;
		PlayerPrefs.SetInt ("LevelIndex", levelIndexNumber);
		
	}

	public void playDeepFreeze(){

		levelIndexNumber = 3;
		PlayerPrefs.SetInt ("LevelIndex", levelIndexNumber);
	
	}

	public void playLevel(){
		
		levelIndexNumber = PlayerPrefs.GetInt ("LevelIndex");

		Application.LoadLevel(LevelNames[levelIndexNumber]);
	
	}

	public void backButton(){
	
		Application.LoadLevel (backToCharacter);
	
	}

	
	
	// Use this for initialization
	void Start () {




		if (PlayerPrefs.HasKey ("LevelsOnProfile")) {
			
			levelsUnlocked = PlayerPrefsX.GetIntArray("LevelsOnProfile");
			
		}
		
		for (int i = 1; i <= 8; i++) {
			
			if(levelsUnlocked[i] == i){
				
				levelButtonPool[i].SetActive(true);
			}
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
