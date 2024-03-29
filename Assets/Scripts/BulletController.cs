﻿using UnityEngine;
using System.Collections;

public class BulletController : WeaponDamage {

	float bullet_force = 1000f;

	void Start () {
		Damage = 1;
		GetComponent<Rigidbody>().AddForce(bullet_force * transform.forward);
	}

	void OnCollisionEnter(Collision collision) 
	{
		GameObject.Destroy(gameObject);
	}
}
