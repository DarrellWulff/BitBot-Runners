using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public string mainMenu = "Title Screen";

	// Use this for initialization
	void Start () {


		StartCoroutine("splashCo");

	
	}
	
	// Update is called once per frame
	void Update () {



	
	}
	public IEnumerator splashCo()
	{
		yield return new WaitForSeconds (3);
		StartCoroutine("waitForFadeCo");

		UnityEngine.SceneManagement.SceneManager.LoadScene (mainMenu);
	}
	public IEnumerator waitForFadeCo()
	{
		float fadeTime = GameObject.Find ("Splash").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
	}
}
