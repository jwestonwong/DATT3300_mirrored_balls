using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	static LevelManager instance = null;

	public int NextLevel;
	public int CurrentLevel;

	// Use this for initialization

	void Start () {
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate LevelManager self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}

		NextLevel = 1;
		CurrentLevel = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (CurrentLevel == 0) {
			if (Input.GetKeyDown(KeyCode.X)){
				LevelPass ();
			}
		}
	}

	public void LevelPass (){
		SceneManager.LoadSceneAsync (NextLevel);
		Increment ();
	}

	public void Death (){
		SceneManager.LoadSceneAsync (CurrentLevel);	
	}

	void Increment (){
		NextLevel++;
		CurrentLevel++;
	}
}
