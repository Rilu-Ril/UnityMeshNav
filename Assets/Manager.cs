using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public static Manager instance;
	public bool isPaused = true;

	void Awake() {
		instance = this;
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad(gameObject);

	}
	public void exit() {
		Application.Quit ();
	}

}
