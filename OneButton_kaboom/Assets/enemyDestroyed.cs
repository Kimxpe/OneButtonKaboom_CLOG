using UnityEngine;
using System.Collections;

public class enemyDestroyed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.O)) {
			Destroy (this.gameObject);

		}
	}
}
