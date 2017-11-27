using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickupPoints : MonoBehaviour {




	public int scoreToGive;
	public int bitCount;
	public int bitWallet = 0;

	private ScoreManager theScoreManager;
	private BitManager theBitManager;
	private GameManager theGameManager;

	public bool iscollided;

	public GameObject bitParticle;


	// Use this for initialization
	void Start () {

		theScoreManager = FindObjectOfType<ScoreManager> ();
		theBitManager = FindObjectOfType < BitManager> ();

		theGameManager = FindObjectOfType<GameManager> ();


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == theGameManager.thePlayer.name) {



		
			theScoreManager.AddScore (scoreToGive);
			iscollided = true;
			Instantiate(bitParticle, gameObject.transform.position, Quaternion.identity);
			theBitManager.AddBit (bitCount);
			gameObject.SetActive (false);
		
		} else {
		
			iscollided = false;

		}



	}



}
