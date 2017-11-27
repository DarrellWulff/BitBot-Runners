using UnityEngine;
using System.Collections;

public class AngrySnow : MonoBehaviour {

	public GameObject theAngrySnow;
	public PlatformGener thePlatformGenerator;
	private Vector3 pos1;
	private Vector3 pos2;
	public float speed = 1.0f;

	public GameObject point1;
	public GameObject point2;

	// Use this for initialization
	// = new Vector3(-4,0,0);
	//private Vector3 pos2 = new Vector3(4,0,0)
	void Start () 
	{

		thePlatformGenerator = FindObjectOfType<PlatformGener> ();
		pos1 = new Vector3(point1.transform.position.x,  point1.transform.position.y, 0f);
		pos2 = new Vector3(point2.transform.position.x,  point2.transform.position.y, 0f);

	
	}
	
	// Update is called once per frame
	void Update () 
	{


		transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
	

		
	}
}
