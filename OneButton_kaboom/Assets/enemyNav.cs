using UnityEngine;
using System.Collections;

public class enemyNav : MonoBehaviour {
	
	public AudioClip audio;
	private bool hasplayed = false;
	public Canvas cv;
	public float atkDist;
	Transform player;
	NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		hasplayed = false;
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
		cv.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		
		//if the distance between player and enemy is less than the atk space then navigate to player

		if (Vector3.Distance (player.position, transform.position) < atkDist) {
			nav. SetDestination(player.transform.position);
		}

		//dont do anything else

		else {
			return;
		}

	}

	//if a game object of the tag "player" enters trigger. play the audio clip assigned

	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.transform.tag == "Player" || !hasplayed) 
		{
			GetComponent<AudioSource> ().PlayOneShot (audio);
			hasplayed = true;
		}


	}

	// if player and enemy collide, activate game over canvas screen

		void OnCollisionEnter(Collision col )
	{
		if (col.gameObject.transform.tag == "Player") 
		{
			cv.gameObject.SetActive(true);
		
		}


	}
}
