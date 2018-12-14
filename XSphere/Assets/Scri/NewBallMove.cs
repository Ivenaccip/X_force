using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBallMove : MonoBehaviour {

	public float ballSpeed;
	Animator BallAnim;
	// Use this for initialization
	void Start () {
		BallAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float xSpeed = -Input.GetAxis("Horizontal");
		float ySpeed = -Input.GetAxis("Vertical");

		Vector3 forward = transform.forward * ySpeed;
		Vector3 horizontal = transform.right * xSpeed;

		Rigidbody body = GetComponent<Rigidbody> ();
		body.AddTorque ( (forward + horizontal) * ballSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Alpha1))
		{
			BallAnim.SetBool("1", true);
			BallAnim.SetBool("2", false);
			BallAnim.SetBool("3", false);
			BallAnim.SetBool("4", false);
			
		body.AddTorque ( -transform.forward * ballSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.Alpha2))
		{
			BallAnim.SetBool("2", true);
			BallAnim.SetBool("1", false);
			BallAnim.SetBool("3", false);
			BallAnim.SetBool("4", false);
			body.AddTorque ( transform.right * ballSpeed * Time.deltaTime);
			
		}

		if(Input.GetKey(KeyCode.Alpha3))
		{
			BallAnim.SetBool("3", true);
			BallAnim.SetBool("2", false);
			BallAnim.SetBool("1", false);
			BallAnim.SetBool("4", false);
			body.AddTorque ( transform.forward * ballSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.Alpha4))
		{
			BallAnim.SetBool("4", true);
			BallAnim.SetBool("2", false);
			BallAnim.SetBool("3", false);
			BallAnim.SetBool("1", false);
			body.AddTorque ( -transform.right * ballSpeed * Time.deltaTime);
		}
	}
}
