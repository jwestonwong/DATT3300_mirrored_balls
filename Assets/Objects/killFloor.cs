using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killFloor : MonoBehaviour {

	private LevelManager level;

	// Use this for initialization
	void Start () {
		level = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			Debug.Log ("Player OOBs. Restarting Level");
			level.Death ();
		}
	}
}
