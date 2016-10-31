using UnityEngine;
using System.Collections;

public class enemyNav : MonoBehaviour {
	/* 
	 * if the distance between player and enemy is less than the atk space then navigate to player
	 *
	 */
	public AudioClip audio;
	private bool hasplayed = false;
	public Canvas cv;
	public float atkDist;
	Transform player;
	NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
		cv.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (player.position, transform.position) < atkDist) {
			nav. SetDestination(player.transform.position);
		}

		else {
			return;
		}
		Debug.Log (transform.position);
	}


	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.transform.tag == "Player" || !hasplayed) 
		{
			GetComponent<AudioSource> ().PlayOneShot (audio);
			hasplayed = true;
		}


	}

		void OnCollisionEnter(Collision col )
	{
		if (col.gameObject.transform.tag == "Player") 
		{
			cv.gameObject.SetActive(true);
		
		}


	}
}
