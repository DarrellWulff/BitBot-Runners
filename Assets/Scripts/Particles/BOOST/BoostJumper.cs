using UnityEngine;
using System.Collections;

public class BoostJumper : MonoBehaviour {

	public GameObject booster;
	public GameObject boostParticle;

	public GameObject tapLogo;
	public Transform tapLogoPos;

	public GameObject scoreAdder;
	public ScoreManager scoreManager;

	public AudioSource source;
	public AudioClip jumpSound;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		scoreAdder = GameObject.FindWithTag ("Score");
		scoreManager = scoreAdder.GetComponent<ScoreManager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {

			tapLogo.SetActive(true);



		} 


	}

	void OnTriggerStay2D(Collider2D other)
	{
		/*if (other.tag == "Player" && Input.anyKeyDown) {
			
			tapLogo.SetActive(false);
			other.attachedRigidbody.AddForce(Vector2.up * 6240);
			Instantiate (boostParticle, booster.transform.position, Quaternion.identity);
			booster.SetActive(false);
			
		}*/

		if (other.tag == "Player") 
		{
			int tapCount = Input.touchCount;
			foreach (Touch touch in Input.touches)
			{
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled && touch.position.x > Screen.width / 2)
				{

						
						
						tapLogo.SetActive(false);
						other.attachedRigidbody.velocity = new Vector2(other.attachedRigidbody.velocity.x, 58);
						Instantiate (boostParticle,other.transform.position, Quaternion.identity);
						scoreManager.AddScore(1);
						

				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") {
			
			tapLogo.SetActive(false);
			
			
			
		}
		
	}




}
