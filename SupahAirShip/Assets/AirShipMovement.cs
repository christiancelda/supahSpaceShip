using UnityEngine;
using System.Collections;

public class AirShipMovement : MonoBehaviour {

	public float zMovement;
	Vector3 acceler;

	// Use this for initialization
	void Start () {
		acceler = Input.acceleration;

		if (acceler.sqrMagnitude > 1) {
			acceler.Normalize();
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0 , zMovement);
		transform.Rotate(Input.acceleration.y * 2, Input.acceleration.x * 2, 0);
	}
}
