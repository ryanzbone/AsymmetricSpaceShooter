using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

	public float rocketForce, turnSpeed, explosionRadius, explosionForce;
	public RocketLauncher RocketLauncher;

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
			if (hit && hit.attachedRigidbody) {
				hit.attachedRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);
			}
		}
		RocketLauncher.Reload();
		GameObject.Destroy(gameObject);
	}
}
