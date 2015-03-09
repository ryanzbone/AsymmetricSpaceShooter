using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

	public float force = 50f;
	public float turnSpeed = 50f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
			GetComponent<Rigidbody>().AddForce(transform.forward * force);
		if(Input.GetKey(KeyCode.DownArrow))
			GetComponent<Rigidbody>().AddForce(transform.forward * -force);
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.RotateAround(transform.position, transform.up, -turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
			transform.RotateAround(transform.position, transform.up, turnSpeed * Time.deltaTime);

	}
}
