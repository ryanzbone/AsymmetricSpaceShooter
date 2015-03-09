using UnityEngine;
using System.Collections;

public class SimpleGunController : MonoBehaviour {
	
	public GameObject bullet;
	Transform bulletSpawn;

	// Use this for initialization
	void Start () {
		bulletSpawn = transform.Find("BulletSpawn").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			GameObject.Instantiate(bullet, bulletSpawn.position, transform.rotation);
	}
}
