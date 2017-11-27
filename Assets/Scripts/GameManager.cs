using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public GameObject thePlayerObj;
	public GameObject thePlayer;


	public Transform startPoint;

	private PlatformDestroyer[] platformList;


	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;
	public PauseMenu thePauseMenu;
	public GameObject pauseButton;

	public CharacterManager playerCharacter;
	private int indexNum;

	public GameObject lifeParticle;

	public float respawnDelay;

	public string level1;

	public AudioSource source;
	public AudioClip deathSound;

	// Use this for initialization
	void Start () {

		platformStartPoint = platformGenerator.position;

		source = GetComponent<AudioSource> ();

		theScoreManager = FindObjectOfType<ScoreManager> ();

		indexNum = PlayerPrefs.GetInt ("CharacterIndex");

		playerCharacter = FindObjectOfType<CharacterManager> ();
		thePauseMenu = FindObjectOfType<PauseMenu> ();

		thePlayerObj = playerCharacter.characterPool [indexNum];

		thePlayer = Instantiate (thePlayerObj, startPoint.position, startPoint.rotation) as GameObject;

		level1 = "Scene 1";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartGame()
	{	
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		thePlayer.GetComponent<PlayerController> ().bitLevelCount = 1;
		StartCoroutine ("RestartGameCo");




		
	}

	public void Reset()
	{
		theDeathScreen.gameObject.SetActive (false);
		pauseButton.SetActive (true);

		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for (int i = 0; i < platformList.Length; i++) {
			
			platformList[i].gameObject.SetActive(false);
			
			
		}

		thePlayer.GetComponent<PlayerController> ().bitLevelCount = 1;
		StartCoroutine("waitForFadeCo");
		UnityEngine.SceneManagement.SceneManager.LoadScene (level1);

		thePlayer.transform.position = startPoint.position;
		platformGenerator.position = platformStartPoint;
		Instantiate(lifeParticle, thePlayer.transform.position, thePlayer.transform.rotation);
		thePlayer.gameObject.SetActive (true);
		
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;

	}


	public IEnumerator waitForFadeCo()
	{
		float fadeTime = GameObject.Find ("GameManager").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
	}

	public IEnumerator RestartGameCo()
	{
		playDeathSound ();
		yield return new WaitForSeconds(1.5f);
		theDeathScreen.gameObject.SetActive (true);
		pauseButton.SetActive (false);
	} 

	public void playDeathSound()
	{
		source.clip = deathSound;
		source.Play();
	}

}
