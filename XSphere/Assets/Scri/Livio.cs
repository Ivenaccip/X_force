using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Livio : MonoBehaviour {
	
	public SceneChanger sceneChanger;

	void OnTriggerEnter(Collider Pelota)
	{
		if(Pelota.tag == "Player")
		{
			sceneChanger.ChangeSceneTo("Livio");
		}
	}
}
