using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponsController : MonoBehaviour {
	public int currentWeapon;
	public List<GameObject> weapons;

	void Start () {
		weapons.Add(transform.Find("Laser").gameObject);
		weapons.Add(transform.Find("SimpleGun").gameObject);
		foreach(GameObject weapon in weapons) {
			weapon.SetActive(false);
		}
		currentWeapon = 0;
		weapons[currentWeapon].SetActive(true);
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
		{
			weapons[currentWeapon].SetActive(false);
			weapons[SetNextWeapon()].SetActive(true);	
		}

	}

	int SetNextWeapon()
	{
		currentWeapon = (currentWeapon + 1) % weapons.Count;
		return currentWeapon;
	}
}
