using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RepeatMenu : MonoBehaviour {


	public Transform repeatPoint;
	public GameObject menuRepeat;
	public GameObject newMenu;
	public Transform secondRepeat;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	 void OnTriggerEnter2D(Collider2D other){
	
	
		if (other.gameObject.name == "repeatPoint") {

			newMenu = Instantiate (menuRepeat, secondRepeat.position, secondRepeat.rotation) as GameObject;
		}



	
	
	
	}




}
