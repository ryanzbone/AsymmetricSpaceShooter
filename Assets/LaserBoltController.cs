using UnityEngine;
using System.Collections;

public class LaserBoltController : WeaponDamage {
	
	float bullet_force = 2000f;
	
	void Start () {
		Damage = 2;
		GetComponent<Rigidbody>().AddForce(bullet_force * transform.forward);
	}

	
	void OnCollisionEnter(Collision collision) 
	{
		GameObject.Destroy(gameObject);
	}
}
