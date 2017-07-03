using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRemoveTile : MonoBehaviour {

	void OnTriggerEnter(Collider remove){
		//If anything tagged "land" is inside the collider
		if (remove.gameObject.tag == "Land") {
			//Put the name of the game object/s and the current frame in the console
			Debug.Log ("enter" + Time.frameCount + this.gameObject.name);
			//Destroy the object/s tagged "Land"
			Destroy (remove.gameObject);
			//Move the collider to a place where it won't collide with anything tagged "Land"
			transform.localPosition = new Vector3 (0, 20, 0);
		}
	}

}
