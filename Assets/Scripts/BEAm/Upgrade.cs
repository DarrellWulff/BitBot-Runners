using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {

	public GameObject powerUP;
	public GameObject powerUpParticle;
	private Vector3 pos1;
	private Vector3 pos2;


	public GameObject point1;
	public GameObject point2;

	public float speed = 1.0f;



	// Use this for initialization
	void Start () 
	{

		//pos1 = new Vector3(point1.transform.position.x,  point1.transform.position.y, 0f);
		//pos2 = new Vector3(point2.transform.position.x,  point2.transform.position.y, 0f);


	
	}
	
	// Update is called once per frame
	void Update () 
	{


		//transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
	
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{


			Instantiate (powerUpParticle, powerUP.transform.position, Quaternion.identity);
			powerUP.SetActive(false);
			
			
		}
		
	}
}
