using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneContinue : MonoBehaviour {
	
	public SceneChanger sceneChanger;
	public Button Continue;

	void Start()
	{
		Button B_C = Continue.GetComponent<Button>();
		B_C.onClick.AddListener(TaskOnCont);
	}

	public void TaskOnCont()
	{
		sceneChanger.ChangeSceneTo("ForestL");
	}
}
