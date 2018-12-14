using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneDeath : MonoBehaviour {
	
	public SceneChanger sceneChanger;

	void OnTriggerEnter(Collider Pelota)
	{
		if(Pelota.tag == "Player")
		{
			sceneChanger.ChangeSceneTo("LoseScene");
		}
	}
}
