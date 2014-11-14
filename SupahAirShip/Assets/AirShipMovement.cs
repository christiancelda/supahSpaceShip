using UnityEngine;
using System.Collections;

public class AirShipMovement : MonoBehaviour {

	public float zMovement;
	Vector3 acceler;

	// Use this for initialization
	void Start () {
		acceler = Input.acceleration;
		Time.timeScale = 0;
		//acceler.x = 0;
		//acceler.y = 0;
		acceler.Set(0,0,0);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(acceler);
		if (Input.GetMouseButtonDown(0)){
			if (Time.timeScale != 1){
				Debug.Log("Funciona el click");
				acceler.Set(0,0,0);
				Time.timeScale = 1;
			}

			else {
				Time.timeScale = 0;
			}
		}

		if (Time.timeScale != 0){
			transform.Translate(0, 0 , zMovement);
			transform.Rotate(Input.acceleration.y * 2, Input.acceleration.x * 2, 0);
		}
	}
}
