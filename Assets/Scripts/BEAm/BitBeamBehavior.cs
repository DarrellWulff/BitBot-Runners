using UnityEngine;
using System.Collections;

public class BitBeamBehavior : MonoBehaviour {

	public float speed;

	public GameObject bitBeamPrefab;



	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);



	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(!other.CompareTag("Player") && !other.CompareTag("Ground"))
		{

			Destroy(bitBeamPrefab);
		
		}

	}
}
