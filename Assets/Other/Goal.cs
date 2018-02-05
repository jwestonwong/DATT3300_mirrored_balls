using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	private LevelManager level;
	private heroController hC;
	private heroInverse hI;

	public bool levelUnbeat;

	// Use this for initialization
	void Start () {
		level = GameObject.FindObjectOfType<LevelManager> ();
		hC = GameObject.FindObjectOfType<heroController> ();
		hI = GameObject.FindObjectOfType<heroInverse> ();
		levelUnbeat = true;
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D coll){
		if (coll.tag == "Ball") {
			if (levelUnbeat == true) {
				if (hC.canJump == true) {
					if (hI.canJump == true) {
						levelUnbeat = false;
						level.LevelPass ();
					}
				}
			}
		}
	}
}
