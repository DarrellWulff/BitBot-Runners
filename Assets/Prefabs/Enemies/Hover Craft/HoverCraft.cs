using UnityEngine;
using System.Collections;

public class HoverCraft : MonoBehaviour {

	public float moveSpeed;
	public float yVal;
	public float yVal2;
	public bool moveRight;
	
	private GameObject thePlayer;
	private GameObject theGround;
	private PlayerController thePlayerControl;
	private Collider2D groundCollider;
	
	public GameObject hoverCraft;
	public GameObject hoverParticle;

	public GameObject scoreAdder;
	public ScoreManager scoreManager;
	
	// Use this for initialization
	void Start () {
		
		thePlayer = GameObject.FindGameObjectWithTag ("Player");
		thePlayerControl = thePlayer.GetComponent<PlayerController> ();
		
		theGround = GameObject.FindGameObjectWithTag ("Ground");
		groundCollider = theGround.GetComponent<BoxCollider2D>();

		scoreAdder = GameObject.FindWithTag ("Score");
		scoreManager = scoreAdder.GetComponent<ScoreManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//GetComponent<Rigidbody2D> ().velocity.y
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		
		
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		
		if (other.tag == "Bullet") {
			Instantiate(hoverParticle, hoverCraft.transform.position, Quaternion.identity);
			hoverCraft.SetActive (false);
			scoreManager.AddScore(5);
			
		}
		
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "Ground") {
			Instantiate(hoverParticle, hoverCraft.transform.position, Quaternion.identity);
			hoverCraft.SetActive (false);
			
		}
	}
	


}
