using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterManager : MonoBehaviour {

	public GameObject[] characterPool;
	public int characterIndexNumber;

	public GameObject[] botbuttonPool;

	public GameObject[] ownedBot;
	public GameObject[] buyBotButton;

	public const int SIZE = 42;
	public int[]characterAcquired = new int[SIZE];
	public int[] botArray = new int[SIZE];

	public int atStoreScene;



	public void Jet()
	{
		characterIndexNumber = 0;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Blu()
	{
		characterIndexNumber = 1;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Zeal()
	{
		characterIndexNumber = 2;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
	}

	public void Thorn()
	{
		characterIndexNumber = 3;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
	}

	public void Rebel()
	{
		characterIndexNumber = 4;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
	}

	public void Alkaline()
	{
		characterIndexNumber = 5;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Mako()
	{
		characterIndexNumber = 6;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Rhino()
	{
		characterIndexNumber = 7;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Lycan()
	{
		characterIndexNumber = 8;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Hero()
	{
		characterIndexNumber = 9;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Cyclops()
	{
		characterIndexNumber = 10;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);


	}

	public void Zolt()
	{
		characterIndexNumber = 11;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);

	}

	public void Sting()
	{
		characterIndexNumber = 12;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
		
	}

	public void Sigma()
	{
		characterIndexNumber = 13;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
		
	}

	public void Aero()
	{
		characterIndexNumber = 14;
		PlayerPrefs.SetInt ("CharacterIndex", characterIndexNumber);
		
	}




	// Use this for initialization
	void Start () {


		if (PlayerPrefs.HasKey ("BitBotsUnlocked")) {

			characterAcquired = PlayerPrefsX.GetIntArray("BitBotsUnlocked");
		
		}

		atStoreScene = PlayerPrefs.GetInt ("StoreScene");

		if (atStoreScene == 1) 
		{
			for (int i = 1; i <= 41; i++) {
				
				if(characterAcquired[i] == i){

					try
					{
						ownedBot[i].SetActive(true);
						buyBotButton[i].SetActive(false);
					}
					catch( System.NullReferenceException ex)
					{
						;
					}

				}
				
			}
		}

		if (atStoreScene == 0) 
		{
			for (int i = 0; i <= 41; i++) 
			{

				if(i <= 41)
				{

					if(characterAcquired[i] == i )
					{
						try
						{
							botbuttonPool[i].SetActive(true);
						}
						catch( System.IndexOutOfRangeException ex)
						{
							;
						}
					}
				}
				
			}
							
		}

		/*for (int i = 0; i <= 41; i++) {

			if(characterAcquired[i] == i){

				botbuttonPool[i].SetActive(true);
			}

		}*/




	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
