using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevTime : MonoBehaviour {

	public static int TiempoAtras = 120;

	Text Clock;
	// Use this for initialization
	void Start () {
		TiempoAtras= 120;
		Clock = GameObject.Find("RelojQuantity").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
