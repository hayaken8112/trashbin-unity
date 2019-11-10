using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 objectSize = gameObject.GetComponent<RectTransform> ().sizeDelta;
        BoxCollider2D collider = GetComponent<BoxCollider2D> ();
        collider.size = objectSize;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
