using UnityEngine;
using System.Collections;

public class TurretEnemyController : MonoBehaviour {

	public GameObject player, bullet;
	public float bulletForce;
	Transform bulletSpawn;
	public float reloadTime, fireRate = 1.5f;
	
	void Start () {
		bulletSpawn = transform.Find("BulletSpawn").transform;
		reloadTime = 0;
	}
	
	void Update () {
		transform.LookAt(player.transform.position);
		if(reloadTime < fireRate)
		{
			reloadTime += Time.deltaTime;
		}
		else
		{
			GameObject.Instantiate(bullet, bulletSpawn.position, transform.rotation);
			reloadTime = 0;
		}
	}

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.tag == "bullet")
		{	
			Debug.Log("Hit with " + collision.gameObject.name);
			GetComponentInChildren<HealthController>().TakeDamage(collision.gameObject.GetComponent<WeaponDamage>().Damage);
		}
	}
}
