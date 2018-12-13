using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBitch : MonoBehaviour {

	public float jumpForce;

	bool hasCooldown = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Jump();
	}

	void Jump(){
		if (!hasCooldown && Input.GetKey (KeyCode.Space)) {
			transform.position = transform.position + new Vector3 (0, jumpForce,0);
			hasCooldown = true;
			StartCoroutine(Cooldown());
		} 
		
	}

	
	IEnumerator Cooldown()
		{
			yield return new WaitForSeconds(1);
			hasCooldown	= false;

			StopCoroutine(Cooldown());
		}

	
}
