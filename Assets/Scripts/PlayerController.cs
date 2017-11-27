using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float speedMultiplier;
	private float moveSpeedStore;

	public float speedIncreaseMilestone;
	private float speedIncreaseMileStoneStore;
	private float speedMilestoneCount;
	private float speedMilestoneCountStore;

	//Bit Beam
	public GameObject bitBeamObj;
	public GameObject bitBeamObj2;
	public GameObject bitBeamObj3;
	public float beamSpeed;
	public float beamSpeed2;
	public float beamSpeed3;
	public int bitLevelCount = 3;

	public float jumpForce;

	public float jumpTime;
	private float jumpTimeCounter;

	private Rigidbody2D myRigidbody;

	//Check for ground, in order to jump.
	public bool grounded;
	public LayerMask whatisground;
	public Transform groundCheck;
	public float groundCheckRadius;


	public bool frontCheck;
	public Transform movingForward;
	public float frontCheckRadius;



	//particle effects
	public GameObject bitBeamBurst;
	public GameObject deathParticle;

	public int leftID;

	//private Collider2D myCollider;

	private Animator myAnimator;

	public GameManager theGameManager;

	public bool boostCollider;

	//For BitShop
	public int bitBotPrice = 1000;

	public AudioSource source;
	public AudioClip jumpSound;
	public AudioClip bitBeamSound;
	public AudioClip bitBeamSound2;
	public AudioClip bitBeamSound3;
	public AudioClip powerUpSound;



	// Use this for initialization
	void Start () {

		boostCollider = false;

		theGameManager = FindObjectOfType<GameManager>();

		myRigidbody = GetComponent<Rigidbody2D> ();

		//myCollider = GetComponent<Collider2D> ();

		myAnimator = GetComponent<Animator> ();

		source = GetComponent<AudioSource> ();

		jumpTimeCounter = jumpTime;

		speedMilestoneCount = speedIncreaseMilestone;

		moveSpeedStore = moveSpeed;
		speedMilestoneCountStore = speedMilestoneCount;
		speedIncreaseMileStoneStore = speedIncreaseMilestone;


	
	}
	void FixedUpdate(){

		//groundTouched = Physics2D.IsTouchingLayers (myCollider, whatisground);
		
		frontCheck = Physics2D.OverlapCircle (movingForward.position, frontCheckRadius, whatisground);
		
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatisground);
		
		if (transform.position.x > speedMilestoneCount) {
			
			speedMilestoneCount += speedIncreaseMilestone;
			
			speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
			moveSpeed = moveSpeed * speedMultiplier;
			
			
		}
		
		
		
		
		//Movement control
		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);
		/*if(jumpTimeCounter > 0)
		{
			
			
			
			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
			jumpTimeCounter -= Time.deltaTime;
			
			
			
		}*/ 
		
		foreach (Touch touch in Input.touches) 
		{
			
			
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled && touch.position.x < Screen.width / 2) 
			{
				
				if(jumpTimeCounter > 0)
				{
					myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);
					jumpTimeCounter -= Time.deltaTime;
				}
			}
		}
		
		
		if (grounded == true) 
		{
			source.pitch = Random.Range (.87f, 1.2f);
			source.clip = jumpSound;
			source.Play();
			
		}
		
		
		
		if (grounded) {
			
			jumpTimeCounter = jumpTime;
			
			
			
		}
		
		//Shoot Bit Beam

		
		
		
		
		myAnimator.SetFloat ("Speed", myRigidbody.velocity.x);
		myAnimator.SetBool ("Grounded", grounded);
		
		
	}
	
	void OnCollisionEnter2D (Collision2D otherE){
		
		if (otherE.gameObject.tag == "killbox") {
			
			
			
			
			
			Instantiate(deathParticle, myRigidbody.transform.position, myRigidbody.transform.rotation);
			
			theGameManager.RestartGame();
			moveSpeed = moveSpeedStore;
			speedMilestoneCount = speedMilestoneCountStore;
			speedIncreaseMilestone = speedIncreaseMileStoneStore;
			
		}


	}
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch (i).phase == TouchPhase.Began && Input.GetTouch(i).position.x > Screen.width / 2) {
				Instantiate (bitBeamBurst, movingForward.position, Quaternion.identity);
				
				
				
				if(bitLevelCount == 1)
				{
					Instantiate (bitBeamObj, movingForward.position, Quaternion.identity);
					source.PlayOneShot(bitBeamSound);
					
				} else if( bitLevelCount == 2){
					
					Instantiate (bitBeamObj2, movingForward.position, Quaternion.identity);
					source.PlayOneShot(bitBeamSound2);
				} else {
					
					Instantiate (bitBeamObj3, movingForward.position, Quaternion.identity);
					source.PlayOneShot(bitBeamSound3);
				}
			}
		}


	}




	public void actionButton()
	{

		moveSpeed += 1;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "BitUp") {

			source.PlayOneShot(powerUpSound);
			bitLevelCount += 1;
			
			
			
		}



		
	}








}
