using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {

	public void OnTriggerEnter () {
		SceneManager.LoadScene ("End");
	}
}
