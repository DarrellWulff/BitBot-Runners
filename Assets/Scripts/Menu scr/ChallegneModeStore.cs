using UnityEngine;
using System.Collections;

public class ChallegneModeStore : MonoBehaviour {

	public ChallegneModeStore comingSoon;
	public GameObject backButton;

	private bool isthere;


	public void ChallengeModeBrowser(){
	
		comingSoon.gameObject.SetActive (true);
		
		isthere = true;
		
		if (isthere == true) {
			
			backButton.gameObject.SetActive (false);
			
		}
	
	
	
	}

	public void ChallengeMenuBacktoStore(){
	
		comingSoon.gameObject.SetActive (false);
		
		isthere = false;
		
		if (isthere == false) {
			
			backButton.gameObject.SetActive (true);
		}
	
	
	
	
	}







	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
