using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour {

	// Use this for initialization
	public int n_amount = 0;
	public int n_plasticBottle = 0;
	public int n_can = 0;
	public Text amountText;
	public Text plasticBottleText;
	public Text canText;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		amountText.text = "Amount : " + n_amount.ToString();
		plasticBottleText.text = "PlasticBottle : " + n_plasticBottle.ToString();
		canText.text = "Can : " + n_can.ToString();

		
	}
}
