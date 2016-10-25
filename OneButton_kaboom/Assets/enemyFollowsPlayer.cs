using UnityEngine;
using System.Collections;

public class enemyFollowsPlayer : MonoBehaviour {

	public float speed;
	private Transform player;

	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);

		GetComponent <Rigidbody> ().AddForce (gameObject.transform.up * speed);
	
	}
}
