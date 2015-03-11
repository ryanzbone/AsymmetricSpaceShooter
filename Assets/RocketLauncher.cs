using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour {

	public GameObject bullet;
	GameObject rocket;
	Transform bulletSpawn;
	bool controllingRocket;
	
	// Use this for initialization
	void Start () {
		controllingRocket = false;
		bulletSpawn = transform.Find("RocketSpawn").transform;
	}
	
	// Update is called once per frame
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
