using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneWin : MonoBehaviour {
	
	public SceneChanger sceneChanger;

	void OnTriggerEnter(Collider Pelota)
	{
		if(Pelota.tag == "Player")
		{
			sceneChanger.ChangeSceneTo("WinScene");
		}
	}
}
