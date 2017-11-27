using UnityEngine;
using System.Collections;

public class PlatformGener : MonoBehaviour {

	public GameObject theQuad;

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	public float distanceBetweenMin;
	public float distanceBetweenMax;

	private int platformSelector;
	private float[] platformWidths;


	public ObjectPooler[] theObjectPools;

	private float minHeight;
	public Transform maxHeightPoint;
	private float maxHeight;
	public float maxHeightChange;
	private float heightChange;

	private BitGenerator theBitGenerator;
	public float randomBitThreshold;

	public float randomSpikeThreshold;
	public ObjectPooler spikePool;

	public float randomEnigmaThreshold;
	public ObjectPooler enigmaPool;

	public float randomBoostThreshold;
	public ObjectPooler boostPool;

	public float randomPowerUpThreshold;
	public ObjectPooler PowerUpPool;

	public GameObject currentPlatform;


	// Use this for initialization
	void Start () {
		//platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;

		platformWidths = new float[theObjectPools.Length];

		for (int i = 0; i < theObjectPools.Length; i++) {

			platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
		}
	
		minHeight = transform.position.y;
		maxHeight = maxHeightPoint.position.y;

		theBitGenerator = FindObjectOfType<BitGenerator>();






	}

	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < generationPoint.position.x) {

			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);

			platformSelector = Random.Range (0, theObjectPools.Length);


			heightChange = transform.position.y + Random.Range (maxHeightChange, -maxHeightChange);

			if(heightChange > maxHeight)
			{
				heightChange = maxHeight;

			} else if (heightChange < minHeight)
			{
				heightChange = minHeight;
			}


			transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, heightChange, transform.position.z);
		
			//Instantiate (thePlatform, transform.position, transform.rotation);

			GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive(true);
			currentPlatform = newPlatform;


			if(Random.Range(0f, 100f) < randomBitThreshold)
			{

				theBitGenerator.SpawnBits(new Vector3(transform.position.x, transform.position.y + 4.5f, transform.position.z));

			}

			if(Random.Range(0f, 100f) < randomSpikeThreshold && theQuad.transform.position.x >= 100f)
			{
				GameObject newSpike = spikePool.GetPooledObject();

				float spikeXPosition = Random.Range(-platformWidths[platformSelector] / 2 +1f, platformWidths[platformSelector] / 2 - 1f); 

				Vector3 spikePosition = new Vector3(spikeXPosition, 2.95f, 0f);

				newSpike.transform.position = transform.position + spikePosition;
				newSpike.transform.rotation = transform.rotation;
				newSpike.SetActive(true);
			}



			if(Random.Range(0f, 100f) < randomEnigmaThreshold && theQuad.transform.position.x >= 325f)
			{
				GameObject newEnigma = enigmaPool.GetPooledObject();

				float enigmaXPosition = Random.Range(platformWidths[platformSelector] / 2 + 1f, -platformWidths[platformSelector] / 2 - 1f);

				Vector3 enigmaPosition = new Vector3(enigmaXPosition, 7f, 0f);

				newEnigma.transform.position = transform.position + enigmaPosition;
				newEnigma.transform.rotation = transform.rotation;
				newEnigma.SetActive(true);
			}

			if(Random.Range(0f, 100f) < randomBoostThreshold && distanceBetween > 13)
			{
				GameObject newBoost = boostPool.GetPooledObject();

				float boostXPosition = -platformWidths[platformSelector] / 2f + -(distanceBetween/ 2f);

				Vector3 boostPosition = new Vector3(boostXPosition, -4f, 0);

				newBoost.transform.position = transform.position + boostPosition;
				newBoost.transform.rotation = transform.rotation;
				newBoost.SetActive(true);
			}

			if(Random.Range(0f, 100f) < randomPowerUpThreshold)
			{
				GameObject newPowerUp = PowerUpPool.GetPooledObject();

				float powerXPosition = Random.Range(-platformWidths[platformSelector] / 2 +1f, platformWidths[platformSelector] / 2 - 1f);

				Vector3 powerUpPosition = new Vector3(platformWidths[platformSelector] / 200, 10f, 0f);

				newPowerUp.transform.position = transform.position + powerUpPosition;
				newPowerUp.transform.rotation = transform.rotation;
				newPowerUp.SetActive(true);
			}

			transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z);
		
		}
	
	}

	/*Gets the current platform width*/
	public GameObject getPlatform()
	{
		GameObject platform = currentPlatform;
		return platform;
	}
}
