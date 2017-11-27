using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	public string nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			
			StartCoroutine("waitForFadeCo");
			UnityEngine.SceneManagement.SceneManager.LoadScene (nextLevel);

			
			
		} 
		
	}

	public IEnumerator waitForFadeCo()
	{
		float fadeTime = GameObject.Find ("GameManager").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
	}
}
