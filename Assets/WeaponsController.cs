using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponsController : MonoBehaviour {
	public int currentWeapon;
	public List<GameObject> weapons;

	void Start () {
		foreach(Transform child in transform)
		{
			weapons.Add (child.gameObject);
			child.gameObject.SetActive(false);
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
