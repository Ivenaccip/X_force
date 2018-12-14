using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevTime : MonoBehaviour {

	public float TiempoAtras = 120;

	Text Clock;
	public SceneChanger sceneChanger;
	// Use this for initialization
	void Start () {
		TiempoAtras= 300;
		Clock = GameObject.Find("ClockQuantity").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		TiempoAtras -= Time.deltaTime;
		Clock.text = TiempoAtras.ToString();

		if (TiempoAtras <= 0 )
		{
			sceneChanger.ChangeSceneTo("LoseScene");
		}
	}


}
