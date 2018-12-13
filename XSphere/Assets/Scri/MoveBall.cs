using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {


	public float maxSpeed = 2;
	public float maxRotationalSpeed = 2;
	public float jumpForce;
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
	bool hasCooldown = false;

	Rigidbody rb;
	Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponentInParent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Duck();
		Jump();
	}

	void Duck(){
		if (Input.GetButton ("Vertical") == true) {
			if (anim != null) {
				anim.SetBool ("Vert", true);
			}
		} else {
			if (anim != null) {
				anim.SetBool ("Vert", false);
			}
		}
	}

	void Jump(){
		if (!hasCooldown && Input.GetKeyDown(KeyCode.Space)) 
		{
			if (anim != null) 
			{
				anim.SetBool ("Jump", true);
			}
			Launch ();
		} 
		else 
		{
			if (anim != null) 
			{
				anim.SetBool ("Jump", false);
			}
		}
		StartCoroutine(Cooldown());
	}

	public void Launch()
	{
		rb.AddForce(new Vector2(0,jumpForce));
		StartCoroutine ("launch");
	}

	IEnumerator Cooldown()
	{
		yield return new WaitForSeconds(1);
		hasCooldown = false;

		StopCoroutine(Cooldown());
	}

	IEnumerator launch()
	{
		while(hasCooldown == false)
		{
			if (rb.velocity.y < 0)
			{
				rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
			}
			else if (rb.velocity.y > 0 && Input.GetAxis("Jump") != 0f)
			{
				rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
			}


			yield return null;
		}
	}
}
