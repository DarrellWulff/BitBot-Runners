using UnityEngine;
using System.Collections;

public class BoundsArrow : MonoBehaviour {


	public GameObject boundsArrow;
	public GameObject thePlayer;
	public PlayerController playerControl;


	// Use this for initialization
	void Start () {

		thePlayer =  GameObject.FindGameObjectWithTag ("Player");
		
		playerControl = thePlayer.GetComponent<PlayerController> ();
		


	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
