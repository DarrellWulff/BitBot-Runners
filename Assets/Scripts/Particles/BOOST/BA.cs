using UnityEngine;
using System.Collections;

public class BA : MonoBehaviour {

	public GameObject thePlayer;
	public PlayerController playerControl;

	public GameObject boundsArrow;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		thePlayer =  GameObject.FindGameObjectWithTag ("Player");
		
		playerControl = thePlayer.GetComponent<PlayerController> ();

		if (playerControl.groundCheck.transform.position.y > 20 && !playerControl == null) {

			boundsArrow.SetActive (true);
		} else {
			boundsArrow.SetActive(false);
		}
	
	}
}
