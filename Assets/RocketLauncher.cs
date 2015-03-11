using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour {

	public GameObject bullet;
	GameObject rocket;
	Transform bulletSpawn;
	bool controllingRocket;
	
	void Start () {
		controllingRocket = false;
		bulletSpawn = transform.Find("RocketSpawn").transform;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && !controllingRocket)
		{
			rocket = GameObject.Instantiate(bullet, bulletSpawn.position, transform.rotation) as GameObject;
			rocket.GetComponent<RocketController>().RocketLauncher = this;
			controllingRocket = true;
		}
	}

	public void Reload()
	{
		controllingRocket = false;
	}
}
