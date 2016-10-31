using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {


	public void restartCurrentScene()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void exit ()
	{
		Application.Quit ();

	}
	public void newGame ()
	{
		SceneManager.LoadScene("OneButtonKaboomFAM");

	}
}
