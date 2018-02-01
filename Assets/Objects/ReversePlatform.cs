using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversePlatform : MonoBehaviour {

    private SpriteRenderer sprite;
    private Collider2D coll;

    public Sprite[] sprites;
    public buttonPress button;

    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<Collider2D>();
        sprite.sprite = (sprites[1]);
        coll.isTrigger = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Switches between being visible and touchable and invisible and intangiable
        if (button != null)
        {
            if (button.Pressed == false)
            {
                sprite.sprite = (sprites[1]);
                coll.isTrigger = true;
            }
            else
            {
                sprite.sprite = (sprites[0]);
                coll.isTrigger = false;
            }
        }
    }
}
