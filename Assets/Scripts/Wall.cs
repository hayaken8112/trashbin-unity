using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//コライダーのサイズをオブジェクトに合わせる
		RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 objectSize = new Vector2(rectTransform.rect.width, rectTransform.rect.height);
        BoxCollider2D collider = GetComponent<BoxCollider2D> ();
        collider.size = objectSize;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
