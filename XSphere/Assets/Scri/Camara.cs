using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	public GameObject target;
	public float xOffset, yOffset, zOffset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
		transform.LookAt (target.transform.position);
		if(Input.GetKey(KeyCode.Q))
		{
			transform.position = target.transform.position + new Vector3(xOffset -2, yOffset + 2, zOffset);
		}
	}
}
