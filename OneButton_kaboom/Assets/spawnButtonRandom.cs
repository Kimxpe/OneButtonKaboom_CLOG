using UnityEngine;
using System.Collections;

public class spawnButtonRandom : MonoBehaviour {

	public GameObject button;
	void Start (){
		//		StartCoroutine ("waitSeconds");
		//		Instantiate (enemy2, transform.position, transform.rotation);
		InvokeRepeating("SpawnButton", 0f, 3f);
	}

	void SpawnEnemy() {
		Instantiate (button, transform.position, transform.rotation);
	}

	IEnumerator waitSeconds() {
		Instantiate (button, transform.position, transform.rotation);
		yield return new WaitForSeconds (7);
		Instantiate (button, transform.position, transform.rotation);
		yield return new WaitForSeconds (9);


	}
}


