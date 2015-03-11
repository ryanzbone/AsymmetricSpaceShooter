using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour {

	public GameObject target;
	public int size = 10, numTargets;

	// Use this for initialization
	void Start () {
		PlaceTargets ();
		Debug.Log(size);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) PlaceTargets();
	}

	void PlaceTargets () {
		float x = Random.Range(-size, size);
		float y = Random.Range(-size, size);
		Debug.Log (string.Format("x: {0} | y: {1}", x, y));

		for(int i = 0; i <= 10; i++)
			GameObject.Instantiate(target, 
			                       new Vector3((float)Random.Range(-size, size), 
			        							0, 
			        							(float)Random.Range(-size, size)), 
                   				   transform.rotation);
	}

}
