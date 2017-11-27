using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {


	public float speed = 0.5f;
	private int characterNum;

	public GameManager theGameManager;



	// Use this for initialization
	void Start () {

		theGameManager = FindObjectOfType<GameManager> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2 (theGameManager.thePlayer.transform.position.x * speed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	
	}
}
