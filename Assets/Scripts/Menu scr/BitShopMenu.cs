using UnityEngine;
using System.Collections;

public class BitShopMenu : MonoBehaviour {

	public BitShopMenu bitBotShopMenu;
	public GameObject backButton;

	private bool isthere;

	public CharacterManager theCharacterManager;



	public void BitBotBrowser()
	{
		bitBotShopMenu.gameObject.SetActive (true);

		isthere = true;

		if (isthere == true) {
		
			backButton.gameObject.SetActive (false);
		
		}

	}

	public void bitbotbackToShopBrowser()
	{
		bitBotShopMenu.gameObject.SetActive (false);

		isthere = false;
		
		if (isthere == false) {
			
			backButton.gameObject.SetActive (true);
		}

	}


	/*BitBot Store Payment Funtions*/

	public void BluBitPayment(){
	}


	





	// Use this for initialization
	void Start () {

			theCharacterManager = FindObjectOfType<CharacterManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
