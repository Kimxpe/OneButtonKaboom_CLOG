using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public void LoadScene(string name) {
		SceneManager.LoadScene (name);
	}
}
