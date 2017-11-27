using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BitManager : MonoBehaviour {

	public Text bitWalletText;
	public Text bitWalletText2;


	public int playerBitWallet;
	public int bitWallet;
	private int bitsToAdd;


	public PickupPoints bitobj;

	public AudioSource source;
	public AudioClip pickUpSound;

	// Use this for initialization
	void Start () {


		bitobj = FindObjectOfType<PickupPoints> ();
		playerBitWallet = PlayerPrefs.GetInt ("BitWallet");

		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		try
		{
			bitWalletText.text = ": " + playerBitWallet;
			bitWalletText2.text = ": " + playerBitWallet;
		}
		catch( System.NullReferenceException ex)
		{
			;
		}
		PlayerPrefs.SetInt ("BitWallet", playerBitWallet);

	
	}

	public void AddBit(int bitsToAdd){
	
		playerBitWallet += bitsToAdd;
		source.pitch = Random.Range (.87f, 1.2f);
		source.clip = pickUpSound;
		source.Play();
	
	}




}
