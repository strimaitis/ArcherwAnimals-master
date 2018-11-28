using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour {
	
	BoxCollider coll;
	GameObject hand;
	public float speed = 1;
	public Vector3 target;

	// Use this for initialization
	void Start () {
		coll = GetComponent<BoxCollider> ();
		hand = GameObject.Find ("Hand");
		target = new Vector3 (hand.transform.position.x, hand.transform.position.y, hand.transform.position.z);
	}

	private void OnTriggerEnter(Collider other) {
		if (true) {
			// transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
			transform.parent = other.transform;
			transform.Translate (Vector3.up * 40 * Time.deltaTime);
			hand.transform.position = Vector3.MoveTowards (hand.transform.position, transform.position, speed * Time.deltaTime);
			coll.isTrigger = false;
		}
	}

	// Update is called once per frame
	void Update () {
	}
}
