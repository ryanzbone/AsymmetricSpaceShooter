using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

	public float rocketForce, turnSpeed, explosionRadius, explosionForce;

	void Update () {
		GetComponent<Rigidbody>().AddForce(rocketForce * transform.forward);
		if(Input.GetKey(KeyCode.Z))
			transform.RotateAround(transform.position, transform.up, -turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.C))
			transform.RotateAround(transform.position, transform.up, turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.X))
			Detonate();
	}

	void Detonate() {

		Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
		foreach (Collider hit in colliders) {
			Debug.Log("hit collider");
			if (hit && hit.attachedRigidbody) {
				Debug.Log(1);
				hit.attachedRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);
			}
		}

		GameObject.Destroy(gameObject);
	}
}
