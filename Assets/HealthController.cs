using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	private int Health;
	public int MaxHealth;

	// Use this for initialization
	void Start () {
		Health = MaxHealth;	
	}

	public void TakeDamage(int amount)
	{
		Health -= amount;

		if (Health <= 0)
			GameObject.Destroy(transform.parent.gameObject);
	}
}
