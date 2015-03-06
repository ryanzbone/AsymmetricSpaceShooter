using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	float bullet_force = 1000f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(bullet_force * transform.forward);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnCollisionEnter(Collision collision) 
	{
		GameObject.Destroy(gameObject);
	}
}
