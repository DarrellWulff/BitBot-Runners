using UnityEngine;
using System.Collections;

public class BitGenerator : MonoBehaviour {

	public ObjectPooler bitPool;

	private float distanceBetweenBits;


	void Update () {

		distanceBetweenBits = Random.Range (4, 4);
	}


	public void SpawnBits(Vector3 startPosition){
	
		GameObject bit1 = bitPool.GetPooledObject();
		bit1.transform.position = startPosition;
		bit1.SetActive (true);

		GameObject bit2 = bitPool.GetPooledObject();
		bit2.transform.position = new Vector3(startPosition.x - distanceBetweenBits, startPosition.y, startPosition.z);
		bit2.SetActive (true);

		GameObject bit3 = bitPool.GetPooledObject();
		bit3.transform.position = new Vector3(startPosition.x + distanceBetweenBits, startPosition.y, startPosition.z);
		bit3.SetActive (true);

	
	}



}
