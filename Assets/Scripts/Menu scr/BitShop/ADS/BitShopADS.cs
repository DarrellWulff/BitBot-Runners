using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class BitShopADS : MonoBehaviour {
	
	/*1015717 is the APPLE STORE ID
	* 1015716 is the GOOGLE PLAY STORE ID*/
	/*
	

	public string mainMenu = "Main Menu";

	public BuyBitbotsAndAds bitShop;
	public BitManager bitwallet;
	public GameObject DeathMenu;
	public GameObject menuButton;

	void Start() {
	
		bitShop = FindObjectOfType<BuyBitbotsAndAds> ();
		bitwallet = FindObjectOfType<BitManager> ();


	}



	// Use this for initialization
	void Awake () {

		Advertisement.Initialize (gameGoogleID, false);



	
	}

	public void ShowAd(){



		if (Advertisement.IsReady ())

			Advertisement.Show ();

		bitShop.bitPrice = 500;



	}

	public void ShowAdLevelBonus(){
		
		if (Advertisement.IsReady ())
			
			Advertisement.Show ();
		
	}





	public void ShowAdBitBonus(){




		if (Advertisement.IsReady ("rewardedVideo"))
			
			Advertisement.Show ("rewardedVideo");
			


		DeathMenu.SetActive (true);

		bitwallet.playerBitWallet += 250;

		menuButton.SetActive (false);


	}
	                            
	/*IEnumerable WaitForAd()
	{
		float currentTimeScale = Time.timeScale;
		Time.timeScale - 0f;
		yield return null;

		while(Advertisement.isShowing)
			yeild return null;

		Time.timeScale - currentTimeScale;

	}*/


	/*
	IEnumerator ShowAdWhenReady()
	{
		while (!Advertisement.IsReady())
			yield return null;

		Advertisement.Show ();
	}

	public IEnumerator waitForFadeCo()
	{
		float fadeTime = GameObject.Find ("Splash").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
	}*/
}
