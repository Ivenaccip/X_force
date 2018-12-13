using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float delay = .5f;
	bool hasCooldown = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int Move = 1;
		int Jump = 3; 
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = transform.position - new Vector3 (0, 0,Move);
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = transform.position + new Vector3 (0, 0,Move);
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = transform.position + new Vector3 (Move, 0,0);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = transform.position - new Vector3 (Move, 0,0);
		}
		if(Input.GetKeyDown(KeyCode.Space) && !hasCooldown)
		{
			transform.position = transform.position + new Vector3 (0, Jump,0);
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