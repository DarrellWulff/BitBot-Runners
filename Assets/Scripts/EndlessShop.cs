using UnityEngine;
using System.Collections;

public class EndlessShop : MonoBehaviour {


	public EndlessShop endlessModeStore;
	public GameObject backbutton;

	private bool isthere;

	public void EndlessModeBroswer()
	{
		endlessModeStore.gameObject.SetActive (true);

		isthere = true;

		if (isthere == true) {
			
			backbutton.gameObject.SetActive (false);
		
		}
		
	}
	
	public void EndlessModebacktoshop()
	{
		endlessModeStore.gameObject.SetActive (false);

		isthere = false;
		
		if (isthere == false) {
			
			backbutton.gameObject.SetActive (true);
			
		}

		
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
