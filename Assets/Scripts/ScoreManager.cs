using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text hiScoreText;

	public Text scoreText2;
	public Text hiScoreText2;

	public Text hiScoreText3;
	public Text hiScoreText4;

	public float scoreCount;
	public float hiScoreCount;


	public float pointsPerSecond;

	public bool scoreIncreasing;

	public GameManager theGameManager;
	public PlayerController thePlayerController;





	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("HighScore") ) {

			hiScoreCount = PlayerPrefs.GetFloat("HighScore");
		}

		if (PlayerPrefs.HasKey ("CurrentScore")) {

			scoreCount = PlayerPrefs.GetFloat("CurrentScore");
		}

		theGameManager = FindObjectOfType<GameManager> ();



		thePlayerController = theGameManager.thePlayer.GetComponent<PlayerController> ();

	}

	// Update is called once per frame
	void Update () {
		if (scoreIncreasing && ( thePlayerController.frontCheck == false)) {
			scoreCount += pointsPerSecond * Time.deltaTime;
			PlayerPrefs.SetFloat("CurrentScore", scoreCount);

		}

		if (scoreCount > hiScoreCount) {
		
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat("HighScore", hiScoreCount);
		
		
		}


		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);

		scoreText2.text = "Score: " + Mathf.Round (scoreCount);
		hiScoreText2.text = "High Score: " + Mathf.Round(hiScoreCount);

		hiScoreText3.text = "High Score: " + Mathf.Round (hiScoreCount);
		hiScoreText4.text = "High Score: " + Mathf.Round(hiScoreCount);
	
	}

	public void AddScore(int pointsToAdd){
	
		scoreCount += pointsToAdd;

	
	}


}
