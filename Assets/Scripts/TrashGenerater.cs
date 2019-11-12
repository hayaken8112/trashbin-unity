using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;
using System.Collections;
using System.Web;

public class TrashGenerater : MonoBehaviour {
	public GameObject trashPrefab;

	public string message = "Hello from Unity";

	public AudioSource source;

	public void OnRequest(HttpListenerContext context)
	{
		if (context.Request.HttpMethod == "POST"){
			Debug.Log(context.Request.QueryString);
			var data_text = new StreamReader (context.Request.InputStream, 
				                context.Request.ContentEncoding).ReadToEnd ();
			Debug.Log (data_text);


			byte[] bytes = System.Convert.FromBase64String(data_text);

			var texture = new Texture2D(100, 100);
			texture.LoadImage(bytes);

			source.Play();

			// Image内に割り当てられたスクリプト内なら下記を呼ぶだけ。
			// GetComponent<Renderer>().material.mainTexture = texture;
			Sprite texture_sprite = Sprite.Create(texture, new Rect(0,0,texture.width,texture.height), new Vector2(0.5f,0.5f));
			GameObject trash = Instantiate(trashPrefab, new Vector3(Random.Range(-1.0f,1.0f),5,0), Quaternion.identity);
			SpriteRenderer sp = trash.GetComponent<SpriteRenderer>();
			sp.sprite = texture_sprite;
		}
		var data = System.Text.Encoding.UTF8.GetBytes(message);
		context.Response.StatusCode = 200;
		context.Response.Close(data, false);



	}
}
