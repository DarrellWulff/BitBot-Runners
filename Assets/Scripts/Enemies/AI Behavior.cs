using UnityEngine;
using System.Collections;

public class AIBehavior : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		
		
	
	}
}
