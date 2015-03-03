using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

	public float force = 50f;
	public float turnSpeed = 50f;

	public GameObject bullet;

	Transform bulletSpawn;

	// Use this for initialization
	void Start () {
		bulletSpawn = transform.Find("BulletSpawn").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
			rigidbody.AddForce(transform.forward * force);
		if(Input.GetKey(KeyCode.DownArrow))
			rigidbody.AddForce(transform.forward * -force);
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.RotateAround(transform.position, transform.up, -turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow))
			transform.RotateAround(transform.position, transform.up, turnSpeed * Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.Space))
			Instantiate(bullet, bulletSpawn.position, transform.rotation);
	}
}
