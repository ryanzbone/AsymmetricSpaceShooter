using UnityEngine;
using System.Collections;

public class TurretEnemyController : MonoBehaviour {

	public GameObject player, bullet;
	public float bulletForce;
	Transform bulletSpawn;
	public float reloadTime, fireRate = 1.5f;

	int health;

	// Use this for initialization
	void Start () {
		health = 3;
		bulletSpawn = transform.Find("BulletSpawn").transform;
		reloadTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform.position);
		if(reloadTime < fireRate)
		{
//			Debug.Log("increment");
			reloadTime += Time.deltaTime;
		}
		else
		{
//			Debug.Log("fire");
			GameObject.Instantiate(bullet, bulletSpawn.position, transform.rotation);
			reloadTime = 0;
		}
	}

	void OnCollisionEnter(Collision collision) 
	{
		Debug.Log("hit");
		if(collision.gameObject.tag == "bullet")
		{	
			health--;
			if (health == 0) GameObject.Destroy(gameObject);
		}
	}
}
