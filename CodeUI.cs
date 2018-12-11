using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeUI : MonoBehaviour {

	public static int LevelQuantity = 1;
	Text LevelText;

	// Use this for initialization
	void Start () {
		LevelQuantity = 1;
        LevelText = GameObject.Find("LevelQuantityText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider LevelCheck)
	{
		if(LevelCheck.tag == "CheckPoint")
		{
			gameObject.SetActive(false);
			LevelQuantity++;
			LevelText.text = LevelQuantity.ToString();
		}
	}
}
