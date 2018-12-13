using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salir_juego : MonoBehaviour {

	public Button salir;		
	// Use this for initialization
	void Start () {
		 Button BS = salir.GetComponent<Button>();
        BS.onClick.AddListener(TaskOnBS);
	}
	
	public void TaskOnBS()
    {
        
        Application.Quit();
        
    }

}
