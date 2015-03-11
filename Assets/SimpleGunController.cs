using UnityEngine;
using System.Collections;

public class SimpleGunController : MonoBehaviour {
	
	public GameObject bullet;
	Transform bulletSpawn;

	void Start () {
		bulletSpawn = transform.Find("BulletSpawn").transform;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			GameObject.Instantiate(bullet, bulletSpawn.position, transform.rotation);
	}
}
