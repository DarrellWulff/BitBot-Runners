using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyBitbotsAndAds : MonoBehaviour {

	public GameObject[] characterList;

	public int characterUnlockNumber;

	public GameObject bit1000;
	public GameObject bit500;

	public Text bitpricetxt1;
	public Text bitpricetxt2;

	public int bitPrice; 

    //Each Button Has a function to purchase the character that was tapped on.
	public void Blu()
	{
		characterUnlockNumber = 1;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);

		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {

			bit500.gameObject.SetActive(true);
		}

		
	}
	
	public void Zeal()
	{
		characterUnlockNumber = 2;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
	
	}
	
	public void Thorn()
	{
		characterUnlockNumber = 3;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
	}
	
	public void Rebel()
	{
		characterUnlockNumber = 4;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
	}
	
	public void Alkaline()
	{
		characterUnlockNumber = 5;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Mako()
	{
		characterUnlockNumber = 6;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Rhino()
	{
		characterUnlockNumber = 7;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Lycan()
	{
		characterUnlockNumber = 8;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Hero()
	{
		characterUnlockNumber = 9;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Cyclops()
	{
		characterUnlockNumber = 10;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
		
	}
	
	public void Zolt()
	{
		characterUnlockNumber = 11;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Sting()
	{
		characterUnlockNumber = 12;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Sigma()
	{
		characterUnlockNumber = 13;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}
	
	public void Aero()
	{
		characterUnlockNumber = 14;
		PlayerPrefs.SetInt ("CharacterUnlock", characterUnlockNumber);
		if (bitPrice == 1000) {
			bit1000.gameObject.SetActive (true);
		} else {
			
			bit500.gameObject.SetActive(true);
		}
		
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bitpricetxt1.text = ": " + bitPrice;
		bitpricetxt2.text = ": " + bitPrice;



	}
}
