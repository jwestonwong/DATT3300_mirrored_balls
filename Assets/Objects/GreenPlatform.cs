using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatform : MonoBehaviour {

	public bool platformOn = true;

	private SpriteRenderer sprite;
	private Collider2D coll;

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		coll = GetComponent<Collider2D> ();
		sprite.sprite = (sprites [0]);
		coll.isTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown (KeyCode.Q)) {
		//	Switch ();
		//}
	}

	//Switches between being visible and touchable and invisible and intangiable.
	public void Switch(){
		if (platformOn == false) {
			sprite.sprite = (sprites [0]);
			coll.isTrigger = false;
			platformOn = true;
		} else {
			sprite.sprite = (sprites [1]);
			coll.isTrigger = true;
			platformOn = false;
		}

	}

}
