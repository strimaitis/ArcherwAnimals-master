using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearscript : MonoBehaviour {

	GameObject terrain;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime);

		// RaycastHit hit;
		// Physics.Raycast;

		int layerMask = 1 << 8;
		layerMask = ~layerMask;

		RaycastHit hit;
		// Does the ray intersect any objects excluding the player layer
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log("Did Hit");
		}
		else
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
			Debug.Log("Did not Hit");
		}
	}

	/*
	void onCollisionEnter(Collision other) {
		float heightatpoint = terraindata.GetHeight ((int)transform.position.x, (int)transform.position.z);
		transform.position = new Vector3(transform.position.x, heightatpoint + 1.0f, transform.position.z);
	}
	*/
}