using UnityEngine;
using System.Collections;

public class TargetCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
			gameObject.SetActive(true);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "bullet") {
			GameObject.Destroy(collision.gameObject);
			GameObject.Destroy(gameObject);
		}
	}
}
