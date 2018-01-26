using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour {

	public GreenPlatform platforms;

	public bool Pressed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//Whenever the Player is overlapping with the button, if you press Q
	//Then it should switch between visible/invisible for the platform it's connected to.
	void OnTriggerStay2D (Collider2D coll){
		if (coll.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.Q)) {
				//platforms.Switch ();
				if (Pressed == false) {
					Pressed = true;
				} else {
					Pressed = false;
				}
			}
		}
	}
		
}
