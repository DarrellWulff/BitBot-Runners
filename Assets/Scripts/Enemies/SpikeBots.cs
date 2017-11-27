using UnityEngine;
using System.Collections;

public class SpikeBots : MonoBehaviour {

	public GameObject spikeBot;
	public GameObject spikeParticles;

	public GameObject scoreAdder;
	public ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		scoreAdder = GameObject.FindWithTag ("Score");
		scoreManager = scoreAdder.GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Bullet"))
		{
			Instantiate(spikeParticles, spikeBot.transform.position, Quaternion.identity);
			spikeBot.SetActive(false);
			scoreManager.AddScore(5);
		}
		
	}
}
