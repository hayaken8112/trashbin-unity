using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		float width = GetComponent<SpriteRenderer>().bounds.size.x;
		float height = GetComponent<SpriteRenderer>().bounds.size.y;
		Debug.Log(width);
		Debug.Log(height);
        Vector2 objectSize = new Vector2(width, height);
        BoxCollider2D collider = GetComponent<BoxCollider2D> ();
        collider.size = objectSize;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
