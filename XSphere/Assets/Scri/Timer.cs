using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	// Use this for initialization
	public static int ClockQuantity;
	Text Clock;
	void Start () {

		ClockQuantity = 120;
		Clock = GameObject.Find("RelojQuantity").GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider PlusTime) {
		if(PlusTime.tag == "Player")
		{
			gameObject.SetActive(false);
			ClockQuantity = ClockQuantity + 10;
			Clock.text = ClockQuantity.ToString();
		}
		
	}
}
