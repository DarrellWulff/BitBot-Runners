using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bit1000500Menu : MonoBehaviour {

	public GameObject bit1000;
	public GameObject bit500;
	private BitManager bitwallet;
	public bool isunlocked;

	public GameObject not_enough_bits;
	public GameObject enoughBits;


	public CharacterManager characterManager;
	public int unlocknumber;

	public BuyBitbotsAndAds bitbotShop;

	public const int SIZE = 42;
	public int[] bitbotArray = new int[SIZE];




	public void Yes1000(){

		if (bitwallet.playerBitWallet >= 1000) {


			isunlocked = true;
			bitwallet.playerBitWallet = bitwallet.playerBitWallet - 1000;
			PlayerPrefs.SetInt ("BitWallet", bitwallet.playerBitWallet);
			bit1000.gameObject.SetActive(false);
			enoughBits.gameObject.SetActive(true);




			unlocknumber = PlayerPrefs.GetInt("CharacterUnlock");
			characterManager.characterAcquired[unlocknumber] = unlocknumber;
			PlayerPrefsX.SetIntArray("BitBotsUnlocked", characterManager.characterAcquired);

			//Clear Data
			/*for(int i = 1; i <= 42; i++){
			
				characterManager.characterAcquiredlist[i] = 0;
				PlayerPrefsX.SetIntArray("Bots", characterManager.characterAcquiredlist);

			}*/
				


		} else {


			isunlocked = false;
			bit1000.gameObject.SetActive(false);
			not_enough_bits.gameObject.SetActive(true);

		}




	}

	public void Yes500(){
		
		if (bitwallet.playerBitWallet >= 500) {


			isunlocked = true;
			bitwallet.playerBitWallet = bitwallet.playerBitWallet - 500;
			PlayerPrefs.SetInt ("BitWallet", bitwallet.playerBitWallet);
			bit500.gameObject.SetActive(false);
			bitbotShop.bitPrice = 1000;
			enoughBits.gameObject.SetActive(true);
			unlocknumber = PlayerPrefs.GetInt("CharacterUnlock");
			characterManager.characterAcquired[unlocknumber] = unlocknumber;
			PlayerPrefsX.SetIntArray("BitBotsUnlocked", characterManager.characterAcquired);
			
			

		} else {
			

			isunlocked = false;
			bit500.gameObject.SetActive(false);
			not_enough_bits.gameObject.SetActive(true);
		}
		
		
		
		
	}

	public void No1000(){
	
		bit1000.gameObject.SetActive (false);
	
	}


	public void No500(){
	
		bit500.gameObject.SetActive (false);

	
	}

	public void backBitsnot(){

		not_enough_bits.gameObject.SetActive (false);

	}

	public void backBits(){

		enoughBits.gameObject.SetActive (false);

	}

	// Use this for initialization
	void Start () {

		bitwallet = FindObjectOfType<BitManager> ();
		isunlocked = false;

		characterManager = FindObjectOfType<CharacterManager> ();

		bitbotShop = FindObjectOfType<BuyBitbotsAndAds> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
